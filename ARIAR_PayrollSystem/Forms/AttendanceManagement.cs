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

namespace ARIAR_PayrollSystem.Forms
{
    public partial class AttendanceManagement : Form
    {
        private readonly MainForm _mainForm;
        private DateTime _currentDate = DateTime.Now;

        public AttendanceManagement(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            MonthComboBox.SelectedIndex = _currentDate.Month-1;
            YearComboBox.SelectedIndex = _currentDate.Year-1970;
            CalendarDayView.ShowCalendarDay(CalendarView, _currentDate);            
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

        private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthComboBox.Enabled = false;
            YearComboBox.Enabled = false;
            _currentDate = new DateTime(_currentDate.Year, MonthComboBox.SelectedIndex+1, _currentDate.Day);
            CalendarDayView.ShowCalendarDay(CalendarView, _currentDate);
            MonthComboBox.Enabled = true;
            YearComboBox.Enabled = true;

        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearComboBox.Enabled = false;
            _currentDate = new DateTime(YearComboBox.SelectedIndex+1970, _currentDate.Month, _currentDate.Day);
            CalendarDayView.ShowCalendarDay(CalendarView, _currentDate);
            YearComboBox.Enabled = true;
        }

        //private async Task LoadingCalendar()
        //{
        //    ProgressCircle.Maximum = 8;
        //    for (int i = 1; i <= 8; i++)
        //    {
        //        ProgressCircle.Value = i + 1;
        //        await Task.Delay(50);
        //    }
        //    await Task.Delay(50);
        //    ProgressCircle.Visible = false;
        //    LoadingPanel.Visible = false;
        //}
    }
}
