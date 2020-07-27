using eBus.Mobile.ViewModels;
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
    public partial class Pretraga : ContentPage
    {
        PretragaViewModel model = null;
        public Pretraga()
        {
            InitializeComponent();

            BindingContext = model = new PretragaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.ListaKompanija();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            await model.Init();
            model.UkupnaVrijednost = model.PrvaVrijednost;
            

        }
    }
}