using System;
using System.Collections.Generic;
using System.Text;

namespace AppSMC.Models
{
    public class MessageUser
    {
        public int MessageUserId { get; set; }
        public string MessageUserTitle { get; set; }
        public string MessageUserText { get; set; }
        public DateTime MessageUserDate { get; set; }
        public string Status { get; set; }
        public int PersonId { get; set; }
        public object Person { get; set; }
    }
}
