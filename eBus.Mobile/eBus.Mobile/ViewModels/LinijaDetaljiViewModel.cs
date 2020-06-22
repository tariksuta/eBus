using eBus.Mobile.Services;
using eBus.Model;
using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eBus.Mobile.ViewModels
{
    public class LinijaDetaljiViewModel : BaseViewModel
    {
        private readonly APIService _vozilaService = new APIService("Vozilo");
        private readonly APIService _kartaService = new APIService("Karta");

        public LinijaDetaljiViewModel()
        {
            Title = "Linija";
        }
       

        public LinijaPodaci Linija { get; set; }

        private string _vozilo = string.Empty;

        public string Vozilo
        {
            get { return _vozilo; }
            set { SetProperty(ref _vozilo, value); }
        }

       

        private string _datumKarte = string.Empty;

        public string DatumKarte
        {
            get { return _datumKarte; }
            set { SetProperty(ref _datumKarte, value); }
        }

        private TimeSpan _vrijemePo;
        public TimeSpan VrijemePo
        {
            get { return _vrijemePo; }
            set { SetProperty(ref _vrijemePo, value); }
        }

        private TimeSpan _vrijemeDo;

        public TimeSpan VrijemeDo
        {
            get { return _vrijemeDo; }
            set { SetProperty(ref _vrijemeDo, value); }
        }


        public async Task prebaci()
        {
            var vozilo = await _vozilaService.GetById<Vozilo>(Linija.VoziloID);
            var search = new KartaSearchRequest()
            {
                PoAngzuje = true,
                PoVozilu = false,
                AngazujeID = Linija.AngazujeID,
                DatumIzdavanja = Linija.DatumPretrage,
                PoDatumu = true,
                PoVremenu = true,
                VrijemePolaska = Linija.VrijemePolaska

              
              
            };

            var listaKarata = await _kartaService.Get<List<Model.Karta>>(search);

            if (listaKarata.Count == 0)
            {
                // DatumKarte = "NE POSTOJI KARTA ZA TRAZENI DATUM";
            }
            else
            {
                
                        DatumKarte = listaKarata[0].DatumIzdavanja.ToString("MM/dd/yyyy");
                VrijemePo = listaKarata[0].VrijemePolaska;
                VrijemeDo = listaKarata[0].VrijemeDolaska;
            }
                

            Vozilo = vozilo.Model;

        }
    }
}
