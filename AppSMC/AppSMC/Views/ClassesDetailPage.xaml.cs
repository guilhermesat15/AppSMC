using AppSMC.Models;
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
    public partial class ClassesDetailPage : ContentPage
    {
        ClassesDetailViewModel viewModel;
        public ClassesDetailPage(ClassesDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
            this.Title = "Detail Class";
            webView.Source = "https://i.ytimg.com/vi/uGE1VCmCKbI/mqdefault.jpg";

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, "TapCommand");
            webView.GestureRecognizers.Add(tapGestureRecognizer);
            tapGestureRecognizer.NumberOfTapsRequired = 1;

        }

        public ClassesDetailPage()
        {
            InitializeComponent();

            var classes = new Classes
            {
                IdClasses = 0,
                NameClasses = ""
            };

            viewModel = new ClassesDetailViewModel(classes);
            BindingContext = viewModel;
        }


        void TapCommand()
        {
            webView.Source = "https://www.youtube.com/watch?v=uGE1VCmCKbI";
        }

        private void btnDownloadClass_Clicked(object sender, EventArgs e)
        {
            webView.Source = "https://www.youtube.com/watch?v=uGE1VCmCKbI";
        }
    }
}