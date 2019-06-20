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
    public partial class EvaluationDisciplinePage : ContentPage
    {
        public EvaluationDisciplinePage()
        {
            InitializeComponent();
            Title = "Evaluation";
            GetEvaluation();


        }

        async void GetEvaluation()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("http://sgclass.somee.com/api/EvaluationDiscipline");
            var evaluationDisciplines = JsonConvert.DeserializeObject<List<EvaluationDiscipline>>(response);
            EvaluationListView.ItemsSource = evaluationDisciplines;
        }

        async void OnEvaluationSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = e.SelectedItem as EvaluationDiscipline;
            if (item == null)
                return;

            await Navigation.PushAsync(new EvaluationDisciplineDetailPage(new EvaluationDisciplineDetailViewModel(item)));

            // Manually deselect item.
            EvaluationListView.SelectedItem = null;

        }

    }
}