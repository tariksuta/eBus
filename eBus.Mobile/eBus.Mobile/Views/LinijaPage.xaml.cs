using eBus.Mobile.ViewModels;
using eBus.Model;
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
    public partial class LinijaPage : ContentPage
    {
        LinijaViewModel model = null;
        public LinijaPage()
        {
            InitializeComponent();
            BindingContext = model = new LinijaViewModel();
           
            
        }

        protected async override void OnAppearing()
        {
            
            base.OnAppearing();
           // await model.Init();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            model.Reverse();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           if(!Regex.IsMatch(model.Polaziste, @"([a-zA-Z])\w+"))
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Dozvoljena su samo slova", "OK");
            }else if (!Regex.IsMatch(model.Odrediste, @"([a-zA-Z])\w+"))
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Dozvoljena su samo slova", "OK");
            }
            else
            {
                await model.Init();
            }

           

           
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if( e.SelectedItem != null)
            {
                var linija = e.SelectedItem as LinijaPodaci;

                Navigation.PushAsync(new LinijaDetaljiPage(linija));
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PreporukaPage());

           
        }
    }
}