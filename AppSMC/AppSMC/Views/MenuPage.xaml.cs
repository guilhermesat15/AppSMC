using AppSMC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSMC.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Classes, Title="Classes", IconTitle="iconClasses.png" },
                new HomeMenuItem {Id = MenuItemType.Download, Title="Download", IconTitle="iconClasses.png" },
                new HomeMenuItem {Id = MenuItemType.Evaluation, Title="Evaluation", IconTitle="iconClasses.png" },
                new HomeMenuItem {Id = MenuItemType.Financial, Title="Financial", IconTitle="iconClasses.png" },
                new HomeMenuItem {Id = MenuItemType.Message, Title="Message", IconTitle="iconClasses.png" },
                new HomeMenuItem {Id = MenuItemType.YouTubeChannelPage, Title="YouTubeChannelPage", IconTitle="iconClasses.png" },
                new HomeMenuItem {Id = MenuItemType.Configuration, Title="Configuration", IconTitle="iconClasses.png" }
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