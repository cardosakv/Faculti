using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;
using static Faculti.Misc.FormAnimation;

namespace Faculti
{
    public partial class ParentHomeForm : Form
    {
        private BunifuButton2 lastButtonClicked;

        public ParentHomeForm()
        {
            InitializeComponent();
            lastButtonClicked = HomeButton;
        }

        private void ParentHomeForm_Load(object sender, EventArgs e)
        {
            FadeIn(this);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Pages.SetPage(HomePage);
            lastButtonClicked.ApplyState(lastButtonClicked.OnIdleState);
            lastButtonClicked = HomeButton;

            if (HomeButton.Focused)
            {
                HomeButton.onHoverState.ForeColor = Color.White;
                HomeButton.onHoverState.FillColor = Color.FromArgb(33, 33, 33);
                HomeButton.onHoverState.IconLeftImage = Faculti.Properties.Resources.home_pressed;
            }
            else
            {
                HomeButton.onHoverState.ForeColor = Color.FromArgb(33, 33, 33);
                HomeButton.onHoverState.FillColor = Color.White;
                HomeButton.onHoverState.IconLeftImage = Faculti.Properties.Resources.home_hover;
            }
        }

        private void NewsButton_Click(object sender, EventArgs e)
        {
            Pages.SetPage(NewsPage);
            lastButtonClicked.ApplyState(lastButtonClicked.OnIdleState);
            lastButtonClicked = NewsButton;
        }

        private void GradesButton_Click(object sender, EventArgs e)
        {
            Pages.SetPage(GradesPage);
            lastButtonClicked.ApplyState(lastButtonClicked.OnIdleState);
            lastButtonClicked = GradesButton;
        }

        private void ChatButton_Click(object sender, EventArgs e)
        {
            Pages.SetPage(ChatPage);
            lastButtonClicked.ApplyState(lastButtonClicked.OnIdleState);
            lastButtonClicked = ChatButton;
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            Pages.SetPage(CalendarPage);
            lastButtonClicked.ApplyState(lastButtonClicked.OnIdleState);
            lastButtonClicked = CalendarButton;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NotificationButton_MouseHover(object sender, EventArgs e)
        {
            NotificationButton.Image = Faculti.Properties.Resources.bell_hover;
        }

        private void NotificationButton_MouseLeave(object sender, EventArgs e)
        {
            NotificationButton.Image = Faculti.Properties.Resources.bell_idle;
        }

        private void DateTimeLabel_MouseHover(object sender, EventArgs e)
        {
            DateTimeLabel.ForeColor = Color.FromArgb(33, 33, 33);
            DateTimePictureBox.Image = Faculti.Properties.Resources.date_hover1;
        }

        private void DateTimeLabel_MouseLeave(object sender, EventArgs e)
        {
            DateTimeLabel.ForeColor = Color.FromArgb(161, 166, 175);
            DateTimePictureBox.Image = Faculti.Properties.Resources.date_idle1;
        }

        private void DateTimePictureBox_MouseHover(object sender, EventArgs e)
        {
            DateTimeLabel.ForeColor = Color.FromArgb(33, 33, 33);
            DateTimePictureBox.Image = Faculti.Properties.Resources.date_hover1;
        }

        private void DateTimePictureBox_MouseLeave(object sender, EventArgs e)
        {
            DateTimeLabel.ForeColor = Color.FromArgb(161, 166, 175);
            DateTimePictureBox.Image = Faculti.Properties.Resources.date_idle1;
        }

        private void DateTimePanel_MouseHover(object sender, EventArgs e)
        {
            DateTimeLabel.ForeColor = Color.FromArgb(33, 33, 33);
            DateTimePictureBox.Image = Faculti.Properties.Resources.date_hover1;
        }

        private void DateTimePanel_MouseLeave(object sender, EventArgs e)
        {
            DateTimeLabel.ForeColor = Color.FromArgb(161, 166, 175);
            DateTimePictureBox.Image = Faculti.Properties.Resources.date_idle1;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            FadeOut(this);
            this.Hide();
        }

        private void SettingsButton_MouseHover(object sender, EventArgs e)
        {
            SettingsButton.Image = Faculti.Properties.Resources.settings_keydown;
        }

        private void SettingsButton_MouseLeave(object sender, EventArgs e)
        {
            SettingsButton.Image = Faculti.Properties.Resources.settings_idle;
        }
    }
}