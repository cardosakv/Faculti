using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Faculti.DataClasses;
using Faculti.Services.FacultiDB;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Faculti.UI.Cards
{
    public partial class ChatPanel : UserControl
    {
        private readonly User _user;
        private int _currInboxId;
        private int _currReceiverId;
        private string _currImageName = String.Empty;
        private int _lastMessageUserId = 0;
        private UserControl _lastMessageCtrl = null;
        private DatabaseClient _contactsClient;
        private OracleDataReader _contactsRdr;
        private DatabaseClient _getMessagesClient;
        private OracleDataReader _getMessagesRdr;
        private DatabaseClient _sendMessagesClient;
        private DatabaseClient _getMessagesUpdateClient;
        private OracleDataReader _getMessagesUpdateRdr;
        private DatabaseClient _sendImageClient;
        private readonly List<int> _messageIds = new List<int>();
        private readonly List<int> _contactIds = new List<int>();
        private bool _isImageAttached = false;

        public ChatPanel(User user)
        {
            InitializeComponent();
            ControlInteractives.SetDoubleBuffered(this);
            ControlInteractives.SetDoubleBuffered(ChatMessagesFlowLayoutPanel);
            ControlInteractives.SetDoubleBuffered(ChatContainer);
            ControlInteractives.SetLabelHoverEvent(SendButton);

            _contactIds.Add(0);
            _user = user;
            if (!GetContactsWorker.IsBusy) GetContactsWorker.RunWorkerAsync();
        }


// ========================================================================================
        private void GetContactsWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _contactsClient = new DatabaseClient();
                var cmdText = $"select user_id, first_name, last_name, active_status from all_users where section_name = '{_user.SectionName}'";
                OracleCommand cmd = new OracleCommand(cmdText, _contactsClient.Conn);
                _contactsRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void GetContactsWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                DisplayContacts();
            }
            else
            {
                _contactsClient.Conn.Close();
                GetContactsWorker.RunWorkerAsync();
            }
        }

        public void DisplayContacts()
        {
            while (_contactsRdr.Read())
            {
                var contactId = _contactsRdr.GetInt32(0);

                if (contactId != _user.Id && Convert.ToInt32(contactId) > Convert.ToInt32(_contactIds[_contactIds.Count-1]))
                {
                    var contactName = $"{_contactsRdr.GetString(1)} {_contactsRdr.GetString(2)}";
                    var contactStatus = _contactsRdr.IsDBNull(3) ? "N" : _contactsRdr.GetString(3);

                    ChatHead chatHead = new ChatHead(_user, contactId, contactName, contactStatus);
                    ChatHeadFlowLayoutPanel.Controls.Add(chatHead);
                    chatHead.Click += (s, o) =>
                    {
                        if (chatHead.InboxId != _currInboxId)
                        {
                            ConstantUpdateTimer.Stop();
                            ConstantUpdateTimer.Enabled = false;

                            ContactActiveStatusLabel.Text = contactStatus == "Y" ? "Active Now" : "Offline";
                            ContactName.Text = contactName;

                            _currInboxId = chatHead.InboxId;
                            _currReceiverId = chatHead.ContactId;
                            _messageIds.Clear();
                            _messageIds.Add(0);
                            _lastMessageUserId = 0;
                            _lastMessageCtrl = null;

                            chatHead.SetAsSelected();
                            MessageLoader.Visible = true;
                            NoMessageSelectedPanel.Visible = false;
                            ChatMessagesFlowLayoutPanel.Controls.Clear();
                            ChatMessagesFlowLayoutPanel.Controls.Add(BeginningBorder);
                            ChatMessagesFlowLayoutPanel.Controls.Add(EmptyPanel);

                            if (!GetMessagesWorker.IsBusy) GetMessagesWorker.RunWorkerAsync();
                        }
                    };

                    _contactIds.Add(contactId);
                }
            }

            _contactsClient.Conn.Close();
        }
// ========================================================================================


// ========================================================================================
        private void GetMessagesWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _getMessagesClient = new DatabaseClient();
                var cmdText = $"select message_id, text, image, sender_id, receiver_id, send_time from messages where inbox_id = {_currInboxId} and message_id > {_messageIds[_messageIds.Count - 1]} order by send_time asc";
                OracleCommand cmd = new OracleCommand(cmdText, _getMessagesClient.Conn);
                _getMessagesRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void GetMessagesWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageError.Visible = true;
                _getMessagesClient.Conn.Close();
                GetMessagesWorker.RunWorkerAsync();
            }
            else
            {
                DisplayMessages(_getMessagesRdr);

                _getMessagesClient.Conn.Close();
                MessageLoader.Visible = false;
                ConstantUpdateTimer.Enabled = true;
                ConstantUpdateTimer.Start();
            }
        }

        private void DisplayMessages(OracleDataReader rdr)
        { 
            while (rdr.Read())
            {
                var messageId = rdr.GetInt32(0);
                var text = rdr.IsDBNull(1) ? null : rdr.GetString(1);
                byte[] image;
                var senderId = rdr.GetInt32(3);
                var receiverId = rdr.GetInt32(4);
                var sendTime = rdr.GetOracleDate(5).Value;

                UserControl _currMessageCtl = null;
                var _currMessageUserId = 0;
                Type lastCtrlType = null;
                int index;

                if (_lastMessageCtrl != null)
                {
                    index = ChatMessagesFlowLayoutPanel.Controls.IndexOf(_lastMessageCtrl);
                    lastCtrlType = ChatMessagesFlowLayoutPanel.Controls[index].GetType();
                }

                if (string.IsNullOrEmpty(text))
                {
                    image = (byte[])_getMessagesRdr["image"];
                    MemoryStream ms = new MemoryStream(image);
                    Image imageMessage = Image.FromStream(ms);

                    if (senderId == _user.Id)
                    {
                        _currMessageUserId = senderId;
                        MyImageMessage myImageMessageCtl = new MyImageMessage(imageMessage, sendTime);

                        if (lastCtrlType == typeof(MyImageMessage) && _lastMessageUserId == _currMessageUserId && _lastMessageCtrl != null && ((MyImageMessage)_lastMessageCtrl).Timestamp == myImageMessageCtl.Timestamp)
                        {
                            ((MyImageMessage)_lastMessageCtrl).RemoveTime();
                            myImageMessageCtl.Margin = new Padding(0);
                        }
                        else if (lastCtrlType == typeof(MyMessage) && _lastMessageUserId == _currMessageUserId && _lastMessageCtrl != null && ((MyMessage)_lastMessageCtrl).Timestamp == myImageMessageCtl.Timestamp)
                        {
                            ((MyMessage)_lastMessageCtrl).RemoveTime();
                            myImageMessageCtl.Margin = new Padding(0);
                        }

                        _currMessageCtl = myImageMessageCtl;
                    }
                    else if (receiverId == _user.Id)
                    {
                        TheirImageMessage theirImgMessageCtl = new TheirImageMessage(imageMessage, sendTime);
                        _currMessageUserId = receiverId;

                        if (lastCtrlType == typeof(TheirImageMessage) && _lastMessageUserId == _currMessageUserId && _lastMessageCtrl != null && ((TheirImageMessage)_lastMessageCtrl).Timestamp == theirImgMessageCtl.Timestamp)
                        {
                            ((TheirImageMessage)_lastMessageCtrl).RemoveImageAndTime();
                            theirImgMessageCtl.Margin = new Padding(0);
                        }
                        else if (lastCtrlType == typeof(TheirMessage) && _lastMessageUserId == _currMessageUserId && _lastMessageCtrl != null && ((TheirMessage)_lastMessageCtrl).Timestamp == theirImgMessageCtl.Timestamp)
                        {
                            ((TheirMessage)_lastMessageCtrl).RemoveImageAndTime();
                            theirImgMessageCtl.Margin = new Padding(0);
                        }

                        _currMessageCtl = theirImgMessageCtl;
                    }
                }
                else
                {
                    if (senderId == _user.Id)
                    {
                        MyMessage myMessageCtl = new MyMessage(text, sendTime);
                        _currMessageUserId = senderId;

                        if (lastCtrlType == typeof(MyMessage) && _lastMessageUserId == _currMessageUserId && _lastMessageCtrl != null && ((MyMessage)_lastMessageCtrl).Timestamp == myMessageCtl.Timestamp)
                        {
                            ((MyMessage)_lastMessageCtrl).RemoveTime();
                            myMessageCtl.Margin = new Padding(0);
                        }
                        else if (lastCtrlType == typeof(MyImageMessage) && _lastMessageUserId == _currMessageUserId && _lastMessageCtrl != null && ((MyImageMessage)_lastMessageCtrl).Timestamp == myMessageCtl.Timestamp)
                        {
                            ((MyImageMessage)_lastMessageCtrl).RemoveTime();
                            myMessageCtl.Margin = new Padding(0);
                        }

                        _currMessageCtl = myMessageCtl;
                    }
                    else if (receiverId == _user.Id)
                    {
                        TheirMessage theirMessageCtl = new TheirMessage(text, sendTime);
                        _currMessageUserId = receiverId;

                        if (lastCtrlType == typeof(TheirMessage) && _lastMessageUserId == _currMessageUserId && _lastMessageCtrl != null && ((TheirMessage)_lastMessageCtrl).Timestamp == theirMessageCtl.Timestamp)
                        {
                            ((TheirMessage)_lastMessageCtrl).RemoveImageAndTime();
                            theirMessageCtl.Margin = new Padding(0);
                        }
                        else if (lastCtrlType == typeof(TheirImageMessage) && _lastMessageUserId == _currMessageUserId && _lastMessageCtrl != null && ((TheirImageMessage)_lastMessageCtrl).Timestamp == theirMessageCtl.Timestamp)
                        {
                            ((TheirImageMessage)_lastMessageCtrl).RemoveImageAndTime();
                            theirMessageCtl.Margin = new Padding(0);
                        }

                        _currMessageCtl = theirMessageCtl;
                    }
                }

                ChatMessagesFlowLayoutPanel.Controls.Add(_currMessageCtl);
                ChatMessagesFlowLayoutPanel.ScrollControlIntoView(_currMessageCtl);
                _lastMessageUserId = _currMessageUserId;
                _lastMessageCtrl = _currMessageCtl;
                _messageIds.Add(messageId);
            }

            if (_messageIds.Count != 1)
            {
                ChatMessagesFlowLayoutPanel.Controls.Remove(EmptyPanel);
            }

            rdr.Dispose();
        }
// =======================================================================================


// =======================================================================================
        private void SendMessageWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!string.IsNullOrEmpty(MessageTextBox.Text))
            {
                try
                {
                    _sendMessagesClient = new DatabaseClient();
                    var cmdText = $"insert into messages (inbox_id, sender_id, receiver_id, text, send_time) values ({_currInboxId}, {_user.Id}, {_currReceiverId}, q'[{MessageTextBox.Text}]', to_date('{DateTime.Now:MM/dd/yyyy HH:mm:ss}', 'MM/DD/YYYY HH24:MI:SS'))";
                    _sendMessagesClient.PerformNonQueryCommand(cmdText);

                    _sendMessagesClient.Conn.Open();
                    cmdText = $"update inboxes set last_user_id = {_user.Id}, last_message = q'[{MessageTextBox.Text}]',  last_update = to_date('{DateTime.Now:MM/dd/yyyy HH:mm:ss}', 'MM/DD/YYYY HH24:MI:SS') where inbox_id = {_currInboxId}";
                    _sendMessagesClient.PerformNonQueryCommand(cmdText);
                }
                catch (Exception)
                {
                    e.Cancel = true;
                }
            }
        }

        private void SendMessageWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                SendMessageWorker.RunWorkerAsync();
            }
            else
            {
                MessageTextBox.Text = string.Empty;
                if (!GetMessagesWorker.IsBusy) GetMessagesWorker.RunWorkerAsync();
            }
        }
// =======================================================================================


// ===========================================================================================
        private void ConstantUpdateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _getMessagesUpdateClient = new DatabaseClient();
                var cmdText = $"select message_id, text, image, sender_id, receiver_id, send_time from messages where inbox_id = {_currInboxId} and message_id > {_messageIds[_messageIds.Count - 1]} order by send_time asc";
                OracleCommand cmd = new OracleCommand(cmdText, _getMessagesUpdateClient.Conn);
                _getMessagesUpdateRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void ConstantUpdateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageError.Visible = true;
                _getMessagesClient.Conn.Close();
            }
            else
            {
                DisplayMessages(_getMessagesUpdateRdr);
                _getMessagesUpdateClient.Conn.Close();
            };
        }

        private void ConstantUpdateTimer_Tick(object sender, EventArgs e)
        {
            if (!ConstantUpdateWorker.IsBusy) ConstantUpdateWorker.RunWorkerAsync();
            if (!GetContactsWorker.IsBusy) GetContactsWorker.RunWorkerAsync();
        }
// ========================================================================================================


// ========================================================================================================
        private void AttachFileButton_Click(object sender, EventArgs e)
        {
            if (_isImageAttached)
            {
                MessageTextBox.Text = string.Empty;
                MessageTextBox.Enabled = true;
                AttachFileButton.Text = "🎴";
                AttachFileButton.ForeColor = Color.FromArgb(202, 217, 238);
                _isImageAttached = false;
                _currImageName = string.Empty;
            }
            else if (!SendImageWorker.IsBusy && _currImageName == string.Empty)
            {
                BrowseImage();
            }
        }

        private void SendImageWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                FileStream fls;
                fls = new FileStream(_currImageName, FileMode.Open, FileAccess.Read);
                byte[] blob = new byte[fls.Length];
                fls.Read(blob, 0, Convert.ToInt32(fls.Length));
                fls.Close();

                _sendImageClient = new DatabaseClient();
                var cmdText = $"insert into messages (inbox_id, sender_id, receiver_id, image, send_time) values ({_currInboxId}, {_user.Id}, {_currReceiverId}, :image_blob, to_date('{DateTime.Now:MM/dd/yyyy HH:mm:ss}', 'MM/DD/YYYY HH24:MI:SS'))";
                OracleCommand cmd = new OracleCommand(cmdText, _sendImageClient.Conn);
                cmd.Parameters.Add("image_blob", OracleDbType.Blob, blob, ParameterDirection.Input);
                cmd.ExecuteNonQuery();

                cmdText = $"update inboxes set last_user_id = {_user.Id}, last_message = 'Photo', last_update = to_date('{DateTime.Now:MM/dd/yyyy HH:mm:ss}', 'MM/DD/YYYY HH24:MI:SS') where inbox_id = {_currInboxId}";
                _sendImageClient.PerformNonQueryCommand(cmdText);
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void BrowseImage()
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
                    _currImageName = fldlg.FileName;
                    MessageTextBox.Text = "🎴 " + _currImageName;
                    MessageTextBox.Enabled = false;
                    AttachFileButton.Text = "❌";
                    AttachFileButton.ForeColor = Color.FromArgb(25, 192, 255);
                    _isImageAttached = true;
                }

                fldlg = null;
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Error browsing image!");
            }
        }

        private void SendImageWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _currImageName = string.Empty;

            if (!e.Cancelled)
            {
                if (!GetMessagesWorker.IsBusy) GetMessagesWorker.RunWorkerAsync();
            }

            MessageTextBox.Enabled = true;
            MessageTextBox.Text = string.Empty;
        }
// ==============================================================================================================


        // ====================================================================================== //
        //                                                                                        //
        //                                        UI METHODS                                      //
        //                                                                                        //
        // ====================================================================================== //

        private void AttachFileButton_MouseHover(object sender, EventArgs e)
        {
            AttachFileButton.ForeColor = Color.FromArgb(25, 192, 255);
        }

        private void AttachFileButton_MouseLeave(object sender, EventArgs e)
        {
            AttachFileButton.ForeColor = Color.FromArgb(202, 217, 238);
        }

        private void SearchChatTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchPeople();
        }

        private void SearchPeople()
        {
            foreach (ChatHead chatHead in ChatHeadFlowLayoutPanel.Controls)
            {
                if (!chatHead.ContactName.ToLower().Contains(SearchPeopleTextBox.Text.ToLower()))
                {
                    chatHead.Visible = false;
                }
                else
                {
                    chatHead.Visible = true;
                }
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (MessageTextBox.Enabled)
            {
                if (!SendMessageWorker.IsBusy)
                {
                    SendMessageWorker.RunWorkerAsync();
                }
            }
            else if (!string.IsNullOrEmpty(_currImageName))
            {
                AttachFileButton.Text = "🎴";
                SendImageWorker.RunWorkerAsync();
            }
        }

        private void MessageTextBox_TextChanged(object sender, EventArgs e)
        {
            var lastSize = MessageTextBox.Size.Height;
            HiddenLabel.Text = MessageTextBox.Text;
            MessageTextBox.Size = new Size(HiddenLabel.Size.Width, HiddenLabel.Size.Height+6);
            var heightDiff = MessageTextBox.Size.Height - lastSize;

            MessageTextBox.Location = new Point(MessageTextBox.Location.X, MessageTextBox.Location.Y - heightDiff);
            ChatMessagesFlowLayoutPanel.Size = new Size(ChatMessagesFlowLayoutPanel.Size.Width, ChatMessagesFlowLayoutPanel.Size.Height - heightDiff);
        }

        private void RetryMessageButton_Click(object sender, EventArgs e)
        {
            MessageError.Visible = false;
            MessageLoader.Visible = true;

            if (!GetMessagesWorker.IsBusy) GetMessagesWorker.RunWorkerAsync();  
        }

        private void ChatContainer_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void NoMessageSelectedPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MessageLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
