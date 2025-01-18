using PayrollSystem.Helpers;
using PayrollSystem.Models;
using PayrollSystem.UserControls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Windows.Forms;
using static PayrollSystem.Helpers.ApiEndpoint;

namespace PayrollSystem.Forms.Modals
{
    public partial class AttendanceDateModal : Form
    {
        private string _date;
        private MainForm _mainForm;
        private List<AttendanceDisplayDto> _attendanceLogs;
        private AttendanceDisplayDto _selectedAttendanceLog;
        private List<AttendanceDisplayDto> AttendanceLogs
        {
            get { return _attendanceLogs; }
            set
            {
                _attendanceLogs = value;
                if (_attendanceLogs != null)
                {
                    if (_attendanceLogs.Count == 0) NullLabel.Visible = true;
                    else NullLabel.Visible = false;
                }
            }
        }
        public AttendanceDisplayDto SelectedAttendanceLog
        {
            get { return _selectedAttendanceLog; }
            set
            {
                _selectedAttendanceLog = value;
            }
        }


        public AttendanceDateModal(MainForm mainForm ,string date)
        {
            InitializeComponent();
            _date = date;
            _mainForm = mainForm;
            _ = GetAttendanceLogs(_date);
            Console.WriteLine(_date);
            var dateString = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateLabel.Text = dateString.ToString("dddd, MMMM d, yyyy");

        }

        private async Task GetAttendanceLogs(string date)
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<List<AttendanceDisplayDto>>>($"{ApiEndpoint.Attendance.GetAttendanceLogs}{date}");

                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " is null");

                if (apiData.isSuccess)
                {
                    AttendanceLogs = apiData.Data;
                    Console.WriteLine($"Data successfully retrieved {nameof(AttendanceLogs)}");
                    LoadView(date, AttendanceLogs);
                }
                else
                {
                    Console.WriteLine(apiData.ErrorMessage);
                    ToastNotify.Error("Can't retrieve attendance logs");
                }              
                


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (AttendanceLogs != null) await LoadAttendanceLog();
            }
        }

        private async void LoadView(string date, List<AttendanceDisplayDto> data)
        {
            await EmployeeAttendanceLogView.DataViewAsync(this, data, date, EmployeeView);
        }

        private async Task LoadAttendanceLog()
        {
            await Task.Delay(250);
            var controls = EmployeeView.Controls.OfType<EmployeeAttendanceLogView>().ToList();
            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    control.LoadData();
                }
            });
        }


        public void RemoveSelected()
        {
            var control = EmployeeView.Controls.OfType<EmployeeAttendanceLogView>().FirstOrDefault(x => x.Selected);
            if (control != null) control.Selected = false;
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (SelectedAttendanceLog == null)
            {
                ToastNotify.Warning("Please select an employee first");
            }
            else
            {
                UpdateAttendanceModal updateLogModal = new UpdateAttendanceModal(SelectedAttendanceLog, _date);
                ControlsHelper.ShowModal(_mainForm, updateLogModal);

            }
        }

        private void AttendanceDateModal_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddAttendanceModal addLogModal = new AddAttendanceModal(_mainForm.EmployeeInfo, _attendanceLogs, _date);
            ControlsHelper.ShowModal(_mainForm, addLogModal);
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            await GetAttendanceLogs(_date);
        }

        private void AddLeaveButton_Click(object sender, EventArgs e)
        {
            var leaveModal = new AddLeaveModal(_mainForm.EmployeeInfo, _date);
            ControlsHelper.ShowModal(_mainForm, leaveModal);
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (String.IsNullOrEmpty(SearchBox.Text))
                {
                    LoadView(_date, AttendanceLogs);
                    return;
                }

                var filter = SearchBox.Text.ToLower();
                var filteredData = AttendanceLogs.Where
                (
                    x => x.Name.ToLower().Contains(filter)
                ).ToList();
                LoadView(_date, filteredData);


            }
        }
    }
}
