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
using Faculti.Services.Airtable;
using Faculti.Helpers;

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
        {/*
            string email = EmailForgotTextBox.Text;

            if (Syntax.IsValidEmail(email))
            {
                AirtableClient airtableClientParent = new AirtableClient();
                var parentRecords = await airtableClientParent.ListRecords("Parent");

                AirtableClient airtableClientTeacher = new AirtableClient();
                var teacherRecords = await airtableClientTeacher.ListRecords("Teacher");

                bool isPresentInParentRecords = Email.IsPresentInDatabase(email, parentRecords);
                bool isPresentInTeacherRecords = Email.IsPresentInDatabase(email, teacherRecords);

                if (isPresentInParentRecords == true || isPresentInTeacherRecords == true)
                {
                    FindAccountButton.Text = "✔️ Account Found";
                    await Task.Delay(1000);

                    VerificationForm verificationForm = new VerificationForm
                    {
                        verificationType = "forgot",
                        emailToSendCode = email
                    };
                    verificationForm.ShowDialog();
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
            }*/
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
    }
}