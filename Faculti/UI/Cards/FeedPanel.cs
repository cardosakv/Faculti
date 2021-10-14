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
        Announcement announcement = new Announcement("Re: Scholarship for Freshman", 
            "The office of the dean will be accepting scholarship application from October 30 " +
            "to November 30 from 9:00 AM to 4:00 PM.");
        Announcement announcement2 = new Announcement("No Classes Today",
            "There will be no classes because of the incoming supertyphoon Yolanda. " +
            "Everyone is advised to evacuate to a safe relocation site.\n\nThank you and stay safe everyone.");
        PostCard post = new PostCard("34343", "The office of the dean will be accepting scholarship application from October 30 to November 30. Please look at your extensions on chrome.\nOkay? Hai? hai?", "dfdfd");
        PostCard post2 = new PostCard("34343", "Kinsay naay papel ninyo diha. Wa gyud ko kadala guys. Please ko bi.", "dfdfd");
        PostCard post3 = new PostCard("34343", "Hoy attention to the following students! Ngano man mo ing-ani man mo?\n\n1. Cardosa\n2. Mabia\n3. Alasagas\n\nI want you to come to my office right now! Grabe na kaayo ning inyong gipangbuhat ha. Wa mo mauwaw, nanguha mos akong mangga sa table? Para inyo diay to? Gidugo baya jud ko, bantay lang mo nako unya.", "dfdfd");

        public FeedPanel()
        {
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(PostButton);

            AnnouncementsFlowLayoutPanel.Controls.Add(announcement);
            AnnouncementsFlowLayoutPanel.Controls.Add(announcement2);
            FeedLayoutPanel.Controls.Add(post);
            FeedLayoutPanel.Controls.Add(post2);
            FeedLayoutPanel.Controls.Add(post3);
            post.AddComment("Please lang grabe naman mo oy");
            post.AddComment(" HAHAHAHHA boang");
            post.AddComment("Yes maam naa ta ana sa school pwede ra gyud kana atong gamiton\nmao man sad ako nahibaw-an");
            post.AddComment("Okay ra ka ato maam?");
            post.AddComment("oo okay ra\ncgecge miss update lang sa mga panghitabo diha");
            post.AddComment("cgecge kato lang ato gamiton");
            post2.AddComment("amawa boang o");
            post2.AddComment("hahahhhahahah shhhh\n\nBhala na");
        }
    }
}
