using eBus.Model;
using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModels
{
    public class RezervacijaDetaljiViewModel : BaseViewModel
    {
        private readonly APIService _rezervacijeService = new APIService("Rezervacija");
        public RezervacijaDetaljiViewModel()
        {
            Title = "Rezervacija";
        }
        public Rezervacija Rezervacija { get; set; }

        public async Task OtkaziRezervaciju()
        {
            if(Rezervacija != null)
            {
                if (Rezervacija.Karta.DatumIzdavanja > DateTime.Now)
                {
                    await _rezervacijeService.Update<Rezervacija>(Rezervacija.Id, new RezervacijaUpsertRequest()
                    {
                        DatumIsteka = Rezervacija.DatumIsteka,
                        DatumKreiranja = Rezervacija.DatumKreiranja,
                        KartaId = Rezervacija.KartaId,
                        PutnikId = Rezervacija.PutnikId,
                        Qrcode = Rezervacija.Qrcode,
                        Otkazana = true
                    });

                    await Application.Current.MainPage.DisplayAlert(" ", "Poništili ste rezervaciju", "OK");

                    
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert(" ", "Rezervacija se ne može poništiti", "OK");
                }
            }
          


        }
    }
}
