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
    public partial class TheirImageMessage : UserControl
    {
        public string Timestamp;
        private Image _image;

        public TheirImageMessage(Image image, DateTime time, Image picture)
        {
            InitializeComponent();
            _image = image;
            Timestamp = $"{time.Hour}:{time.Minute}";

            ImageMessagePictureBox.BorderRadius = 10;
            ImageMessagePictureBox.Image = image;
            this.Height = 10 + (370 * image.Height) / image.Width;
            ImageMessagePictureBox.BorderRadius = 10;

            TimeLabel.Text = time.ToString("hh:mm tt");

            MessagePictureBox.Image = picture;
        }

        public void RemoveImageAndTime()
        {
            TimeLabel.Visible = false;
            MessagePictureBox.Visible = false;
            ImageMessagePictureBox.Height = this.Height;
            this.Height = (370 * _image.Height) / _image.Width;
            this.Margin = new Padding(0, 30, 0, 6);
        }

        private void MessagePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
