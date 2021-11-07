using Faculti.DataClasses;
using Faculti.Services.FacultiDB;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faculti.UI.Cards;

namespace Faculti.UI.Cards
{
    public partial class TeacherHomePanel : UserControl
    {
        private readonly Teacher _teacherUser;
        private DatabaseClient _dashboardClient;
        private DatabaseClient _classInfoClient;
        private DatabaseClient _notesClient;
        private DatabaseClient _scheduleClient;
        private OracleDataReader _scheduleRdr;
        private OracleDataReader _classInfoRdr;
        private OracleDataReader _notesRdr;
        private string _exams;
        private string _assignments;
        private string _totalStudents;

        public TeacherHomePanel(Teacher teacherUser)
        {
            _teacherUser = teacherUser;
            InitializeComponent();
            UpdateData();
        }

        public async void UpdateData()
        {
            await GetNotes();
            if (!DashboardWorker.IsBusy) DashboardWorker.RunWorkerAsync();
            if (!ScheduleWorker.IsBusy) ScheduleWorker.RunWorkerAsync();
            if (!ClassInfoWorker.IsBusy) ClassInfoWorker.RunWorkerAsync();
        }

        private async Task GetNotes()
        {
            try
            {
                DatabaseClient client = new DatabaseClient();
                var cmdText = $"select text from notes where teacher_id = {_teacherUser.Id}";
                OracleCommand cmd = new OracleCommand(cmdText, client.Conn);
                OracleDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    NotesTextBox.Text = rdr.IsDBNull(0) ? string.Empty : rdr.GetString(0);
                }
            }
            catch (Exception)
            {
                await GetNotes();
            }
        }


        private void DashboardWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _dashboardClient = new DatabaseClient();
                var cmdText = $"select count(*) from calendar where is_exam = 'Y' and section_name = '{_teacherUser.SectionName}'";
                OracleCommand cmd = new OracleCommand(cmdText, _dashboardClient.Conn);
                var examsT = cmd.ExecuteScalar();
                _exams = examsT.ToString();

                cmdText = $"select count(*) from calendar where is_ass = 'Y' and section_name = '{_teacherUser.SectionName}'";
                cmd = new OracleCommand(cmdText, _dashboardClient.Conn);
                var assigns = cmd.ExecuteScalar();
                _assignments = assigns.ToString();

                _dashboardClient.Close();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void DashboardWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                ClassesToday_Label.Text = "9";
                Exams_Label.Text = _exams;
                Assignments_Label.Text = _assignments;
                ClassesLoader.Visible = false;
                ExamsLoader.Visible = false;
                AssignsLoader.Visible = false;
            }  
        }

        private void ScheduleWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var i = 1;
                _scheduleClient = new DatabaseClient();
                var cmdText = $"select sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++} from schedules where section_name = '{_teacherUser.SectionName}'";
                OracleCommand cmd = new OracleCommand(cmdText, _scheduleClient.Conn);
                _scheduleRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void ScheduleWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (_scheduleRdr.Read())
                {
                    for (int i = 0; i < _scheduleRdr.FieldCount;)
                    {
                        var subName = _scheduleRdr.GetString(i++);
                        var subTime = _scheduleRdr.GetOracleDate(i++).Value;
                        Schedule sub = new Schedule(subName, subTime);
                        ScheduleFlowLayoutPanel.Controls.Add(sub);
                    }
                }

                _scheduleClient.Close();
                ScheduleLoader.Visible = false;
            }
            else
            {
                _scheduleClient.Close();
                ScheduleWorker.RunWorkerAsync();
            }
        }

        private void ClassInfoWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _classInfoClient = new DatabaseClient();
                var cmdText = $"select grade_level from schedules where section_name = '{_teacherUser.SectionName}'";
                OracleCommand cmd = new OracleCommand(cmdText, _classInfoClient.Conn);
                _classInfoRdr = cmd.ExecuteReader();

                cmdText = $"select count(*) from students where section_name = '{_teacherUser.SectionName}'";
                cmd = new OracleCommand(cmdText, _classInfoClient.Conn);
                var students = cmd.ExecuteScalar();
                _totalStudents = students.ToString();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void ClassInfoWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (_classInfoRdr.Read())
                {
                    GradeSection_Label.Text = $"{_classInfoRdr.GetString(0)} - {_teacherUser.SectionName}";
                    NumStudentsLabel.Text = $"{_totalStudents}";

                    InfoAndNotesLoader.Visible = false;
                }

                _classInfoClient.Conn.Close();
            }
            else
            {
                if (_classInfoClient.Conn != null) _classInfoClient.Close();
                ClassInfoWorker.RunWorkerAsync();
            }
        }

        private void NotesWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _notesClient = new DatabaseClient();
                var cmdText = $"update notes set text = q'[{NotesTextBox.Text}]' where teacher_id = {_teacherUser.Id}";
                _notesClient.PerformNonQueryCommand(cmdText);
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void NotesWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //
        }

        private void NotesTimer_Tick(object sender, EventArgs e)
        {
            if (!NotesWorker.IsBusy) NotesWorker.RunWorkerAsync();
        }

        private void NotesTextBox_TextChanged(object sender, EventArgs e)
        {
            SavedLabel.Visible = false;
        }

        private void ClassesLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardTimer_Tick(object sender, EventArgs e)
        {
            if (!DashboardWorker.IsBusy) DashboardWorker.RunWorkerAsync();
        }
    }
}
