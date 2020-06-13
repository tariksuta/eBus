using eBus.Mobile.Models;
using eBus.Model;
using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBus.Mobile.ViewModels
{
    public class Preporuka2ViewModel
    {
        private readonly APIService _putniciService = new APIService("Putnik");
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");
        private readonly APIService _karteService = new APIService("Karta");
        private readonly APIService _angazujeService = new APIService("Angazuje");
        private readonly APIService _cijenaService = new APIService("Cijena");
        private readonly APIService _linijaService = new APIService("Linija");
        private readonly APIService _kompanijeService = new APIService("Kompanija");
        private readonly APIService _gradService = new APIService("Grad");

        public ObservableCollection<LinijaPodaci> ListaLinija { get; set; } = new ObservableCollection<LinijaPodaci>();

        public async Task Init()
        {

            var listaPutnika = await _putniciService.Get<List<Putnik>>(new PutnikSearchRequest() { KorisnickoIme = APIService.KorisnickoIme });

            //pronadjemo putnika koji je logovan
             Putnik putnik = listaPutnika.FirstOrDefault(l => l.KorisnickoIme == APIService.KorisnickoIme);

            if(putnik != null)
            {

                //preuzmemo sve rezervacije za putnika
                var mojeRezervacije = await _rezervacijaService.Get<List<Rezervacija>>(new RezervacijaSearchRequest()
                {
                    PoAngazmanu = false,
                    PutnikId = putnik.Id
                });

               


                Dictionary<int, int> Angazman = new Dictionary<int, int>();

                int brojac = 0;

                var listaOdredista = new List<int>();
                var listaPolazista = new List<int>();
                foreach (var item in mojeRezervacije)
                {

                    var linija = await _linijaService.GetById<Linija>(item.Karta.Angazuje.LinijaId);

                    // zabiljezimo sva odredista i polazista iz karata koje je putnik rezervisao
                    // radi kasnije provjere
                    listaOdredista.Add(linija.OdredisteId);
                    listaPolazista.Add(linija.PolazisteId);
                   
                }

                var listaAngazmana = await _angazujeService.Get<List<Angazuje>>(null);

                

                foreach (var item in listaAngazmana)
                {
                    var brojacRez = 0;
                    for (int i = 0; i < listaOdredista.Count; i++)
                    {
                        // kako mora biti isti broj odredista i polazista nije bitno koju listu izmemo za petlji
                        // poredimo koliko puta se pojavljuju spremljeni polaziste i odrediste u angazmanu
                        if(item.Linija.OdredisteId == listaOdredista[i] && item.Linija.PolazisteId == listaPolazista[i] 
                            && item.DatumIsteka.Date > DateTime.Now.Date)
                        {
                            brojacRez++;
                           
                            
                        }
                    }

                    if (brojacRez >= 2)
                    {
                        if (!Angazman.ContainsKey(item.Id))
                        {
                            //spasimo angazman tj njegova id za svaki koji ima veci od dva ponavljanja
                            Angazman.Add(item.Id, brojacRez);
                        }
                    }
                }

                ListaLinija.Clear();

                // prolazimo petljom kroz spremljene angazmane koji su ispunili prethodni uslov
                foreach (var item in Angazman)
                {
                    var angazuje = await _angazujeService.GetById<Angazuje>(item.Key);

                    var cijena = await _cijenaService.Get<List<Model.Cijena>>(new CijenaSearchRequest() { LinijaID = angazuje.LinijaId, KompanijaID = angazuje.Vozilo.KompanijaId});

                    var linija = await _linijaService.GetById<Linija>(angazuje.LinijaId);

                    var polaz = await _gradService.GetById<Grad>(linija.PolazisteId);
                    var odred = await _gradService.GetById<Grad>(linija.OdredisteId);

                    var karta = await _karteService.Get<List<Karta>>(new KartaSearchRequest()
                    {
                        PoAngzuje = true,
                        AngazujeID = item.Key,  // ovaj upit poboljsati
                        PoDatumu = false,
                        PoVremenu = false

                    });

                    // prolazimo kroz listu karata u odnosu na angazujeID
                    foreach (var item2 in karta.OrderBy(k => k.VrijemePolaska).OrderBy(l => l.DatumIzdavanja))
                    {

                        // pronadjemo svaku prvu kartu gdje je i datum izdavanja veci od danasnjeg datuma
                        // isto tako da datum izdavanja ne prelazi vise od pet dana radi obimnosti
                        // jer prikazuje sve kompanije i njihova vremena
                        if( item2.Sjediste.Red == 1 && item2.Sjediste.Kolona == 1 && item2.DatumIzdavanja.Date >= DateTime.Now.Date
                            && item2.DatumIzdavanja.Date <= DateTime.Now.AddDays(5))
                        {
                            ListaLinija.Add(new LinijaPodaci()
                            {
                                AngazujeID = angazuje.Id,
                                DatumPretrage = item2.DatumIzdavanja.Date,
                                VoziloID = angazuje.VoziloId,
                                Cijena = cijena[0].Iznos,
                                Kompanija = angazuje.Vozilo.Model,
                                OdredisteNaziv = odred.Naziv,
                                PolazisteNaziv = polaz.Naziv,
                                VrijemePolaska = item2.VrijemePolaska
                            });
                        }
                       
                    }
                   
                }

            }

          
        }
    }
}
