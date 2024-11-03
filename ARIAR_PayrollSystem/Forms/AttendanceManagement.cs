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
            DateLabel.Text = _currentDate.ToString("MMMM ( yyyy )");
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
            _currentDate = _currentDate.AddMonths(-1);
            DateLabel.Text = _currentDate.ToString("MMMM ( yyyy )");
            CalendarDayView.ShowCalendarDay(CalendarView, _currentDate);
        }

        private async void guna2Button3_Click(object sender, EventArgs e)
        {
            await Task.Delay(200);
            _currentDate = _currentDate.AddMonths(+1);
            DateLabel.Text = _currentDate.ToString("MMMM ( yyyy )");
            CalendarDayView.ShowCalendarDay(CalendarView, _currentDate);
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            await Task.Delay(200);
            _currentDate = _currentDate.AddYears(-1);
            DateLabel.Text = _currentDate.ToString("MMMM ( yyyy )");
            CalendarDayView.ShowCalendarDay(CalendarView, _currentDate);
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            await Task.Delay(200);
            _currentDate = _currentDate.AddYears(+1);
            DateLabel.Text = _currentDate.ToString("MMMM ( yyyy )");
            CalendarDayView.ShowCalendarDay(CalendarView, _currentDate);
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
