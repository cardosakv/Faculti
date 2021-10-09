using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using Faculti.Helpers;
using Faculti.UI;

namespace Faculti
{
    /// <summary>
    ///     Dialog form used for all Faculti email verifications.
    /// </summary>
    public partial class VerificationForm : Form
    {
        private int _verificationCode;
        private int _inputCode;
        private string _inputEmail;
        private string _verificationType;
        private int _resendTime = 0;
        private Timer ResendTimer;

        public VerificationForm()
        {
            InitializeComponent();
        }

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            int code = GetInputCodeFromTextboxes();
           
            if (code == _verificationCode)
            {
                IncorrectCodeLabel.Visible = false;
                ConfirmButton.Text = "✔️ Account Verified";
                await Task.Delay(1000);

                if (_verificationType == "signup")
                {
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                }
                else if (_verificationType == "forgot")
                { 
                    ForgotPasswordForm forgot = new ForgotPasswordForm();
                    forgot.Show();
                    this.Hide();
                }
            }
            else if (code == 0)
            {
                IncorrectCodeLabel.Text = "Please enter your code";
                IncorrectCodeLabel.Visible = true;
            }
            else if (Math.Floor(Math.Log10(code) + 1) < 4)
            {
                IncorrectCodeLabel.Text = "Lacking digits";
                IncorrectCodeLabel.Visible = true;
            }
            else
            {
                IncorrectCodeLabel.Text = "Incorrect code";
                IncorrectCodeLabel.Visible = true;
            }
        }

        private int GetInputCodeFromTextboxes()
        {
            try
            {
                return Convert.ToInt32(FirstDigitTextBox.Text + SecondDigitTextBox.Text +
                                    ThirdDigitTextBox.Text + FourthDigitTextBox.Text);
            }
            catch (FormatException)
            {
                return 0;
            }

             
        }

        public void CopyEmailAndCode(string email, int code, string verType)
        {
            _verificationCode = code;
            _inputEmail = email;
            _verificationType = verType;
        }




        // ====================================================================================== //
        //                                                                                        //
        //                                        UI METHODS                                      //
        //                                                                                        //
        // ====================================================================================== //
        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void FirstDigitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKey(e);

            if (e.KeyChar == '\b') FirstDigitTextBox.Focus();
            if (e.KeyChar <= '9' && e.KeyChar >= '0') SecondDigitTextBox.Focus();
            IncorrectCodeLabel.Visible = false;
        }

        private void SecondDigitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKey(e);

            if (e.KeyChar == '\b') FirstDigitTextBox.Focus();
            if (e.KeyChar <= '9' && e.KeyChar >= '0') ThirdDigitTextBox.Focus();
            IncorrectCodeLabel.Visible = false;
        }

        private void ThirdDigitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKey(e);

            if (e.KeyChar == '\b') SecondDigitTextBox.Focus();
            if (e.KeyChar <= '9' && e.KeyChar >= '0') FourthDigitTextBox.Focus();
            IncorrectCodeLabel.Visible = false;
        }

        private void FourthDigitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKey(e);

            if (e.KeyChar == '\b') ThirdDigitTextBox.Focus();
            if (e.KeyChar <= '9' && e.KeyChar >= '0') FourthDigitTextBox.Focus();
            IncorrectCodeLabel.Visible = false;
        }

        private void HandleKey(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FirstDigitTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                _inputCode = Convert.ToInt32(Clipboard.GetText());

                FirstDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 4 - 1) % 10).ToString();
                SecondDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 3 - 1) % 10).ToString();
                ThirdDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 2 - 1) % 10).ToString();
                FourthDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 1 - 1) % 10).ToString();

                FourthDigitTextBox.Focus();
                IncorrectCodeLabel.Visible = false;
            }
        }

        private void SecondDigitTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                _inputCode = Convert.ToInt32(Clipboard.GetText());

                FirstDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 4 - 1) % 10).ToString();
                SecondDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 3 - 1) % 10).ToString();
                ThirdDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 2 - 1) % 10).ToString();
                FourthDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 1 - 1) % 10).ToString();

                FourthDigitTextBox.Focus();
                IncorrectCodeLabel.Visible = false;
            }
        }

        private void ThirdDigitTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                _inputCode = Convert.ToInt32(Clipboard.GetText());

                FirstDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 4 - 1) % 10).ToString();
                SecondDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 3 - 1) % 10).ToString();
                ThirdDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 2 - 1) % 10).ToString();
                FourthDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 1 - 1) % 10).ToString();

                FourthDigitTextBox.Focus();
                IncorrectCodeLabel.Visible = false;
            }
        }

        private void FourthDigitTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                _inputCode = Convert.ToInt32(Clipboard.GetText());

                FirstDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 4 - 1) % 10).ToString();
                SecondDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 3 - 1) % 10).ToString();
                ThirdDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 2 - 1) % 10).ToString();
                FourthDigitTextBox.Text = (_inputCode / (int)Math.Pow(10, 1 - 1) % 10).ToString();

                FourthDigitTextBox.Focus();
                IncorrectCodeLabel.Visible = false;
            }
        }

        private void ResendCodeButton_Click(object sender, EventArgs e)
        {
            if (_resendTime >= 29  || _resendTime == 0)
            {
                Email.SendVerificationCode(_inputEmail, _verificationCode);

                SuccessfulResentLabel.Visible = true;
                _resendTime = 0;
                ResendTimer = new Timer { Interval = 1000 };
                ResendTimer.Tick += ResendTimer_Tick;
                ResendTimer.Start();

                Cursor = Cursors.Default;
            }   
        }

        private void ConfirmationBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void VerificationForm_Load(object sender, EventArgs e)
        {
            FormAnimation.FadeIn(this);
        }

        private void ResendTimer_Tick(object sender, EventArgs e)
        {
            if (_resendTime >= 29)
            {
                ResendTimer.Stop();
                ResendCodeButton.Enabled = true;
                ResendCodeButton.Text = "RESEND";
            }
            else
            {
                ResendCodeButton.Text = $"{30 - ++_resendTime} S";
            }
        }
    }
}