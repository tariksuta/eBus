using eBus.Mobile.Views;
using eBus.Model;
using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _putniciService = new APIService("Putnik");
        private readonly APIService _korisniciService = new APIService("Korisnici");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await InitPrijava());
            RegistracijaCommand = new Command(Registracija);
        }

        public ICommand RegistracijaCommand { get; set; }

          async void Registracija()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new RegistracijaPage());
        }

        private string _korisnickoIme = string.Empty;

        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }

        private string _lozinka = string.Empty;

        public string Lozinka
        {
            get { return _lozinka; }
            set { SetProperty(ref _lozinka, value); }
        }

        

        public ICommand LoginCommand { get; set; }

        async Task InitPrijava()
        {

            try
            {
                APIService.KorisnickoIme = KorisnickoIme;
                APIService.Lozinka = Lozinka;

               

                await _putniciService.Get<dynamic>(null);

                var search = new KorisniciSearchRequest()
                {
                    KorisnickoIme = APIService.KorisnickoIme
                };

                var lista = await _korisniciService.Get<List<Korisnici>>(search);

                var listaPutnika = await _putniciService.Get<List<Putnik>>(new PutnikSearchRequest() { KorisnickoIme = APIService.KorisnickoIme });

                Putnik putnik = listaPutnika.Where(l => l.KorisnickoIme == APIService.KorisnickoIme).FirstOrDefault();


                bool dozvoljeno = true;
                foreach (var item in lista)
                {
                    if(item.KorisnickoIme == APIService.KorisnickoIme)
                    {
                        dozvoljeno = false;
                        await Application.Current.MainPage.DisplayAlert(" ", " Nemate pravo pristupa", "OK");
                        
                    }
                }

                if (dozvoljeno && putnik != null)
                    Application.Current.MainPage = new MainPage();
                else
                    await Application.Current.MainPage.DisplayAlert(" ", "Korisnicko ime ili lozinka su neispravni", "OK");
            }
            catch (Exception ex)
            {

                //throw new Exception(ex.Message);
            }
        }
    }
}
