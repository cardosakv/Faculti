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
    public partial class MyImageMessage : UserControl
    {
        public string Timestamp;
        private Image _image;

        public MyImageMessage(Image image, DateTime time)
        {
            InitializeComponent();
            _image = image;
            Timestamp = $"{time.Hour}:{time.Minute}";

            ImageMessagePictureBox.BorderRadius = 10;
            ImageMessagePictureBox.Image = image;
            this.Height = 5 + (370 * image.Height) / image.Width;
            ImageMessagePictureBox.BorderRadius = 10;

            TimeLabel.Text = time.ToString("hh:mm tt");
        }

        public void RemoveTime()
        {
            TimeLabel.Visible = false;
            ImageMessagePictureBox.Height = this.Height;
            this.Height = (370 * _image.Height) / _image.Width;
            this.Margin = new Padding(0, 30, 0, 6);
        }


        private void ImageMessagePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void MyImageMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
