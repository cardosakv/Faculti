using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faculti.DataClasses;
using Faculti.Services.FacultiDB;
using Faculti.UI.Cards;
using Oracle.ManagedDataAccess.Client;
using Bunifu.UI.WinForms;
using System.Reflection;
using System.Drawing.Drawing2D;
using Faculti.Helpers;

namespace Faculti.UI.Cards
{
    public partial class FeedPanel : UserControl
    {
        private readonly User _user;
        private readonly List<int> postIds = new List<int>();
        private DatabaseClient _displayPostClient;
        private DatabaseClient _displayAnnounceClient;
        private DatabaseClient _insertPostClient;
        private OracleDataReader _displayPostRdr;
        private OracleDataReader _announceRdr;
        private bool _firstTime = true;
        private bool _isTimedOut = false;
        private int _retries = 0;

        public FeedPanel(User user)
        {
            _user = user;
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(PostButton);
            ControlInteractives.SetDoubleBuffered(FeedLayoutPanel);
            PostPictureBox.Image = _user.Picture;
            FeedLoader.BringToFront();
            
            UpdateData();
        }

        public void UpdateData()
        {
            if (!DisplayPostWorker.IsBusy) DisplayPostWorker.RunWorkerAsync();
            if (!AnnounceWorker.IsBusy) AnnounceWorker.RunWorkerAsync();
        }

        public void ChangePicture(Image picture)
        {
            PostPictureBox.Image = picture;
        }

        private void DisplayPostWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _displayPostClient = new DatabaseClient();
                string cmdText = $"select post_id from posts where section_name = '{_user.SectionName}' order by post_time asc";
                OracleCommand cmd = new OracleCommand(cmdText, _displayPostClient.Conn);
                _displayPostRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void DisplayPostWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                if (_retries >= 30)
                {
                    FeedLoader.Visible = false;
                    FeedError.Visible = true;
                    FeedLayoutPanel.AutoScroll = false;
                    _isTimedOut = true;
                }
                else
                {
                    _retries++;
                    DisplayPostWorker.RunWorkerAsync();
                }
            }
            else
            {
                DisplayPosts();
                _retries = 0;
                _isTimedOut = false;
                FeedLoader.Visible = false;
                FeedError.Visible = false;
                FeedLayoutPanel.AutoScroll = true;
            }
        }

        public void DisplayPosts()
        {
            while (_displayPostRdr.Read())
            {
                var currPostId = _displayPostRdr.GetInt32(0);

                if (_firstTime)
                {
                    PostCard post = new PostCard(currPostId, _user);

                    FeedLayoutPanel.SuspendLayout();
                    FeedLayoutPanel.Controls.Add(post);
                    FeedLayoutPanel.Controls.SetChildIndex(post, 3);
                    FeedLayoutPanel.ResumeLayout();

                    postIds.Add(currPostId);
                    _firstTime = false;
                }
                else if (currPostId > postIds[postIds.Count - 1])
                {
                    PostCard post = new PostCard(currPostId, _user);

                    FeedLayoutPanel.SuspendLayout();
                    FeedLayoutPanel.Controls.Add(post);
                    FeedLayoutPanel.Controls.SetChildIndex(post, 3);
                    FeedLayoutPanel.ResumeLayout();

                    postIds.Add(currPostId);
                }
            }

            _displayPostClient.Close();
        }

        private void AnnounceWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //try
            //{
                _displayAnnounceClient = new DatabaseClient();
                var cmdText = $"select title, text, post_time from announces order by post_time desc";
                OracleCommand cmd = new OracleCommand(cmdText, _displayAnnounceClient.Conn);
                _announceRdr = cmd.ExecuteReader();
            //}
            //catch (Exception)
            //{
            //    e.Cancel = true;
            //}
        }

        private void AnnounceWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                DisplayAnnounces();
            }
        }

        public void DisplayAnnounces()
        {
            while (_announceRdr.Read())
            {
                Announcement announce = new Announcement(_announceRdr.GetString(0), _announceRdr.GetString(1), _announceRdr.GetOracleDate(2).Value);
                AnnouncementsFlowLayoutPanel.Controls.Add(announce);
            }

            _displayAnnounceClient.Close();
        }

        private void InsertPostWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _insertPostClient = new DatabaseClient();
                var cmdText = $"insert into posts (text, user_id, post_time, section_name) values (q'[{WritePostTextBox.Text}]', {_user.Id}, to_date('{DateTime.Now:MM/dd/yyyy HH:mm:ss}', 'MM/DD/YYYY HH24:MI:SS'), '{_user.SectionName}')";
                OracleCommand cmd = new OracleCommand(cmdText, _insertPostClient.Conn);
                cmd.ExecuteNonQuery();

                string postString = string.Empty;
                if (_user.Type == "teachers")
                {
                    postString = "The teacher posted something in the feed channel.";
                }
                else
                {
                    postString = $"{_user.FirstName} {_user.LastName} posted something in the feed channel.";
                }

                cmdText = $"insert into updates (update_type, text, created_time, sender_id, sender_user_type) values ('feed', '{postString}', to_date('{DateTime.Now:MM/dd/yyyy HH:mm:ss}', 'MM/DD/YYYY HH24:MI:SS'), {_user.Id}, '{_user.Type}')";
                cmd = new OracleCommand(cmdText, _insertPostClient.Conn);
                cmd.ExecuteNonQuery();
                _insertPostClient.Close();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void InsertPostWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                WritePostTextBox.Text = string.Empty;
                if (!DisplayPostWorker.IsBusy) DisplayPostWorker.RunWorkerAsync();
            }
        }

        




        // ====================================================================================== //
        //                                                                                        //
        //                                        UI METHODS                                      //
        //                                                                                        //
        // ====================================================================================== //
        private void PostButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(WritePostTextBox.Text))
            {
                if (!InsertPostWorker.IsBusy) InsertPostWorker.RunWorkerAsync();
            }
        }

        private void RetryFeedButton_Click(object sender, EventArgs e)
        {
            FeedLoader.Visible = true;
            FeedError.Visible = false;

            _displayPostClient.Conn.Close();
            if (!DisplayPostWorker.IsBusy) DisplayPostWorker.RunWorkerAsync();
        }

        private void AnnounceTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control announe in AnnouncementsFlowLayoutPanel.Controls)
            {
                AnnouncementsFlowLayoutPanel.Controls.Remove(announe);
            }

            if (!AnnounceWorker.IsBusy) AnnounceWorker.RunWorkerAsync();
        }

        private void NewPostUpdateTimer_Tick(object sender, EventArgs e)
        {
            if (!DisplayPostWorker.IsBusy && !_isTimedOut) DisplayPostWorker.RunWorkerAsync();
        }
    }
}
