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
    public partial class ScheduleConfirmForm : Form
    {
        public ScheduleConfirmForm(string sectionName)
        {
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(ConfirmButton);
            SectionLabel.Text = sectionName;
            ConfirmButton.DialogResult = DialogResult.OK;
            CancelButton.DialogResult= DialogResult.Cancel; 
        }
    }
}
