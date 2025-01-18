using PayrollSystem.Helpers;
using PayrollSystem.Models;
using PayrollSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms.Modals
{
    public partial class AttendanceLogModal : Form
    {
        private List<AttendanceDto> _attendanceLogs = new List<AttendanceDto>();
        private MainForm _mainForm;
        private DateTime _startDate;
        private DateTime _endDate;
        private Guid _id;
        private PersonalInformationDisplayDto _employee;
        public AttendanceLogModal(MainForm mainForm, DateTime startDate, DateTime endDate, Guid id)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _startDate = startDate;
            _endDate = endDate;
            _id = id;
            _employee = _mainForm.EmployeeInfo.FirstOrDefault(x => x.PersonalId == _id);
        }

        private async Task GetAttendanceLogs(string startDate, string endDate, Guid id)
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<List<AttendanceDto>>>($"{ApiEndpoint.Attendance.GetAttendanceByDateRangeAndId}?start={startDate}&end={endDate}&id={id}");

                if (apiData == null) throw new HttpRequestException("Attendance logs returned null");

                if (apiData.isSuccess)
                {
                    ToastNotify.Success("Attendance records loaded successfully");
                    _attendanceLogs = apiData.Data;
                    if (_attendanceLogs.Count > 1)
                    {
                        NullLabel.Visible = false;
                        await AttendanceMonthlyView.DataViewAsync(_attendanceLogs, _startDate.ToString("dddd, MMMM d, yyyy"), AttendanceView);
                    }
                    else
                    {
                        NullLabel.Visible = true;
                    }
                }
                else
                {
                    ToastNotify.Warning(apiData.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (AttendanceView.Controls.Count > 0)
                {
                    await LoadAttendanceLog();
                }
            }
        }

        private async void AttendaceLogModal_Load(object sender, EventArgs e)
        {
            DateLabel.Text = $"ATTENDANCE RECORD ({_startDate.ToString("MMMM yyyy")})";
            EmployeeLabel.Text = $"{_employee.FirstName} {(string.IsNullOrEmpty(_employee.MiddleName) ? "" : $"{_employee.MiddleName[0]}. ")}{_employee.LastName}";
            await GetAttendanceLogs(_startDate.ToString("yyyy-MM-dd"), _endDate.ToString("yyyy-MM-dd"), _id);
        }

        private async Task LoadAttendanceLog()
        {
            await Task.Delay(250);
            var controls = AttendanceView.Controls.OfType<AttendanceMonthlyView>().ToList();
            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    control.LoadView();
                }
            });
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            await GetAttendanceLogs(_startDate.ToString("yyyy-MM-dd"), _endDate.ToString("yyyy-MM-dd"), _id);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (_attendanceLogs.Count == 0)
            {
                ToastNotify.Info("Can't generate report, no attendance records");
                return;
            }
            var attendanceLogs = _attendanceLogs;
            foreach(var data in attendanceLogs)
            {
                data.MorningIn = data.MorningIn == null ? "--:--" : TimeOnly.ParseExact(data.MorningIn, "HH:mm:ss").ToString("hh:mm tt");
                data.MorningOut = data.MorningOut == null ? "--:--" : TimeOnly.ParseExact(data.MorningOut, "HH:mm:ss").ToString("hh:mm tt");
                data.AfternoonIn = data.AfternoonIn == null ? "--:--" : TimeOnly.ParseExact(data.AfternoonIn, "HH:mm:ss").ToString("hh:mm tt");
                data.AfternoonOut = data.AfternoonOut == null ? "--:--" : TimeOnly.ParseExact(data.AfternoonOut, "HH:mm:ss").ToString("hh:mm tt");
            }

            var reportModal = new ReportModal(attendanceLogs);
            ControlsHelper.ShowModal(_mainForm, reportModal);
        }
    }
}
