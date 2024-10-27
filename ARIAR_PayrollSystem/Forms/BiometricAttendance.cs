using ARIAR_PayrollSystem.Forms.Modals;
using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
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

namespace ARIAR_PayrollSystem.Forms
{
    public partial class BiometricAttendance : Form
    {
        MainForm _mainForm;
        public readonly HttpClient client = new HttpClient();
        private const int DPFJ_PROBABILITY_ONE = 0x7fffffff;
        private Dictionary<Guid?, Fmd> employeeFmds;
        private Fmd attendanceFmd;
        private int count;
        private ApiResponse<List<AttendanceDataLog>> attendanceLogs;


        private TimeSpan _morningInStart = new TimeSpan(5, 0, 0);
        private TimeSpan _morningInEnd = new TimeSpan(8, 30, 0);

        private TimeSpan _afternoonInStart = new TimeSpan(11, 0, 0);
        private TimeSpan _afternoonInEnd = new TimeSpan(13, 0, 0);

        private TimeSpan _morningOutStart = new TimeSpan(11, 30, 0);
        private TimeSpan _morningOutEnd = new TimeSpan(12, 30, 0);

        private TimeSpan _afternoonOutStart = new TimeSpan(16, 30, 0);
        private TimeSpan _afternoonOutEnd = new TimeSpan(17, 30, 0);

        public BiometricAttendance(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
            GetAttendanceLogs();

        }

        private void FilterAttendanceLogs(string searchItem)
        {
            if (attendanceLogs.Data == null)
            {
                ToastNotify.Error("No item found with that keyword");
                return;
            }

            var filteredLogs = attendanceLogs.Data
                            .Where(x => x.Name.ToLower().Contains(searchItem.ToLower()))
                            .ToList();

            UpdateDataGrid(filteredLogs);

        }


        private async void GetAttendanceLogs()
        {
            try
            {
                var DateNowString = DateTime.Now.Date.ToString("yyyy-MM-dd");
                //GunaMessage.Info(_mainForm,$"{ApiHelper.Attendance.GetAttendanceLogShort}{DateTime.Now.Date.ToString("yyyy-MM-dd")}","DATA");
                attendanceLogs = await HttpHelper.GetAsync<ApiResponse<List<AttendanceDataLog>>>($"{ApiHelper.Attendance.GetAttendanceLogShort}{DateNowString}");
                //Console.Write(attendanceLogs.Data);
                if (attendanceLogs == null)
                {
                    GunaMessage.Error(_mainForm, "Can't retrieve attendance logs!", "ERROR");
                    return;
                }
                attendanceLogs.Data.ForEach(a =>
                {
                    a.Log = TimeOnly.Parse(a.Log).ToString("h:mm tt");
                });


                UpdateDataGrid(attendanceLogs.Data);
                

            }
            catch (Exception ex)
            {
                GunaMessage.Error(_mainForm, ex.Message, "ERROR");
            }
        }

        private async void GetEmployeeBiometrics()
        {
            try
            {
                var _employeeInfo = await HttpHelper.GetAsync<ApiResponse<List<EmployeeBiometrics>>>(ApiHelper.Biometric.GetBiometric);

                if (_employeeInfo == null)
                {
                    GunaMessage.Error(_mainForm, "Can't retrieve employee info!", "ERROR");
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
                GunaMessage.Error(ParentForm, $"Error retrieving employee biometrics: {ex.Message}", "ERROR");
            }
        }

        private async Task<bool> HasMorningIn(Guid personalId)
        {
            try
            {
                var attendanceData = new Attendance
                {
                    PersonalId = personalId,
                    AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd")
                };

                var result = await HttpHelper.PostAsync<ApiResponse<bool>, dynamic>(ApiHelper.Attendance.HasMorningIn, attendanceData);
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
                Attendance attendanceData = null;
                var timeNow = DateTime.Now.TimeOfDay;

                if (timeNow > _morningInStart && timeNow < _morningInEnd)
                {
                    attendanceData = new Attendance
                    {
                        PersonalId = personalId,
                        AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                        MorningIn = DateTime.Now.TimeOfDay.ToString()
                    };

                }

                if (timeNow > _afternoonOutStart && timeNow < _afternoonOutEnd)
                {
                    attendanceData = new Attendance
                    {
                        PersonalId = personalId,
                        AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                        AfternoonOut = DateTime.Now.TimeOfDay.ToString()
                    };
                }

                if (!hasMorningIn && timeNow > _afternoonInStart && timeNow < _afternoonInEnd)
                {
                    attendanceData = new Attendance
                    {
                        PersonalId = personalId,
                        AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                        AfternoonIn = DateTime.Now.TimeOfDay.ToString()
                    };
                }

                if (hasMorningIn && timeNow > _morningOutStart && timeNow < _morningOutEnd)
                {
                    attendanceData = new Attendance
                    {
                        PersonalId = personalId,
                        AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                        MorningOut = DateTime.Now.TimeOfDay.ToString()
                    };
                }


                if (attendanceData != null)
                {
                    var result = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiHelper.Attendance.LogAttendance, attendanceData);

                    if (result.isSuccess)
                    {
                        ToastNotify.Info(result.Data);
                        //MakeReport(result.Data, "INFO");
                        var _employeeInfo = await HttpHelper.GetAsync<ApiResponse<PersonalInformation>>(ApiHelper.Employee.GetPersonalInfoById + personalId);
                        if (_employeeInfo != null)
                        {
                            await ControlsHelper.ConvertByteToImageAsync(_employeeInfo.Data.EmployeeImage, pictureBox2);
                            Invoke((Action)(() =>
                            {
                                NameLabel.Text = $"{_employeeInfo.Data.FirstName} {(string.IsNullOrEmpty(_employeeInfo.Data.MiddleName) ? "" : $"{_employeeInfo.Data.MiddleName[0]}. ")}{_employeeInfo.Data.LastName}";
                            }));
                            GetAttendanceLogs();
                        }

                        //GunaMessage.InfoMessage(_mainForm, result.Data, "Attendance Logged");
                    }
                    else
                    {
                        //MakeReport($"Attendance not logged: {result.ErrorMessage}");
                        //MakeReport(result.ErrorMessage, "ERROR");
                        ToastNotify.Error(result.ErrorMessage);
                        //GunaMessage.ErrorMessage(_mainForm, result.ErrorMessage, "Attendance not logged!");
                    }
                }
                else
                {
                    //MakeReport("INVALID: Time does not match time in or out range");
                    //MakeReport("Time does not match time in or out range", "ERROR");
                    ToastNotify.Error("Time does not match time in or out range");
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
                GunaMessage.Warning(ParentForm,"No fingerprint scanner found.","WARNING");
            }
            if (this.IsHandleCreated && !_mainForm.StartCaptureAsync(this.OnCaptured))
            {
                GunaMessage.Warning(ParentForm, "No fingers captured.", "WARNING");
            }
        }

        protected void SetPrompt(string prompt)
        {
            Invoke((Action)(() => PromptLabel.Text = prompt));
        }

        protected void MakeReport(string message, string type)
        {
            Invoke((Action)(() => ToastNotify.ShowToastr(message, type)));
            //Invoke((Action)(() => ReportLabel.Text += $"{message} \r\n")); 
        }


        protected void SendStatus(string status)
        {
            Invoke((Action)((() => GunaMessage.Error(ParentForm, status, "ERROR"))));
        }

        private void UpdateDataGrid<T>(T data)
        {
            Invoke((Action)(() =>
            {
                AttendanceDataGrid.DataSource = data;
                AttendanceDataGrid.ClearSelection();
            }));
        }

        private void BiometricAttPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void TimerProcess_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void BiometricAttendance_Load(object sender, EventArgs e)
        {
            GetEmployeeBiometrics();
            //StartCapture();
            TimerProcess.Start();
            DateLabel.Text = DateTime.Now.Date.ToString("MMMM d, yyyy");
            

        }


        private void ReportLabel_TextChanged(object sender, EventArgs e)
        {

            ReportLabel.SelectionStart = ReportLabel.Text.Length;
            ReportLabel.ScrollToCaret();
            
        }

        private void ReportLabel_Leave(object sender, EventArgs e)
        {
            //StopCapture();
        }

        private void BiometricAttendance_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.CancelCaptureAndCloseReader(this.OnCaptured);
        }

        private void AttendanceDataGrid_Leave(object sender, EventArgs e)
        {
            AttendanceDataGrid.ClearSelection();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            FilterAttendanceLogs(SearchBox.Text);
            if (String.IsNullOrEmpty(SearchBox.Text))
            {
                UpdateDataGrid(attendanceLogs.Data);
            }
        }
    }
}
