using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faculti.UI.Cards;

namespace Faculti.UI.Cards
{
    public partial class FeedPanel : UserControl
    {
        AnnouncementPanel announcement = new AnnouncementPanel("Re: Scholarship for Freshman", 
            "The office of the dean will be accepting scholarship application from October 30 " +
            "to November 30 from 9:00 AM to 4:00 PM.\n\nYou can access the application form through " +
            "this link: https//goo.gl/4K7sn4");

        public FeedPanel()
        {
            InitializeComponent();
            AnnouncementsFlowLayoutPanel.Controls.Add(announcement);
        }
    }
}
