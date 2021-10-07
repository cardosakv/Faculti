using AirtableApiClient;
using Bunifu.UI.WinForms;
using Faculti.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Faculti.Helpers;
using Faculti.UI;
using Faculti.Services.Airtable;

namespace Faculti
{
    public partial class SignupForm : Form
    {
        public string userType = null;
        public string firstName, lastName, email, password, phoneNumber;
        public bool isPasswordMatched = false;
        public bool isError = true, isPassword1Revealed = false, isPassword2Revealed = false;

        public SignupForm()
        {
            InitializeComponent();
        }

        private void LoginSignupForm_Load(object sender, EventArgs e)
        {
            FormAnimation.FadeIn(this);

            TeacherRadioButton.Checked = false;
            ParentRadioButton.Checked = false;
        }

        private void ParentRadioButton_CheckedChanged2(object sender, BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (ParentRadioButton.Checked)
            {
                userType = "Parent";
                TeacherRadioButton.Checked = false;

                SetDefaultBorder(ParentCheckPanel);
                SetDefaultBorder(TeacherCheckPanel);
            }
        }

        private void TeacherRadioButton_CheckedChanged2(object sender, BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (TeacherRadioButton.Checked)
            {
                userType = "Teacher";
                ParentRadioButton.Checked = false;

                SetDefaultBorder(ParentCheckPanel);
                SetDefaultBorder(TeacherCheckPanel);
            }
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FirstNameTooltip.Visible = false;
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            LastNameTooltip.Visible = false;
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Syntax.IsValidMobileNumber(PhoneNumberTextBox.Text))
            {
                PhoneTooltip.Visible = false;
                phoneNumber = PhoneNumberTextBox.Text;
            }
            else
            {
                PhoneTooltip.Visible = true;
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Syntax.IsValidEmail(EmailTextBox.Text))
            {
                EmailTooltip.Visible = false;
            }
            else
            {
                EmailTooltip.Text = "Invalid email address";
                EmailTooltip.Visible = true;
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Syntax.IsValidPassword(PasswordTextBox.Text))
            {
                PasswordTooltip.Visible = false;
            }
            else
            {
                PasswordTooltip.Visible = true;
            }
        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ConfirmPasswordTextBox.Text != PasswordTextBox.Text || !Syntax.IsValidPassword(PasswordTextBox.Text))
            {
                isPasswordMatched = false;
                ConfirmPasswordTooltip.Visible = true;
            }
            else if (ConfirmPasswordTextBox.Text == PasswordTextBox.Text && Syntax.IsValidPassword(PasswordTextBox.Text))
            {
                isPasswordMatched = true;
                ConfirmPasswordTooltip.Visible = false;
            }
        }

        private void AgreeCheckBox_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            TermsPrivacyLabel.ForeColor = Color.DimGray;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void PasswordRevelButton_Click(object sender, EventArgs e)
        {
            if (isPassword1Revealed)
            {
                isPassword1Revealed = false;
                PasswordTextBox.PasswordChar = '•';
                PasswordRevealButton.Image = Faculti.Properties.Resources.password_hidden;
            }
            else
            {
                isPassword1Revealed = true;
                PasswordTextBox.PasswordChar = '\0';
                PasswordRevealButton.Image = Faculti.Properties.Resources.password_revealed;
            }
        }

        private void ConfirmPasswordRevealButton_Click(object sender, EventArgs e)
        {
            if (isPassword2Revealed)
            {
                isPassword2Revealed = false;
                ConfirmPasswordTextBox.PasswordChar = '•';
                ConfirmPasswordRevealButton.Image = Faculti.Properties.Resources.password_hidden;
            }
            else
            {
                isPassword2Revealed = true;
                ConfirmPasswordTextBox.PasswordChar = '\0';
                ConfirmPasswordRevealButton.Image = Faculti.Properties.Resources.password_revealed;
            }
        }

        private async void CreateAccountButton_Click(object sender, EventArgs e)
        {
            var errorCounter = 0;

            firstName = FirstNameTextBox.Text;
            lastName = LastNameTextBox.Text;
            email = EmailTextBox.Text;
            password = ConfirmPasswordTextBox.Text;

            if (userType == null)
            {
                errorCounter++;
                SetBorderError(ParentCheckPanel);
                SetBorderError(TeacherCheckPanel);
            }
            else
            {
                SetDefaultBorder(ParentCheckPanel);
                SetDefaultBorder(TeacherCheckPanel);
            }

            if (firstName == "")
            {
                errorCounter++;
                FirstNameTooltip.Visible = true;
            }
            else
            {
                FirstNameTooltip.Visible = false;
            }

            if (lastName == "")
            {
                errorCounter++;
                LastNameTooltip.Visible = true;
            }
            else
            {
                LastNameTooltip.Visible = false;
            }

            if (!Syntax.IsValidMobileNumber(PhoneNumberTextBox.Text))
            {
                errorCounter++;
                PhoneTooltip.Visible = true;
            }
            else
            {
                PhoneTooltip.Visible = false;
            }

            if (!Syntax.IsValidEmail(email))
            {
                errorCounter++;
                EmailTooltip.Visible = true;
            }
            else if (Syntax.IsValidEmail(email))
            {
                bool emailPresent = false;

                AirtableClient airtableClient = new AirtableClient();
                var recordsArr = await airtableClient.ListRecords(userType);

                for (int recordNum = 0; recordNum < recordsArr.Length; recordNum++)
                {
                    foreach (KeyValuePair<string, object> kvp in recordsArr[recordNum].Fields)
                    {
                        if (kvp.Key == "Email" && kvp.Value.ToString() == email)
                        {
                            emailPresent = true;
                            break;
                        }
                    }
                }

                if (emailPresent)
                {
                    errorCounter++;
                    EmailTooltip.Text = "Email already registered";
                    EmailTooltip.Visible = true;
                }
                else
                {
                    EmailTooltip.Visible = false;
                }
            }

            if (password == "")
            {
                errorCounter++;
                PasswordTooltip.Visible = true;
            }
            else
            {
                PasswordTooltip.Visible = false;
            }

            if (!isPasswordMatched)
            {
                errorCounter++;
                ConfirmPasswordTooltip.Visible = true;
            }
            else
            {
                ConfirmPasswordTooltip.Visible = false;
            }

            if (!AgreeCheckBox.Checked)
            {
                errorCounter++;
                TermsPrivacyLabel.ForeColor = Color.FromArgb(255, 127, 127);
            }
            else
            {
                TermsPrivacyLabel.ForeColor = Color.FromArgb(49, 63, 79);
            }

            // if there are no other errors, proceed to account creation
            if (errorCounter == 0)
            {
                Cursor = Cursors.AppStarting;
                Fields fields = new Fields();
                fields.AddField("Email", email);
                fields.AddField("Password", Password.Encrypt(password));
                fields.AddField("First Name", firstName);
                fields.AddField("Last Name", lastName);
                fields.AddField("Phone Number", phoneNumber);

                AirtableClient helper = new AirtableClient();
                helper.CreateRecord(userType, fields);

                // generate a random code for verification
                Random rnd = new Random();
                int verificationCode = rnd.Next(1000, 9999);

                Email.SendVerificationCode(email, verificationCode);

                VerificationForm verificationForm = new VerificationForm();
                verificationForm.FormClosed += new FormClosedEventHandler(VerificationForm_FormClosed);
                verificationForm.CopyEmailAndCode(email, verificationCode);
                verificationForm.ShowDialog();
                Cursor = Cursors.Default;
            }
        }

        private void LogInButton_MouseLeave(object sender, EventArgs e)
        {
            LogInButton.ForeColor = Color.FromArgb(255, 209, 24);
        }

        private void VerificationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void SetBorderError(BunifuPanel panel)
        {
            if (panel != null) panel.BorderColor = Color.FromArgb(255, 127, 127);
        }

        private void SetDefaultBorder(BunifuPanel panel)
        {
            if (panel != null) panel.BorderColor = Color.FromArgb(224, 224, 224);
        }

        private void LogInButton_MouseHover(object sender, EventArgs e)
        {
            ActiveTextHover(LogInButton);
        }

        private void ActiveTextHover(Label label)
        {
            label.ForeColor = Color.FromArgb(255, 237, 64);
        }
    }
}