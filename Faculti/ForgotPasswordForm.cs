using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Faculti.Misc.FormAnimation;

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
            FadeIn(this);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}