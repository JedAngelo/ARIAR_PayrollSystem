using PayrollSystem.Forms.Modals;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using PayrollSystem.UserControls;
using DPUruNet;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static PayrollSystem.Helpers.ApiEndpoint;

namespace PayrollSystem.Forms
{
    public partial class BiometricAttendance : Form
    {
        MainForm _mainForm;
        public readonly HttpClient client = new HttpClient();
        private const int DPFJ_PROBABILITY_ONE = 0x7fffffff;
        private Dictionary<Guid?, Fmd> employeeFmds;
        private Fmd attendanceFmd;
        private int count;
        private ApiResponse<List<AttendanceDisplayDto>> attendanceLogs;


        private readonly TimeOnly _morningInStart = new TimeOnly(5, 0, 0);
        private readonly TimeOnly _morningInEnd = new TimeOnly(12, 0, 0);

        private readonly TimeOnly _afternoonInStart = new TimeOnly(12, 0, 0);
        private readonly TimeOnly _afternoonInEnd = new TimeOnly(17, 0, 0);

        private readonly TimeOnly _morningOutStart = new TimeOnly(8, 0, 0);
        private readonly TimeOnly _morningOutEnd = new TimeOnly(13, 00, 0);

        private readonly TimeOnly _afternoonOutStart = new TimeOnly(13, 0, 0);
        private readonly TimeOnly _afternoonOutEnd = new TimeOnly(18, 0, 0);

        public BiometricAttendance(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            TimeLabel.Text = DateTime.Now.ToString("T");
            DateLabel.Text = DateTime.Now.Date.ToString("MMMM d, yyyy");
            DayOfTheWeekLabel.Text = DateTime.Now.Date.ToString("dddd");
            //ProgressCircle.Visible = true;
            //ProgressCircle.Value = 0;
            PopulateAttendanceView(); 

        }

        private async Task<AttendanceDto> GetEmployeeAttendance(Guid id)
        {
            try
            {
                var todayDate = DateOnly.FromDateTime(DateTime.Now).ToString("yyyy-MM-dd");
                var apiData = await HttpHelper.GetAsync<ApiResponse<AttendanceDto>>($"{ApiEndpoint.Attendance.GetAttendanceById}?id={id}&date={todayDate}");

                if (apiData == null) return null;

                if (apiData.isSuccess)
                {
                    return apiData.Data;
                }
                else
                {
                    Console.WriteLine(apiData.ErrorMessage);
                    return null;
                }

                throw new InvalidOperationException("apiData is not null but didn't returned either success flag");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       
        private async Task PopulateView(List<AttendanceDisplayDto> data)
        {
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke((Action)(async () =>
                    {
                        await AttendanceLogView.DataViewAsync(data, AttendanceView);
                    }));
                }
                else
                {
                    await AttendanceLogView.DataViewAsync(data, AttendanceView);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void PopulateAttendanceView()
        {
            try
            {
                var DateNowString = DateTime.Now.Date.ToString("yyyy-MM-dd");
                attendanceLogs = await HttpHelper.GetAsync<ApiResponse<List<AttendanceDisplayDto>>>($"{ApiEndpoint.Attendance.GetAttendanceLogShort}{DateNowString}");
                if (attendanceLogs == null)
                {
                    GunaMessage.Error("Can't retrieve attendance logs!", "ERROR");
                    return;
                }                

                if (attendanceLogs.isSuccess)
                {
                    attendanceLogs.Data.ForEach(a =>
                    {
                        a.Log = TimeOnly.Parse(a.Log).ToString("t");
                    });
                    await PopulateView(attendanceLogs.Data);
                }
                else
                {
                    GunaMessage.Warning(attendanceLogs.ErrorMessage, "Warning");
                }              

            }
            catch (Exception ex)
            {
                GunaMessage.Error(ex.Message, "ERROR");
            }
        }

        private async void GetEmployeeBiometrics()
        {
            try
            {
                var _employeeInfo = await HttpHelper.GetAsync<ApiResponse<List<EmployeeBiometricsDto>>>(ApiEndpoint.Biometric.GetBiometric);

                if (_employeeInfo == null)
                {
                    GunaMessage.Error("Can't retrieve employee info!", "ERROR");
                    return;
                }

                // Initialize the dictionary to hold Fmd objects
                employeeFmds = new Dictionary<Guid?, Fmd>();

                // Iterate through the retrieved employee biometric data
                foreach (var employee in _employeeInfo.Data)
                {
                    // Assuming BiometricData is a byte array (or byte[] equivalent)
                    byte[] biometricData = employee.BiometricData;

                    int ConversionFormate = Convert.ToInt32(Constants.Formats.Fmd.ANSI);

                    Fmd fmd = new Fmd(biometricData, ConversionFormate, Constants.WRAPPER_VERSION);

                    // Add the personal ID and Fmd object to the dictionary
                    employeeFmds[employee.PersonalId] = fmd; // Assuming employee.PersonalId is the property holding the ID
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                GunaMessage.Error($"Error retrieving employee biometrics: {ex.Message}", "ERROR");
            }
        }

        private async Task<bool> HasMorningIn(Guid personalId)
        {
            try
            {
                var attendanceData = new AttendanceDto
                {
                    PersonalId = personalId,
                    AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd")
                };

                var result = await HttpHelper.PostAsync<ApiResponse<bool>, dynamic>(ApiEndpoint.Attendance.HasMorningIn, attendanceData);
                if (!result.isSuccess)            
                {
                    //MakeReport($"Error retrieving morning in data: {result.ErrorMessage}");
                    MakeReport(result.ErrorMessage, "ERROR");
                }

                return result.Data;

            }
            catch (Exception ex)
            {
                SendStatus(ex.Message);
                return false;
            }
        }

        private async void LogAttendance(Guid personalId)
        {
            try
            {
                bool hasMorningIn = await HasMorningIn(personalId);
                AttendanceDto attendanceData = null;
                var timeNow = TimeOnly.FromDateTime(DateTime.Now);
                var errorMessage = "Invalid attendance";

                var _attendance = await GetEmployeeAttendance(personalId);
                
                if (_attendance == null)
                {
                    if (timeNow >= _morningInStart && timeNow < _morningInEnd)
                    {
                        attendanceData = new AttendanceDto
                        {
                            PersonalId = personalId,
                            AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                            MorningIn = DateTime.Now.TimeOfDay.ToString()
                        };
                    }
                    else if (timeNow > _afternoonInStart && timeNow < _afternoonInEnd)
                    {
                        attendanceData = new AttendanceDto
                        {
                            PersonalId = personalId,
                            AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                            AfternoonIn = DateTime.Now.TimeOfDay.ToString()
                        };
                    }
                    errorMessage = "Attendance does not match time in range";
                }
                else
                {                    
                    errorMessage = "Attendance error, existing record found";
                    if (_attendance.MorningOut == null && _attendance.MorningIn != null && timeNow >= _morningOutStart && timeNow <= _morningOutEnd)
                    {
                        var morningIn = TimeOnly.ParseExact(_attendance.MorningIn, "HH:mm:ss");
                        var timeDifference =  timeNow - morningIn;
                        if (timeDifference <= new TimeSpan(1, 0, 0))
                        {
                            DialogResult result = GunaMessage.Question(_mainForm, "Time in record found 1 hour earlier, proceed?", "Early Out");
                            if (result == DialogResult.No || result == DialogResult.Cancel) return;
                        }
                        attendanceData = new AttendanceDto
                        {
                            PersonalId = personalId,
                            AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                            MorningOut = DateTime.Now.TimeOfDay.ToString()
                        };
                    }
                    else if (_attendance.AfternoonOut == null && (_attendance.MorningIn != null || _attendance.AfternoonIn != null) && timeNow >= _afternoonOutStart && timeNow <= _afternoonOutEnd)
                    {
                        var timeDifference = timeNow - TimeOnly.ParseExact(_attendance.MorningIn ?? _attendance.AfternoonIn, "HH:mm:ss");
                        if (timeDifference <= new TimeSpan(1, 0, 0))
                        {
                            DialogResult result = GunaMessage.Question(_mainForm, "Time in record found 1 hour earlier, proceed?", "Early Out");
                            if (result == DialogResult.No || result == DialogResult.Cancel) return;
                        }
                        attendanceData = new AttendanceDto
                        {
                            PersonalId = personalId,
                            AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                            AfternoonOut = DateTime.Now.TimeOfDay.ToString()
                        };
                    }
                    else if (_attendance.MorningOut != null || _attendance.AfternoonOut != null)
                    {
                        errorMessage = "Invalid, attendance record found";
                    }

                    if (_attendance.Status == "ABSENT")
                    {
                        if (timeNow >= _morningInStart && timeNow < _morningInEnd)
                        {
                            attendanceData = new AttendanceDto
                            {
                                PersonalId = personalId,
                                AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                                MorningIn = DateTime.Now.TimeOfDay.ToString()
                            };
                        }
                        else if (timeNow >= _afternoonInStart && timeNow <= _afternoonInEnd)
                        {
                            attendanceData = new AttendanceDto
                            {
                                PersonalId = personalId,
                                AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                                AfternoonIn = DateTime.Now.TimeOfDay.ToString()
                            };
                        }
                    }
                }
                

                if (attendanceData != null)
                {
                    var result = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiEndpoint.Attendance.LogAttendance, attendanceData);

                    if (result.isSuccess)
                    {
                        ToastNotify.Info(result.Data);
                        //MakeReport(result.Data, "INFO");
                        var _employeeInfo = await HttpHelper.GetAsync<ApiResponse<PersonalInformationDto>>(ApiEndpoint.Employee.GetPersonalInfoById + personalId);
                        if (_employeeInfo != null)
                        {
                            await ControlsHelper.ConvertByteToImageAsync(_employeeInfo.Data.EmployeeImage, EmployeePictureBox);
                            Invoke((Action)(() =>
                            {
                                NameLabel.Text = $"{_employeeInfo.Data.FirstName} {(string.IsNullOrEmpty(_employeeInfo.Data.MiddleName) ? "" : $"{_employeeInfo.Data.MiddleName[0]}. ")}{_employeeInfo.Data.LastName}";
                            }));
                            PopulateAttendanceView();

                        }
                    }
                    else
                    {
                        ToastNotify.Error(result.ErrorMessage);
                    }
                }
                else
                {
                    ToastNotify.Warning(errorMessage);
                }

            }
            catch (Exception ex)
            {
                //GunaMessage.ErrorMessage(_mainForm, ex.Message, "ERROR");
                SendStatus(ex.Message);
            }
        }



        public void OnCaptured(CaptureResult captureResult)
        {
            try
            {
                // Check capture quality and throw an error if bad.
                if (!_mainForm.CheckCaptureResult(captureResult)) return;

                //MakeReport("A finger was captured.");
                //MakeReport("A finger was captured", "INFO");

                DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(captureResult.Data, Constants.Formats.Fmd.ANSI);
                if (captureResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    throw new Exception(captureResult.ResultCode.ToString());
                }

                attendanceFmd = resultConversion.Data;

                // See the SDK documentation for an explanation on threshold scores.
                int thresholdScore = DPFJ_PROBABILITY_ONE * 1 / 100000;

                if (employeeFmds == null || employeeFmds.Count == 0)
                {
                    //MakeReport("No employee biometrics data found");
                    MakeReport("No employee biometrics found", "WARNING");
                    return;
                }

                IdentifyResult identifyResult = Comparison.Identify(attendanceFmd, 0, employeeFmds.Values.ToList(), thresholdScore, 2);

                //MakeReport($"Matched indexes: {string.Join(", ", identifyResult.Indexes.SelectMany(index => index).Select(i => i.ToString()))}");


                if (identifyResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    throw new Exception(identifyResult.ResultCode.ToString());
                }


                if (identifyResult.Indexes.Length > 0)
                {
                    var matchedEmployeeIds = new List<Guid?>();
                    foreach (var index in identifyResult.Indexes)
                    {
                        matchedEmployeeIds.Add(employeeFmds.Keys.ElementAt(index[0])); // Assuming index[0] is the index in the 
                    }
                    var personalId = matchedEmployeeIds.FirstOrDefault().ToString();
                    LogAttendance(Guid.Parse(personalId));



                    //MakeReport($"Matched employee IDs: {matchedEmployeeIds.FirstOrDefault().ToString()}");

                }
                else
                {
                    //MakeReport("No employee matched with fingerprint data.");
                    MakeReport("No employee matched with fingerprint data", "WARNING");
                }


            }
            catch (Exception ex)
            {
                
                if(ex.Message == "DP_DEVICE_FAILURE")
                {
                    _mainForm.CancelCaptureAndCloseReader(this.OnCaptured);
                    _mainForm.CurrentReader = null; 
                    //_mainForm._timer.Change(100, 1000);
                }
                else
                {
                    //MakeReport($"OnCapture Error: {ex.Message}");
                    Console.WriteLine($"OnCapture Error: {ex.Message}");
                }
                //_mainForm.ReaderDetector.Start();
                // Send error message, then close form
            }

        }


        public void StartCapture()
        {
            SetPrompt("Place a finger on the scanner");
            if (!_mainForm.OpenReader())
            {
                GunaMessage.Warning("No fingerprint scanner found.","WARNING");
            }
            if (this.IsHandleCreated && !_mainForm.StartCaptureAsync(this.OnCaptured))
            {
                GunaMessage.Warning("No fingers captured.", "WARNING");
            }
        }

        protected void SetPrompt(string prompt)
        {
            Invoke((Action)(() => Console.WriteLine(prompt)));
        }

        protected void MakeReport(string message, string type)
        {
            Invoke((Action)(() => ToastNotify.ShowToastr(message, type)));
            //Invoke((Action)(() => ReportLabel.Text += $"{message} \r\n")); 
        }


        protected void SendStatus(string status)
        {
            Invoke((Action)((() => GunaMessage.Error(status, "ERROR"))));
        }

        

        private void TimerProcess_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("T");
        }

        private void BiometricAttendance_Load(object sender, EventArgs e)
        {
            GetEmployeeBiometrics();
            //StartCapture();
            TimerProcess.Start();
            
            

        }


        

        private void ReportLabel_Leave(object sender, EventArgs e)
        {
            //StopCapture();
        }

        private void BiometricAttendance_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.CancelCaptureAndCloseReader(this.OnCaptured);
        }

        
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TimeInAmButton_Click(object sender, EventArgs e)
        {
            var manualAttendanceView = new AttendanceModal("TIME IN AM", _mainForm.EmployeeInfo, DateTime.Now);
            using (manualAttendanceView)
            {
                ControlsHelper.ShowModal(_mainForm, manualAttendanceView);
            }
            PopulateAttendanceView();
        }

        private void TimeOutAmButton_Click(object sender, EventArgs e)
        {
            var manualAttendanceView = new AttendanceModal("TIME OUT AM", _mainForm.EmployeeInfo, DateTime.Now);
            using (manualAttendanceView)
            {
                ControlsHelper.ShowModal(_mainForm, manualAttendanceView);
            }
            PopulateAttendanceView();
        }

        private void TimeInPmButton_Click(object sender, EventArgs e)
        {
            var manualAttendanceView = new AttendanceModal("TIME IN PM", _mainForm.EmployeeInfo, DateTime.Now);
            using (manualAttendanceView)
            {
                ControlsHelper.ShowModal(_mainForm, manualAttendanceView);
            }
            PopulateAttendanceView();
        }

        private void TimeOutPmButton_Click(object sender, EventArgs e)
        {
            var manualAttendanceView = new AttendanceModal("TIME OUT PM", _mainForm.EmployeeInfo, DateTime.Now);
            using (manualAttendanceView)
            {
                ControlsHelper.ShowModal(_mainForm, manualAttendanceView);
            }
            PopulateAttendanceView();
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
                    await PopulateView(attendanceLogs.Data);
                    return;
                }
                var filteredData = new List<AttendanceDisplayDto>();

                var filter = SearchBox.Text.ToLower();
                //FilterPersonnel(guna2TextBox1.Text);
                filteredData = attendanceLogs.Data.Where
                (
                    x => x.Name.ToLower().Contains(filter)
                ).ToList();
                await PopulateView(filteredData);


            }
        }
    }
}
