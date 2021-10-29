using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculti.UI.Forms
{
    public partial class ConfirmExitForm : Form
    {
        public ConfirmExitForm()
        {
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(ConfirmButton);
            ConfirmButton.DialogResult = DialogResult.OK;
            CancelButton.DialogResult = DialogResult.Cancel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
