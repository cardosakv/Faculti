using Faculti.Services.FacultiDB;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Faculti.DataClasses;
using System.IO;

namespace Faculti.UI.Cards
{
    public partial class PostCard : UserControl
    {
        private readonly User _user;
        public int PostId;
        private Image _postImage = Faculti.Properties.Resources.default_profile;
        private int _authorId;
        private string _firstName;
        private string _lastName;   
        private string _postBody;
        private string _dateTime;
        private int _likeNum;
        private bool _likeClicked = false;
        private readonly List<string> commentIds = new List<string>();
        private DatabaseClient _commentClient;
        private OracleDataReader _commentRdr;
        private bool _firstTime = true;
        private string _picName;

        public PostCard(int postId, User user)
        {
            InitializeComponent();

            PostId = postId;
            _user = user;

            UpdateData();
        }

        public void UpdateData()
        {
            if (!PostInfoWorker.IsBusy) PostInfoWorker.RunWorkerAsync();
        }

        private void PostInfoWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DatabaseClient client = new DatabaseClient();
                var cmdText = $"select text, post_time, user_id, like_count from posts where post_id = {PostId}";
                OracleCommand cmd = new OracleCommand(cmdText, client.Conn);
                OracleDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                _postBody = rdr.GetString(0);
                _dateTime = rdr.GetOracleDate(1).Value.ToString("MMM dd • hh:mm tt");
                _authorId = rdr.GetInt32(2);
                _likeNum = Convert.ToInt32(rdr.GetString(3));

                cmdText = $"select first_name, last_name from all_users where user_id = {_authorId}";
                cmd = new OracleCommand(cmdText, client.Conn);
                rdr = cmd.ExecuteReader();
                rdr.Read();

                _firstName = rdr.GetString(0);
                _lastName = rdr.GetString(1);
                
                cmdText = $"select picture, pic_name from all_users where user_id = {_authorId}";
                cmd = new OracleCommand(cmdText, client.Conn);
                rdr = cmd.ExecuteReader();
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
                            _postImage = pic;
                        }

                        _picName = picName;
                    }
                }

                client.Close();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void PostInfoWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                DisplayPostInfo();
                if (!GetCommentsWorker.IsBusy) GetCommentsWorker.RunWorkerAsync();
            }
        }

        public void DisplayPostInfo()
        {
            PostPictureBox.Image = _postImage;
            PosterNameLabel.Text = $"{_firstName} {_lastName}";
            PostDateTimeLabel.Text = _dateTime;
            PostBodyLabel.Text = _postBody;
            LikeCountLabel.Text = _likeNum.ToString();
            PostPanel.Height = PostBodyLabel.Height + 140;

            if (Convert.ToInt32(_authorId) > 5000)
            {
                IsTeacherLabel.Visible = true;
                IsTeacherLabel.Enabled = false;
            }
        }

        private void CommentWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _commentClient = new DatabaseClient();
                var cmdText = $"select comment_id from comments where post_id = '{PostId}' order by post_time asc";
                OracleCommand cmd = new OracleCommand(cmdText, _commentClient.Conn);
                _commentRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void CommentWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                DisplayComments();
            }
        }

        public void DisplayComments()
        {
            while (_commentRdr.Read())
            {
                var currCommentId = _commentRdr.GetString(0);

                if (_firstTime)
                {
                    CommentCard comment = new CommentCard(currCommentId);
                    comment.Location = new Point(0, this.Height - 2);
                    this.Controls.Add(comment);
                    commentIds.Add(currCommentId);
                    _firstTime = false;
                }
                else if (Convert.ToInt32(currCommentId) > Convert.ToInt32(commentIds[commentIds.Count - 1]))
                {
                    CommentCard comment = new CommentCard(currCommentId);
                    comment.Location = new Point(0, this.Height);
                    this.Controls.Add(comment);
                    commentIds.Add(currCommentId);
                }
            }

            _commentClient.Close();
        }

        private void PostCommentWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DatabaseClient client = new DatabaseClient();
                var cmdText = $"insert into comments (text, post_id, user_id, post_time) values (q'[{CommentPostTextBox.Text}]', {PostId}, {_user.Id}, to_date('{DateTime.Now:MM/dd/yyyy HH:mm:ss}', 'MM/DD/YYYY HH24:MI:SS'))";
                client.PerformNonQueryCommand(cmdText);
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void PostCommentWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                CommentPostTextBox.Text = string.Empty;
                if (!GetCommentsWorker.IsBusy) GetCommentsWorker.RunWorkerAsync();
            }
        }


        // ====================================================================================== //
        //                                                                                        //
        //                                        UI METHODS                                      //
        //                                                                                        //
        // ====================================================================================== //
        private void LikeButton_Click(object sender, EventArgs e)
        {
            if (_likeClicked)
            {
                try
                {
                    DatabaseClient client = new DatabaseClient();
                    var cmdText = $"update posts set like_count = {--_likeNum} where post_id = {PostId}";
                    client.PerformNonQueryCommand(cmdText);

                    _likeClicked = false;
                    LikeButton.Image = Properties.Resources.like_inactive;
                    LikeCountLabel.Text = _likeNum.ToString();
                }
                catch (Exception)
                {
                    _likeClicked = true;
                    LikeButton.Image = Properties.Resources.like_active;
                    LikeCountLabel.Text = _likeNum.ToString();
                }
            }
            else
            {
                try
                {
                    DatabaseClient client = new DatabaseClient();
                    var cmdText = $"update posts set like_count = {++_likeNum} where post_id = {PostId}";
                    client.PerformNonQueryCommand(cmdText);

                    _likeClicked = true;
                    LikeButton.Image = Properties.Resources.like_active;
                    LikeCountLabel.Text = _likeNum.ToString();
                }
                catch (Exception)
                {
                    _likeClicked = false;
                    LikeButton.Image = Properties.Resources.like_inactive;
                    LikeCountLabel.Text = _likeNum.ToString();
                }
            }
            
        }

        private void CommentPostTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(CommentPostTextBox.Text))
            {
                if (!PostCommentWorker.IsBusy) PostCommentWorker.RunWorkerAsync();
            }
        }
  
        private void PostTimer_Tick(object sender, EventArgs e)
        {
            if (!PostInfoWorker.IsBusy) UpdateData();
        }

        private void PostPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
