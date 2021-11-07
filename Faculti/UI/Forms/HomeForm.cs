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
using System.IO;
using Faculti.Helpers;

namespace Faculti
{
    public delegate void NotifyHomeForm();

    public partial class HomeForm : Form
    {
        private dynamic _user;
        private dynamic _homePage;
        private dynamic _gradesPage;
        private FeedPanel _feedPage;
        private ChatPanel _chatPage;
        private CalendarPanel _calendarPage;
        private Point pageLoc = new Point(3, 55);

        private int _lastUpdateId = 0;
        private int _currUpdateId;
        private string _notifType;
        private string _notifDesc;
        private DateTime _notifTime;
        private bool _isNewNotifArrived = false;
        private int _senderId;
        private int _receiverId;
        private string _senderUserType;

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        public HomeForm(User user)
        {
            InitializeComponent();
            DisableUI();

            _user = user;
            FirstTimeCheckWorker.RunWorkerAsync();
        }

      
        private void FirstTimeCheckWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = _user.IsFirstTime();
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
            if (_user.Type == "teachers")
            {
                GetStartedTeacher _getStarted = new GetStartedTeacher(_user.As<Teacher>());
                _getStarted.GetStartedFinished += new NotifyHomeForm(InitializeAfterGetStarted);
                _getStarted.Location = pageLoc;
                MainPanel.Controls.Add(_getStarted);
            }
            else
            {
                GetStartedParent _getStarted = new GetStartedParent(_user.As<Parent>());
                _getStarted.GetStartedFinished += new NotifyHomeForm(InitializeAfterGetStarted);
                _getStarted.Location = pageLoc;
                MainPanel.Controls.Add(_getStarted);
            }
        }

        private void InitializeAfterGetStarted()
        {
            Loader.Visible = true;
            HomeWorker.RunWorkerAsync();
        }

        private void HomeWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _user.GetGeneralInfo();
            if (_user.Type == "parents")
            {
                Student stud = new Student();
                stud.GetInfo(_user.Id);
                _user.AssignedStudent = stud;
            }
            _user.SetStatus("Y");
    
            TopProfilePictureBox.Image = _user.Picture;
        }

        private void HomeWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AddTabs();
            EnableUI();
            HomeButton.Focus();
            Loader.Visible = false;
            NotifCheckTimer.Enabled = true;
        }

        private void AddTabs()
        {
            if (_user.Type == "teachers")
            {
                _homePage = new TeacherHomePanel(_user);
                _gradesPage = new GradesTeacherPanel(_user);
            }
            else
            {
                _homePage = new ParentHomePanel(_user);
                _gradesPage = new GradesParentPanel(_user);
            }
            
            _feedPage = new FeedPanel(_user);
            _calendarPage = new CalendarPanel(_user);
            _chatPage = new ChatPanel(_user);

            _homePage.Location = pageLoc;
            _gradesPage.Location = pageLoc;
            _feedPage.Location = pageLoc;
            _calendarPage.Location = pageLoc;
            _chatPage.Location = pageLoc;

            MainPanel.Controls.Add(_homePage);
            MainPanel.Controls.Add(_gradesPage);
            MainPanel.Controls.Add(_feedPage);
            MainPanel.Controls.Add(_calendarPage);
            MainPanel.Controls.Add(_chatPage);
        }

        private void CheckNotifWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DatabaseClient notifClient = new DatabaseClient();
                var cmdText = $"select update_id, update_type, text, created_time, sender_id, receiver_id, sender_user_type from updates order by created_time asc";
                OracleCommand cmd = new OracleCommand(cmdText, notifClient.Conn);
                using (OracleDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        _currUpdateId = rdr.IsDBNull(0) ? 0 : rdr.GetInt32(0);
                        _notifType = rdr.IsDBNull(1) ? null : rdr.GetString(1);
                        _notifDesc = rdr.IsDBNull(2) ? null : rdr.GetString(2);
                        _notifTime = rdr.IsDBNull(3) ? DateTime.MinValue : rdr.GetOracleDate(3).Value;
                        _senderId = rdr.IsDBNull(4) ? 0 : rdr.GetInt32(4);
                        _receiverId = rdr.IsDBNull(5) ? 0 : rdr.GetInt32(5);
                        _senderUserType = rdr.IsDBNull(6) ? null : rdr.GetString(6);
                    }
                }

                notifClient.Close();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void CheckNotifWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!string.IsNullOrEmpty(_notifType))
            {
                NothingLabel.Visible = false;

                if (_currUpdateId != _lastUpdateId && _senderId != _user.Id && _senderUserType != _user.Type)
                {
                    NotifCard notifCard = new NotifCard(_notifType, _notifDesc, _notifTime);
                    NotifFlowLayoutPanel.SuspendLayout();
                    NotifFlowLayoutPanel.Controls.Add(notifCard);
                    NotifFlowLayoutPanel.Controls.SetChildIndex(notifCard, 0);
                    NotifFlowLayoutPanel.ResumeLayout();

                    notifCard.Click += (s, o) =>
                    {
                        if (notifCard.Type == "feed") { NewsButton.Focus(); }
                        if (notifCard.Type == "grades") { GradesButton.Focus(); }
                        if (notifCard.Type == "chat") { ChatButton.Focus(); }
                        if (notifCard.Type == "calendar") { CalendarButton.Focus(); }
                        NotifPanel.Visible = false;
                        NotifFlowLayoutPanel.Controls.Remove(notifCard);
                    };

                    if (_notifType == "feed" && !NewsButton.Focused)
                    {
                        FeedNotif.Visible = true;
                    }
                    else if (_notifType == "grades" && !GradesButton.Focused)
                    {
                        GradesNotif.Visible = true;
                    }
                    else if (_notifType == "chat" && !ChatButton.Focused)
                    {
                        ChatNotif.Visible = true;
                    }
                    else if (_notifType == "calendar" && !CalendarButton.Focused)
                    {
                        CalendarNotif.Visible = true;
                    }

                    _isNewNotifArrived = true;
                    NotificationButton.Image = Faculti.Properties.Resources.notif_newnotif;

                    _lastUpdateId = _currUpdateId;
                }
                
            }
        }



        // ====================================================================================== //
        //                                                                                        //
        //                                        UI METHODS                                      //
        //                                                                                        //
        // ====================================================================================== //
        private void DisableUI()
        {
            HomeButton.Enabled = false;
            NewsButton.Enabled = false;
            GradesButton.Enabled = false;
            CalendarButton.Enabled = false;
            ChatButton.Enabled = false;
            NotificationButton.Enabled = false;
            //SettingsButton.Enabled = false;
            TopProfilePictureBox.Enabled = false;
            LogOutButton.Enabled = false;
        }

        private void EnableUI()
        {
            HomeButton.Enabled = true;
            NewsButton.Enabled = true;
            GradesButton.Enabled = true;
            CalendarButton.Enabled = true;
            ChatButton.Enabled = true;
            NotificationButton.Enabled = true;
            //SettingsButton.Enabled = true;
            TopProfilePictureBox.Enabled = true;
            LogOutButton.Enabled = true;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            PageLabel.Text = "Overview";
            //_feedPage.Enabled = false;
            //_chatPage.Enabled = false;
            //_calendarPage.Enabled = false;
            //_gradesPage.Enabled = false;
            //_homePage.Enabled = true;
            _homePage.BringToFront();
        }

        private void NewsButton_Click(object sender, EventArgs e)
        {
            FeedNotif.Visible = false;
            PageLabel.Text = "Feed";
            //_homePage.Enabled = false;
            //_chatPage.Enabled = false;
            //_calendarPage.Enabled = false;
            //_gradesPage.Enabled = false;
            //_feedPage.Enabled = true;
            _feedPage.BringToFront();
        }

        private void GradesButton_Click(object sender, EventArgs e)
        {
            GradesNotif.Visible = false;
            PageLabel.Text = "Grades";
            //_homePage.Enabled = false;
            //_chatPage.Enabled = false;
            //_calendarPage.Enabled = false;
            //_feedPage.Enabled = false;
            //_gradesPage.Enabled = true;
            _gradesPage.BringToFront();
        }

        private void ChatButton_Click(object sender, EventArgs e)
        {
            ChatNotif.Visible = false;
            PageLabel.Text = "Chat";
            //_homePage.Enabled = false;
            //_gradesPage.Enabled = false;
            //_calendarPage.Enabled = false;
            //_feedPage.Enabled = false;
            //_chatPage.Enabled = true;
            _chatPage.BringToFront();
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            CalendarNotif.Visible = false;
            PageLabel.Text = "Calendar";
            //_homePage.Enabled = false;
            //_gradesPage.Enabled = false;
            //_chatPage.Enabled = false;
            //_feedPage.Enabled = false;
            //_calendarPage.Enabled = true;
            _calendarPage.BringToFront();
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
            if (_isNewNotifArrived)
            {
                NotificationButton.Image = Faculti.Properties.Resources.notif_newnotif_hover;
            }
            else
            {
                NotificationButton.Image = Faculti.Properties.Resources.notif_hover;
            }
        }

        private void NotificationButton_MouseLeave(object sender, EventArgs e)
        {
            if (_isNewNotifArrived)
            {
                NotificationButton.Image = Faculti.Properties.Resources.notif_newnotif;
            }
            else
            {
                NotificationButton.Image = Faculti.Properties.Resources.notif_idle;
            }
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
                    _user.SetStatus("N");
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    FormAnimation.FadeOut(this);
                    this.Close();
                }

                bgForm.Dispose();
            }
        }
           
        /*
        private void SettingsButton_MouseHover(object sender, EventArgs e)
        {
            SettingsButton.Image = Faculti.Properties.Resources.settings_hover;
        }

        private void SettingsButton_MouseLeave(object sender, EventArgs e)
        {
            SettingsButton.Image = Faculti.Properties.Resources.settings_idle;
        }*/

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
            if (NotifPanel.Visible)
            {
                NotifPanel.Visible = false;
            }
            else
            {
                NotifPanel.Visible = true;
                NotifPanel.BringToFront();
            }

            if (NotifFlowLayoutPanel.Controls.Count == 1)
            {
                NothingLabel.Visible = true;
            }
            else
            {
                NothingLabel.Visible = false;
            }

            NotificationButton.Image = Faculti.Properties.Resources.notif_hover;
            _isNewNotifArrived = false;
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
                    _user.SetStatus("N");
                    Environment.Exit(Environment.ExitCode);
                    Application.Exit();
                }

                bgForm.Dispose();
            }  
        }

        private void NotifCheckTimer_Tick(object sender, EventArgs e)
        {
            if (!CheckNotifWorker.IsBusy) CheckNotifWorker.RunWorkerAsync();
        }

        private void TopProfilePictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog fldlg = new OpenFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                    Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"
                };

                
                if (fldlg.ShowDialog() == DialogResult.OK)
                {
                    Image pic;
                    string imgPath = fldlg.FileName;
                    byte[] blob;

                    using (FileStream fls = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
                    {
                        pic = Image.FromStream(fls);
                        pic = Picture.ResizeImage(pic, 40, 40);

                        string saveImagePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "profile.jpg");
                        pic.Save(saveImagePath);
                    }

                    using (FileStream fls2 = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
                    {
                        blob = new byte[fls2.Length];
                        fls2.Read(blob, 0, Convert.ToInt32(fls2.Length));
                    }

                    DatabaseClient client = new DatabaseClient();
                    var cmdText = $"update all_users set pic_name = '{imgPath}', picture = :image_blob where user_id = {_user.Id}";
                    OracleCommand cmd = new OracleCommand(cmdText, client.Conn);
                    cmd.Parameters.Add("image_blob", OracleDbType.Blob, blob, ParameterDirection.Input);
                    cmd.ExecuteNonQuery();

                    cmdText = $"update {_user.Type} set pic_name = '{imgPath}', picture = :image_blob where {_user.Type.Remove(_user.Type.Length - 1, 1)}_id = {_user.Id}";
                    cmd = new OracleCommand(cmdText, client.Conn);
                    cmd.Parameters.Add("image_blob", OracleDbType.Blob, blob, ParameterDirection.Input);
                    cmd.ExecuteNonQuery();

                    client.Close();

                    MemoryStream ms = new MemoryStream(blob);
                    Image pic2 = Image.FromStream(ms);
                    TopProfilePictureBox.Image = pic2;

                    _feedPage.ChangePicture(pic);
                }
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Error browsing image!");
            }
        }
    }
}