using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirtableApiClient;
using Faculti.Helpers;
using Faculti.Services.Airtable;
using Faculti.UI.Forms;

namespace Faculti.UI.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private bool _passwordRevealed, _reenterPasswordRevealed;
        public string email;

        public ChangePasswordForm()
        {
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(ConfirmChangePasswordButton);
        }

        private async void ConfirmChangeButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == string.Empty)
            {
                IncorrecPasswordFormatTooltip.Text = "Input password";
                IncorrecPasswordFormatTooltip.Visible = true;
            }

            if (IncorrecPasswordFormatTooltip.Visible == false &&
                PasswordNotMatchToolTip.Visible == false)
            {
                // List Records - return array of AirtableRecords
                AirtableClient airtableClientParent = new AirtableClient();
                var parentRecords = await airtableClientParent.ListRecords("Parent");

                AirtableClient airtableClientTeacher = new AirtableClient();
                var teacherRecords = await airtableClientTeacher.ListRecords("Teacher");

                // to check user type
                var isPresentInParentRecords = Email.IsPresentInDatabase(email, parentRecords);
                var isPresentInTeacherRecords = Email.IsPresentInDatabase(email, teacherRecords);

                string userType = string.Empty;

                if (isPresentInParentRecords)
                {
                    userType = "Parent";
                }
                else if (isPresentInTeacherRecords)
                {
                    userType = "Teacher";
                }

                User userToSearch = new User
                {
                    Email = email,
                    PasswordInHash = Password.Encrypt(PasswordTextBox.Text),
                    Type = userType
                };
                // Get record id - User.GetRecordId();
                var recordId = await userToSearch.GetRecordId();

                Fields fields = new Fields();
                fields.AddField("Password", userToSearch.PasswordInHash);

                // Update password using AirtableClient.UpdateRecord();
                AirtableClient airtableClient = new AirtableClient();
                airtableClient.UpdateRecord(userType, fields, recordId);

                ConfirmChangePasswordButton.Text = "✔️ Change Successful";
                await Task.Delay(1000);
                FormAnimation.FadeOut(this);
                this.Hide();
            }
            else
            {
                PasswordTextBox.Text = string.Empty;
                ReEnterPasswordTextbox.Text = string.Empty;
            }
        }



        // ====================================================================================== //
        //                                                                                        //
        //                                        UI METHODS                                      //
        //                                                                                        //
        // ====================================================================================== //

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Syntax.IsValidPassword(PasswordTextBox.Text))
            {
                IncorrecPasswordFormatTooltip.Visible = false;
            }
            else
            {
                IncorrecPasswordFormatTooltip.Visible = true;
            }
        }

        private void ReEnterPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == ReEnterPasswordTextbox.Text)
            {
                PasswordNotMatchToolTip.Visible = false;
            }
            else
            {
                PasswordNotMatchToolTip.Visible = true;
            }
        }

        private void PasswordRevealButton_Click(object sender, EventArgs e)
        {
            if (_passwordRevealed)
            {
                _passwordRevealed = false;
                PasswordTextBox.PasswordChar = '•';
                PasswordRevealButton.Image = Properties.Resources.password_hidden;
            }
            else
            {
                _passwordRevealed = true;
                PasswordTextBox.PasswordChar = '\0';
                PasswordRevealButton.Image = Properties.Resources.password_revealed;
            }
        }

        private void ChangePasswordForm_Shown(object sender, EventArgs e)
        {
            FormAnimation.FadeIn(this);
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            FormAnimation.FadeIn(this);
        }

        private void ConfirmPasswordRevealButton_Click(object sender, EventArgs e)
        {
            if (_reenterPasswordRevealed)
            {
                _reenterPasswordRevealed = false;
                ReEnterPasswordTextbox.PasswordChar = '•';
                ConfirmPasswordRevealButton.Image = Faculti.Properties.Resources.password_hidden;
            }
            else
            {
                _reenterPasswordRevealed = true;
                ReEnterPasswordTextbox.PasswordChar = '\0';
                ConfirmPasswordRevealButton.Image = Faculti.Properties.Resources.password_revealed;
            }
        }
    }
}
