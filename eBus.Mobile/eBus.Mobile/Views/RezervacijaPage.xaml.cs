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
    public partial class RezervacijaPage : ContentPage
    {
        RezervacijaViewModel model = null;
        public RezervacijaPage()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijaViewModel();
            
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
         
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            if(e.SelectedItem != null)
            {
                var rezervacije = e.SelectedItem as Rezervacija;


                await Navigation.PushAsync(new RezervacijaDetaljiPage(rezervacije));
            }
        }

    

       
    }
}