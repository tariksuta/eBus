using eBus.Mobile.ViewModels;
using eBus.Model;
using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBus.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SjedistePage : ContentPage
    {
        SjedisteViewModel model = null;
        private int _id = 0;
        private int _angazujeID = 0;
        private DateTime _datum;
        private TimeSpan _vrijeme;
        private Sjediste odabranoSjedaloObj = null;

        private readonly APIService _rezervacijeService = new APIService("Rezervacija");
        private readonly APIService _karteService = new APIService("Karta");
        private readonly APIService _voziloService = new APIService("Vozilo");
        private readonly APIService _sjedistaService = new APIService("Sjediste");

        public SjedistePage(int VoziloID, int AngazujeID,DateTime DatumPretrage, TimeSpan vrijeme)
        {
            InitializeComponent();
            BindingContext = model = new SjedisteViewModel();
            _id = VoziloID;
            _angazujeID = AngazujeID;
            _datum = DatumPretrage;
            _vrijeme = vrijeme;
        }

        protected async override void OnAppearing()
        {
            model.Angazman = _angazujeID;
            base.OnAppearing();
            await model.Init(_id);

          



            var brSjedala = model.BrojSjedalaDodnih;
            this.gridSjedala.Children.Clear();

            //this.gridSjedala.VerticalOptions = LayoutOptions.CenterAndExpand;
            this.gridSjedala.HorizontalOptions = LayoutOptions.CenterAndExpand;
            this.gridSjedala.RowDefinitions = new RowDefinitionCollection();
            this.gridSjedala.ColumnDefinitions = new ColumnDefinitionCollection();

            var brR = 0;

            this.gridSjedala.RowDefinitions.Add(new RowDefinition() { Height = 60 }); 

            var brK = 0;

            bool dodajRed = false;

           

                   

                    var searchRez = new RezervacijaSearchRequest() 
                    {
                        PoAngazmanu = true,
                        AngazmanId = _angazujeID
                    };

                    //da samo prikaze rezervacije koje se odnose na ovaj angazman
                    var listaRezervacije = await _rezervacijeService.Get<List<Rezervacija>>(searchRez);

                    var searchSjedista = new SjedisteSearchRequest()
                    {
                        VoziloId = _id
                    };

                    var listaSjedista = await _sjedistaService.Get<List<Model.Sjediste>>(searchSjedista);

            var brojac = 0;

                    foreach (var sjediste in listaSjedista)
                    {

                        if (brojac != 0 && brK == 0 && dodajRed)
                        {
                            brR++;
                            this.gridSjedala.RowDefinitions.Add(new RowDefinition() { Height = 60 });
                            brK = 0;
                            dodajRed = false;
                        }

                        dodajRed = true;
                        this.gridSjedala.ColumnDefinitions.Add(new ColumnDefinition() { Width = 50 });

                        Button l = new Button
                        {
                            MinimumWidthRequest = 40,
                            Text = sjediste.Red.ToString() + " " + sjediste.Kolona.ToString(),
                            TextColor = Color.White,
                            CornerRadius = 10,

                            HeightRequest = 50,
                            WidthRequest = 67,
                            FontSize = 10,

                            BindingContext = sjediste
                        };

                       bool zauzeto = false;

                        if (brK < 4)
                        {

                       
                            foreach (var rezervacija in listaRezervacije)
                            {
                                if (rezervacija.Karta.SjedisteId == sjediste.Id && rezervacija.Karta.DatumIzdavanja.Date == _datum.Date)
                                {
                                    zauzeto = true;
                               
                                }
                            }

                            if (zauzeto)
                            {
                                l.BackgroundColor = Color.Red;
                            }
                            else
                            {
                                l.BackgroundColor = Color.Green;
                                l.Pressed += btn_Clicked;
                            }

                             this.gridSjedala.Children.Add(l, brK, brR);

                                if (brK == 3)
                                {
                                    brK = 0;

                                }
                                else
                                {
                                    brK++;
                                }

                        }
                        else
                        {
                            brK = 0;
                        }

                          brojac++;

                    }




            model.Poruka = false;
            model.VidljivaSjedista = true;

        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            for (int i = 0; i < this.gridSjedala.ColumnDefinitions.Count; i++)
            {
                var btn2 = this.gridSjedala.Children[i] as Button;
                if (btn2.Text != btn.Text && btn2.IsEnabled == false)
                {
                    btn2.IsEnabled = true;
                    btn2.BackgroundColor = Color.Green;
                }

            }

            btn.BackgroundColor = Color.Gray;
            btn.IsEnabled = false;
            this.nastavidalje.IsVisible = true;
            this.odabranoSjedalo.Text = btn.Text;
            this.odabranoSjedaloObj = btn.BindingContext as Sjediste;
            this.poruka.Text = "Odabrali ste sjedalo sa oznakom: " + btn.Text + ". ";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await model.KupiKartu(this.odabranoSjedaloObj,_datum,_vrijeme);
        }
    }
}