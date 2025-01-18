using PayrollSystem.Forms;
using PayrollSystem.Forms.Modals;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PayrollSystem.UserControls
{
    public partial class CalendarDayView : UserControl
    {
        private bool _currentMonth = false;
        private string _date;
        private LogCountDto _logCount;
        private readonly MainForm _mainForm;
        private WorklogManagement _parent;
        public CalendarDayView(MainForm mainForm, WorklogManagement parent)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _parent = parent;
        }

        public static void ShowCalendarDay(MainForm mainForm, WorklogManagement parent,TableLayoutPanel viewParent, DateTime dateTime)
        {
            viewParent.Controls.Clear();
            viewParent.Visible = false;

            var startOfMonth = new DateTime(dateTime.Year, dateTime.Month, 1);
            var convertedStartOfMonth = ((int)startOfMonth.DayOfWeek + 1);
            //Console.WriteLine("Start of month" +startOfMonth);
            //Console.WriteLine("Convertion 1 " + convertedStartOfMonth);
            //Console.WriteLine("Convertion 2 " + (((int)startOfMonth.DayOfWeek + 1) % 7));


            var pastMonthDays = convertedStartOfMonth - 1;
            var calendarDays = new List<Control>();
            (DateTime currentWeekStart, DateTime currentWeekEnd) = ControlsHelper.GetCurrentWeek();


            for (int cellIndex = 1; cellIndex <= 42; cellIndex++)
            {                
                var days = startOfMonth.AddDays(-pastMonthDays);
                var calendarDay = new CalendarDayView(mainForm, parent) { Dock = DockStyle.Fill };
                calendarDay.DayLabel.Text = days.Day.ToString("d");                    

                calendarDay._date = days.Date.ToString("yyyy-MM-dd");
                _ = calendarDay.GetAttendanceLog(calendarDay._date);

                if (days.Month == dateTime.Month)
                {
                    calendarDay._currentMonth = true;
                    
                    if (days.Date == DateTime.Now.Date)
                    {
                        calendarDay.BackColor = Color.DeepSkyBlue;
                    }
                    else if (days.Date >= currentWeekStart && days.Date <= currentWeekEnd)
                    {
                        calendarDay.BackColor = Color.LightBlue;
                    }
                }
                else
                {
                    ApplyOutOfMonthStyle(calendarDay);
                    if (days.Date >= currentWeekStart && days.Date <= currentWeekEnd)
                    {
                        calendarDay.BackColor = Color.LightBlue;
                        calendarDay.DayLabel.ForeColor = Color.FromArgb(145, 145, 145);
                    }
                }

                pastMonthDays--;

                //viewParent.Controls.Add(calendarDay);
                calendarDays.Add(calendarDay);
            }
            viewParent.Controls.AddRange(calendarDays.ToArray());
            //Task.Delay(50);
            viewParent.Visible = true;
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            //guna2Panel1.FillColor = Color.DodgerBlue;
            this.BackColor = Color.DodgerBlue;
            DayLabel.ForeColor = _currentMonth? Color.White : Color.LightGray;
            PresentCount.ForeColor = _currentMonth? Color.White : Color.LightGray;
            AbsentCount.ForeColor = _currentMonth? Color.White : Color.LightGray;
            LeaveCount.ForeColor = _currentMonth? Color.White : Color.LightGray;


        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            var dateConverted = DateTime.ParseExact(_date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //guna2Panel1.FillColor = Color.White;
            DayLabel.ForeColor = _currentMonth ? Color.FromArgb(45,45,45) : Color.FromArgb(200, 200, 200);
            PresentCount.ForeColor = _currentMonth ? Color.FromArgb(45,45,45) : Color.FromArgb(200, 200, 200);
            AbsentCount.ForeColor = _currentMonth ? Color.FromArgb(45,45,45) : Color.FromArgb(200, 200, 200);
            LeaveCount.ForeColor = _currentMonth ? Color.FromArgb(45,45,45) : Color.FromArgb(200, 200, 200);
            
            (DateTime currentWeekStart, DateTime currentWeekEnd) = ControlsHelper.GetCurrentWeek();
            if (dateConverted == DateTime.Now.Date)
            {
                this.BackColor = Color.DeepSkyBlue;
            }
            else if (dateConverted.Date >= currentWeekStart && dateConverted.Date <= currentWeekEnd)
            {
                this.BackColor = Color.LightBlue;
                DayLabel.ForeColor = _currentMonth ? Color.FromArgb(45, 45, 45) : Color.FromArgb(145, 145, 145);
            }
            else this.BackColor = Color.White;

        }

        private void Control_Click(object sender, EventArgs e)
        {
            //ToastNotify.Info(DateTime.Parse(_date).ToString("D"));
            //var trueDate = DateTime.ParseExact(_date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //if (trueDate.Date.DayOfWeek == 0) return;


            var attendanceModal = new AttendanceDateModal(_mainForm, _date);
            ControlsHelper.ShowModal(_mainForm, attendanceModal);


        }

        public async void UpdateAttendanceLog(string date)
        {
            await GetAttendanceLog(date);
        }

        private async Task GetAttendanceLog(string date)
        {
            try
            {
                var logs = await HttpHelper.GetAsync<ApiResponse<LogCountDto>>($"{ApiEndpoint.Attendance.GetLogCount}{date}");
                var dateConverted = DateTime.ParseExact(_date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                (DateTime currentWeekStart, DateTime currentWeekEnd) = ControlsHelper.GetCurrentWeek();

                PresentCount.Visible = true;
                LeaveCount.Visible = true;
                AbsentCount.Visible = true;

                if (logs.Data == null)
                {
                    MainView.Controls.Remove(PresentCount);
                    MainView.Controls.Remove(LeaveCount);
                    MainView.Controls.Remove(AbsentCount);
                    return;
                }
                else
                {                    

                    if (logs.Data.PresentCount == 0) MainView.Controls.Remove(PresentCount);
                    else
                    {
                        PresentCount.Text = logs.Data.PresentCount > 1 ? $"     {logs.Data.PresentCount.ToString()} Presents" : $"     {logs.Data.PresentCount.ToString()} Present";
                        if (dateConverted.Date >= currentWeekStart && dateConverted.Date <= currentWeekEnd)  _parent.PresentCount += logs.Data.PresentCount;
                    }

                    if (logs.Data.LeaveCount == 0) MainView.Controls.Remove(LeaveCount);
                    else
                    {
                        LeaveCount.Text = logs.Data.LeaveCount > 1 ? $"     {logs.Data.LeaveCount.ToString()} On Leaves" : $"     {logs.Data.LeaveCount.ToString()} On Leave";
                        if (dateConverted.Date >= currentWeekStart && dateConverted.Date <= currentWeekEnd) _parent.LeaveCount += logs.Data.LeaveCount;
                    }
                    if (logs.Data.AbsentCount == 0) MainView.Controls.Remove(AbsentCount);
                    else
                    {
                        AbsentCount.Text = logs.Data.AbsentCount > 1 ? $"     {logs.Data.AbsentCount.ToString()} Absents" : $"     {logs.Data.AbsentCount.ToString()} Absent";
                        if (dateConverted.Date >= currentWeekStart && dateConverted.Date <= currentWeekEnd) _parent.AbsentCount += logs.Data.AbsentCount;
                    }
                }

            }
            catch (Exception ex)
            {
                GunaMessage.Error(ex.Message, "ERROR");
            }
        }
        private static void ApplyOutOfMonthStyle(CalendarDayView calendarDay)
        {
            var fadedColor = Color.FromArgb(200, 200, 200);
            calendarDay.DayLabel.ForeColor = fadedColor;
            calendarDay.PresentCount.ForeColor = fadedColor;
            calendarDay.LeaveCount.ForeColor = fadedColor;
            calendarDay.AbsentCount.ForeColor = fadedColor;
        }
    }
}
