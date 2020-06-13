using eBus.Mobile.ViewModels;
using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBus.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KorisnickiProfilPage : ContentPage
    {
        private readonly APIService _putniciService = new APIService("Putnik");

        KorisnickiProfilViewModel model = null;

  
        public KorisnickiProfilPage(Model.Putnik p)
        {
            InitializeComponent();

            BindingContext = model = new KorisnickiProfilViewModel()
            {
                Putnik = p
            };

           
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                var putnikzmjena = new PutnikUpsertRequest()
                {
                    DatumRegistracije = model.Putnik.DatumRegistracije,
                    Ime = model.Putnik.Ime,
                    Prezime = model.Putnik.Prezime,
                    KorisnickoIme = model.Putnik.KorisnickoIme,
                    Email = model.Putnik.Email,
                    Lozinka = this.Lozinka.Text,
                    Slika = model.Putnik.Slika,
                    PotvrdiLozinku = this.PotvrdiLozinku.Text,
                    DatumRodjenja = this.DatumRodjenja.Date
                };

                var korIme = APIService.KorisnickoIme;
                var pass = APIService.Lozinka;

               

                await _putniciService.Update<Model.Putnik>(model.Putnik.Id, putnikzmjena);

                await Application.Current.MainPage.DisplayAlert("Uspjeh", "Izmjenuli ste vaše podatke", "OK");
                if(korIme != model.Putnik.KorisnickoIme || pass != this.Lozinka.Text)
                {
                    Application.Current.MainPage = new LoginPage();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
          

        }
    }
}