using Faculti.Services.FacultiDB;
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
    public partial class SubmitGradeConfirmForm : Form
    {
        private string _currStudentId;
        private int _currGrading;
        private int _average;
        private Dictionary<string, int> _currGradingGrades;

        public SubmitGradeConfirmForm(Dictionary<string, int> currGradingGrades, int currGrading, string currStudentId, int average)
        {
            InitializeComponent();
            FormAnimation.FadeIn(this);
            ControlInteractives.SetButtonHoverEvent(ConfirmButton);

            _currStudentId = currStudentId;
            _currGrading = currGrading; 
            _currGradingGrades = currGradingGrades;
            _average = average;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SubmitGradesWorker.RunWorkerAsync();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitGrades_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (KeyValuePair<string, int> grade in _currGradingGrades)
            {
                DatabaseClient client = new DatabaseClient();
                var cmdText = $"update grades set mark_{_currGrading} = {grade.Value}, last_average = {_average}, last_grading = {_currGrading}, last_update = to_date('{DateTime.Now:MM/dd/yyyy}', 'MM/DD/YYYY') where sub_name = '{grade.Key}' and student_id = {_currStudentId}";
                client.PerformNonQueryCommand(cmdText);
            }
        }

        private async void SubmitGrades_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressPanel.Visible = true;

            await Task.Delay(1000);
            this.DialogResult = DialogResult.OK;
        }

        private void SubmitGradeConfirmForm_Load(object sender, EventArgs e)
        {
            CircleProgress.Value = 99;
        }

        private void CircleProgress_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }
    }
}
