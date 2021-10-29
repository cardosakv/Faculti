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
    public partial class ChangeStudentConfirmForm : Form
    {
        public ChangeStudentConfirmForm()
        {
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(ConfirmButton);
            ConfirmButton.DialogResult = DialogResult.OK;
        }

        private void ChangeStudentConfirmForm_Load(object sender, EventArgs e)
        {
            FormAnimation.FadeIn(this);
        }

        private void ChangeStudentConfirmForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
