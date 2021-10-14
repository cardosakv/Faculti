using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Faculti.Helpers;

namespace Faculti.UI.Cards
{
    public partial class CalendarPanel : UserControl
    {
        private DateTime _date = DateTime.Now;
        private BunifuPanel _lastSelectedDayPanel;
        private Color _accentColor = Color.FromArgb(25, 192, 255);
        private Color _panelDefaultColor = Color.FromArgb(243, 246, 250);
        private Color _labelDefaultColor = Color.FromArgb(162, 177, 198);
        private Color _fillerDefaultColor = Color.FromArgb(220, 231, 245);

        public CalendarPanel()
        {
            InitializeComponent();
            AddDates(_date);
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            _date = _date.AddMonths(-1);
            AddDates(_date);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            _date = _date.AddMonths(+1);
            AddDates(_date);
        }

        private void AddDates(DateTime date)
        {
            MonthYear.Text = (date.ToString("MMMM") + " " + date.ToString("yyyy"));

            var year = date.Year;
            var month = date.Month;
            var monthNext = date.AddMonths(+1).Month;
            var daysInMonth = DateTime.DaysInMonth(year, month);

            var firstDateOfMonth = new DateTime(year, month, 1);
            var firstDayWeekOfMonth = (int)firstDateOfMonth.DayOfWeek;

            var row = 0;
            var col = 0;

            for (int day = firstDayWeekOfMonth; day > 0; day--)
            {
                AddDay(firstDateOfMonth.AddDays(-day), true, row, col++);
                if (col > 6)
                {
                    col = 0;
                    row++;
                }
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                AddDay(new DateTime(year, month, day), false, row, col++);
                if (col > 6)
                {
                    col = 0;
                    row++;
                }
            }

            int nextDay = 1;
            do
            {
                AddDay(new DateTime(year, monthNext, nextDay++), true, row, col++);
                if (col > 6)
                {
                    col = 0;
                    row++;
                }
            } while (row <= 5 && col <= 6);
        }

        private void AddDay(DateTime date, bool isFillerDay, int row, int col)
        {
            BunifuPanel dayPanel = (BunifuPanel)CalendarLayoutPanel.GetControlFromPosition(col, row);

            foreach (Label dayLabel in dayPanel.Controls)
            {
                dayLabel.Text = date.Day.ToString();

                if (isFillerDay)
                {
                    dayLabel.Cursor = Cursors.Default;
                    dayPanel.Cursor = Cursors.Default;
                    dayLabel.ForeColor = _fillerDefaultColor;
                    dayPanel.BorderColor = _panelDefaultColor;
                    dayPanel.BackgroundColor = _panelDefaultColor;
                    UIEventHandler.RemoveClickEvent(dayLabel);
                    UIEventHandler.RemoveClickEvent(dayPanel);
                    _lastSelectedDayPanel = null;
                    break;
                }
                else if (date.Day == DateTime.Now.Day &&
                         date.Month == DateTime.Now.Month &&
                         date.Year == DateTime.Now.Year)
                {
                    dayLabel.Cursor = Cursors.Hand;
                    dayPanel.Cursor = Cursors.Hand;
                    dayLabel.ForeColor = Color.White;
                    dayPanel.BorderColor = _accentColor;
                    dayPanel.BackgroundColor = _accentColor;
 
                    break;
                }
                else if (!isFillerDay)
                {
                    dayLabel.Cursor = Cursors.Hand;
                    dayPanel.Cursor = Cursors.Hand;
                    dayLabel.ForeColor = _labelDefaultColor;
                    dayPanel.BorderColor = _panelDefaultColor;
                    dayPanel.BackgroundColor = _panelDefaultColor;
                    dayPanel.Click += DayPanel_Click;
                    dayLabel.Click += DayLabel_Click;
                    break;
                }
            }
        }

        private void DayPanel_Click(object sender, EventArgs e)
        {
            BunifuPanel dayPanel = sender as BunifuPanel;
            SetUIAsSelected(dayPanel);
        }

        private void DayLabel_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            BunifuPanel dayPanel = (BunifuPanel)label.Parent;    
            SetUIAsSelected(dayPanel);   
        }

        private void SetUIAsSelected(BunifuPanel dayPanel)
        {
            if (!IsSelected(dayPanel))
            {
                if (IsTodayPanel(dayPanel))
                {
                    SetUIAsNotSelected(_lastSelectedDayPanel);
                }
                else
                {
                    SetUIAsNotSelected(_lastSelectedDayPanel);
                    _lastSelectedDayPanel = dayPanel;
                    dayPanel.BorderColor = _accentColor;
                    dayPanel.BackgroundColor = Color.White;

                    foreach (Label dayLabel in dayPanel.Controls)
                        dayLabel.ForeColor = _accentColor;
                }
            }
        }

        private void SetUIAsNotSelected(BunifuPanel dayPanel)
        {
            if (dayPanel == null) return;

            dayPanel.BorderColor = _panelDefaultColor;
            dayPanel.BackgroundColor = _panelDefaultColor;

            foreach (Label dayLabel in dayPanel.Controls)
                dayLabel.ForeColor = _labelDefaultColor;
        }

        private bool IsSelected(BunifuPanel dayPanel)
        {
            if (dayPanel.BorderColor == _accentColor &&
                dayPanel.BackgroundColor == Color.White)
                return true;

            return false;
        }

        private bool IsTodayPanel(BunifuPanel dayPanel)
        {
            if (dayPanel.BorderColor == _accentColor &&
                dayPanel.BackgroundColor == _accentColor)
                return true;

            return false;
        }
    }
}
