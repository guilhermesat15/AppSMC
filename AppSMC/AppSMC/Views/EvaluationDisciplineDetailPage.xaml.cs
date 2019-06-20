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
    public partial class EvaluationDisciplineDetailPage : ContentPage
    {
        List<EvaluationDiscipline> listItems = new List<EvaluationDiscipline>();

        EvaluationDisciplineDetailViewModel viewModel;
        public EvaluationDisciplineDetailPage()
        {
            InitializeComponent();

        }

        public EvaluationDisciplineDetailPage(EvaluationDisciplineDetailViewModel viewModel = null)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;

            this.Title = "Detail Evaluation";
            StringBuilder sbCountDayExpire = new StringBuilder();
            sbCountDayExpire.AppendFormat("{0} dias restantes     Terminio: 18/08", this.viewModel.Item.Takes);

            StringBuilder sbAttemp = new StringBuilder();
            sbAttemp.AppendFormat("Tentativas: {0}/{1}", this.viewModel.Item.Takes, this.viewModel.Item.Takes);

            lblDisciplineName.Text = this.viewModel.Item.DisciplineName;
            lblEvaluationDisciplineDate.Text = this.viewModel.Item.EvaluationDisciplineDate.ToString();
            lblAttempt.Text = sbAttemp.ToString();
            lblCountDayExpire.Text = sbCountDayExpire.ToString();


            GeEvaluationRegister();

            EvaluationRegisterListView.RefreshCommand = new Command(() => {
                //Do your stuff.
                RefreshData();
                EvaluationRegisterListView.IsRefreshing = false;
            });
        }
        public void RefreshData()
        {

            EvaluationRegisterListView.ItemsSource = null;
            EvaluationRegisterListView.ItemsSource = listItems;
        }

        private async void GeEvaluationRegister()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("http://sgclass.somee.com/api/EvaluationDiscipline");
            var evaluationDisciplines = JsonConvert.DeserializeObject<List<EvaluationDiscipline>>(response);
            EvaluationRegisterListView.ItemsSource = evaluationDisciplines;
            listItems = evaluationDisciplines;
        }

    }
}