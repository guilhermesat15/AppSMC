using AppSMC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSMC.ViewModels
{
    public class MessageUserDetailViewModel : BaseViewModel
    {
        public MessageUser Item { get; set; }
        public MessageUserDetailViewModel(MessageUser item = null)
        {
            Title = "Message Detail";
            Item = item;
        }
    }
}
