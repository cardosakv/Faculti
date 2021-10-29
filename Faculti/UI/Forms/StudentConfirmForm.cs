using Faculti.DataClasses;
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
    public partial class StudentConfirmForm : Form
    {
        public StudentConfirmForm(Student studentToDisplay)
        {
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(ConfirmButton);

            FullNameLabel.Text = $"{studentToDisplay.FirstName} {studentToDisplay.LastName}";
            GradeSectionLabel.Text = $"{studentToDisplay.GradeLevel} - {studentToDisplay.SectionName}";
            ConfirmButton.DialogResult = DialogResult.OK;
        }
   
    }
}
