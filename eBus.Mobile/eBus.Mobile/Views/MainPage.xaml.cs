using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using eBus.Mobile.Models;
using eBus.Model.Requests;
using System.Runtime.CompilerServices;

namespace eBus.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        private readonly APIService _putnici = new APIService("Putnik");
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

           // MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
            MenuPages.Add((int)MenuItemType.Notifikacija, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Notifikacija:
                        MenuPages.Add(id, new NavigationPage(new NotifikacijePage()));
                        break;
                    //case (int)MenuItemType.Browse:
                    //    MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                    //    break;
                    //case (int)MenuItemType.About:
                    //    MenuPages.Add(id, new NavigationPage(new AboutPage()));
                    //    break;
                    case (int)MenuItemType.Profil:
                        
                        var search = new PutnikSearchRequest()
                        {
                            KorisnickoIme = APIService.KorisnickoIme
                        };

                        var putnici = await _putnici.Get<List<Model.Putnik>>(search);
                        Model.Putnik putnik = new Model.Putnik();
                        putnik = putnici[0];
                        MenuPages.Add(id, new NavigationPage(new KorisnickiProfilPage(putnik)));
                        break;
                    case (int)MenuItemType.Novosti:
                        MenuPages.Add(id, new NavigationPage(new NovostiPage()));
                        break;
                    case (int)MenuItemType.Ocjena:
                        MenuPages.Add(id, new NavigationPage(new OcjenaPage()));
                        break;
                  
                    case (int)MenuItemType.Linija:
                        MenuPages.Add(id, new NavigationPage(new LinijaPage()));
                        break;
                    case (int)MenuItemType.Rezervacija:
                        MenuPages.Add(id, new NavigationPage(new RezervacijaPage()));
                        break;
                    case (int)MenuItemType.Odjava:
                        MenuPages.Add(id, new NavigationPage(new Logout()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}