using AppSMC.Models;
using AppSMC.ViewModels;
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
    public partial class ClassesPage : ContentPage
    {
        public ClassesPage()
        {
            InitializeComponent();

            Title = "Classes";
            GetClasses();
        }

        private async void GetClasses()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("http://sgclass.somee.com/api/classes");
            var classes = JsonConvert.DeserializeObject<List<Classes>>(response);
            ClassesListView.ItemsSource = classes;
        }

        async void OnClassesSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Classes;
            if (item == null)
                return;

            await Navigation.PushAsync(new ClassesDetailPage(new ClassesDetailViewModel(item)));

            // Manually deselect item.
            ClassesListView.SelectedItem = null;
        }

        private void btnClass_Clicked(object sender, EventArgs e)
        {
            int indexClass = (sender as Button).TabIndex;
        }
    }
}