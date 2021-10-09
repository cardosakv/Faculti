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
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            FormAnimation.FadeIn(this);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FindAccountButton_Click(object sender, EventArgs e)
        {
            var email = EmailForgotTextBox.Text;

            if (Syntax.IsValidEmail(email))
            {
                AirtableClient airtableClientParent = new AirtableClient();
                var parentRecords = await airtableClientParent.ListRecords("Parent");

                AirtableClient airtableClientTeacher = new AirtableClient();
                var teacherRecords = await airtableClientTeacher.ListRecords("Teacher");

                var isPresentInParentRecords = Email.IsPresentInDatabase(email, parentRecords);
                var isPresentInTeacherRecords = Email.IsPresentInDatabase(email, teacherRecords);

                if (isPresentInParentRecords == true || isPresentInTeacherRecords == true)
                {
                    Random rnd = new Random();
                    int verificationCode = rnd.Next(1000, 9999);

                    Email.SendVerificationCode(email, verificationCode);

                    VerificationForm verificationForm = new VerificationForm();
                    verificationForm.CopyEmailAndCode(email, verificationCode, "forgot");
                    verificationForm.ShowDialog();
           
                }
                else
                {
                    IncorrectEmailForgotTooltip.Text = "Account does not exist";
                    EmailForgotTextBox.Text = String.Empty;
                }  
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