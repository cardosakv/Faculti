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
namespace Faculti.UI.Cards
{
    public partial class ChatPanel : UserControl
    {
        public ChatPanel()
        {
            InitializeComponent();
            ChatHead c = new ChatHead();
            ChatHeadFlowLayoutPanel.Controls.Add(c);
            TeacherMessage op = new TeacherMessage();
            MyMessage a = new MyMessage();
            ChatMessagesFlowLayoutPanel.Controls.Add(op);
            ChatMessagesFlowLayoutPanel.Controls.Add(a);
        }
    }
}
