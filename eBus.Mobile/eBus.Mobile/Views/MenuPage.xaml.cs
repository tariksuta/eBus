﻿using eBus.Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBus.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Notifikacija, Title="Notifikacije" },
                //new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                //new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                new HomeMenuItem {Id = MenuItemType.Novosti, Title="Novosti" },
                new HomeMenuItem {Id = MenuItemType.Linija, Title="Linije" },
                new HomeMenuItem {Id = MenuItemType.Rezervacija, Title="Rezervacije" },
                new HomeMenuItem {Id = MenuItemType.Ocjena, Title="Ocjena" },
                new HomeMenuItem {Id = MenuItemType.Profil, Title="Profil" },
                new HomeMenuItem {Id = MenuItemType.Pretraga, Title="Pretraga" },

                new HomeMenuItem {Id = MenuItemType.Odjava, Title="Odjava" },






            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}