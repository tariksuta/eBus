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
    public partial class PreporukaPage : ContentPage
    {
        
        Preporuka2ViewModel model2 = null;
        public PreporukaPage()
        {
            InitializeComponent();
            BindingContext = model2 = new Preporuka2ViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model2.Init();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                var linija = e.SelectedItem as LinijaPodaci;

                Navigation.PushAsync(new LinijaDetaljiPage(linija));
            }
        }
    }
}