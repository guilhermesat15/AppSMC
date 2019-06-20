using AppSMC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSMC.ViewModels
{
    public class EvaluationDisciplineDetailViewModel : BaseViewModel
    {
        public EvaluationDiscipline Item { get; set; }
        public EvaluationDisciplineDetailViewModel(EvaluationDiscipline item = null)
        {
            Title = "Evaluation Detail";
            Item = item;
        }
    }
}
