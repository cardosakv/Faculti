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

namespace Faculti.UI.Cards
{
    public partial class ParentHomePanel : UserControl
    {
        private readonly Parent _parentUser;
        private DatabaseClient _dashboardClient;
        private DatabaseClient _scheduleClient;
        private DatabaseClient _summaryClient;
        private DatabaseClient _teacherInfoClient;
        private OracleDataReader _scheduleRdr;
        private OracleDataReader _summaryRdr;
        private OracleDataReader _teacherInfoRdr;

        private string _upcomingExams;
        private string _assignments;

        public ParentHomePanel(Parent parentUser)
        {
            InitializeComponent();
            _parentUser = parentUser;
            UpdateData();
        }

        public void UpdateData()
        {
            if (!DashboardWorker.IsBusy) DashboardWorker.RunWorkerAsync();
            if (!ScheduleWorker.IsBusy) ScheduleWorker.RunWorkerAsync();
            if (!StudentInfoWorker.IsBusy) StudentInfoWorker.RunWorkerAsync();
            if (!SummaryReportWorker.IsBusy) SummaryReportWorker.RunWorkerAsync();
        }

        private void DashboardWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _dashboardClient = new DatabaseClient();
                var cmdText = $"select count(*) from calendar where is_exam = 'Y' and section_name = '{_parentUser.SectionName}'";
                OracleCommand cmd = new OracleCommand(cmdText, _dashboardClient.Conn);
                _upcomingExams = cmd.ExecuteScalar().ToString();

                cmdText = $"select count(*) from calendar where is_ass = 'Y' and section_name = '{_parentUser.SectionName}'";
                cmd = new OracleCommand(cmdText, _dashboardClient.Conn);
                _assignments = cmd.ExecuteScalar().ToString();

                _dashboardClient.Conn.Close();
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
                UpcomingExams_Label.Text = _upcomingExams.ToString();
                AssignmentsDue_Label.Text = _assignments.ToString();
                ClassesLoader.Visible = false;
                ExamsLoader.Visible = false;
                AssignsLoader.Visible = false;
            }
            else
            {
                DashboardWorker.RunWorkerAsync();
            }
        }

        private void StudentInfoWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _teacherInfoClient = new DatabaseClient();
                var cmdText = $"select first_name, last_name from teachers where section_name = '{_parentUser.SectionName}'";
                OracleCommand cmd = new OracleCommand(cmdText, _teacherInfoClient.Conn);
                _teacherInfoRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void StudentInfoWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                _teacherInfoRdr.Read();
                Student student = _parentUser.AssignedStudent;

                ChildName_Label.Text = $"{student.FirstName} {student.LastName}";
                GradeSection_Label.Text = $"{student.GradeLevel} - {student.SectionName}";
                ChildAge_Label.Text = $"{student.Age}";
                ChildSex_Label.Text = $"{student.Sex}";
                StudentIdLabel.Text = $"{student.Id}";
                ChildTeacher_Label.Text = $"{_teacherInfoRdr.GetString(0)} {_teacherInfoRdr.GetString(1)}";
                
                _teacherInfoClient.Conn.Close();
                ChildInfoLoader.Visible = false;
            }
            else
            {
                _teacherInfoClient.Conn.Close();
                StudentInfoWorker.RunWorkerAsync();
            }
        }

        private void ScheduleWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var i = 1;
                _scheduleClient = new DatabaseClient();
                var cmdText = $"select sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++}, sub_name_{i}, sub_time_{i++} from schedules where section_name = '{_parentUser.SectionName}'";
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

                _scheduleClient.Conn.Close();
                ScheduleLoader.Visible = false;
            }
            else
            {
                _scheduleClient.Conn.Close();
                ScheduleWorker.RunWorkerAsync();
            }
        }

        private void SummaryReportWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _summaryClient = new DatabaseClient();
                var cmdText = $"select mark_1, mark_2, mark_3, mark_4, last_average, last_grading from grades where student_id = {_parentUser.AssignedStudent.Id}";
                OracleCommand cmd = new OracleCommand(cmdText, _summaryClient.Conn);
                _summaryRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void SummaryReportWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                int totalSubjects = 0;
                int passedSubjects = 0;
                int lastAverage = 0;
                int lastGrading = 0;

                while (_summaryRdr.Read())
                {
                    totalSubjects++;
                    lastGrading = _summaryRdr.IsDBNull(5) ? 0 : _summaryRdr.GetInt32(5);
                    lastAverage = _summaryRdr.IsDBNull(4) ? 0 : _summaryRdr.GetInt32(4);

                    if (lastGrading != 0)
                    {
                        var grade = _summaryRdr.GetInt32(lastGrading-1);
                        if (grade >= 75)
                        {
                            passedSubjects++;
                        }
                    }
                }

                if (lastAverage != 0)
                {
                    LatestAverage_Label.Text = lastAverage.ToString();
                }

                if (lastGrading != 0)
                {
                    string gradingStr = null;

                    if (lastGrading == 1)
                    {
                        gradingStr = "1st";
                    }
                    else if (lastGrading == 2)
                    {
                        gradingStr = "2nd";
                    }
                    else if (lastGrading == 3)
                    {
                        gradingStr = "3rd";
                    }
                    else if (lastGrading == 4)
                    {
                        gradingStr = "4th";
                    }

                    LatestGrading_Label.Text = $"{gradingStr} Grading";
                }

                if (totalSubjects != 0 && passedSubjects != 0)
                {
                    PassedSubjects_Label.Text = passedSubjects.ToString();
                    PassedOutOfNo_Label.Text = $"Out of {totalSubjects}";
                }

                _summaryClient.Conn.Close();
                LatestAverageLoader.Visible = false;
                PassedSubjectsLoader.Visible = false;
                AbsencesLoader.Visible = false;
            }
            else
            {
                _summaryClient.Conn.Close();
                SummaryReportWorker.RunWorkerAsync();
            }
        }

        private void ChildTeacher_Label_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel7_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuShadowPanel6_ControlAdded(object sender, ControlEventArgs e)
        {

        }


        // ====================================================================================== //
        //                                                                                        //
        //                                        UI METHODS                                      //
        //                                                                                        //
        // ====================================================================================== //
    }
}
