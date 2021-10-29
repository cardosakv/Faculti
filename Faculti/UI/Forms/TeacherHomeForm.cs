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
using Faculti.DataClasses;
using Faculti.Services.FacultiDB;
using Oracle.ManagedDataAccess.Client;
using Faculti.UI.Forms;

namespace Faculti
{
    public delegate void NotifyTeacherHomeForm();

    public partial class TeacherHomeForm : Form
    {
        private Teacher _teacherUser;
        private GetStartedTeacher _getStarted;
        private TeacherHomePanel _homePage;
        private FeedPanel _feedPage;
        private GradesTeacherPanel _gradesPage;
        private ChatPanel _chatPage;
        private CalendarPanel _calendarPage;
        private ContactsPanel _contactsPage;
        private SecurityCheckPanel _securityCheckPanel;
        private Point pageLoc = new Point(3, 55);

        public Teacher TeacherUser
        {
            get { return _teacherUser; }
            set { _teacherUser = value; }
        }

        public TeacherHomeForm(Teacher teacherUser)
        {
            InitializeComponent();
            _teacherUser = teacherUser;
            FirstTimeCheckWorker.RunWorkerAsync();
        }

        private void FirstTimeCheckWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = _teacherUser.IsFirstTime();
        }

        private void FirstTimeCheckWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result == true)
            {
                Loader.Visible = false;
                InitializeGetStarted();
            }
            else
            {
                HomeWorker.RunWorkerAsync();
            }
        }

        private void InitializeGetStarted()
        {
            _getStarted = new GetStartedTeacher(_teacherUser);
            _getStarted.GetStartedFinished += new NotifyTeacherHomeForm(InitializeAfterGetStarted);
            _getStarted.Location = pageLoc;
            MainPanel.Controls.Add(_getStarted);
        }

        private void InitializeAfterGetStarted()
        {
            Loader.Visible = true;
            HomeWorker.RunWorkerAsync();
        }

        private void HomeWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _teacherUser.GetGeneralInfo();
            _teacherUser.SetStatus("Y");
        }

        private void HomeWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            InitializeTabs();
            AddTabs();
            Loader.Visible = false;
        }

        private void InitializeTabs()
        {
            _homePage = new TeacherHomePanel(_teacherUser);
            _feedPage = new FeedPanel(_teacherUser);
            _gradesPage = new GradesTeacherPanel(_teacherUser);
            _calendarPage = new CalendarPanel(_teacherUser);
            _chatPage = new ChatPanel(_teacherUser);
            _securityCheckPanel = new SecurityCheckPanel(_teacherUser);
            /*
             _calendarPage = new CalendarPanel(teacherUser);
             _contactsPage = new ContactsPanel(teacherUser);*/

            _homePage.Location = pageLoc;
            _feedPage.Location = pageLoc;
            _calendarPage.Location = pageLoc;
            _gradesPage.Location = pageLoc;
            _chatPage.Location = pageLoc;
            _securityCheckPanel.Location = pageLoc;
        }

        private void AddTabs()
        {
            MainPanel.Controls.Add(_homePage);
            MainPanel.Controls.Add(_feedPage);
            MainPanel.Controls.Add(_gradesPage);
            MainPanel.Controls.Add(_calendarPage);
            MainPanel.Controls.Add(_chatPage);
            MainPanel.Controls.Add(_securityCheckPanel);
        }




        // ====================================================================================== //
        //                                                                                        //
        //                                        UI METHODS                                      //
        //                                                                                        //
        // ====================================================================================== //
        private void HomeButton_Click(object sender, EventArgs e)
        {
            PageLabel.Text = "Overview";
            _homePage.BringToFront();
        }

        private void NewsButton_Click(object sender, EventArgs e)
        {
            FeedNotif.Visible = false;
            PageLabel.Text = "Feed";
            _feedPage.BringToFront();
        }

        private void GradesButton_Click(object sender, EventArgs e)
        {
            GradesNotif.Visible = false;
            PageLabel.Text = "Grades";
            _gradesPage.BringToFront();
            _securityCheckPanel.BringToFront();
            _securityCheckPanel.Visible = true;
        }

        private void ChatButton_Click(object sender, EventArgs e)
        {
            ChatNotif.Visible = false;
            PageLabel.Text = "Chat";
            _chatPage.BringToFront();
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            CalendarNotif.Visible = false;
            PageLabel.Text = "Calendar";
            _calendarPage.BringToFront();
        }

        private void ContactsButton_Click(object sender, EventArgs e)
        {
            PageLabel.Text = "Contacts";
            //_contactsPage.Visible = true;
        }

        private void ParentHomeForm_Load(object sender, EventArgs e)
        {
            FormAnimation.FadeIn(this);
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
            DialogBGForm bgForm = new DialogBGForm();
            using (ConfirmLogoutForm confirm = new ConfirmLogoutForm())
            {
                bgForm.Show();
                confirm.Owner = bgForm;

                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    _teacherUser.SetStatus("N");
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    FormAnimation.FadeOut(this);
                    this.Close();
                }

                bgForm.Dispose();
            }
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

        //private void ContactsButton_MouseHover(object sender, EventArgs e)
        //{
        //    ContactsButton.Text = "  ☎️   Contacts";
        //}

        //private void ContactsButton_MouseLeave(object sender, EventArgs e)
        //{
        //    ContactsButton.Text = "  📞   Contacts";
        //}

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
            DialogBGForm bgForm = new DialogBGForm();
            using (ConfirmExitForm confirm = new ConfirmExitForm())
            {
                bgForm.Show();
                confirm.Owner = bgForm;

                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    Application.Exit();
                }

                bgForm.Dispose();
            }  
        }

        private void TeacherHomeForm_Shown(object sender, EventArgs e)
        {
            
        }
    }
}