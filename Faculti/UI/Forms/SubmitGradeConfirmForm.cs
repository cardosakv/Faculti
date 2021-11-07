using Faculti.DataClasses;
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
        private int _teacherId;
        private Dictionary<string, int> _currGradingGrades;

        public SubmitGradeConfirmForm(Dictionary<string, int> currGradingGrades, int currGrading, string currStudentId, int average, int teacherId)
        {
            InitializeComponent();
            FormAnimation.FadeIn(this);
            ControlInteractives.SetButtonHoverEvent(ConfirmButton);

            _teacherId = teacherId;
            _currStudentId = currStudentId;
            _currGrading = currGrading; 
            _currGradingGrades = currGradingGrades;
            _average = average;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!SubmitGradesWorker.IsBusy) SubmitGradesWorker.RunWorkerAsync();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitGrades_DoWork(object sender, DoWorkEventArgs e)
        {
            DatabaseClient client = new DatabaseClient();
            string cmdText;

            foreach (KeyValuePair<string, int> grade in _currGradingGrades)
            {
                client = new DatabaseClient();
                cmdText = $"update grades set mark_{_currGrading} = {grade.Value}, last_average = {_average}, last_grading = {_currGrading}, last_update = to_date('{DateTime.Now:MM/dd/yyyy}', 'MM/DD/YYYY') where sub_name = '{grade.Key}' and student_id = {_currStudentId}";
                client.PerformNonQueryCommand(cmdText);
            }

            client.Conn.Open();
            cmdText = $"insert into updates (update_type, text, created_time, receiver_id, sender_id, sender_user_type) values ('grades', 'Latest grades have been submitted by the teacher.', to_date('{DateTime.Now:MM/dd/yyyy HH:mm:ss}', 'MM/DD/YYYY HH24:MI:SS'), {_currStudentId}, {_teacherId}, 'teachers')";
            client.PerformNonQueryCommand(cmdText);
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
