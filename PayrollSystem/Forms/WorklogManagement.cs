using PayrollSystem.Forms.Modals;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using PayrollSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using static PayrollSystem.Helpers.ApiEndpoint;

namespace PayrollSystem.Forms
{
    public partial class WorklogManagement : Form
    {
        private readonly MainForm _mainForm;
        private DateTime _currentDate = DateTime.Now;
        private bool _yearChanged = false;
        private bool _isLoaded = false;
        public Guid? SelectedId { get; set; }

        private int _leaveCount = 0;
        private int _absentCount = 0;
        private int _presentCount = 0;

        public int LeaveCount
        {
            get { return _leaveCount; }
            set
            {
                _leaveCount = value;
                LeaveCountLabel.Text = _leaveCount.ToString();
            }
        }
        public int AbsentCount
        {
            get { return _absentCount; }
            set
            {
                _absentCount = value;
                AbsentCountLabel.Text = _absentCount.ToString();
            }
        }
        public int PresentCount
        {
            get { return _presentCount; }
            set
            {
                _presentCount = value;
                PresentCountLabel.Text = _presentCount.ToString();
            }
        }
        

        public WorklogManagement(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            MonthComboBox.SelectedIndex = _currentDate.Month-1;
            YearComboBox.SelectedIndex = _currentDate.Year-1970;
        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void guna2Button4_Click(object sender, EventArgs e)
        {
            await Task.Delay(200);
            if (MonthComboBox.SelectedIndex == 0)
            {
                _yearChanged = true;
                MonthComboBox.SelectedIndex = 11;
                YearComboBox.SelectedIndex -= 1;
                return;
            }
            MonthComboBox.SelectedIndex -= 1;
        }

        private async void guna2Button3_Click(object sender, EventArgs e)
        {
            await Task.Delay(200);
            if (MonthComboBox.SelectedIndex == 11)
            {
                _yearChanged = true;
                MonthComboBox.SelectedIndex = 0;
                YearComboBox.SelectedIndex += 1;
                return;
            }
            MonthComboBox.SelectedIndex += 1;
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            await Task.Delay(200);
            YearComboBox.SelectedIndex -= 1;
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            await Task.Delay(200);
            YearComboBox.SelectedIndex += 1;
        }

        private async void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthComboBox.Enabled = false;
            YearComboBox.Enabled = false;

            if (!_yearChanged)
            {
                int newMonth = MonthComboBox.SelectedIndex + 1;
                int originalDay = _currentDate.Day;

                int lastDayOfNewMonth = DateTime.DaysInMonth(_currentDate.Year, newMonth);
                int newDay = Math.Min(originalDay, lastDayOfNewMonth);

                _absentCount = 0;
                _presentCount = 0;
                _leaveCount = 0;
                _currentDate = new DateTime(_currentDate.Year, newMonth, newDay);
                CalendarDayView.ShowCalendarDay(_mainForm, this, CalendarView, _currentDate);
                await LoadEmployeeCount(_currentDate);
                //if (_isLoaded) await LoadViews();
            }


            MonthComboBox.Enabled = true;
            YearComboBox.Enabled = true;
            _yearChanged = false;
        }

        private async void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearComboBox.Enabled = false;

            int newMonth = MonthComboBox.SelectedIndex + 1;
            int originalDay = _currentDate.Day;

            int lastDayOfNewMonth = DateTime.DaysInMonth(_currentDate.Year, newMonth);
            int newDay = Math.Min(originalDay, lastDayOfNewMonth);

            _absentCount = 0;
            _presentCount = 0;
            _leaveCount = 0;
            _currentDate = new DateTime(YearComboBox.SelectedIndex+1970, newMonth, newDay);
            CalendarDayView.ShowCalendarDay(_mainForm, this, CalendarView, _currentDate);
            YearComboBox.Enabled = true;
            await LoadEmployeeCount(_currentDate);
        }

        private async void AttendanceManagement_Load(object sender, EventArgs e)
        {
            await LoadViews(_mainForm.EmployeeInfo);
            _isLoaded = true;
            EmployeeCountLabel.Text = _mainForm.EmployeeInfo.Count().ToString();
        }

        public void RemoveSelected()
        {
            var control = LogsView.Controls.OfType<WorkLogView>().FirstOrDefault(x => x.Selected);
            if (control != null) control.Selected = false;
        }

        private async Task LoadViews(List<PersonalInformationDisplayDto> data)
        {
            Console.WriteLine(_currentDate);
            await WorkLogView.DataViewAsync(this, data.Where(x => x.IsActive).ToList(), _currentDate, LogsView);
            await LoadEmployeeCount(_currentDate);
        }

        private async Task LoadEmployeeCount(DateTime date)
        {
            var controls = LogsView.Controls.OfType<WorkLogView>().ToList();
            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    control.LoadData(date);
                }
            });
        }


        //private async Task GetLogCount()
        //{
        //    try
        //    {
        //        var endPoint = $"{ApiEndpoint.Attendance.GetLogCountById}74a7fe53-2031-4a96-b253-08b984ace0a0&2024-12-12";
        //        Console.WriteLine(endPoint);
        //        //https://localhost:44376/api/Attendance/GetLogCountById?id=74a7fe53-2031-4a96-b253-08b984ace0a0&date=2024-12-31
        //        var _data = await HttpHelper.GetAsync<ApiResponse<LogCountDto>>(endPoint);

        //        if (_data == null) throw new ArgumentNullException("No attendance count log found");

        //        if (_data.isSuccess)
        //        {
                    
        //            Console.WriteLine($"Log count retrieved for: {_data.Data}");
        //            Console.WriteLine(_data.Data.PresentCount);
        //        }
        //        else
        //        {
        //            Console.WriteLine(_data.ErrorMessage);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //private async void guna2Button8_Click(object sender, EventArgs e)
        //{
        //    await GetLogCount();
        //}

        private async void guna2Button9_Click(object sender, EventArgs e)
        {
            _absentCount = 0;
            _presentCount = 0;
            _leaveCount = 0;
            CalendarDayView.ShowCalendarDay(_mainForm, this, CalendarView, _currentDate);
            await LoadViews(_mainForm.EmployeeInfo);
        }

        private async void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                await Task.Delay(500);
                if (String.IsNullOrEmpty(SearchBox.Text))
                {
                    await LoadViews(_mainForm.EmployeeInfo);
                    return;
                }

                var filter = SearchBox.Text.ToLower();
                //FilterPersonnel(guna2TextBox1.Text);
                var _employees = _mainForm.EmployeeInfo.Where
                (
                    x => $"{x.FirstName} {(String.IsNullOrEmpty(x.MiddleName) ? "" : $"{x.MiddleName[0]}. ")}{x.LastName}".ToLower().Contains(filter)
                ).ToList();
                await LoadViews(_employees);


            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (SelectedId == null)
            {
                GunaMessage.Warning("Please select an employee first", "Try Again");
                return;
            }
            var datePicker = new DateRangeModal(_mainForm, false, SelectedId);
            ControlsHelper.ShowModal(_mainForm, datePicker);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            var datePicker = new DateRangeModal(_mainForm, true);
            ControlsHelper.ShowModal(_mainForm, datePicker);
        }
    }
}
