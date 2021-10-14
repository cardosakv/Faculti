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
        public MyMessage(string message)
        {
            InitializeComponent();
            MessageLabel.Text = message;
            this.Height = MessageLabel.Height + 35;
        }
    }
}
