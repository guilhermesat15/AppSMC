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
    public partial class MessageUserPage : ContentPage
    {
        public MessageUserPage()
        {
            InitializeComponent();

            Title = "Message";

            GetMessages();
        }

        private async void GetMessages()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("http://sgclass.somee.com/api/MessageUser");
            var messagesPersons = JsonConvert.DeserializeObject<List<MessageUser>>(response);
            MessageUserListView.ItemsSource = messagesPersons;
        }

        async void OnMessageUserSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MessageUser;
            if (item == null)
                return;

            await Navigation.PushAsync(new MessageUserDetailPage(new MessageUserDetailViewModel(item)));

            // Manually deselect item.
            MessageUserListView.SelectedItem = null;
        }
    }
}