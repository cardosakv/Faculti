using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculti.UI.Cards
{
    public partial class Announcement : UserControl
    {
        public Announcement(string announcementTitle, string announcementMessage)
        {
            InitializeComponent();
            AnnouncementTitleLabel.Text = announcementTitle;
            AnnouncementMessageLabel.Text = announcementMessage;
            AnnouncementBodyPanel.Height = AnnouncementMessageLabel.Height + 88;
        }

        private void AnnouncementBodyPanel_MouseHover(object sender, EventArgs e)
        {
            AnnouncementBodyPanel.BackgroundColor = Color.FromArgb(220, 231, 245);
        }

        private void AnnouncementBodyPanel_MouseLeave(object sender, EventArgs e)
        {
            AnnouncementBodyPanel.BackgroundColor = Color.FromArgb(243, 246, 250);
        }
    }
}
