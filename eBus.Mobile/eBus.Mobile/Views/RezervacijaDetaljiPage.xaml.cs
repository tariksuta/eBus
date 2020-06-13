using eBus.Mobile.ViewModels;
using eBus.Model;
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
    public partial class RezervacijaDetaljiPage : ContentPage
    {
        RezervacijaDetaljiViewModel model = null;
        public RezervacijaDetaljiPage(Rezervacija r)
        {
            InitializeComponent();
            BindingContext = model = new RezervacijaDetaljiViewModel()
            {
                Rezervacija = r
            };
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await model.OtkaziRezervaciju();

            await Navigation.PushAsync(new RezervacijaPage());
        }
    }
}