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
    public partial class EmployeeAttendanceLogView : UserControl
    {
        private AttendanceDisplayDto _attendanceLog;
        private AttendanceDateModal _parent;
        private string _date;
        private bool _selected;
        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                if (_selected)
                {
                    MainView.FillColor = Color.FromArgb(27, 75, 95);
                    Fullname.ForeColor = Color.White;
                    MorningInLabel.ForeColor = Color.White;
                    MorningOutLabel.ForeColor = Color.White;
                    AfternoonInLabel.ForeColor = Color.White;
                    AfternoonOutLabel.ForeColor = Color.White;
                    LeaveLabel.ForeColor = Color.White;
                    _parent.SelectedAttendanceLog = _attendanceLog;
                }
                else
                {
                    MainView.FillColor = Color.White;
                    Fullname.ForeColor = Color.FromArgb(65,65,65);
                    MorningInLabel.ForeColor = Color.FromArgb(65, 65, 65);
                    MorningOutLabel.ForeColor = Color.FromArgb(65, 65, 65);
                    AfternoonInLabel.ForeColor = Color.FromArgb(65, 65, 65);
                    AfternoonOutLabel.ForeColor = Color.FromArgb(65, 65, 65);
                    LeaveLabel.ForeColor = Color.FromArgb(65, 65, 65);
                    _parent.SelectedAttendanceLog = null;
                }
                Invoke((Action)(() => TopView.Refresh()));

            }
        }
        public EmployeeAttendanceLogView(AttendanceDateModal parent, AttendanceDisplayDto attendanceLog, string date)
        {
            InitializeComponent();
            _parent = parent;
            _attendanceLog = attendanceLog;
            _ = ControlsHelper.ConvertByteToImageAsync(attendanceLog.EmployeeImage, EmployeePic);
            Fullname.Text = attendanceLog.Name;
            _date = date;


        }

        public static async Task DataViewAsync(AttendanceDateModal parent, List<AttendanceDisplayDto> attendanceLogs, string date, FlowLayoutPanel view)
        {
            try
            {
                view.Controls.Clear();
                var logViewList = new List<EmployeeAttendanceLogView>();

                await Task.Run(() =>
                {
                    foreach(var attendance in attendanceLogs)
                    {
                        if (attendance.Type == "ABSENT") continue;
                        var logView = new EmployeeAttendanceLogView(parent, attendance, date)
                        {
                            Width = view.ClientSize.Width - 10
                        };
                        logView.LoadData();

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
            if (!Selected) _parent.RemoveSelected();
            Selected = !Selected;
        }

        public async void LoadData()
        {
            await GetAttendanceLog(_attendanceLog.PersonalId, _date);
        }

        private async Task GetAttendanceLog(Guid id, string date)
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<AttendanceDto>>($"{ApiEndpoint.Attendance.GetAttendanceById}?id={id}&date={date}");

                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " is null");

                if (apiData.isSuccess)
                {
                    await SetView(apiData.Data);
                    Console.WriteLine("Attendance log fetched successfully");
                }
                else
                {
                    Console.WriteLine(apiData.ErrorMessage);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task SetView(AttendanceDto data)
        {
            await Task.Run(() =>    
            {
                Invoke((Action)(() =>
                {
                    if (data.Status == "LEAVE")
                    {
                        MorningInLabel.Visible = false;
                        MorningOutLabel.Visible = false;
                        AfternoonInLabel.Visible = false;
                        AfternoonOutLabel.Visible = false;
                        LeaveLabel.Visible = true;
                        TopView.Refresh();
                        return;
                    }
                    MorningInLabel.Text = data.MorningIn == null ? "--:--" : TimeOnly.ParseExact(data.MorningIn, "HH:mm:ss").ToString("hh:mm");
                    MorningOutLabel.Text = data.MorningOut == null ? "--:--" : TimeOnly.ParseExact(data.MorningOut, "HH:mm:ss").ToString("hh:mm");
                    AfternoonInLabel.Text = data.AfternoonIn == null ? "--:--" : TimeOnly.ParseExact(data.AfternoonIn, "HH:mm:ss").ToString("hh:mm");
                    AfternoonOutLabel.Text = data.AfternoonOut == null ? "--:--" : TimeOnly.ParseExact(data.AfternoonOut, "HH:mm:ss").ToString("hh:mm");
                    TopView.Refresh();
                }));
            });
        }
    }
}
