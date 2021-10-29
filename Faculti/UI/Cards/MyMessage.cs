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
    public partial class MyMessage : UserControl
    {
        public string Timestamp;

        public MyMessage(string message, DateTime time)
        {
            InitializeComponent();
            Timestamp = $"{time.Hour}:{time.Minute}";

            MessageLabel.Text = message;
            TimeLabel.Text = time.ToString("hh:mm tt");

            MessageContainer.Size = new Size(MessageLabel.Width + 25, MessageContainer.Size.Height);
            this.Height = MessageLabel.Height + 38;
            MessageContainer.Location = new Point(535 - MessageContainer.Width, MessageContainer.Location.Y);
        }

        public void RemoveTime()
        {
            TimeLabel.Visible = false;
            MessageContainer.Height = MessageLabel.Height + 31;
            this.Height = MessageContainer.Height;
        }

        private void MessageContainer_Click(object sender, EventArgs e)
        {

        }
    }
}
