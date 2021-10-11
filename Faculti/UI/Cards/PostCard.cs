using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculti.UI.Cards
{
    public partial class PostCard : UserControl
    {
        private string _postId;
        private string _authorId;
        private string _messageBody;
        private string _dateTime;
        private int _likeNum;
        private bool _likeClicked = false;

        public PostCard(string userId, string messageBody, string dateTime)
        {
            InitializeComponent();
            PostBodyLabel.Text = messageBody;
            PostPanel.Height = PostBodyLabel.Height + 140;
        }

        public void AddComment(string commentBody)
        {
            CommentCard comment = new CommentCard(commentBody);
            comment.Location = new Point(0, this.Height);
            this.Controls.Add(comment);
        }

        private void LikeButton_Click(object sender, EventArgs e)
        {
            if (_likeClicked)
            {
                _likeClicked = false;
                LikeButton.Image = Properties.Resources.like_inactive;
            }
            else
            {
                _likeClicked = true;
                LikeButton.Image = Properties.Resources.like_active;
            }
            
        }
    }
}
