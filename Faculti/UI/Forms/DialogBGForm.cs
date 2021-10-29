using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faculti.UI.Forms;

namespace Faculti.UI.Forms
{
    public partial class DialogBGForm : Form
    {
        public DialogBGForm()
        {
            InitializeComponent();
        }

        private void DialogBGForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;

            Timer fadeInTimer = new Timer { Interval = 30 };
            fadeInTimer.Start();
            fadeInTimer.Tick += (o, i) =>
            {
                if (this.Opacity >= 0.6) fadeInTimer.Stop();
                this.Opacity += 0.2;
            };
        }

        private void DialogBGForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
