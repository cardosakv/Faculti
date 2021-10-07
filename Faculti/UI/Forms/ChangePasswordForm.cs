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

namespace Faculti.UI.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private bool _passwordRevealed, _reenterPasswordRevealed;
        private string _email, _password;

        public ChangePasswordForm()
        {
            InitializeComponent();
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

        private void ConfirmChangeButton_Click(object sender, EventArgs e)
        {
            // List Records - return array of AirtableRecords
            // Get record id - User.GetRecordId();
            // Update password using AirtableClient.UpdateRecord();
            // if success, print Success on button
            // declare LoginForm object
            // show LoginForm
            // close this form
        }

        private void ConfirmPasswordRevealButton_Click(object sender, EventArgs e)
        {
            if (_reenterPasswordRevealed)
            {
                _reenterPasswordRevealed = false;
                PasswordTextBox.PasswordChar = '•';
                ConfirmPasswordRevealButton.Image = Faculti.Properties.Resources.password_hidden;
            }
            else
            {
                _reenterPasswordRevealed = true;
                PasswordTextBox.PasswordChar = '\0';
                ConfirmPasswordRevealButton.Image = Faculti.Properties.Resources.password_revealed;
            }
        }

        public void CopyEmail(string email)
        {
            _email = email;
        }
    }
}
