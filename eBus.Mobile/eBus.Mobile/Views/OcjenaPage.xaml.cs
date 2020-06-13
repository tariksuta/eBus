using eBus.Mobile.ViewModels;
using eBus.Model;
using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBus.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OcjenaPage : ContentPage
    {
        private readonly APIService _ocjenaService = new APIService("Ocjena");
        private readonly APIService _putnikService = new APIService("Putnik");
        OcjenaViewModel model = null;
        public OcjenaPage()
        {
            InitializeComponent();
            BindingContext = model = new OcjenaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(model.Ocjena.ToString(), @"[1-5]"))
            {
               await  Application.Current.MainPage.DisplayAlert(" ", "Ocjena mora biti izmedju 1 i 5", "OK");
            }

            try
            {

                var search = new PutnikSearchRequest()
                {
                    KorisnickoIme = APIService.KorisnickoIme
                };
                var listaPutnika = await _putnikService.Get<List<Putnik>>(search);
                Putnik putnik = null;
                foreach (var item in listaPutnika)
                {
                    if(item.KorisnickoIme == APIService.KorisnickoIme)
                    {
                        putnik = item;
                        break;
                    }
                }

                var ocjena = new OcjenaUpsertRequest();

                ocjena.PutnikId = putnik.Id;
                ocjena.KompanijaId = model.Kompanija.Id;
                ocjena.OcjenaUsluge = model.Ocjena;
                ocjena.Komentar = model.Komentar;

                await _ocjenaService.Insert<Ocjena>(ocjena);

                await Application.Current.MainPage.DisplayAlert(" ", "Uspješno ste ocjenili kompaniju", "OK");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}