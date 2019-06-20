using AppSMC.Models;
using AppSMC.PageModels;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSMC.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Classes, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Classes:
                        MenuPages.Add(id, new NavigationPage(new ClassesPage()));
                        break;
                    case (int)MenuItemType.Download:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.Evaluation:
                        MenuPages.Add(id, new NavigationPage(new EvaluationDisciplinePage()));
                        break;
                    case (int)MenuItemType.Financial:
                        MenuPages.Add(id, new NavigationPage(new FinancialPage()));
                        break;
                    case (int)MenuItemType.Message:
                        MenuPages.Add(id, new NavigationPage(new MessageUserPage()));
                        break;
                    case (int)MenuItemType.YouTubeChannelPage:
                        MenuPages.Add(id, new NavigationPage(FreshPageModelResolver.ResolvePageModel<YouTubeChannelPageModel>()));
                        break;
                    case (int)MenuItemType.Configuration:
                        MenuPages.Add(id, new NavigationPage(new ConfigurationPage()));
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