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
    public partial class LinijaDetaljiPage : ContentPage
    {
        LinijaDetaljiViewModel model = null;
        public LinijaDetaljiPage(LinijaPodaci l)
        {
            InitializeComponent();
            BindingContext = model = new LinijaDetaljiViewModel()
            {
                Linija = l
            };
            
            
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await model.prebaci();
            
        }

       

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            
              Navigation.PushAsync(new SjedistePage(model.Linija.VoziloID,model.Linija.AngazujeID,DateTime.Parse(model.DatumKarte),model.VrijemePo));
        }
    }
}