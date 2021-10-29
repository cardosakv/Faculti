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
    public partial class GradesParentPanel : UserControl
    {
        private readonly Parent _parentUser;
        private DatabaseClient _getGradesClient;
        private OracleDataReader _getGradesRdr;
        private Dictionary<string, int> _grades;
        private Dictionary<string, int> _gradeDiffs;
        private DateTime _lastUpdate;
        private int _currGrading;
        private int _lastAverage;

        public GradesParentPanel(Parent parentUser)
        {
            InitializeComponent();
            _parentUser = parentUser;
            GetGradesWorker.RunWorkerAsync();
        }

        private void GetGradesWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _getGradesClient = new DatabaseClient();
                var cmdText = $"select sub_name, mark_1, mark_2, mark_3, mark_4, last_update, last_grading, last_average from grades where student_id = '{_parentUser.AssignedStudent.Id}' order by sub_name asc";
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

                while (_getGradesRdr.Read())
                {
                    var subName = _getGradesRdr.GetString(0);
                    var grade1 = _getGradesRdr.IsDBNull(1) ? null : _getGradesRdr.GetString(1);
                    var grade2 = _getGradesRdr.IsDBNull(2) ? null : _getGradesRdr.GetString(2);
                    var grade3 = _getGradesRdr.IsDBNull(3) ? null : _getGradesRdr.GetString(3);
                    var grade4 = _getGradesRdr.IsDBNull(4) ? null : _getGradesRdr.GetString(4);
                    _lastUpdate = _getGradesRdr.IsDBNull(5) ? DateTime.MinValue : _getGradesRdr.GetOracleDate(5).Value;
                    _currGrading = _getGradesRdr.IsDBNull(6) ? 0 : _getGradesRdr.GetInt32(6);
                    _lastAverage = _getGradesRdr.IsDBNull(7) ? 0 : _getGradesRdr.GetInt32(7);

                    _grades = new Dictionary<string, int>();
                    _gradeDiffs = new Dictionary<string, int>();
                    _grades.Add(subName, 0);
                    _gradeDiffs.Add(subName, 0);

                    GradeRecord subjectGrade = new GradeRecord(subName, grade1, grade2, grade3, grade4, _parentUser);
                    GradeRecordLayoutPanel.Controls.Add(subjectGrade);
                    CalculateGradeStats();
                    DisplayStats();

                    if (_lastAverage == 0)
                    {
                        GradeCover.Visible = true;
                        NoGradeCover.Visible = true;
                    }
                    else
                    {
                        GradeCover.Visible = false;
                        NoGradeCover.Visible = false;
                    }
                }

                _getGradesClient.Conn.Close();
            }
            else
            {
                _getGradesClient.Conn.Close();
                GetGradesWorker.RunWorkerAsync();
            }
        }

        public void CalculateGradeStats()
        {
            foreach (GradeRecord gradeRec in GradeRecordLayoutPanel.Controls)
            {
                if (_currGrading == 1)
                {
                    _grades[gradeRec.SubjectName] = gradeRec.Grade1;
                }
                else if (_currGrading == 2)
                {
                    _grades[gradeRec.SubjectName] = gradeRec.Grade2;
                }
                else if (_currGrading == 3)
                {
                    _grades[gradeRec.SubjectName] = gradeRec.Grade3;
                }
                else if (_currGrading == 4)
                {
                    _grades[gradeRec.SubjectName] = gradeRec.Grade4;
                }
                else if (_currGrading == 5)
                {
                    _grades[gradeRec.SubjectName] = gradeRec.GradeFinal;
                }

                _gradeDiffs[gradeRec.SubjectName] = gradeRec.GainFall;
            }

            var passed = _grades.Values.Count(v => v >= 75);
            var highest = _grades.FirstOrDefault(x => x.Value == _grades.Values.Max()).Key;
            var lowest = _grades.FirstOrDefault(x => x.Value == _grades.Values.Min()).Key;
            string greatestGain = "-";
            string biggestDrop = "-";

            if (_currGrading != 1)
            {
                greatestGain = _gradeDiffs.FirstOrDefault(x => x.Value == _gradeDiffs.Values.Max()).Key;
                biggestDrop = _gradeDiffs.FirstOrDefault(x => x.Value == _gradeDiffs.Values.Min()).Key;
            }

            if (_lastAverage < 75) { AverageCircleProgress.ForeColor = Color.FromArgb(248, 43, 96); }
            if (passed < _grades.Count) { PassedCircleProgress.ForeColor = Color.FromArgb(248, 43, 96); }

            AverageCircleProgress.Value = _lastAverage;
            PassedCircleProgress.Value = passed;
            HighestLabel.Text = highest;
            LowestLabel.Text = lowest;
            GreatestGainLabel.Text = greatestGain;
            BiggestDropLabel.Text = biggestDrop;
        }

        private void DisplayStats()
        {
            if (_currGrading == 1)
            {
                Grading_Label.Text = "1st";
            }
            else if (_currGrading == 2)
            {
                Grading_Label.Text = "2nd";
            }
            else if (_currGrading == 3)
            {
                Grading_Label.Text = "3rd";
            }
            else if (_currGrading == 4)
            {
                Grading_Label.Text = "4th";
            }
            else if (_currGrading == 5)
            {
                Input_Label.Text = "Grades";
                Grading_Label.Text = "Final";
            }

            MonthYearLabel.Text = $"{_lastUpdate.ToString("MMMM yyyy")}";
            DayLabel.Text = $"{_lastUpdate.ToString("dd")}";
        }

        private void Grading_Label_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




        // ====================================================================================== //
        //                                                                                        //
        //                                        UI METHODS                                      //
        //                                                                                        //
        // ====================================================================================== //
    }
}
