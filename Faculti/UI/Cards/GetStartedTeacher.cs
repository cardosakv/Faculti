using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faculti.DataClasses;
using Faculti.Services.FacultiDB;
using Faculti.UI.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Faculti.UI.Cards
{
    public partial class GetStartedTeacher : UserControl
    {
        public event NotifyTeacherHomeForm GetStartedFinished = delegate { };

        private readonly Teacher _teacherUser;
        private string _sectionToCheck;
        private DatabaseClient _client;
        private OracleDataReader _rdr;

        public GetStartedTeacher(Teacher teacherUser)
        {
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(AccessButton);

            _teacherUser = teacherUser;
        }

        private void AccessButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (InvalidCodeLabel.Text.Length != 0)
            {
                _sectionToCheck = SectionTextBox.Text;
                SectionCheckWorker.RunWorkerAsync();
            }
            else
            {
                InvalidCodeLabel.Text = "Input section";
                InvalidCodeLabel.Visible = true;
            }

            Cursor = Cursors.Default;
        }

        private void SectionCheckWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            QuerySection();
        }

        private void QuerySection()
        {
            TextInfo txtinfo = new CultureInfo("en-US", false).TextInfo;
            _sectionToCheck = txtinfo.ToTitleCase(_sectionToCheck);

            _client = new DatabaseClient();
            var cmdText = $"select * from schedules where section_name = '{_sectionToCheck}'";
            OracleCommand cmd = new OracleCommand(cmdText, _client.Conn);
            _rdr = cmd.ExecuteReader();
        }

        private void SectionCheckWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_rdr.Read())
            {
                ScheduleConfirmForm form = new ScheduleConfirmForm(_rdr.GetString(21));
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var cmdText = $"update teachers set section_name = '{_sectionToCheck}' where email = '{_teacherUser.Email}'";
                    _client.PerformNonQueryCommand(cmdText);
                    GetStartedFinished();
                    this.Hide();
                    this.Dispose();
                }
            }

            _rdr.Close();
            _client.Conn.Close();
        }




        // ====================================================================================== //
        //                                                                                        //
        //                                        UI METHODS                                      //
        //                                                                                        //
        // ====================================================================================== //
        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SectionTextBox.Text.Length == 0)
            {
                InvalidCodeLabel.Text = "Input section";
                InvalidCodeLabel.Visible = true;
            }
            else
            {
                InvalidCodeLabel.Visible = false;
            }
        }
    }
}
