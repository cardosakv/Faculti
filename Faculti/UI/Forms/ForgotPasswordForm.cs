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

        private void EmailForgotTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}