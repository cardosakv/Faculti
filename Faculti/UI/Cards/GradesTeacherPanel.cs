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
using Faculti.UI.Forms;
using Faculti.Services.FacultiDB;
using Oracle.ManagedDataAccess.Client;

namespace Faculti.UI.Cards
{
    public delegate void NotifyGradeChange();

    public partial class GradesTeacherPanel : UserControl
    {
        private readonly Teacher _teacherUser;
        private string _currStudentId;
        private string _currStudentName;
        private int _currGrading = 0;
        private readonly Dictionary<string, string> _studentList = new Dictionary<string, string>();
        private Dictionary<string, int> _currGradingGrades = new Dictionary<string, int>();
        private Dictionary<string, int> _gradeDiffs = new Dictionary<string, int>();
        private DatabaseClient _getGradesClient = new DatabaseClient();
        private OracleDataReader _getGradesRdr;
        private OracleDataReader _gradingRdr;
        private DatabaseClient _getStudListClient = new DatabaseClient();
        private OracleDataReader _getStudListRdr;
        private SecurityCheckPanel _securityCheck;
        private bool _isReverted = false;
        private OracleDataReader _gradingRdr2;

        public GradesTeacherPanel(Teacher teacherUser)
        {
            InitializeComponent();

            _teacherUser = teacherUser;
            _securityCheck = new SecurityCheckPanel(teacherUser);
            _securityCheck.Location = new Point(0, 0);
            this.Controls.Add(_securityCheck);
            _securityCheck.BringToFront();

            ControlInteractives.SetButtonHoverEvent(SubmitButton);
            GetStudentsWorker.RunWorkerAsync();
        }

        private void GetStudentsWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _getStudListClient = new DatabaseClient();
                var cmdText = $"select student_id, last_name, first_name from students where section_name = '{_teacherUser.SectionName}' order by last_name asc";
                OracleCommand cmd = new OracleCommand(cmdText, _getStudListClient.Conn);
                _getStudListRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void GetStudentsWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                while (_getStudListRdr.Read())
                {
                    _studentList.Add($"{_getStudListRdr.GetString(1)}, {_getStudListRdr.GetString(2)}", _getStudListRdr.GetString(0));
                }

                _getStudListClient.Close();
                PopulateStudentDropDown();
            }
            else
            {
                _getStudListClient.Close();
                GetStudentsWorker.RunWorkerAsync();
            }
        }

        private void PopulateStudentDropDown()
        {
            foreach (var student in _studentList.Keys)
            {
                StudentDropDown.Items.Add(student);
            }
        }

        public void CalculateGradeStats()
        { 
            foreach (GradeRecord gradeRec in GradeRecordLayoutPanel.Controls)
            {
                if (_currGrading == 1)
                {
                    _currGradingGrades[gradeRec.SubjectName] = gradeRec.Grade1;
                }
                else if (_currGrading == 2)
                {
                    _currGradingGrades[gradeRec.SubjectName] = gradeRec.Grade2;
                }
                else if (_currGrading == 3)
                {
                    _currGradingGrades[gradeRec.SubjectName] = gradeRec.Grade3;
                }
                else if (_currGrading == 4)
                {
                    _currGradingGrades[gradeRec.SubjectName] = gradeRec.Grade4;
                }
                else if (_currGrading == 5)
                {
                    _currGradingGrades[gradeRec.SubjectName] = gradeRec.GradeFinal;
                }

                _gradeDiffs[gradeRec.SubjectName] = gradeRec.GainFall;
            }

            int average = 0;
            try
            {
                average = _currGradingGrades.Sum(x => x.Value) / (_currGradingGrades.Count - _currGradingGrades.Values.Count(v => v.Equals(0)));
            }
            catch (Exception)
            {
                // Do nothing hahaha.
            }
            
            var highest = _currGradingGrades.FirstOrDefault(x => x.Value == _currGradingGrades.Values.Max()).Key;
            var lowest = _currGradingGrades.FirstOrDefault(x => x.Value == _currGradingGrades.Values.Min()).Key;
            string greatestGain = "-";
            string biggestDrop = "-";

            if (_currGrading != 1)
            {
                greatestGain = _gradeDiffs.FirstOrDefault(x => x.Value == _gradeDiffs.Values.Max()).Key;
                biggestDrop = _gradeDiffs.FirstOrDefault(x => x.Value == _gradeDiffs.Values.Min()).Key;
            }

            AverageCircleProgress.Value = average;
            HighestLabel.Text = highest;
            LowestLabel.Text = lowest;
            GreatestGainLabel.Text = greatestGain;
            BiggestDropLabel.Text = biggestDrop;
        }

        public void ResetStudentStats()
        {
            GradeRecordLayoutPanel.Controls.Clear();
            AverageCircleProgress.Value = 0;
            HighestLabel.Text = "-";
            LowestLabel.Text = "-";
            GreatestGainLabel.Text = "-";
            BiggestDropLabel.Text = "-";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateGrades() == true)
            {
                DialogBGForm bgForm = new DialogBGForm();
                using (SubmitGradeConfirmForm confirm = new SubmitGradeConfirmForm(_currGradingGrades, _currGrading, _currStudentId, AverageCircleProgress.Value, _teacherUser.Id))
                {
                    bgForm.Show();
                    confirm.Owner = bgForm;

                    if (confirm.ShowDialog() == DialogResult.OK)
                    {
                        bgForm.Dispose();
                        if (!RecordCheckWorker.IsBusy) RecordCheckWorker.RunWorkerAsync();
                    }

                    bgForm.Dispose();
                }
            }
            else
            {
                DialogBGForm bgForm = new DialogBGForm();
                using (ErrorGradeForm error = new ErrorGradeForm())
                {
                    bgForm.Show();
                    error.Owner = bgForm;
                    error.ShowDialog();
                    bgForm.Dispose();
                }
            }
        }

        private bool ValidateGrades()
        {
            foreach (KeyValuePair<string, int> grade in _currGradingGrades)
            {
                if (grade.Value <= 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void StudentDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!GradingWorker.IsBusy) GradingWorker.RunWorkerAsync();

            if (_currGrading == 0 || _currGrading == 5)
            {
                _currStudentId = _studentList[StudentDropDown.SelectedItem.ToString()];
                _currStudentName = StudentDropDown.SelectedItem.ToString();
                if (!RecordCheckWorker.IsBusy) RecordCheckWorker.RunWorkerAsync();
            }
            else if (AverageCircleProgress.Value != 0 && !_isReverted)
            {
                DialogBGForm bgForm = new DialogBGForm();
                using (ChangeStudentConfirmForm confirm = new ChangeStudentConfirmForm())
                {
                    bgForm.Show();
                    confirm.Owner = bgForm;

                    if (confirm.ShowDialog() == DialogResult.OK)
                    {
                        _isReverted = false;
                        _currStudentId = _studentList[StudentDropDown.SelectedItem.ToString()];
                        _currStudentName = StudentDropDown.SelectedItem.ToString();
                        if (!RecordCheckWorker.IsBusy) RecordCheckWorker.RunWorkerAsync();
                    }
                    else
                    {
                        _isReverted = true;
                        StudentDropDown.SelectedValue = _currStudentName;
                        StudentDropDown.SelectedItem = _currStudentName;
                    }

                    bgForm.Dispose();
                }
            }
            else if (AverageCircleProgress.Value != 0 && _isReverted)
            {
                _isReverted = false;
                StudentDropDown.SelectedValue = _currStudentName;
                StudentDropDown.SelectedItem = _currStudentName;
            }
            else if (AverageCircleProgress.Value == 0)
            {
                _isReverted = false;
                _currStudentId = _studentList[StudentDropDown.SelectedItem.ToString()];
                _currStudentName = StudentDropDown.SelectedItem.ToString();
                if (!RecordCheckWorker.IsBusy) RecordCheckWorker.RunWorkerAsync();
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (StudentDropDown.SelectedIndex != 0)
            {
                StudentDropDown.SelectedIndex--;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (StudentDropDown.SelectedIndex != StudentDropDown.Items.Count - 1)
            {
                StudentDropDown.SelectedIndex++;
            }
        }

        private void GetGradesWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _getGradesClient = new DatabaseClient();
                var cmdText = $"select sub_name, mark_1, mark_2, mark_3, mark_4 from grades where student_id = '{_currStudentId}' order by sub_name asc";
                OracleCommand cmd = new OracleCommand(cmdText, _getGradesClient.Conn);
                _getGradesRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void GetGradesWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                ResetStudentStats();

                while (_getGradesRdr.Read())
                {
                    var subName = _getGradesRdr.GetString(0);
                    var grade1 = _getGradesRdr.IsDBNull(1) ? null : _getGradesRdr.GetString(1);
                    var grade2 = _getGradesRdr.IsDBNull(2) ? null : _getGradesRdr.GetString(2);
                    var grade3 = _getGradesRdr.IsDBNull(3) ? null : _getGradesRdr.GetString(3);
                    var grade4 = _getGradesRdr.IsDBNull(4) ? null : _getGradesRdr.GetString(4);

                    _currGradingGrades = new Dictionary<string, int>();
                    _gradeDiffs = new Dictionary<string, int>();
                    _currGradingGrades.Add(subName, 0);
                    _gradeDiffs.Add(subName, 0);

                    GradeRecord subjectGrade = new GradeRecord(subName, grade1, grade2, grade3, grade4, _teacherUser);
                    subjectGrade.NotifyParentGradeChangeEvent += new NotifyGradeChange(CalculateGradeStats);
                    GradeRecordLayoutPanel.Controls.Add(subjectGrade);

                    if (_currGrading == 5) CalculateGradeStats();
                }

                _getGradesClient.Close();
            }
            else
            {
                _getGradesClient.Close();
                GetGradesWorker.RunWorkerAsync();
            }
        }

        private void RecordCheckWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DatabaseClient client = new DatabaseClient();
                string cmdText = $"select * from grades where student_id = {_currStudentId}";
                OracleCommand cmd = new OracleCommand(cmdText, client.Conn);
                OracleDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                if (!rdr.HasRows)
                {
                    rdr.Close();

                    cmdText = $"select sub_name_1, sub_name_2, sub_name_3, sub_name_4, sub_name_5, sub_name_6, sub_name_7, sub_name_8, sub_name_9 from schedules where section_name = '{_teacherUser.SectionName}'";
                    OracleCommand cmd2 = new OracleCommand(cmdText, client.Conn);
                    OracleDataReader rdr2 = cmd2.ExecuteReader();
                    rdr2.Read();

                    for (int i = 0; i < 9; i++)
                    {
                        cmdText = $"insert into grades (sub_name, student_id) values ('{rdr2.GetString(i)}', '{_currStudentId}')";
                        DatabaseClient quickClient = new DatabaseClient();
                        OracleCommand quickCmd = new OracleCommand(cmdText, quickClient.Conn);
                        quickCmd.ExecuteNonQuery();

                        cmdText = $"insert into updates (update_type, text, created_time, sender_user_type, sender_id) values ('grades', 'The teacher has uploaded the latest grades.', to_date('{DateTime.Now:MM/dd/yyyy HH:mm:ss}', 'MM/DD/YYYY HH24:MI:SS'), 'teachers', {_teacherUser.Id})";
                        quickCmd = new OracleCommand(cmdText, quickClient.Conn);
                        quickCmd.ExecuteNonQuery();
                    }
                }

                client.Close();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void RecordCheckWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (!GetGradingWorker2.IsBusy) GetGradingWorker2.RunWorkerAsync();
            }
            else
            {
                RecordCheckWorker.RunWorkerAsync();
            }
        }

        private void GradingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DatabaseClient client = new DatabaseClient();
                var cmdText = $"select last_grading from grades where student_id = {_currStudentId}";
                OracleCommand cmd = new OracleCommand(cmdText, client.Conn);
                _gradingRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void GradingWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (_gradingRdr.Read())
                {
                    if (_gradingRdr.IsDBNull(0))
                    {
                        Grading_Label.Text = "1st";
                        _currGrading = 1;
                        SubmitButton.Visible = true;
                        InputLabel.Text = "To Input";
                    }
                    else if (_gradingRdr.GetString(0) == "1")
                    {
                        Grading_Label.Text = "2nd";
                        _currGrading = 2;
                        SubmitButton.Visible = true;
                        InputLabel.Text = "To Input";
                    }
                    else if (_gradingRdr.GetString(0) == "2")
                    {
                        Grading_Label.Text = "3rd";
                        _currGrading = 3;
                        SubmitButton.Visible = true;
                        InputLabel.Text = "To Input";
                    }
                    else if (_gradingRdr.GetString(0) == "3")
                    {
                        Grading_Label.Text = "4th";
                        _currGrading = 4;
                        SubmitButton.Visible = true;
                        InputLabel.Text = "To Input";
                    }
                    else if (_gradingRdr.GetString(0) == "4")
                    {
                        InputLabel.Text = "Grades";
                        Grading_Label.Text = "Final";
                        SubmitButton.Visible = false;
                        _currGrading = 5;
                    }


                    _gradingRdr.Close();
                }
            }
            else
            {
                GradingWorker.RunWorkerAsync();
            }
        }

        private void GetGradingWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DatabaseClient client = new DatabaseClient();
                var cmdText = $"select last_grading from grades where student_id = {_currStudentId}";
                OracleCommand cmd = new OracleCommand(cmdText, client.Conn);
                _gradingRdr2 = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void GetGradingWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (_gradingRdr2.Read())
                {
                    if (_gradingRdr2.IsDBNull(0))
                    {
                        Grading_Label.Text = "1st";
                        _currGrading = 1;
                    }
                    else if (_gradingRdr2.GetString(0) == "1")
                    {
                        Grading_Label.Text = "2nd";
                        _currGrading = 2;
                    }
                    else if (_gradingRdr2.GetString(0) == "2")
                    {
                        Grading_Label.Text = "3rd";
                        _currGrading = 3;
                    }
                    else if (_gradingRdr2.GetString(0) == "3")
                    {
                        Grading_Label.Text = "4th";
                        _currGrading = 4;
                    }
                    else if (_gradingRdr2.GetString(0) == "4")
                    {
                        InputLabel.Text = "Grades";
                        Grading_Label.Text = "Final";
                        SubmitButton.Visible = false;
                        _currGrading = 5;
                    }

                }

                if (!GetGradesWorker.IsBusy) GetGradesWorker.RunWorkerAsync();
            }
            else
            {
                GradingWorker.RunWorkerAsync();
            }
        }


        // ====================================================================================== //
        //                                                                                        //
        //                                        UI METHODS                                      //
        //                                                                                        //
        // ====================================================================================== //

        private void AverageCircleProgress_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {
            if (AverageCircleProgress.Value < 75)
            {
                AverageCircleProgress.ForeColor = Color.FromArgb(248, 43, 96);
            }
            else
            {
                AverageCircleProgress.ForeColor = Color.FromArgb(25, 192, 255);
            }
        }

        private void bunifuPanel11_Click(object sender, EventArgs e)
        {

        }


    }
}
