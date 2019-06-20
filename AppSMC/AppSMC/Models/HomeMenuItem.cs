using System;
using System.Collections.Generic;
using System.Text;

namespace AppSMC.Models
{
    public enum MenuItemType
    {
        Classes,
        Download,
        Evaluation,
        Financial,
        Message,
        YouTubeChannelPage,
        Configuration
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
        public string IconTitle { get; set; }
    }
}
