using eBus.Model;
using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModels
{
    public class PretragaViewModel : BaseViewModel
    {
        private readonly APIService _rezervacije = new APIService("Rezervacija");
        private readonly APIService _angazuje = new APIService("Angazuje");
        private readonly APIService _linijeService = new APIService("Linija");
        private readonly APIService _sjedisteService  = new APIService("Sjediste");
        private readonly APIService _voziloService  = new APIService("Vozilo");
        private readonly APIService _kompanijaService  = new APIService("Kompanija");
        private readonly APIService _cijenaService  = new APIService("Cijena");
        private readonly APIService _gradService  = new APIService("Grad");



        public PretragaViewModel()
        {
            Title = "Pretraga";
            

        }

        private Kompanija _IzborKompanije = null;
        public Kompanija IzborKompanije
        {
            get { return _IzborKompanije; }
            set { SetProperty(ref _IzborKompanije, value); }
        }

        public ObservableCollection<Kompanija> ListaKompanijaLista { get; set; } = new ObservableCollection<Kompanija>();

        public async Task ListaKompanija()
        {
            var lista = await _kompanijaService.Get<List<Kompanija>>(null);

            ListaKompanijaLista.Clear();

            foreach (var item in lista)
            {
                ListaKompanijaLista.Add(item);
            }

        }


        private decimal _prvaVrijednost = 0;

        public decimal PrvaVrijednost
        {
            get { return _prvaVrijednost; }
            set { SetProperty(ref _prvaVrijednost, value); }
        }

        private decimal _UkupnaVrijednost = 0;

        public decimal UkupnaVrijednost
        {
            get { return _UkupnaVrijednost; }
            set { SetProperty(ref _UkupnaVrijednost, value); }
        }

      
        private string _polaziste = string.Empty;
        public string Polaziste
        {
            get { return _polaziste; }
            set { SetProperty(ref _polaziste, value); }
        }

        private string _odrediste = string.Empty;
        public string Odrediste
        {
            get { return _odrediste; }
            set { SetProperty(ref _odrediste, value); }
        }

        private string _kompanija = string.Empty;

        public string Kompanija
        {
            get { return _kompanija; }
            set { SetProperty(ref _kompanija, value); }
        }

        decimal UkupnaCijena = 0;

        public ObservableCollection<Pretraga> Podaci { get; set; } = new ObservableCollection<Pretraga>();
        public async Task Init()
        {

            var listaRzervacije = await _rezervacije.Get<List<Rezervacija>>(null);

            decimal UkupnoSve = 0;

            Dictionary<string, int> putnici = new Dictionary<string, int>();

            foreach (var item in listaRzervacije)
            {
                if (!putnici.ContainsKey(item.Putnik.Ime))
                {
                    putnici.Add(item.Putnik.Ime, 1);
                }
            }


            

            if(_IzborKompanije == null)
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Niste odabrali kompaniju", "OK");
            }
            else { 
           

            foreach (var item2 in putnici.ToList())
            {
                int brojacKarate = 0;
                

                foreach (var item in listaRzervacije)
                {

                    var angazuje = await _angazuje.GetById<Angazuje>(item.Karta.AngazujeId);

                    var linija = await _linijeService.GetById<Linija>(angazuje.LinijaId);
                    var sjediste = await _sjedisteService.GetById<Sjediste>(item.Karta.SjedisteId);

                    var vozilo = await _voziloService.GetById<Vozilo>(sjediste.VoziloId.Value);

                    var kompanija = await _kompanijaService.GetById<Kompanija>(vozilo.KompanijaId.Value);

                    var odr =await  _gradService.GetById<Grad>(linija.OdredisteId);
                    var pol =await  _gradService.GetById<Grad>(linija.PolazisteId);

                    if (odr.Naziv == _odrediste && pol.Naziv == _polaziste  && kompanija.Id == IzborKompanije.Id)
                    {
                        if(item2.Key == item.Putnik.Ime)
                        {
                            brojacKarate++;

                            var cijenaSearch = new CijenaSearchRequest()
                            {
                                KompanijaID = kompanija.Id,
                                LinijaID = linija.Id
                            };

                            var listaCijena = await _cijenaService.Get<List<Cijena>>(cijenaSearch);

                            UkupnaCijena += listaCijena[0].Iznos;
                            
                        }
                    }
                }



                Podaci.Add(new Pretraga()
                {
                    BrojKarata = brojacKarate,
                    Ukupno = UkupnaCijena,
                    ImeKorisnika = item2.Key
                });
                _prvaVrijednost += UkupnaCijena;
            }

            }
        }

       


    }

}