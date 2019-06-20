using AppSMC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSMC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinancialPage : ContentPage
    {
        public FinancialPage()
        {
            InitializeComponent();

            Title = "Financial";

            GetFinancials();
        }

        private async void GetFinancials()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("http://sgclass.somee.com/api/financial");
            var financials = JsonConvert.DeserializeObject<List<Financial>>(response);
            FinancialListView.ItemsSource = financials;
        }

        private void OnFinancialSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}