using AppSMC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSMC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessageUserDetailPage : ContentPage
    {
        MessageUserDetailViewModel viewModel;
        public MessageUserDetailPage()
        {
            InitializeComponent();
        }

        public MessageUserDetailPage(MessageUserDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
            this.Title = "Detail Message";

            txtTitle.Text = this.viewModel.Item.MessageUserTitle;
            txtText.Text = this.viewModel.Item.MessageUserText;
            txtDate.Text = this.viewModel.Item.MessageUserDate.ToString("dd/MM/yyyy");
            txtDetailText.Text = this.viewModel.Item.MessageUserText;

        }
    }
}