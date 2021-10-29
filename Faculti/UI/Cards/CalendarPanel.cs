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
using Faculti.DataClasses;
using Faculti.Helpers;
using Faculti.Services.FacultiDB;
using Oracle.ManagedDataAccess.Client;
using Faculti.UI.Forms;

namespace Faculti.UI.Cards
{
    public partial class CalendarPanel : UserControl
    {
        private readonly User _user;
        private DateTime _date = DateTime.Now;
        private DateTime _dateToAddMark;
        private BunifuPanel _lastSelectedDayPanel;
        private readonly Color _accentColor = Color.FromArgb(25, 192, 255);
        private readonly Color _panelDefaultColor = Color.FromArgb(243, 246, 250);
        private readonly Color _labelDefaultColor = Color.FromArgb(162, 177, 198);
        private readonly Color _fillerDefaultColor = Color.FromArgb(220, 231, 245);

        private DatabaseClient _holidayClient;
        private DatabaseClient _localClient;
        private DatabaseClient _examClient;
        private DatabaseClient _assClient;
        private OracleDataReader _holidayRdr;
        private OracleDataReader _localRdr;
        private OracleDataReader _examRdr;
        private OracleDataReader _assRdr;

        private bool _isLoadingDate = true;

        public CalendarPanel(User user)
        {
            _user = user;
            InitializeComponent();
            ControlInteractives.SetButtonHoverEvent(AddEventButton);
            AddDates(_date);

            if (user.Type == "parents")
            {
                AddEventButton.Visible = false;
            }
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            DialogBGForm bgForm = new DialogBGForm();
            using (AddEventForm addEvent = new AddEventForm(_user))
            {
                bgForm.Show();
                addEvent.Owner = bgForm;
                addEvent.ShowDialog();
            }
            bgForm.Dispose();
        }

        private void HolidayWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _holidayClient = new DatabaseClient();
                var cmdText = $"select event_title from calendar where is_holiday = 'Y' and event_date = to_date('{_date:MM/dd/yyyy}', 'MM/DD/YYYY')";
                OracleCommand cmd = new OracleCommand(cmdText, _holidayClient.Conn);
                _holidayRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void HolidayWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                _holidayClient.Conn.Close();
                HolidayWorker.RunWorkerAsync();
            }
            else
            {
                while (_holidayRdr.Read())
                { 
                    EventCard holiday = new EventCard(_holidayRdr.GetString(0), "Holiday");
                    EventsFlowLayoutPanel.Controls.Add(holiday);
                }

                _holidayClient.Conn.Close();

                if (!LocalWorker.IsBusy) LocalWorker.RunWorkerAsync();
            }
        }

        private void LocalWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _localClient = new DatabaseClient();
                var cmdText = $"select event_title from calendar where is_local = 'Y' and event_date = to_date('{_date:MM/dd/yyyy}', 'MM/DD/YYYY')";
                OracleCommand cmd = new OracleCommand(cmdText, _localClient.Conn);
                _localRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void LocalWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                _localClient.Conn.Close();
                LocalWorker.RunWorkerAsync();
            }
            else
            {
                while (_localRdr.Read())
                {
                    EventCard local = new EventCard(_localRdr.GetString(0), "School");
                    EventsFlowLayoutPanel.Controls.Add(local);
                }

                _localClient.Conn.Close();

                if (!ExamWorker.IsBusy) ExamWorker.RunWorkerAsync();
            }
        }

        private void ExamWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _examClient = new DatabaseClient();
                var cmdText = $"select event_title, event_desc from calendar where is_exam = 'Y' and event_date = to_date('{_date:MM/dd/yyyy}', 'MM/DD/YYYY') and section_name = '{_user.SectionName}'";
                OracleCommand cmd = new OracleCommand(cmdText, _examClient.Conn);
                _examRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void ExamWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                _examClient.Conn.Close();
                ExamWorker.RunWorkerAsync();
            }
            else
            {
                while (_examRdr.Read())
                {
                    EventCard exam = new EventCard(_examRdr.GetString(0), _examRdr.GetString(1), "Exam");
                    EventsFlowLayoutPanel.Controls.Add(exam);
                }

                _examClient.Conn.Close();
                if (!AssWorker.IsBusy) AssWorker.RunWorkerAsync();
            }
        }

        private void AssWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _assClient = new DatabaseClient();
                var cmdText = $"select event_title, event_desc from calendar where is_ass = 'Y' and event_date = to_date('{_date:MM/dd/yyyy}', 'MM/DD/YYYY') and section_name = '{_user.SectionName}'";
                OracleCommand cmd = new OracleCommand(cmdText, _assClient.Conn);
                _assRdr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
        }

        private void AssWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                _assClient.Conn.Close();
                AssWorker.RunWorkerAsync();
            }
            else
            {
                while (_assRdr.Read())
                {
                    EventCard ass = new EventCard(_assRdr.GetString(0), _assRdr.GetString(1), "Assignment");
                    EventsFlowLayoutPanel.Controls.Add(ass);
                }

                _assClient.Conn.Close();
            }
        }

        private void AddHolidayMark(BunifuPanel dayPanel)
        {
            BunifuLabel holidayMark = new BunifuLabel
            {
                Text = "❌",
                Font = new Font("Circular Spotify Tx T Bold", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 192, 255),
                Location = new Point(21, 43),
                AutoSize = true
            };
            dayPanel.Controls.Add(holidayMark);
            holidayMark.BringToFront();
        }

        private void AddExamMark(BunifuPanel dayPanel)
        {
            BunifuLabel examMark = new BunifuLabel
            {
                Text = "E",
                Font = new Font("Circular Spotify Tx T Bold", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 192, 255),
                Location = new Point(19, 45),
                AutoSize = true
            };
            dayPanel.Controls.Add(examMark);
            examMark.BringToFront();
        }

        private void AddAssignmentMark(BunifuPanel dayPanel)
        {
            BunifuLabel assignMark = new BunifuLabel
            {
                Text = "A",
                Font = new Font("Circular Spotify Tx T Bold", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 192, 255),
                Location = new Point(36, 45),
                AutoSize = true
            };
            dayPanel.Controls.Add(assignMark);
            assignMark.BringToFront();
        }

        // =====================================================================================================

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
            _dateToAddMark = date;
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

            //_isLoadingDate = false;
        }

        private void AddDay(DateTime date, bool isFillerDay, int row, int col)
        {
            BunifuPanel dayPanel = (BunifuPanel)CalendarLayoutPanel.GetControlFromPosition(col, row);

            foreach (BunifuLabel mark in dayPanel.Controls.OfType<BunifuLabel>())
            {
                dayPanel.Controls.Remove(mark);
            }

            foreach (BunifuLabel mark in dayPanel.Controls.OfType<BunifuLabel>())
            {
                dayPanel.Controls.Remove(mark);
            }

            foreach (Label dayLabel in dayPanel.Controls.OfType<Label>())
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
                    bool isHoliday = false, isExam = false, isAssign = false;
                    BackgroundWorker worker = new BackgroundWorker();
                    worker.DoWork += (s, o) =>
                    {
                        try
                        {
                            DatabaseClient client = new DatabaseClient();
                            var cmdText = $"select * from calendar where is_holiday = 'Y' and event_date = to_date('{date:MM/dd/yyyy}', 'MM/DD/YYYY')";
                            OracleCommand cmd = new OracleCommand(cmdText, client.Conn);
                            OracleDataReader rdr = cmd.ExecuteReader();
                            if (rdr.Read()) isHoliday = true;

                            cmdText = $"select * from calendar where is_exam = 'Y' and event_date = to_date('{date:MM/dd/yyyy}', 'MM/DD/YYYY')";
                            cmd = new OracleCommand(cmdText, client.Conn);
                            rdr = cmd.ExecuteReader();
                            if (rdr.Read()) isExam = true;

                            cmdText = $"select * from calendar where is_ass = 'Y' and event_date = to_date('{date:MM/dd/yyyy}', 'MM/DD/YYYY')";
                            cmd = new OracleCommand(cmdText, client.Conn);
                            rdr = cmd.ExecuteReader();
                            if (rdr.Read()) isAssign = true;

                            client.Conn.Close();
                        }
                        catch (Exception)
                        {
                            o.Cancel = true;
                        }
                    };

                    worker.RunWorkerCompleted += (s, o) =>
                    {
                        if (o.Cancelled)
                        {
                            worker.RunWorkerAsync();
                        }
                        else
                        {
                            if (isExam) AddExamMark(dayPanel);
                            if (isAssign) AddAssignmentMark(dayPanel);
                            if (isHoliday) AddHolidayMark(dayPanel);
                        }
                    };

                    worker.RunWorkerAsync();

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

            EventsFlowLayoutPanel.Controls.Clear();
            if (!HolidayWorker.IsBusy) HolidayWorker.RunWorkerAsync();
        }

        private void DayLabel_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            BunifuPanel dayPanel = (BunifuPanel)label.Parent;    
            SetUIAsSelected(dayPanel);

            EventsFlowLayoutPanel.Controls.Clear();
            if (!HolidayWorker.IsBusy) HolidayWorker.RunWorkerAsync();
        }

        private void SetUIAsSelected(BunifuPanel dayPanel)
        {
            if (!IsSelected(dayPanel))
            {
                if (IsTodayPanel(dayPanel))
                {
                    SetUIAsNotSelected(_lastSelectedDayPanel);
                    WeekAndDayLabel.Text = DateTime.Now.ToString("dddd dd");
                }
                else
                {
                    SetUIAsNotSelected(_lastSelectedDayPanel);
                    _lastSelectedDayPanel = dayPanel;
                    dayPanel.BorderColor = _accentColor;
                    dayPanel.BackgroundColor = Color.White;

                    foreach (Label dayLabel in dayPanel.Controls.OfType<Label>())
                    {
                        dayLabel.ForeColor = _accentColor;
                        _date = new DateTime(_date.Year, _date.Month, Convert.ToInt32(dayLabel.Text));
                        WeekAndDayLabel.Text = _date.ToString("dddd dd");
                    }
                }
            }
        }

        private void SetUIAsNotSelected(BunifuPanel dayPanel)
        {
            if (dayPanel == null) return;

            dayPanel.BorderColor = _panelDefaultColor;
            dayPanel.BackgroundColor = _panelDefaultColor;

            foreach (Label dayLabel in dayPanel.Controls.OfType<Label>())
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



        #region Samok
        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
