using Bunifu.UI.WinForms;
using Faculti.Database;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Faculti.Misc.ControlInteractives;
using static Faculti.Misc.FormAnimation;
using static Faculti.Misc.SyntaxValidation;
using static Faculti.Security.PasswordChecker;
using static Faculti.Security.PasswordEncryption;
using static Faculti.Validation.EmailVerification;

namespace Faculti
{
    /// <summary>
    /// Main form for the users to log in.
    /// </summary>
    public partial class LoginForm : Form
    {
        private string _userType;
        private bool _passwordRevealed;
        private Timer _timer;

        public LoginForm()
        {
            InitializeComponent();
            _userType = String.Empty;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            FadeIn(this);

            ParentRadioButton.Checked = false;
            TeacherRadioButton.Checked = false;
            SetLabelHover(ForgotPasswordLinkLabel);
            SetLabelHover(SignupLinkLabel);
        }

        private void ParentRadioButton_CheckedChanged2(object sender, BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (ParentRadioButton.Checked)
            {
                _userType = "Parent";
                TeacherRadioButton.Checked = false;
                SetUserSelectionError(false);
            }
        }

        private void TeacherRadioButton_CheckedChanged2(object sender, BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (TeacherRadioButton.Checked)
            {
                _userType = "Teacher";
                ParentRadioButton.Checked = false;
                SetUserSelectionError(false);
            }
        }

        private void SetUserSelectionError(bool isError)
        {
            // Sets the 'Parent' and 'Teacher' selection panel borders to red when error is passed.
            if (isError)
            {
                ParentCheckPanel.BorderColor = Color.FromArgb(255, 127, 127);
                TeacherCheckPanel.BorderColor = Color.FromArgb(255, 127, 127);
            }
            else
            {
                ParentCheckPanel.BorderColor = Color.FromArgb(224, 224, 224);
                TeacherCheckPanel.BorderColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEmail(EmailTextBox.Text))
            {
                IncorrectEmailTooltip.Visible = false;
            }
            else
            {
                IncorrectEmailTooltip.Text = "Incorrect email format";
                IncorrectEmailTooltip.Visible = true;
            }

            if (IncorrectPasswordTooltip.Text == "Password is incorrect")
            {
                IncorrectPasswordTooltip.Visible = false;
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsValidPassword(PasswordTextBox.Text) || PasswordTextBox.Text == String.Empty)
            {
                IncorrectPasswordTooltip.Visible = false;
            }
            else
            {
                IncorrectPasswordTooltip.Text = "Minimum of 8 characters (a-Z, 0-9)";
                IncorrectPasswordTooltip.Visible = true;
            }
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

        private async void LogInButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            IncorrectEmailTooltip.Visible = false;
            IncorrectPasswordTooltip.Visible = false;

            // Checks if required inputs are entered by the user; shows error texts when needed.
            if (String.IsNullOrEmpty(_userType)) SetUserSelectionError(true);
            if (PasswordTextBox.Text == String.Empty)
            {
                IncorrectPasswordTooltip.Text = "Input password";
                IncorrectPasswordTooltip.Visible = true;
            }

            if (EmailTextBox.Text == String.Empty)
            {
                IncorrectEmailTooltip.Text = "Input email";
                IncorrectEmailTooltip.Visible = true;
            }

            // Textboxes' values saved into class if required inputs are entered and are valid.
            // Input password encrypted and credentials are checked if present in the database.
            if (IsValidPassword(PasswordTextBox.Text) &&
                IsValidEmail(EmailTextBox.Text) &&
                _userType != String.Empty)
            {
                User sessionUser = new User
                {
                    Type = _userType,
                    Email = EmailTextBox.Text,
                    PasswordInHash = EncryptPlainTextToCipherText(PasswordTextBox.Text)
                };

                AirtableHelper databaseHelper = new AirtableHelper();
                var response = await databaseHelper.ListRecords(_userType);
                var records = response.Records.ToArray();

                if (sessionUser.DoesExistInDatabase(records))
                {
                    // Log in is successful.
                    LogInButton.Text = "✔ Success";
                    Cursor = Cursors.Default;

                    _timer = new Timer { Interval = 2000 };
                    _timer.Start();
                    _timer.Tick += Timer_Tick;
                }
                else if (!IsPasswordCorrect(sessionUser.Email, sessionUser.PasswordInHash, records) &&
                          IsEmailRegistered(sessionUser.Email, records))
                {
                    IncorrectPasswordTooltip.Text = "Password is incorrect";
                    IncorrectPasswordTooltip.Visible = true;
                }
                else
                {
                    IncorrectEmailTooltip.Text = "Email is not registered";
                    IncorrectEmailTooltip.Visible = true;
                }
            }
            else
            {
                // Else clear password textbox.
                PasswordTextBox.Text = String.Empty;
            }

            Cursor = Cursors.Default;
        }

        private void ForgotPasswordLinkLabel_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.ShowDialog();
        }

        private void SignUpLinkLabel_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            FadeOut(this);
            Application.Exit();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();

            if (_userType == "Teacher")
            {
                TeacherHomeForm homeForm = new TeacherHomeForm();
                homeForm.Show();
                this.Close();
            }
            else
            {
                ParentHomeForm homeForm = new ParentHomeForm();
                homeForm.Show();
                this.Close();
            }
        }
    }
}