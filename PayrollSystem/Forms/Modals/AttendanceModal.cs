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
    public partial class AttendanceModal : Form
    {
        private List<PersonalInformationDisplayDto> _employees;
        private List<PersonalInformationDisplayDto> _selectedEmployees = new List<PersonalInformationDisplayDto>();
        private string _attendance;
        private string _date;
        private List<AttendanceDto> _attendanceDtos = new List<AttendanceDto>();
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



        public AttendanceModal(string type, List<PersonalInformationDisplayDto> employees, DateTime date)
        {
            InitializeComponent();
            _employees = employees;
            _date = date.ToString("yyyy-MM-dd");
            _ = LoadEmployeeData(_employees);
            TimeTextBox.Text = DateTime.Now.ToString("hh:mm");

            switch (type)
            {
                case "TIME IN AM":
                    TitleLabel.Text = "Manual Time IN (AM)";
                    SubLabel.Text = "Time IN (AM)";
                    AttendanceButton.Text = "TIME IN";
                    Attendance = "MORNING IN";
                    break;
                case "TIME OUT AM":
                    TitleLabel.Text = "Manual Time OUT (AM)";
                    SubLabel.Text = "Time OUT (AM)";
                    AttendanceButton.Text = "TIME OUT";
                    Attendance = "MORNING OUT";
                    break;
                case "TIME IN PM":
                    TitleLabel.Text = "Manual Time IN (PM)";
                    SubLabel.Text = "Time IN (PM)";
                    AttendanceButton.Text = "TIME IN";
                    Attendance = "AFTERNOON IN";
                    break;
                case "TIME OUT PM":
                    TitleLabel.Text = "Manual Time OUT (PM)";
                    SubLabel.Text = "Time OUT (PM)";
                    AttendanceButton.Text = "TIME OUT";
                    Attendance = "AFTERNOON OUT";
                    break;

            }


        }

        private async Task LoadEmployeeData(List<PersonalInformationDisplayDto> data)
        {
            await EmployeeShortView.DataViewAsync(this , data, EmployeeView);
        }


        public async void RemoveSelected()
        {
            var controls = EmployeeView.Controls.OfType<EmployeeShortView>().Where(x => x.Selected).ToList();
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
            var controls = EmployeeView.Controls.OfType<EmployeeShortView>().Where(x => !x.Selected).ToList();
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

        private async void AttendanceButton_Click(object sender, EventArgs e)
        {
            try
            {
                var timeData = TimeTextBox.Text;
                var success = false;

                switch (Attendance)
                {
                    case "MORNING IN":
                        foreach (var employee in SelectedEmployees)
                        {
                            AttendanceDto attendanceDto;
                            attendanceDto = new AttendanceDto
                            {
                                PersonalId = (Guid)employee.PersonalId,
                                MorningIn = ControlsHelper.FormatTimeOnly(ControlsHelper.ParseTimeOnly(timeData)),
                                AttendanceDate = _date
                            };
                            _attendanceDtos.Add(attendanceDto);
                        }
                        break;
                    case "MORNING OUT":
                        foreach (var employee in SelectedEmployees)
                        {
                            AttendanceDto attendanceDto;
                            attendanceDto = new AttendanceDto
                            {
                                PersonalId = (Guid)employee.PersonalId,
                                MorningOut = ControlsHelper.FormatTimeOnly(ControlsHelper.ParseTimeOnly(timeData)),
                                AttendanceDate = _date
                            };
                            _attendanceDtos.Add(attendanceDto);
                        }
                        break;
                    case "AFTERNOON IN":
                        foreach (var employee in SelectedEmployees)
                        {
                            AttendanceDto attendanceDto;
                            attendanceDto = new AttendanceDto
                            {
                                PersonalId = (Guid)employee.PersonalId,
                                AfternoonIn = ControlsHelper.FormatTimeOnly(ControlsHelper.ParseTimeOnly(timeData)),
                                AttendanceDate = _date
                            };
                            _attendanceDtos.Add(attendanceDto);
                        }
                        break;
                    case "AFTERNOON OUT":
                        foreach (var employee in SelectedEmployees)
                        {
                            AttendanceDto attendanceDto;
                            attendanceDto = new AttendanceDto
                            {
                                PersonalId = (Guid)employee.PersonalId,
                                AfternoonOut = ControlsHelper.FormatTimeOnly(ControlsHelper.ParseTimeOnly(timeData)),
                                AttendanceDate = _date
                            };
                            _attendanceDtos.Add(attendanceDto);
                        }
                        break;
                }


                if (_attendanceDtos == null) throw new ArgumentNullException(nameof(_attendanceDtos) + " cannot be null");
                

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
                }

                if (success)
                {
                    GunaMessage.Info($"Successfully logged {Attendance}", "Success");
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
    }
}
