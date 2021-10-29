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
    public partial class ErrorGradeForm : Form
    {
        public ErrorGradeForm()
        {
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(ConfirmButton);
            ConfirmButton.DialogResult = DialogResult.OK;   
        }
    }
}
