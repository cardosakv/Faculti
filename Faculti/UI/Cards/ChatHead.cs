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
    public partial class ChatHead : UserControl
    {
        public ChatHead()
        {
            InitializeComponent();
        }

        private void ChatHead_MouseHover(object sender, EventArgs e)
        {
            ChatNameLabel.Font = new Font("Circular Spotify Tx T Bold", 10F, FontStyle.Bold);
            ChatPanel.BackgroundColor = Color.White;
            Cursor = Cursors.Hand;
        }

        private void ChatHead_MouseLeave(object sender, EventArgs e)
        {
            ChatNameLabel.Font = new Font("Gotham", 9.75F, FontStyle.Regular);
            ChatPanel.BackgroundColor = Color.FromArgb(243, 246, 250);
            Cursor = Cursors.Default;
        }
    }
}
