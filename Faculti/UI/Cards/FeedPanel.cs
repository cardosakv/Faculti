using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faculti.UI.Cards;

namespace Faculti.UI.Cards
{
    public partial class FeedPanel : UserControl
    {
        AnnouncementPanel announcement = new AnnouncementPanel("Re: Scholarship for Freshman", 
            "The office of the dean will be accepting scholarship application from October 30 " +
            "to November 30 from 9:00 AM to 4:00 PM.");
        AnnouncementPanel announcement2 = new AnnouncementPanel("No Classes Today",
            "There will be no classes because of the incoming supertyphoon Yolanda. " +
            "Everyone is advised to evacuate to a safe relocation site.\n\nThank you and stay safe everyone.");
        PostCard post = new PostCard("34343", "The office of the dean will be accepting scholarship application from October 30 to November 30. Please look at your extensions on chrome.\nOkay? Hai? hai?", "dfdfd");
        PostCard post2 = new PostCard("34343", "Kinsay naay papel ninyo diha. Wa gyud ko kadala guys. Please ko bi.", "dfdfd");
        PostCard post3 = new PostCard("34343", "Hoy attention to the following students! Ngano man mo ing-ani man mo?\n\n1. Cardosa\n2. Mabia\n3. Alasagas\n\nI want you to come to my office right now! Grabe na kaayo ning inyong gipangbuhat ha. Wa mo mauwaw, nanguha mos akong mangga sa table? Para inyo diay to? Gidugo baya jud ko, bantay lang mo nako unya.", "dfdfd");
        CommentCard comment = new CommentCard();
        
        public FeedPanel()
        {
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(PostButton);

            AnnouncementsFlowLayoutPanel.Controls.Add(announcement);
            AnnouncementsFlowLayoutPanel.Controls.Add(announcement2);
            FeedLayoutPanel.Controls.Add(post);
            FeedLayoutPanel.Controls.Add(post2);
            FeedLayoutPanel.Controls.Add(post3);
            FeedLayoutPanel.Controls.Add
        }

        private void AddComment(FlowLayoutPanel feedPanel, Control postCardIndex, Control commentCard)
        {

            int index = feedPanel.Controls.IndexOf(postCardIndex);

            if (index == -1) return;

            fl.Controls.Remove(Control2Replace);

            foreach (Control c in Controls2Add)
            {

                fl.Controls.Add(c);

                fl.SetChildIndex(c, index++);

            }

        }
    }
}
