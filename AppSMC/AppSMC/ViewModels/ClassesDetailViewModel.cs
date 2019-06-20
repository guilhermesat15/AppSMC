using System;

using AppSMC.Models;

namespace AppSMC.ViewModels
{
    public class ClassesDetailViewModel : BaseViewModel
    {
        public Classes Item { get; set; }
        public ClassesDetailViewModel(Classes item = null)
        {
            Title = "Class Detail";
            Item = item;
        }
    }
}

