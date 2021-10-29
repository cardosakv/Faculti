using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faculti.DataClasses;
using Faculti.Helpers;

namespace Faculti.UI.Cards
{
    public partial class SecurityCheckPanel : UserControl
    {
        private User _user;

        public SecurityCheckPanel(User user)
        {
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(AccessButton);
            _user = user;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Syntax.IsValidPassword(PasswordTextBox.Text) || PasswordTextBox.Text == string.Empty)
            {
                IncorrectPasswordTooltip.Visible = false;
            }
            else
            {
                IncorrectPasswordTooltip.Text = "Minimum of 8 characters (a-Z, 0-9)";
                IncorrectPasswordTooltip.Visible = true;
            }
        }

        private void AccessButton_Click(object sender, EventArgs e)
        {
            if (Password.Encrypt(PasswordTextBox.Text) == _user.PasswordInHash)
            {
                this.Visible = false;
                PasswordTextBox.Text = string.Empty;
            }
            else
            {
                IncorrectPasswordTooltip.Text = "Incorrect password";
                IncorrectPasswordTooltip.Visible = true;
            }
        }
    }
}
