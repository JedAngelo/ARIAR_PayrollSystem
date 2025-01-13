using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
using ARIAR_PayrollSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ARIAR_PayrollSystem.Helpers.ApiEndpoint;

namespace ARIAR_PayrollSystem.Forms
{
    public partial class AttendanceManagement : Form
    {
        private readonly MainForm _mainForm;
        private DateTime _currentDate = DateTime.Now;
        private bool _yearChanged = false;
        private bool _isLoaded = false;

        public AttendanceManagement(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            MonthComboBox.SelectedIndex = _currentDate.Month-1;
            YearComboBox.SelectedIndex = _currentDate.Year-1970;
            CalendarDayView.ShowCalendarDay(_mainForm, CalendarView, _currentDate);         
            
            
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

                _currentDate = new DateTime(_currentDate.Year, newMonth, newDay);
            
                CalendarDayView.ShowCalendarDay(_mainForm, CalendarView, _currentDate);
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

            _currentDate = new DateTime(YearComboBox.SelectedIndex+1970, newMonth, newDay);
            CalendarDayView.ShowCalendarDay(_mainForm, CalendarView, _currentDate);
            YearComboBox.Enabled = true;
            await LoadEmployeeCount(_currentDate);
        }

        private async void AttendanceManagement_Load(object sender, EventArgs e)
        {
            await LoadViews();
            _isLoaded = true;
        }

        public async void RemoveSelected()
        {
            var controls = LogsView.Controls.OfType<WorkLogView>().Where(x => x.Selected).ToList();
            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    control.Selected = false;
                }
            });
        }

        private async Task LoadViews()
        {
            Console.WriteLine(_currentDate);
            var date = new DateTime(2024, 12, 12, new Random().Next(0, 24), new Random().Next(0, 60), new Random().Next(0, 60), new Random().Next(0, 1000));
            await WorkLogView.DataViewAsync(this, _mainForm.EmployeeInfo, date, LogsView);
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


        private async Task GetLogCount()
        {
            try
            {
                var endPoint = $"{ApiEndpoint.Attendance.GetLogCountById}74a7fe53-2031-4a96-b253-08b984ace0a0&2024-12-12";
                Console.WriteLine(endPoint);
                //https://localhost:44376/api/Attendance/GetLogCountById?id=74a7fe53-2031-4a96-b253-08b984ace0a0&date=2024-12-31
                var _data = await HttpHelper.GetAsync<ApiResponse<LogCountDto>>(endPoint);

                if (_data == null) throw new ArgumentNullException("No attendance count log found");

                if (_data.isSuccess)
                {
                    
                    Console.WriteLine($"Log count retrieved for: {_data.Data}");
                    Console.WriteLine(_data.Data.PresentCount);
                }
                else
                {
                    Console.WriteLine(_data.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void guna2Button8_Click(object sender, EventArgs e)
        {
            await GetLogCount();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            CalendarDayView.ShowCalendarDay(_mainForm, CalendarView, _currentDate);
        }
    }
}
