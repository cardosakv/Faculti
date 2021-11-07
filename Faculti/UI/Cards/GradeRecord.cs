using Faculti.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculti.UI.Cards
{
    public partial class GradeRecord : UserControl
    {
        public string SubjectName;
        public int Grade1;
        public int Grade2;
        public int Grade3;
        public int Grade4;
        public int GradeFinal = Convert.ToInt32(null);
        public int GainFall = 0;

        public event NotifyGradeChange NotifyParentGradeChangeEvent = delegate { };

        public GradeRecord(string subject, string grade1, string grade2, string grade3, string grade4, User user)
        {
            InitializeComponent();
            SubjectName = subject;
            Grade1 = Convert.ToInt32(grade1);    
            Grade2 = Convert.ToInt32(grade2);
            Grade3 = Convert.ToInt32(grade3);
            Grade4 = Convert.ToInt32(grade4);


            Subject_Label.Text = subject;

            if (!string.IsNullOrEmpty(grade1))
            {
                Grade1_TextBox.Text = grade1;

                if (Grade1 < 75)
                { 
                    Grade1_TextBox.OnDisabledState.ForeColor = Color.FromArgb(248, 43, 96);
                }
                else
                {
                    Grade1_TextBox.OnDisabledState.ForeColor = Color.FromArgb(75, 109, 124);
                }

                Grade1_TextBox.Enabled = false;
            }
            else
            {
                Grade2_TextBox.Visible = false;
                Grade3_TextBox.Visible = false;
                Grade4_TextBox.Visible = false;
                GradeFinal_Label.Visible = false;
            }

            if (!string.IsNullOrEmpty(grade2))
            {
                Grade2_TextBox.Text = grade2;

                if (Grade2 < 75)
                {
                    Grade2_TextBox.OnDisabledState.ForeColor = Color.FromArgb(248, 43, 96);
                }
                else
                {
                    Grade2_TextBox.OnDisabledState.ForeColor = Color.FromArgb(75, 109, 124);
                }

                Grade2_TextBox.Enabled = false;
            }
            else
            {
                Grade3_TextBox.Visible = false;
                Grade4_TextBox.Visible = false;
                GradeFinal_Label.Visible = false;
            }

            if (!string.IsNullOrEmpty(grade3))
            {
                Grade3_TextBox.Text = grade3;

                if (Grade3 < 75)
                {
                    Grade3_TextBox.OnDisabledState.ForeColor = Color.FromArgb(248, 43, 96);
                }
                else
                {
                    Grade3_TextBox.OnDisabledState.ForeColor = Color.FromArgb(75, 109, 124);
                }

                Grade3_TextBox.Enabled = false;
            }
            else
            {
                Grade4_TextBox.Visible = false;
                GradeFinal_Label.Visible = false;
            }

            if (!string.IsNullOrEmpty(grade4))
            {
                Grade4_TextBox.Text = grade4;

                if (Grade4 < 75)
                {
                    Grade4_TextBox.OnDisabledState.ForeColor = Color.FromArgb(248, 43, 96);
                }
                else
                {
                    Grade4_TextBox.OnDisabledState.ForeColor = Color.FromArgb(75, 109, 124);
                }

                Grade4_TextBox.Enabled = false;

                CalculateFinal();
            }
            else
            {
                GradeFinal_Label.Visible = false;
            }

            if (user.Type == "parents")
            {
                Grade1_TextBox.Enabled = false;
                Grade2_TextBox.Enabled = false;
                Grade3_TextBox.Enabled = false;
                Grade4_TextBox.Enabled = false;
            }
        }

        public void CalculateFinal()
        {
            GradeFinal = (Grade1 + Grade2 + Grade3 + Grade4) / 4;

            GradeFinal_Label.Text = GradeFinal.ToString();

            if (GradeFinal < 75)
            {
                GradeFinal_Label.ForeColor = Color.FromArgb(248, 43, 96);
            }
            else
            {
                GradeFinal_Label.ForeColor = Color.FromArgb(75, 109, 124);
            }
        }

        private void Grade1_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Grade1_TextBox.Text) && !Regex.IsMatch(Grade1_TextBox.Text, "[^0-9]"))
            {
                Grade1 = Convert.ToInt32(Grade1_TextBox.Text);
                NotifyParentGradeChangeEvent();
            }

            if (string.IsNullOrEmpty(Grade1_TextBox.Text))
            {
                Grade1 = 0;
                NotifyParentGradeChangeEvent();
            }
        }

        private void Grade2_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Grade2_TextBox.Text) && !Regex.IsMatch(Grade2_TextBox.Text, "[^0-9]"))
            {
                Grade2 = Convert.ToInt32(Grade2_TextBox.Text);
                GainFall = Grade2 - Grade1;
                NotifyParentGradeChangeEvent();
            }

            if (string.IsNullOrEmpty(Grade2_TextBox.Text))
            {
                Grade2 = 0;
                NotifyParentGradeChangeEvent();
            }
        }

        private void Grade3_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Grade3_TextBox.Text) && !Regex.IsMatch(Grade3_TextBox.Text, "[^0-9]"))
            {
                Grade3 = Convert.ToInt32(Grade3_TextBox.Text);
                GainFall = Grade3 - Grade2;
                NotifyParentGradeChangeEvent();
            }

            if (string.IsNullOrEmpty(Grade3_TextBox.Text))
            {
                Grade3 = 0;
                NotifyParentGradeChangeEvent();
            }
        }

        private void Grade4_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Grade4_TextBox.Text) && !Regex.IsMatch(Grade4_TextBox.Text, "[^0-9]"))
            {
                Grade4 = Convert.ToInt32(Grade4_TextBox.Text);
                GainFall = Grade4 - Grade3;
                NotifyParentGradeChangeEvent();
            }

            if (string.IsNullOrEmpty(Grade4_TextBox.Text))
            {
                Grade4 = 0;
                NotifyParentGradeChangeEvent();
            }
        }
    }
}
