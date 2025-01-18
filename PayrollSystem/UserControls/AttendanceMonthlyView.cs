using PayrollSystem.Forms.Modals;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PayrollSystem.Helpers.ApiEndpoint;

namespace PayrollSystem.UserControls
{
    public partial class AttendanceMonthlyView : UserControl
    {
        private string _date;
        private AttendanceDto _attendanceLog;
       
        public AttendanceMonthlyView(AttendanceDto attendanceLog, string date)
        {
            InitializeComponent();
            _date = date;
            _attendanceLog = attendanceLog;

        }

        public static async Task DataViewAsync(List<AttendanceDto> attendanceLogs, string date, FlowLayoutPanel view)
        {
            try
            {
                view.Controls.Clear();
                var logViewList = new List<AttendanceMonthlyView>();

                await Task.Run(() =>
                {
                    foreach(var attendance in attendanceLogs)
                    {
                        var logView = new AttendanceMonthlyView(attendance, date)
                        {
                            Width = view.ClientSize.Width - 10
                        };
                        logViewList.Add(logView);
                    }
                    view.Invoke((Action)(() => view.Controls.AddRange(logViewList.ToArray())));
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void MainView_Click(object sender, EventArgs e)
        {
        }



        private void SetView(AttendanceDto data)
        {
            DateLabel.Text = DateOnly.ParseExact(data.AttendanceDate, "yyyy-MM-dd").ToString("dddd MMMM d, yyyy");
            if (data.Status == "LEAVE" || data.Status == "ABSENT")
            {
                LeaveLabel.Visible = true;
                MorningInLabel.Visible = false;
                MorningOutLabel.Visible = false;
                AfternoonInLabel.Visible = false;
                AfternoonOutLabel.Visible = false;
                AttendanceType.Visible = false;
                LeaveLabel.Text = data.Status == "LEAVE" ? "ON LEAVE" : data.Status == "ABSENT" ? "ABSENT" : data.Status;
                TopView.Refresh();
                return;
            }
            AttendanceType.Text = data.Type;
            MorningInLabel.Text = data.MorningIn == null ? "--:--" : TimeOnly.ParseExact(data.MorningIn, "HH:mm:ss").ToString("hh:mm");
            MorningOutLabel.Text = data.MorningOut == null ? "--:--" : TimeOnly.ParseExact(data.MorningOut, "HH:mm:ss").ToString("hh:mm");
            AfternoonInLabel.Text = data.AfternoonIn == null ? "--:--" : TimeOnly.ParseExact(data.AfternoonIn, "HH:mm:ss").ToString("hh:mm");
            AfternoonOutLabel.Text = data.AfternoonOut == null ? "--:--" : TimeOnly.ParseExact(data.AfternoonOut, "HH:mm:ss").ToString("hh:mm");
            TopView.Refresh();
        }
        public void LoadView()
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() =>
                {
                    SetView(_attendanceLog);
                }));
            }
            else
            {
                SetView(_attendanceLog);
            }

        }
    }
}
