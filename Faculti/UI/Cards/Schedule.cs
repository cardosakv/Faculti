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
    public partial class Schedule : UserControl
    {
        private readonly DateTime _subTime;

        public Schedule(string subName, DateTime subTime)
        {
            InitializeComponent();
            Subject_Label.Text = subName;   
            Time_Label.Text = subTime.ToString("hh:mm tt");
            _subTime = subTime;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var temp = _subTime;

            if (DateTime.Now.Hour >= temp.Hour && DateTime.Now.Hour < temp.AddHours(1).Hour)
            {
                SchedulePanel.BorderColor = Color.FromArgb(25, 192, 255);
                SchedulePanel.BackgroundColor = Color.White;
                Subject_Label.ForeColor = Color.FromArgb(25, 192, 255);
                Time_Label.ForeColor = Color.FromArgb(25, 192, 255);
            }
            else
            {
                SchedulePanel.BorderColor = Color.FromArgb(220, 231, 245);
                SchedulePanel.BackgroundColor = Color.Transparent;
                Subject_Label.ForeColor = Color.FromArgb(75, 109, 124);
                Time_Label.ForeColor = Color.FromArgb(75, 109, 124);
            }
        }
    }
}
