using eBus.Model;
using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModels
{
    public class SjedisteViewModel : BaseViewModel
    {
        private readonly APIService _sjedistaService = new APIService("Sjediste");
        private readonly APIService _voziloService = new APIService("Vozilo");
        private readonly APIService __rezervacijaService = new APIService("Rezervacija");
        private readonly APIService __putniciService = new APIService("Putnik");
        private readonly APIService __karteService = new APIService("Karta");
        private readonly APIService _cijenaService = new APIService("Cijena");

        public SjedisteViewModel()
        {
            Title = "Sjedista";
        }

        public ObservableCollection<Sjediste> SjedistaList { get; set; } = new ObservableCollection<Sjediste>();
        public ObservableCollection<Karta> KartaList { get; set; } = new ObservableCollection<Karta>();

        private int _angazmanID = 0;

        public int Angazman
        {
            get { return _angazmanID; }
            set { SetProperty(ref _angazmanID, value); }
        }

        private bool _vidljivaSjedista = false;
        public bool VidljivaSjedista
        {
            get { return _vidljivaSjedista; }
            set { SetProperty(ref _vidljivaSjedista, value); }
        }
        private bool _poruka = true;
        public bool Poruka
        {
            get { return _poruka; }
            set { SetProperty(ref _poruka, value); }
        }

        public int BrojSjedalaDodnih { get; set; } = 0;

        public int BrojRedova { get; set; }

        public int BrojKolona { get; set; }

        private int _voziloid = 0;

        public async Task  Init(int voziloID)
        {
            _voziloid = voziloID;

            


            var search = new SjedisteSearchRequest()
            {
                VoziloId = voziloID
            };

            var lista = await _sjedistaService.Get<List<Sjediste>>(search); 

            SjedistaList.Clear();

            foreach (var item in lista)
            {
                SjedistaList.Add(item);
                BrojSjedalaDodnih++;
            }

            var vozilo = await _voziloService.GetById<Vozilo>(voziloID);
            BrojKolona = 4;
            BrojRedova = BrojSjedalaDodnih / BrojKolona;

          



        }

        public async Task KupiKartu(Sjediste s,DateTime datum, TimeSpan vrijemePolaska)  
        {
            var reze = new RezervacijaUpsertRequest();

            var searchP = new PutnikSearchRequest()
            {
                KorisnickoIme = APIService.KorisnickoIme
            };
            var listaPutnika = await __putniciService.Get<List<Putnik>>(searchP);

            Putnik putnik = null;

            foreach (var item in listaPutnika)
            {
                if(item.KorisnickoIme == APIService.KorisnickoIme)
                {
                    putnik = item;
                    break;
                }
            }

            var searchKa = new KartaSearchRequest()
            {
                PoAngzuje = false,
                PoVozilu = true,
                Red = s.Red,
                Kolona = s.Kolona,
                PoDatumu = true, 
                DatumIzdavanja = datum,
                IzSjedista = false,
                PoVremenu = true,
                VrijemePolaska = vrijemePolaska
                
            };

            var listaKarata = await __karteService.Get<List<Karta>>(searchKa);

            Karta karta = null;

            foreach (var item in listaKarata)
            {
              

               
                    if (item.Sjediste.VoziloId == _voziloid && item.AngazujeId == Angazman)
                    {
                        karta = item;
                        break;
                    }
               
               
            }

            if(karta == null)
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Trenutno karta nije kreirana", "OK");

            }else if(karta.DatumIzdavanja.Date < DateTime.Now.Date)
            {
               await  Application.Current.MainPage.DisplayAlert(" ", "Niste u mogučnosti rezervisati", "OK");


            }
            else if (karta.DatumIzdavanja.Date == DateTime.Now.Date && karta.VrijemePolaska < DateTime.Now.TimeOfDay)
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Vrijeme koje ste izabrali je isteklo", "OK");


            }
            else
            {
                var cijena = await _cijenaService.Get<List<Cijena>>(new CijenaSearchRequest()
                {
                    KompanijaID = s.Vozilo.KompanijaId,
                    LinijaID = karta.Angazuje.LinijaId
                });
                reze.KartaId = karta.Id;
                reze.PutnikId = putnik.Id;
                reze.DatumKreiranja = DateTime.Now;
                reze.DatumIsteka = karta.DatumIzdavanja.AddDays(1);
                reze.Otkazana = false;
                

                if(DateTime.Now.Date.Year - putnik.DatumRodjenja.Value.Date.Year > 50 || DateTime.Now.Date.Year - putnik.DatumRodjenja.Value.Date.Year <18)
                {
                    reze.CijenaSaPopustom = cijena[0].Popust == 0 ? cijena[0].Iznos :cijena[0].Iznos - (cijena[0].Iznos * decimal.Parse(cijena[0].Popust.Value.ToString()));
                }
                else
                {
                    reze.CijenaSaPopustom = cijena[0].Iznos;
                }
                
                

                await __rezervacijaService.Insert<Rezervacija>(reze);

                await Application.Current.MainPage.DisplayAlert(" ", "Uspješno ste kreirali rezervaciju", "OK");
            }
         
            
        }
        
    }
}
