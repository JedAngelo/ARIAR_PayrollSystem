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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PayrollSystem.Helpers.ApiEndpoint;

namespace PayrollSystem.Forms.Modals
{
    public partial class AddAttendanceModal : Form
    {
        private List<PersonalInformationDisplayDto> _employees;
        private List<PersonalInformationDisplayDto> _selectedEmployees = new List<PersonalInformationDisplayDto>();
        private string _attendance;
        private string _date;
        private List<AttendanceDto> _attendanceDtos = new List<AttendanceDto>();
        private List<AttendanceDisplayDto> _attendanceLogs = new List<AttendanceDisplayDto>();
        public string Attendance
        {
            get { return _attendance; }
            private set
            {
                _attendance = value;
            }
        }


        public List<PersonalInformationDisplayDto> SelectedEmployees
        {
            get { return _selectedEmployees; }
            set
            {
                _selectedEmployees = value;
            }
        }


        public AddAttendanceModal(List<PersonalInformationDisplayDto> employees, List<AttendanceDisplayDto> attendanceLogs, string date)
        {
            InitializeComponent();
            _employees = employees;
            _attendanceLogs = attendanceLogs;
            _date = date;
            _ = LoadEmployeeData(_employees);

        }

        private async Task LoadEmployeeData(List<PersonalInformationDisplayDto> data)
        {
            await EmployeeShortView2.DataViewAsync(this, data, _attendanceLogs, EmployeeView);
        }


        public async void RemoveSelected()
        {
            var controls = EmployeeView.Controls.OfType<EmployeeShortView2>().Where(x => x.Selected).ToList();
            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    control.Selected = false;
                }
            });


        }

        public async void SelectAll()
        {
            var controls = EmployeeView.Controls.OfType<EmployeeShortView2>().Where(x => !x.Selected).ToList();
            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    control.Selected = true;
                }
            });
        }

        public async Task SetView(PersonalInformationDisplayDto employee)
        {
            if (employee == null)
            {
                await LoadPic(null);
                FullnameLabel.Text = "---";
                return;
            }
            await LoadPic(employee.EmployeeImage);
            FullnameLabel.Text = $"{employee.FirstName} {(string.IsNullOrEmpty(employee.MiddleName) ? "" : $"{employee.MiddleName[0]}. ")}{employee.LastName}";
        }

        

        private async void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (String.IsNullOrEmpty(SearchBox.Text))
                {
                    await LoadEmployeeData(_employees);
                    return;
                }

                var filter = SearchBox.Text.ToLower();
                var filteredData = _employees.Where
                (
                    x => $"{x.FirstName} {(String.IsNullOrEmpty(x.MiddleName) ? "" : $"{x.MiddleName[0]}. ")}{x.LastName}".ToLower().Contains(filter)
                ).ToList();
                await LoadEmployeeData(filteredData);


            }
        }
        private async Task LoadPic(byte[] data)
        {
            if (data == null) { EmployeePictureBox.Image = EmployeePictureBox.InitialImage; }
            await ControlsHelper.ConvertByteToImageAsync(data, EmployeePictureBox);
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            RemoveSelected();
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private async Task UpdateDataView()
        {
            var controls = EmployeeView.Controls.OfType<EmployeeShortView2>().Where(x => x.Selected).ToList();
            await Task.Run(() =>
            {
                BeginInvoke((Action)(() =>
                {
                    foreach(var control in controls)
                    {
                        EmployeeView.Controls.Remove(control);
                    }
                }));                
            });
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                //ControlsHelper.FormatTimeOnly(ControlsHelper.ParseTimeOnly(timeData))
                var success = false;
                var timeInAm = String.IsNullOrEmpty(TimeInAmTextBox.Text) ? null : ControlsHelper.FormatTimeOnly(ControlsHelper.ParseTimeOnly($"{TimeInAmTextBox.Text}AM"));
                var timeOutAm = String.IsNullOrEmpty(TimeOutAmTextBox.Text) ? null : ControlsHelper.FormatTimeOnly(ControlsHelper.ParseTimeOnly($"{TimeOutAmTextBox.Text}{(TimeOutAmTextBox.Text.Contains("12") ? "PM" : "AM")}"));
                var timeInPm = String.IsNullOrEmpty(TimeInPmTextBox.Text) ? null : ControlsHelper.FormatTimeOnly(ControlsHelper.ParseTimeOnly($"{TimeInPmTextBox.Text}PM"));
                var timeOutPm = String.IsNullOrEmpty(TimeOutPmTextBox.Text) ? null : ControlsHelper.FormatTimeOnly(ControlsHelper.ParseTimeOnly($"{TimeOutPmTextBox.Text}PM"));

                if (SelectedEmployees.Count == 0)
                {
                    ToastNotify.Warning("Please select an employee first");
                    return;
                }

                //progress circle
                ProgressCircle.Visible = true;
                ProgressCircle.Value = 0;
                ProgressCircle.Minimum = 0;
                ProgressCircle.Maximum = SelectedEmployees.Count;




                foreach (var employee in SelectedEmployees)
                {
                    var attendanceDto = new AttendanceDto
                    {
                        PersonalId = (Guid)employee.PersonalId,
                        MorningIn = timeInAm,
                        MorningOut = timeOutAm,
                        AfternoonIn = timeInPm,
                        AfternoonOut = timeOutPm,
                        AttendanceDate = _date,     
                        PayMultiplier = 1.0m
                    };
                    _attendanceDtos.Add(attendanceDto);
                }

                foreach (var attendance in _attendanceDtos)
                {
                    var attendanceData = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiEndpoint.Attendance.LogAttendance, attendance);

                    if (attendanceData == null) throw new HttpRequestException($"API returned null: {nameof(attendanceData)}");


                    if (attendanceData.isSuccess)
                    {
                        Console.WriteLine(attendanceData.Data);
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine(attendanceData.ErrorMessage);
                        success = false;
                    }

                    ProgressCircle.Value += 1;
                }

                ProgressCircle.Visible = false;
                if (success)
                {
                    GunaMessage.Info($"Successfully logged {Attendance}", "Success");
                    await UpdateDataView();
                }
                else
                {
                    GunaMessage.Warning("Trouble logging attendance data", "Try Again");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
