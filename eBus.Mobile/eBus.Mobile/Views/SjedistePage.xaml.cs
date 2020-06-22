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

            for (int i = 0; i < brSjedala; i++)
            {

                if( i != 0 && brK == 0 && dodajRed)
                { 
                    brR++;
                    this.gridSjedala.RowDefinitions.Add(new RowDefinition() { Height = 60 });
                    brK = 0;
                    dodajRed = false;
                }

               if(brK < 4)
                {
                    dodajRed = true;
                    this.gridSjedala.ColumnDefinitions.Add(new ColumnDefinition() { Width = 50 });

                    Button l = new Button
                    {
                        MinimumWidthRequest = 40,
                        Text = model.SjedistaList[i].Red.ToString() + " " + model.SjedistaList[i].Kolona.ToString(),
                        TextColor = Color.White,
                        CornerRadius = 10,

                        HeightRequest = 50,
                        WidthRequest = 67,
                        FontSize = 10,

                        BindingContext = model.SjedistaList[i]
                    };

                    bool zauzeto = false;



                    var searchRez = new RezervacijaSearchRequest() 
                    {
                        PoAngazmanu = true,
                        AngazmanId = _angazujeID
                    };

                    //da samo prikaze rezervacije koje se odnose na ovaj angazman
                    var listaRezervacije = await _rezervacijeService.Get<List<Rezervacija>>(searchRez);



                    foreach (var item in listaRezervacije)
                    {

                        var searchKarta = new KartaSearchRequest() // ovdje trebam dodati i vrijeme polaska pretragu
                        {
                            PoAngzuje = false,
                            PoVozilu = true,
                            Red = model.SjedistaList[i].Red,
                            Kolona = model.SjedistaList[i].Kolona,
                            PoDatumu = true,
                            DatumIzdavanja = _datum,
                            IzSjedista = true, 
                            PoVremenu = true,
                            VrijemePolaska = _vrijeme 
                           
                        };

                        var listaKarata = await _karteService.Get<List<Karta>>(searchKarta);
                        var vozilId = await _voziloService.GetById<Vozilo>(item.Karta.Angazuje.VoziloId);
                        for (int j = 0; j < listaKarata.Count; j++)
                        {

                          

                            if (item.KartaId == listaKarata[j].Id && !item.Otkazana.Value && vozilId.Id == _id && item.Karta.Angazuje.LinijaId == listaKarata[j].Angazuje.LinijaId)
                            {
                                zauzeto = true;
                                break;
                            }
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


                    if(brK == 3)
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