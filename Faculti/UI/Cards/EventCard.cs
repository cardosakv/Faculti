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
    public partial class EventCard : UserControl
    {
        public EventCard(string classEventTitle, string desc, string type)
        {
            InitializeComponent();
            EventTimeTextBox.Text = type;
            EventTitleTextBox.Text = classEventTitle;
            EventDescTextBox.Text = desc;

            EventTimeTextBox.Enabled = false;
            EventTitleTextBox.Enabled = false;

            this.Height = EventDescTextBox.Height + 110;
        }

        public EventCard(string holidayName, string eventType)
        {
            InitializeComponent();
            EventTimeTextBox.Text = eventType;
            EventTitleTextBox.Text = holidayName;
            EventDescTextBox.Visible = false;

            EventTimeTextBox.Enabled = false;
            EventTitleTextBox.Enabled = false;

            this.Height = 107;
        }
    }
}
