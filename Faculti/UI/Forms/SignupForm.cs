using AirtableApiClient;
using Bunifu.UI.WinForms;
using Faculti.Helpers;
using Faculti.Services.Airtable;
using Faculti.UI;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faculti.UI.Forms;

namespace Faculti
{
    /// <summary>
    ///     Main form for signing up to Faculti.
    /// </summary>
    public partial class SignupForm : Form
    {
        private string _userType;
        private bool _isPasswordMatched;
        private bool _isPassword1Revealed, _isPassword2Revealed;

        public SignupForm()
        {
            InitializeComponent();
            ControlInteractives.SetLabelHoverEvent(LogInButton);
            ControlInteractives.SetButtonHoverEvent(CreateAccountButton);
        }

        private async void CreateAccountButton_Click(object sender, EventArgs e)
        {
            // Check for input errors in the textboxes
            var errors = await CheckForInputErrors();

            // If there are no errors, proceed to account creation
            if (errors == 0)
            {
                Cursor = Cursors.WaitCursor;

                // Create a new user object
                User signupUser = new User
                {
                    Type = _userType,
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    Email = EmailTextBox.Text,
                    PasswordInHash = Password.Encrypt(ConfirmPasswordTextBox.Text), // encrypt the password
                    PhoneNumber = PhoneNumberTextBox.Text
                };

                // Create an Airtable Fields object and add the user details
                Fields fields = new Fields();
                fields.AddField("Email", signupUser.Email);
                fields.AddField("Password", signupUser.PasswordInHash);
                fields.AddField("First Name", signupUser.FirstName);
                fields.AddField("Last Name", signupUser.LastName);
                fields.AddField("Phone Number", signupUser.PhoneNumber);

                // Add user to the database
                AirtableClient airtableClient = new AirtableClient();
                airtableClient.CreateRecord(signupUser.Type, fields);

                // Generate a random code for verification and send to email
                int verificationCode = Randomizer.GenerateVerificationCode();
                Email.SendVerificationCode(signupUser.Email, verificationCode);

                // Show the verification form for the user to input code
                VerificationForm verificationForm = new VerificationForm();
                verificationForm.CopyEmailAndCode(signupUser.Email, verificationCode, "signup");
                verificationForm.ShowDialog();

                Cursor = Cursors.Default;
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private async Task<int> CheckForInputErrors()
        {
            var errors = 0;

            if (string.IsNullOrEmpty(_userType))
            {
                errors++;
                SetBorderError(ParentCheckPanel);
                SetBorderError(TeacherCheckPanel);
            }
            else
            {
                SetDefaultBorder(ParentCheckPanel);
                SetDefaultBorder(TeacherCheckPanel);
            }

            if (FirstNameTextBox.Text == string.Empty)
            {
                errors++;
                FirstNameTooltip.Visible = true;
            }
            else
            {
                FirstNameTooltip.Visible = false;
            }

            if (LastNameTextBox.Text == string.Empty)
            {
                errors++;
                LastNameTooltip.Visible = true;
            }
            else
            {
                LastNameTooltip.Visible = false;
            }

            if (!Syntax.IsValidMobileNumber(PhoneNumberTextBox.Text))
            {
                errors++;
                PhoneTooltip.Visible = true;
            }
            else
            {
                PhoneTooltip.Visible = false;
            }

            if (Syntax.IsValidEmail(EmailTextBox.Text))
            {
                AirtableClient airtableClient = new AirtableClient();
                var records = await airtableClient.ListRecords(_userType);

                if (Email.IsPresentInDatabase(EmailTextBox.Text, records))
                {
                    errors++;
                    EmailTooltip.Text = "Email already registered";
                    EmailTooltip.Visible = true;
                }
                else
                {
                    EmailTooltip.Visible = false;
                }
            }
            else
            {
                errors++;
                EmailTooltip.Visible = true;
            }

            if (PasswordTextBox.Text == string.Empty)
            {
                errors++;
                PasswordTooltip.Visible = true;
            }
            else
            {
                PasswordTooltip.Visible = false;
            }

            if (!_isPasswordMatched)
            {
                errors++;
                ConfirmPasswordTooltip.Visible = true;
            }
            else
            {
                ConfirmPasswordTooltip.Visible = false;
            }

            if (!AgreeCheckBox.Checked)
            {
                errors++;
                TermsPrivacyLabel.ForeColor = Color.FromArgb(248, 43, 96);
            }
            else
            {
                TermsPrivacyLabel.ForeColor = Color.FromArgb(49, 63, 79);
            }

            return errors;
        }




        // ====================================================================================== //
        //                                                                                        //
        //                                        UI METHODS                                      //
        //                                                                                        //
        // ====================================================================================== //
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
                _userType = "Parent";
                TeacherRadioButton.Checked = false;

                SetDefaultBorder(ParentCheckPanel);
                SetDefaultBorder(TeacherCheckPanel);
            }
        }

        private void TeacherRadioButton_CheckedChanged2(object sender, BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (TeacherRadioButton.Checked)
            {
                _userType = "Teacher";
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
                _isPasswordMatched = false;
                ConfirmPasswordTooltip.Visible = true;
            }
            else if (ConfirmPasswordTextBox.Text == PasswordTextBox.Text && Syntax.IsValidPassword(PasswordTextBox.Text))
            {
                _isPasswordMatched = true;
                ConfirmPasswordTooltip.Visible = false;
            }
        }

        private void PasswordRevealButton_Click(object sender, EventArgs e)
        {
            if (_isPassword1Revealed)
            {
                _isPassword1Revealed = false;
                PasswordTextBox.PasswordChar = '•';
                PasswordRevealButton.Image = Faculti.Properties.Resources.password_hidden;
            }
            else
            {
                _isPassword1Revealed = true;
                PasswordTextBox.PasswordChar = '\0';
                PasswordRevealButton.Image = Faculti.Properties.Resources.password_revealed;
            }
        }

        private void ConfirmPasswordRevealButton_Click(object sender, EventArgs e)
        {
            if (_isPassword2Revealed)
            {
                _isPassword2Revealed = false;
                ConfirmPasswordTextBox.PasswordChar = '•';
                ConfirmPasswordRevealButton.Image = Faculti.Properties.Resources.password_hidden;
            }
            else
            {
                _isPassword2Revealed = true;
                ConfirmPasswordTextBox.PasswordChar = '\0';
                ConfirmPasswordRevealButton.Image = Faculti.Properties.Resources.password_revealed;
            }
        }

        private void AgreeCheckBox_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            TermsPrivacyLabel.ForeColor = Color.DimGray;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogInButton_MouseLeave(object sender, EventArgs e)
        {
            LogInButton.ForeColor = Color.FromArgb(255, 209, 24);
        }

        private void SetBorderError(BunifuPanel panel)
        {
            panel.BorderColor = Color.FromArgb(248, 43, 96);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            FormAnimation.FadeOut(this);
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SetDefaultBorder(BunifuPanel panel)
        {
            if (panel != null) panel.BorderColor = Color.FromArgb(224, 224, 224);
        }
    }
}