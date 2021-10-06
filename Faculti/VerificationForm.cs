using System;
using System.Drawing;
using System.Windows.Forms;
using static Faculti.Validation.Email;
using static Faculti.Misc.FormAnimation;

namespace Faculti
{
    public partial class VerificationForm : Form
    {
        public int verCode;
        public int inputCode;
        public string inputEmail;

        private Timer timer, timer2;
        public int time = 0;

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

        public VerificationForm()
        {
            InitializeComponent();
        }

        public void CopyEmailAndCode(string email, int code)
        {
            verCode = code;
            inputEmail = email;
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
                inputCode = Convert.ToInt32(Clipboard.GetText());

                FirstDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 4 - 1) % 10).ToString();
                SecondDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 3 - 1) % 10).ToString();
                ThirdDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 2 - 1) % 10).ToString();
                FourthDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 1 - 1) % 10).ToString();

                FourthDigitTextBox.Focus();
                IncorrectCodeLabel.Visible = false;
            }
        }

        private void SecondDigitTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                inputCode = Convert.ToInt32(Clipboard.GetText());

                FirstDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 4 - 1) % 10).ToString();
                SecondDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 3 - 1) % 10).ToString();
                ThirdDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 2 - 1) % 10).ToString();
                FourthDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 1 - 1) % 10).ToString();

                FourthDigitTextBox.Focus();
                IncorrectCodeLabel.Visible = false;
            }
        }

        private void ThirdDigitTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                inputCode = Convert.ToInt32(Clipboard.GetText());

                FirstDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 4 - 1) % 10).ToString();
                SecondDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 3 - 1) % 10).ToString();
                ThirdDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 2 - 1) % 10).ToString();
                FourthDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 1 - 1) % 10).ToString();

                FourthDigitTextBox.Focus();
                IncorrectCodeLabel.Visible = false;
            }
        }

        private void FourthDigitTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                inputCode = Convert.ToInt32(Clipboard.GetText());

                FirstDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 4 - 1) % 10).ToString();
                SecondDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 3 - 1) % 10).ToString();
                ThirdDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 2 - 1) % 10).ToString();
                FourthDigitTextBox.Text = (inputCode / (int)Math.Pow(10, 1 - 1) % 10).ToString();

                FourthDigitTextBox.Focus();
                IncorrectCodeLabel.Visible = false;
            }
        }

        private void ResendCodeButton_Click(object sender, EventArgs e)
        {
            time = 0;
            SendEmailVerificationCode(inputEmail, verCode);
            Cursor = Cursors.AppStarting;
            SuccessfulResentLabel.Visible = true;
            ResendCodeButton.ForeColor = Color.DimGray;
            ResendCodeButton.Enabled = false;

            timer = new Timer { Interval = 1000 };
            Cursor = Cursors.Default;
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string inputCodeInString = FirstDigitTextBox.Text +
                                        SecondDigitTextBox.Text +
                                        ThirdDigitTextBox.Text +
                                        FourthDigitTextBox.Text;

            inputCode = Convert.ToInt32(inputCodeInString);

            if (FirstDigitTextBox.Text == "")
            {
                IncorrectCodeLabel.Visible = true;
            }
            else if (inputCode == verCode)
            {
                IncorrectCodeLabel.Visible = false;
                ConfirmButton.Text = "✔ Account Verified";

                timer2 = new Timer { Interval = 3000 };
                timer2.Start();
                timer2.Tick += Timer2_Tick;
            }
            else
            {
                IncorrectCodeLabel.Visible = true;
            }
        }

        private void ConfirmationBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time++;
            ResendCodeButton.Text = (31 - time).ToString() + " S";

            //after 10 secs, stop the timer
            if (time > 30)
            {
                ResendCodeButton.Enabled = true;
                ResendCodeButton.Text = "RESEND CODE";
                ResendCodeButton.ForeColor = Color.FromArgb(255, 209, 24);
                SuccessfulResentLabel.Visible = false;
                timer.Stop();
                Cursor = Cursors.Default;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void VerificationForm_Load(object sender, EventArgs e)
        {
            FadeIn(this);
        }

        private void VerificationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}