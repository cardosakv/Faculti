using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faculti.DataClasses;
using Faculti.Services.FacultiDB;
using Oracle.ManagedDataAccess.Client;

namespace Faculti.UI.Cards
{
    public partial class ChatHead : UserControl
    {
        private readonly User _user;
        public Image Picture = Properties.Resources.default_profile;
        private string _picName;
        public int InboxId;
        public int ContactId;
        public string ContactName;
        private string _contactStatus;
        private string _lastMessage;
        private int _lastUserId;
        private DateTime _lastUpdate;
        private DatabaseClient _chatInfoClient;
        private OracleDataReader _chatInfoRdr;
        private DatabaseClient _createInboxClient;
        private DateTime _dateDefault = Convert.ToDateTime("01/01/2001");

        public ChatHead(User user, int contactId, string contactName, string contactStatus)
        {
            InitializeComponent();
            WireAllControls(this);

            _user = user;
            ContactId = contactId;
            ContactName = contactName;
            _contactStatus = contactStatus;

            GetChatInfoWorker.RunWorkerAsync();
        }



        // =========================================================================================
        private void GetChatInfoWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _chatInfoClient = new DatabaseClient();

                var cmdText = $"select picture, pic_name from all_users where user_id = {ContactId}";
                OracleCommand cmd = new OracleCommand(cmdText, _chatInfoClient.Conn);
                using (OracleDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        var picName = rdr.IsDBNull(1) ? null : rdr.GetString(1);

                        if (picName != _picName)
                        {
                            byte[] image = rdr.IsDBNull(0) ? null : (byte[])rdr["picture"];
                            if (image != null)
                            {
                                MemoryStream ms = new MemoryStream(image);
                                Image pic = Image.FromStream(ms);
                                Picture = pic;
                            }

                            _picName = picName;
                        }
                    }
                }

                cmdText = $"select active_status from all_users where user_id = {ContactId}";
                cmd = new OracleCommand(cmdText, _chatInfoClient.Conn);
                using (OracleDataReader rdr2 = cmd.ExecuteReader())
                {
                    if (rdr2.Read())
                    {
                        _contactStatus = rdr2.IsDBNull(0) ? null : rdr2.GetString(0);
                    }
                }

                cmdText = $"select inbox_id, last_message, last_update, last_user_id from inboxes where user_id1 = {_user.Id} and user_id2 = {ContactId} or user_id1 = {ContactId} and user_id2 = {_user.Id}";
                cmd = new OracleCommand(cmdText, _chatInfoClient.Conn);
                _chatInfoRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void GetChatInfoWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                if (_chatInfoRdr.Read())
                {
                    InboxId = _chatInfoRdr.IsDBNull(0) ? 0 : _chatInfoRdr.GetInt32(0);
                    _lastMessage = _chatInfoRdr.IsDBNull(1) ? null : _chatInfoRdr.GetString(1);
                    _lastUpdate = _chatInfoRdr.IsDBNull(2) ? _dateDefault : _chatInfoRdr.GetOracleDate(2).Value;
                    _lastUserId = _chatInfoRdr.IsDBNull(3) ? 0 : _chatInfoRdr.GetInt32(3);

                    _chatInfoClient.Close();
                    DisplayChatHeadInfo();
                    InboxUpdateTimer.Start();
                }
                else
                {
                    _chatInfoClient.Close();
                    CreateInboxWorker.RunWorkerAsync();
                }
            }   
        }

        public void DisplayChatHeadInfo()
        {
            ChatNameLabel.Text = ContactName;
            ChatPictureBox.Image = Picture;

            if (_lastUserId == _user.Id && _lastMessage == "Photo")
            {
                LastMesageLabel.Text = "You sent a photo";
            }
            else if (_lastUserId == _user.Id) 
            {
                LastMesageLabel.Text = "You: " + _lastMessage;
            }
            else if (_lastUserId != _user.Id && _lastMessage == "Photo")
            {
                LastMesageLabel.Text = "Sent a photo";
            }
            else if (_lastUserId != _user.Id)
            {
                LastMesageLabel.Text = _lastMessage;
            }
            else
            {
                LastMesageLabel.Text = string.Empty;
            }


            if (_lastUpdate == _dateDefault)
            {
                LastUpdateLabel.Text = string.Empty;
            }
            else
            {
                TimeSpan lastSpan = DateTime.Now - _lastUpdate;
                double lastUpdate = lastSpan.TotalSeconds / 60;
                string lastUpdateString;

                if (lastUpdate >= 1440)
                {
                    lastUpdate /= 1440;
                    lastUpdateString = $"{Convert.ToInt32(lastUpdate)}d";
                }
                else if (lastUpdate >= 60)
                {
                    lastUpdate /= 60;
                    lastUpdateString = $"{Convert.ToInt32(lastUpdate)}h";
                }
                else if (Convert.ToInt32(lastUpdate) == 0)
                {
                    lastUpdateString = "Now";
                }
                else
                {
                    lastUpdateString = $"{Convert.ToInt32(lastUpdate)}m";
                }

                LastUpdateLabel.Text = lastUpdateString;
            }

            if (_contactStatus == "Y")
            {
                IsActivePictureBox.Image = Properties.Resources.online;
            }
            else
            {
                IsActivePictureBox.Image = Properties.Resources.offline;
            }
        }
        // =========================================================================================




        // =========================================================================================
        private void CreateInboxWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            CreateInboxOnDb();
        }

        public void CreateInboxOnDb()
        {
            _createInboxClient = new DatabaseClient();
            var createInboxCmdText = $"insert into inboxes (user_id1, user_id2, last_update) values ({_user.Id}, {ContactId}, to_date('{_dateDefault:MM/dd/yyyy HH:mm:ss}', 'MM/DD/YYYY HH24:MI:SS'))";
            _createInboxClient.PerformNonQueryCommand(createInboxCmdText);
        }

        private void CreateInboxWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!GetChatInfoWorker.IsBusy) GetChatInfoWorker.RunWorkerAsync();
        }
        // =========================================================================================


        // =========================================================================================
        /*private void InboxUpdateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (!GetChatInfoWorker.IsBusy) GetChatInfoWorker.RunWorkerAsync();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void InboxUpdateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }
        // =========================================================================================
        */

        // =========================================================================================
        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                ctl.Click += (s, o) =>
                {
                    this.InvokeOnClick(this, EventArgs.Empty);
                };

                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }

        public void SetAsSelected()
        {
            ChatPanel.BackgroundColor = Color.White;
        }

        private void ChatHead_MouseHover(object sender, EventArgs e)
        {
            ChatPanel.BackgroundColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void ChatHead_MouseLeave(object sender, EventArgs e)
        {
            ChatPanel.BackgroundColor = Color.FromArgb(243, 246, 250);
            Cursor = Cursors.Default;
        }

        private void InboxUpdateTimer_Tick(object sender, EventArgs e)
        {
            if (!GetChatInfoWorker.IsBusy) GetChatInfoWorker.RunWorkerAsync();
        }
    }
}
