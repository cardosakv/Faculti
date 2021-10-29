using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class GetStartedParent : UserControl
    {
        public event NotifyParentHomeForm GetStartedFinished = delegate { };

        private readonly Parent _parentUser;
        private readonly Student _studentToQuery = new Student();
        private string _codeToCheck;
        private DatabaseClient _client = new DatabaseClient();

        public GetStartedParent(Parent parentUser)
        {
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(AccessButton);

            _parentUser = parentUser;
        }

        private void AccessButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (InvalidCodeLabel.Text.Length != 0)
            {
                _codeToCheck = CodeTextBox.Text;
                if (!CodeWorker.IsBusy) CodeWorker.RunWorkerAsync();
            }
            else
            {
                InvalidCodeLabel.Text = "Input code";
                InvalidCodeLabel.Visible = true;
            }

            Cursor = Cursors.Default;
        }

        private void CodeWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _studentToQuery.GetInfo(_codeToCheck);
        }

        private void CodeWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StudentConfirmForm form = new StudentConfirmForm(_studentToQuery);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var cmdText = $"update parents set student_id = {_studentToQuery.Id}, student_code = '{_studentToQuery.Code}', section_name = '{_studentToQuery.SectionName}' where email = '{_parentUser.Email}'";
                _client.PerformNonQueryCommand(cmdText);

                _client.Conn.Open();
                cmdText = $"update students set parent_id = {_parentUser.Id} where student_code = '{_studentToQuery.Code}'";
                _client.PerformNonQueryCommand(cmdText);


                _parentUser.AssignedStudent = _studentToQuery;
                GetStartedFinished();

                this.Hide();
                this.Dispose();
            }
        }


        // ====================================================================================== //
        //                                                                                        //
        //                                        UI METHODS                                      //
        //                                                                                        //
        // ====================================================================================== //
        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CodeTextBox.Text.Length < 5)
            {
                InvalidCodeLabel.Text = "Lacking characters";
                InvalidCodeLabel.Visible = true;
            }
            else
            {
                InvalidCodeLabel.Visible = false;
            }

            if (CodeTextBox.Text.Length == 0)
            {
                InvalidCodeLabel.Text = "Input code";
                InvalidCodeLabel.Visible = true;
            }
            else
            {
                InvalidCodeLabel.Visible = false;
            }
        }
    }
}
