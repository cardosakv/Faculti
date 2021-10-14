using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;
using Faculti.UI.Cards;
using Faculti.UI;

namespace Faculti
{
    public partial class ParentHomeForm : Form
    {
        HomePanel homePanel = new HomePanel();
        FeedPanel feedPanel = new FeedPanel();
        GradesPanel gradesPanel = new GradesPanel();
        ChatPanel chatPanel = new ChatPanel();
        CalendarPanel calendarPanel = new CalendarPanel();
        ContactsPanel contactsPanel = new ContactsPanel();
        Loader loader = new Loader();

        public ParentHomeForm(User parentUser)
        {
            InitializeComponent();
            homePanel.Location = new Point(3, 55);
            feedPanel.Location = new Point(3, 55);
            gradesPanel.Location = new Point(3, 60);
            chatPanel.Location = new Point(3, 60);
            calendarPanel.Location = new Point(3, 60);
            contactsPanel.Location = new Point(3, 60);
            loader.Location = new Point(3, 60);
            MainPanel.Controls.Add(homePanel);
            MainPanel.Controls.Add(feedPanel);
            MainPanel.Controls.Add(gradesPanel);
            MainPanel.Controls.Add(chatPanel);
            MainPanel.Controls.Add(calendarPanel);
            MainPanel.Controls.Add(contactsPanel);
            MainPanel.Controls.Add(loader);
            DisplayTimeAndDate();
        }

        private void ParentHomeForm_Load(object sender, EventArgs e)
        {
            FormAnimation.FadeIn(this);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            PageLabel.Text = "Overview";
            homePanel.Visible = false;
            feedPanel.Visible = false;
            gradesPanel.Visible = false;
            chatPanel.Visible = false;
            calendarPanel.Visible = false;
            contactsPanel.Visible = false;
        }

        private void NewsButton_Click(object sender, EventArgs e)
        {
            PageLabel.Text = "Feed";
            homePanel.Visible = false;
            feedPanel.Visible = true;
            gradesPanel.Visible = false;
            chatPanel.Visible = false;
            calendarPanel.Visible = false;
            contactsPanel.Visible = false;
        }

        private void GradesButton_Click(object sender, EventArgs e)
        {
            PageLabel.Text = "Grades";
            homePanel.Visible = false;
            feedPanel.Visible = false;
            gradesPanel.Visible = true;
            chatPanel.Visible = false;
            calendarPanel.Visible = false;
            contactsPanel.Visible = false;
        }

        private void ChatButton_Click(object sender, EventArgs e)
        {
            PageLabel.Text = "Chat";
            homePanel.Visible = false;
            feedPanel.Visible = false;
            gradesPanel.Visible = false;
            chatPanel.Visible = true;
            calendarPanel.Visible = false;
            contactsPanel.Visible = false;
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            PageLabel.Text = "Calendar";
            homePanel.Visible = false;
            feedPanel.Visible = false;
            gradesPanel.Visible = false;
            chatPanel.Visible = false;
            calendarPanel.Visible = true;
            contactsPanel.Visible = false;
        }

        private void ContactsButton_Click(object sender, EventArgs e)
        {
            PageLabel.Text = "Contacts";
            homePanel.Visible = false;
            feedPanel.Visible = false;
            gradesPanel.Visible = false;
            chatPanel.Visible = false;
            calendarPanel.Visible = false;
            contactsPanel.Visible = true;
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
            NotificationButton.Image = Faculti.Properties.Resources.notif_newnotif_hover;
        }

        private void NotificationButton_MouseLeave(object sender, EventArgs e)
        {
            NotificationButton.Image = Faculti.Properties.Resources.notif_newnotif;
        }
        private void DateTimePanel_MouseHover(object sender, EventArgs e)
        {
            DateTime_Hover();
        }

        private void DateTimePanel_MouseLeave(object sender, EventArgs e)
        {
            DateTime_Leave();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            FormAnimation.FadeOut(this);
            this.Hide();
        }

        private void SettingsButton_MouseHover(object sender, EventArgs e)
        {
            SettingsButton.Image = Faculti.Properties.Resources.settings_hover;
        }

        private void SettingsButton_MouseLeave(object sender, EventArgs e)
        {
            SettingsButton.Image = Faculti.Properties.Resources.settings_idle;
        }

        private void DisplayTimeAndDate()
        {
            DateTime now = DateTime.Now;
            string day = now.ToString("ddd");
            string month = now.ToString("MMM");
            string date = now.ToString("dd");
            string time = now.ToString("hh:mm tt");
            DateTimeLabel.Text = $"{day} • {month} {date} • {time}";
        }

        private void DisplayRandomTips()
        {
            string[] tips = { "  Eat your meal  🥣",
                              "  Drink some water  🥛",
                              "  Take a break  💤",
                              "  Exercise daily  💪",
                              "  Schedule your day  📝",
                              "  Try to meditate  🧘",
                              "  Travel someday  ⛰️",
                              "  Read some books  📗",
                              "  Sleep early  🛌",
                              "  Check schedule  📌"};

            Random rnd = new Random();
            DateTimeLabel.Text = tips[rnd.Next(0, 9)];
        }

        private void DateTime_Hover()
        {
            DateTimeTimer.Stop();
            DisplayRandomTips();
            DateTimePictureBox.Image = Faculti.Properties.Resources.tips;
        }

        private void DateTime_Leave()
        {
            DisplayTimeAndDate();
            DateTimeTimer.Start();
            DateTimeLabel.ForeColor = Color.FromArgb(162, 177, 198);
            DateTimePictureBox.Image = Faculti.Properties.Resources.calendar_idle;
        }

        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            DisplayTimeAndDate();
        }

        private void HomeButton_MouseHover(object sender, EventArgs e)
        {
            HomeButton.Text = "  🏡   Home";
        }

        private void HomeButton_MouseLeave(object sender, EventArgs e)
        {
            HomeButton.Text = "  🏚   Home";
        }

        private void NewsButton_MouseHover(object sender, EventArgs e)
        {
            NewsButton.Text = "  📰   Feed";
        }

        private void NewsButton_MouseLeave(object sender, EventArgs e)
        {
            NewsButton.Text = "  📄   Feed";
        }

        private void GradesButton_MouseHover(object sender, EventArgs e)
        {
            GradesButton.Text = "  ✅   Grades";
        }

        private void GradesButton_MouseLeave(object sender, EventArgs e)
        {
            GradesButton.Text = "  ☑   Grades";
        }

        private void ChatButton_MouseHover(object sender, EventArgs e)
        {
            ChatButton.Text = "  🗨   Chat";
        }

        private void ChatButton_MouseLeave(object sender, EventArgs e)
        {
            ChatButton.Text = "  💬   Chat";
        }

        private void CalendarButton_MouseHover(object sender, EventArgs e)
        {
            CalendarButton.Text = "  📅   Calendar";
        }

        private void CalendarButton_MouseLeave(object sender, EventArgs e)
        {
            CalendarButton.Text = "  📆   Calendar";
        }

        private void ContactsButton_MouseHover(object sender, EventArgs e)
        {
            ContactsButton.Text = "  ☎️   Contacts";
        }

        private void ContactsButton_MouseLeave(object sender, EventArgs e)
        {
            ContactsButton.Text = "  📞   Contacts";
        }

        private void TopProfilePictureBox_MouseHover(object sender, EventArgs e)
        {
            TopProfilePictureBox.BorderRadius = 10;
        }

        private void TopProfilePictureBox_MouseLeave(object sender, EventArgs e)
        {
            TopProfilePictureBox.BorderRadius = 17;
        }

        private void NotificationButton_Click(object sender, EventArgs e)
        {
            NotificationButton.Image = Faculti.Properties.Resources.notif_hover;
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}