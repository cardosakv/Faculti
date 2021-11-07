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
using Faculti.UI.Forms;

namespace Faculti.UI.Forms
{
    public partial class AddEventForm : Form
    {
        private readonly User _user;

        public AddEventForm(User user)
        {
            _user = user;
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(ConfirmButton);
            CancelButton.DialogResult = DialogResult.Cancel;
        }

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EventTitleTextBox.Text) &&
                !string.IsNullOrEmpty(EventDescTextBox.Text) &&
                !string.IsNullOrEmpty(TypeDropdown.Text))
            {
                DatabaseClient client = new DatabaseClient();
                string cmdText = string.Empty;

                if (TypeDropdown.Text == "Exam")
                {
                    cmdText = $"insert into calendar (event_title, event_desc, event_date, section_name, is_exam) values ('{EventTitleTextBox.Text}', '{EventDescTextBox.Text}', to_date('{DatePicker.Value:MM/dd/yyyy}', 'MM/DD/YYYY'), '{_user.SectionName}', 'Y')";
                }
                else if (TypeDropdown.Text == "Assignment")
                {
                    cmdText = $"insert into calendar (event_title, event_desc, event_date, section_name, is_ass) values ('{EventTitleTextBox.Text}', '{EventDescTextBox.Text}', to_date('{DatePicker.Value:MM/dd/yyyy}', 'MM/DD/YYYY'), '{_user.SectionName}', 'Y')";
                }
                
                client.PerformNonQueryCommand(cmdText);

                client.Conn.Open();
                cmdText = $"insert into updates (update_type, text, created_time, sender_user_type, sender_id) values ('calendar', 'A new event has been added by the teacher.', to_date('{DateTime.Now:MM/dd/yyyy HH:mm:ss}', 'MM/DD/YYYY HH24:MI:SS'), 'teachers', {_user.Id})";
                client.PerformNonQueryCommand(cmdText);

                await Task.Delay(1000);
                this.Close();
            }
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
            FormAnimation.FadeIn(this);
        }

        private void EventTitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
