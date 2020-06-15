using eBus.Model;
using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModels
{
    public class LinijaViewModel : BaseViewModel
    {
        private readonly APIService _linijeService = new APIService("Linija");

        private readonly APIService _angazujeService = new APIService("Angazuje");
        private readonly APIService _cijenaService = new APIService("Cijena");
        private readonly APIService _kompanijaService = new APIService("Kompanija");
        private readonly APIService _gradService = new APIService("Grad");
        private readonly APIService _kartaService = new APIService("Karta");

        public LinijaViewModel()
        {
            Title = "Linije";
            
        }

        public ObservableCollection<Linija> LinijaList { get; set; } = new ObservableCollection<Linija>();
        public ObservableCollection<LinijaPodaci> LinijaPodaciList { get; set; } = new ObservableCollection<LinijaPodaci>();
        public ObservableCollection<LinijaPodaci> TestniPodaci { get; set; } = new ObservableCollection<LinijaPodaci>();

        private bool _preporuka = false;
        public bool Preporuka
        {
            get { return _preporuka; }
            set { SetProperty(ref _preporuka, value); }
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

        private bool _poDatumu = true;
        public bool PoDatumu
        {
            get { return _poDatumu; }
            set { SetProperty(ref _poDatumu, value); }
        }

        private DateTime _datum = DateTime.Now;

        public DateTime Datum
        {
            get { return _datum; }
            set { SetProperty(ref _datum, value); }
        }

        

        public ICommand PretraziCommand { get; set; }


        public async Task Init()
        {
            try
            {




                List<Model.Angazuje> listaAngazuje = null;
                //if (PoDatumu)
                //{
                //    var serchAn = new AngazujeSearchRequest()
                //    {
                //        Datum = Datum,
                //        ZaLiniju = true
                //    };

                //    listaAngazuje = await _angazujeService.Get<List<Angazuje>>(serchAn);
                //}
                //else
                //{
                //    listaAngazuje = await _angazujeService.Get<List<Angazuje>>(null);

                //}

           

                var serchAn = new AngazujeSearchRequest()
                {
                    Datum = Datum.Date,
                    ZaLiniju = true
                };

                listaAngazuje = await _angazujeService.Get<List<Angazuje>>(serchAn);

                var search = new LinijaSearchRequest()
                {
                    NazivOdredista = Odrediste,
                    NazivPolazista = Polaziste,
                    PoNazivu = true,
                    Datum = Datum
                };

                var listaLinija = await _linijeService.Get<List<Linija>>(search);


                

                LinijaPodaciList.Clear();

              


               

                TestniPodaci.Clear();



                foreach (var item in listaAngazuje)
                {
                    var searchKarta = new KartaSearchRequest()
                    {
                        PoAngzuje = true,
                        AngazujeID = item.Id,
                        PoDatumu = true,
                        PoVozilu = false,
                        DatumIzdavanja = Datum.Date,
                        PoVremenu = false // dodao


                    };

                    var listaKarat = await _kartaService.Get<List<Karta>>(searchKarta);

                    foreach (var item2 in listaLinija)
                    {
                        if (item.LinijaId == item2.Id)
                        {


                            var gradP = await _gradService.GetById<Grad>(item.Linija.PolazisteId);
                            var gradO = await _gradService.GetById<Grad>(item.Linija.OdredisteId);
                            var kompanija = await _kompanijaService.GetById<Kompanija>(item.Vozilo.KompanijaId.Value);

                            var searchCijena = new CijenaSearchRequest()
                            {
                                LinijaID = item.LinijaId,
                                KompanijaID = kompanija.Id
                            };

                            var cijena = await _cijenaService.Get<List<Cijena>>(searchCijena);

                            if (listaKarat.Count != 0)
                            {
                                TestniPodaci.Add(new LinijaPodaci()
                                {
                                    OdredisteNaziv = gradO.Naziv,
                                    PolazisteNaziv = gradP.Naziv,
                                    Cijena = cijena.Count == 0 ? 0 : cijena[0].Iznos,
                                    Kompanija = kompanija.Naziv,
                                    AngazujeID = item.Id,
                                    VoziloID = item.VoziloId,
                                    DatumPretrage = Datum,
                                    VrijemePolaska = listaKarat[0].VrijemePolaska


                                });
                            }




                        }

                    }

                }


                var searchK = new KartaSearchRequest()
                {
                    PoAngzuje = false,
                    PoDatumu = true,
                    PoVozilu = false,
                    DatumIzdavanja = Datum.Date,
                    PoVremenu = false



                };

                var listaKarata = await _kartaService.Get<List<Karta>>(searchK);

                var testnaLista = new List<Object>();

                int brojacDodanihKarata = 0;

                foreach (var item in listaKarata)
                {
                    foreach (var item2 in TestniPodaci.ToList())
                    {
                        if (item.VrijemePolaska != item2.VrijemePolaska && item.AngazujeId == item2.AngazujeID && item.Sjediste.Red == 1 && item.Sjediste.Kolona == 1)
                        {
                            var gradP = await _gradService.GetById<Grad>(item.Angazuje.Linija.PolazisteId);
                            var gradO = await _gradService.GetById<Grad>(item.Angazuje.Linija.OdredisteId);
                            var kompanija = await _kompanijaService.GetById<Kompanija>(item.Angazuje.Vozilo.KompanijaId.Value);

                            var searchCijena = new CijenaSearchRequest()
                            {
                                LinijaID = item.Angazuje.LinijaId,
                                KompanijaID = kompanija.Id
                            };

                            var cijena = await _cijenaService.Get<List<Cijena>>(searchCijena);

                            if (brojacDodanihKarata == 0)
                            {
                                TestniPodaci.Add(new LinijaPodaci()
                                {
                                    OdredisteNaziv = gradO.Naziv,
                                    PolazisteNaziv = gradP.Naziv,
                                    Cijena = cijena.Count == 0 ? 0 : cijena[0].Iznos,
                                    Kompanija = kompanija.Naziv,
                                    AngazujeID = item.AngazujeId,
                                    VoziloID = item.Angazuje.VoziloId,
                                    DatumPretrage = Datum,
                                    VrijemePolaska = item.VrijemePolaska


                                });

                                // brojacDodanihKarata++;
                            }

                        }
                    }
                }


                foreach (var item in TestniPodaci.ToList())
                {
                    LinijaPodaciList.Add(item);
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Reverse()
        {
            var pocetak = Polaziste;
            Polaziste = Odrediste;
            Odrediste = pocetak;
        }
    }
}
