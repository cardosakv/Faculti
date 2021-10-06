using System;
using System.Windows.Forms;
using static Faculti.Misc.FormAnimation;

namespace Faculti
{
    /// <summary>
    /// Opens whenever no internet connectivity is found upon checking during the application start
    /// or after the splash screen finishes loading.
    /// </summary>
    public partial class NoInternetFoundForm : Form
    {
        public NoInternetFoundForm()
        {
            InitializeComponent();
            this.Opacity = 0;
        }

        private void NoInternetFoundForm_Shown(object sender, EventArgs e)
        {
            FadeIn(this);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RetryButton_Click(object sender, EventArgs e)
        {
            // Returns back to the splash screen to try checking the network.
            SplashScreen splashScreenForm = new SplashScreen();
            splashScreenForm.Show();

            FadeOut(this);
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            FadeOut(this);
            Application.Exit();
        }
    }
}