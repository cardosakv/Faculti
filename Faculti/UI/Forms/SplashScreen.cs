using System;
using System.Windows.Forms;
using static Faculti.UI.Internet;
using Faculti.UI;
using Faculti.Services;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Faculti
{
    /// <summary>
    /// Shows splash screen for the application.
    /// </summary>
    public partial class SplashScreen : Form
    {
        // Initializes timer for the splash screen.
        private Timer _splashShowTimer;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            FormAnimation.FadeIn(this);

            // Sets time to 3.5 seconds before the splash screen disappears.
            _splashShowTimer = new Timer { Interval = 3500 };
            _splashShowTimer.Start();
            _splashShowTimer.Tick += SplashShowTimer_Tick;
        }

        private void SplashShowTimer_Tick(object sender, EventArgs e)
        {
            // After the first tick of 3.5 sec, stops the splash screen timer.
            _splashShowTimer.Stop();

            // Immediately checks for internet connectivity and opens the login form when an active
            // network is detected. Otherwise, shows the 'no internet found' form.
            if (IsAvailableNetworkActive())
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                FormAnimation.FadeOut(this);
                this.Hide();
            }
            else
            {
                NoInternetFoundForm noInternetFoundForm = new NoInternetFoundForm();
                noInternetFoundForm.Show();

                FormAnimation.FadeOut(this);
                this.Hide();
            }
        }
    }
}