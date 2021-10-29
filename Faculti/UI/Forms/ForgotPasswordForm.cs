using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faculti.UI;
using Faculti.Helpers;
using Faculti.UI.Forms;

namespace Faculti
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(FindAccountButton);
        }

        private async void FindAccountButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            string email = EmailForgotTextBox.Text;
            if (Syntax.IsValidEmail(email))
            {
                bool isPresentInParentRecords = Email.IsPresentInDatabase(email, "parents");
                bool isPresentInTeacherRecords = Email.IsPresentInDatabase(email, "teachers");

                if (isPresentInParentRecords == true || isPresentInTeacherRecords == true)
                {
                    FindAccountButton.Text = "✔️ Account Found";
                    CodeEmailedLabel.Visible = true;
                    await Task.Delay(1000);


                    VerificationForm verificationForm = new VerificationForm
                    {
                        verificationType = "forgot",
                        emailToSendCode = email
                    };

                    verificationForm.ShowDialog();
                    Cursor = Cursors.Default;
                    this.Hide();
                }
                else
                {
                    IncorrectEmailForgotTooltip.Text = "Account does not exist";
                    IncorrectEmailForgotTooltip.Visible = true;
                }
            }
            else
            {
                IncorrectEmailForgotTooltip.Text = "Please enter email";
                IncorrectEmailForgotTooltip.Visible = true;
            }

            Cursor = Cursors.Default;
        }




        // ====================================================================================== //
        //                                                                                        //
        //                                        UI METHODS                                      //
        //                                                                                        //
        // ====================================================================================== //

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            FormAnimation.FadeIn(this);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForgotPasswordForm_Shown(object sender, EventArgs e)
        {
            FormAnimation.FadeIn(this);
        }

        private void EmailForgotTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Syntax.IsValidEmail(EmailForgotTextBox.Text))
            {
                IncorrectEmailForgotTooltip.Visible = false;
            }
            else if (EmailForgotTextBox.Text == string.Empty)
            {
                IncorrectEmailForgotTooltip.Text = "Please enter email";
                IncorrectEmailForgotTooltip.Visible = true;
            }
            else
            {
                IncorrectEmailForgotTooltip.Text = "Invalid email format";
                IncorrectEmailForgotTooltip.Visible = true;
            }
        }

        private void IncorrectEmailForgotTooltip_Click(object sender, EventArgs e)
        {

        }

        private void EmailForgotTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Syntax.IsValidEmail(EmailForgotTextBox.Text))
            {
                IncorrectEmailForgotTooltip.Visible = false;
            }
            else
            {
                IncorrectEmailForgotTooltip.Visible = true;
            }
        }
    }
}