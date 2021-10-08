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
using Faculti.Helpers;
using AirtableApiClient;
using Faculti.Services.Airtable;


namespace Faculti.UI.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private bool _passwordRevealed, _reenterPasswordRevealed;
        private string _email, _password;
        public string userType;
        public bool isPasswordMatched = false;

        public ChangePasswordForm()
        {
            InitializeComponent();
            userType = String.Empty;
        }

        private void PasswordRevealButton_Click(object sender, EventArgs e)
        {
            if (_passwordRevealed)
            {
                _passwordRevealed = false;
                PasswordTextBox.PasswordChar = '•';
                PasswordRevealButton.Image = Faculti.Properties.Resources.password_hidden;
            }
            else
            {
                _passwordRevealed = true;
                PasswordTextBox.PasswordChar = '\0';
                PasswordRevealButton.Image = Faculti.Properties.Resources.password_revealed;
            }
        }

        private async void ConfirmChangeButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == String.Empty)
            {
                IncorrecPasswordFormatTooltip.Visible = true;
            }

            if (ReEnterPasswordTextbox.Text == String.Empty)
            {
                PasswordNotMatchToolTip.Visible = true;
            }
         

            if (IncorrecPasswordFormatTooltip.Visible == false &&
                PasswordNotMatchToolTip.Visible == false)
            {
                _password = PasswordTextBox.Text;

                // List Records - return array of AirtableRecords
                AirtableClient airtableClientParent = new AirtableClient();
                var parentRecords = await airtableClientParent.ListRecords("Parent");

                AirtableClient airtableClientTeacher = new AirtableClient();
                var teacherRecords = await airtableClientTeacher.ListRecords("Teacher");

                // to check user type
                var isPresentInParentRecords = Email.IsPresentInDatabase(_email, parentRecords);
                var isPresentInTeacherRecords = Email.IsPresentInDatabase(_email, teacherRecords);

                if (isPresentInParentRecords)
                {
                    userType = "Parent";
                }
                else if (isPresentInTeacherRecords)
                {
                    userType = "Teacher";
                }

                // Get record id - User.GetRecordId();
                User user = new User();
                var recordId = await user.GetRecordId(userType, _email);

                var newPassword = Password.Encrypt(_password);

                Fields fields = new Fields();
                fields.AddField("Password", newPassword);

                // Update password using AirtableClient.UpdateRecord();
                AirtableClient airtableClient = new AirtableClient();
                airtableClient.UpdateRecord(userType, fields, recordId);

                ConfirmChangePasswordButton.Text = "Success!";
                await Task.Delay(1000);
                // declare LoginForm object x
                // show LoginForm x
                // close this form
                this.Close();
                ForgotPasswordForm obj = (ForgotPasswordForm)Application.OpenForms["ForgotPasswordForm"];
                obj.Close();
            }
            else
            {
                PasswordTextBox.Text = String.Empty;
                ReEnterPasswordTextbox.Text = String.Empty;
            }
        }

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
            if (ReEnterPasswordTextbox.Text != PasswordTextBox.Text || !Syntax.IsValidPassword(PasswordTextBox.Text))
            {
                isPasswordMatched = false;
                PasswordNotMatchToolTip.Visible = true;
            }
            else if (ReEnterPasswordTextbox.Text == PasswordTextBox.Text && Syntax.IsValidPassword(PasswordTextBox.Text))
            {
                isPasswordMatched = true;
                PasswordNotMatchToolTip.Visible = false;
                
            }
        }

        private void IncorrecPasswordFormatTooltip_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public void CopyEmail(string email)
        {
            _email = email;
        }
    }
}
