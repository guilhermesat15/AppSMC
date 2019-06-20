using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using AppSMC.Models;

namespace AppSMC.ViewModels
{
    public class MessageUserViewModel : BaseViewModel
    {
        public ObservableCollection<MessageUser> MessageUsers { get; set; }

        public MessageUserViewModel()
        {
            Title = "Message";
            MessageUsers = new ObservableCollection<MessageUser>();
        }

       
    }
}
