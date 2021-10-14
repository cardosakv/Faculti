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
            TeacherMessage op = new TeacherMessage("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.");
            MyMessage a = new MyMessage("Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
            ChatMessagesFlowLayoutPanel.Controls.Add(op);
            ChatMessagesFlowLayoutPanel.Controls.Add(a);
        }
    }
}
