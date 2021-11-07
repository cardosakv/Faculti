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
    public partial class NotifCard : UserControl
    {
        private readonly DateTime _time;
        public string Type;

        public NotifCard(string type, string desc, DateTime time)
        {
            InitializeComponent();
            WireAllControls(this);
            Description.Text = desc;
            _time = time;

            if (type == "grades")
            {
                IconLabel.Text = "☑";
            }
            else if (type == "feed")
            {
                IconLabel.Text = "📰";
            }
            else if (type == "chat")
            {
                IconLabel.Text = "💬";
            }
            else
            {
                IconLabel.Text = "📆";
            }
        }

        public void UpdateTime()
        {
            TimeSpan lastSpan = DateTime.Now - _time;
            double lastUpdate = lastSpan.TotalSeconds / 60;
            string lastUpdateString;

            if (lastUpdate >= 1440)
            {
                lastUpdate /= 1440;
                lastUpdateString = $"{Convert.ToInt32(lastUpdate)} day ago";
            }
            else if (lastUpdate >= 60)
            {
                lastUpdate /= 60;
                lastUpdateString = $"{Convert.ToInt32(lastUpdate)} hour ago";
            }
            else if (Convert.ToInt32(lastUpdate) == 0)
            {
                lastUpdateString = "Now";
            }
            else
            {
                lastUpdateString = $"{Convert.ToInt32(lastUpdate)} min ago";
            }

            TimeLabel.Text = lastUpdateString;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                ctl.Click += (s, o) =>
                {
                    this.InvokeOnClick(this, EventArgs.Empty);
                };

                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }
    }
}
