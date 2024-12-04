using ARIAR_PayrollSystem.Forms.Modals;
using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
using ARIAR_PayrollSystem.UserControls;
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
            TimeLabel.Text = DateTime.Now.ToString("T");
            DateLabel.Text = DateTime.Now.Date.ToString("MMMM d, yyyy");
            ProgressCircle.Visible = true;
            ProgressCircle.Value = 0;
            PopulateAttendanceView("*"); 

        }

       

        private async void PopulateAttendanceView(string type)
        {
            try
            {
                var DateNowString = DateTime.Now.Date.ToString("yyyy-MM-dd");
                attendanceLogs = await HttpHelper.GetAsync<ApiResponse<List<AttendanceDataLog>>>($"{ApiEndpointHelper.Attendance.GetAttendanceLogShort}{DateNowString}");
                if (attendanceLogs == null)
                {
                    GunaMessage.Error("Can't retrieve attendance logs!", "ERROR");
                    return;
                }
                attendanceLogs.Data.ForEach(a =>
                {
                    a.Log = TimeOnly.Parse(a.Log).ToString("t");
                });

                if (attendanceLogs.isSuccess)
                {
                    if (String.Equals(type, "*"))
                    {
                        ProgressCircle.Visible = true;
                        ProgressCircle.Maximum = attendanceLogs.Data.Count();
                        await AttendanceLogView.DataViewAsync(attendanceLogs.Data, AttendanceView);
                        for (int i = 0; i < attendanceLogs.Data.Count; i++)
                        {
                            ProgressCircle.Value = i + 1;
                            await Task.Delay(50);
                        }
                        if (attendanceLogs.Data.Count() > 4)
                        {
                            ToastNotify.Info(attendanceLogs.Data.Count().ToString());
                            foreach (Control control in AttendanceView.Controls)
                            {
                                if (control.Name == "AttendanceLogView")
                                {
                                    control.Width -= 15;
                                }
                            }
                        }
                        ProgressCircle.Visible = false;
                        LoadingLabel.Visible = false;
                        AttendanceView.Visible = true;

                    }
                    else if (String.Equals(type, "LAST"))
                    {                       

                        await AttendanceLogView.DataViewAddAsync(attendanceLogs.Data.LastOrDefault(), AttendanceView);
                        if (attendanceLogs.Data.Count() > 4)
                        {
                            PopulateAttendanceView("*");
                        }
                    }
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
                var _employeeInfo = await HttpHelper.GetAsync<ApiResponse<List<EmployeeBiometricsDto>>>(ApiEndpointHelper.Biometric.GetBiometric);

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

                var result = await HttpHelper.PostAsync<ApiResponse<bool>, dynamic>(ApiEndpointHelper.Attendance.HasMorningIn, attendanceData);
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
                var timeNow = DateTime.Now.TimeOfDay;

                if (timeNow > _morningInStart && timeNow < _morningInEnd)
                {
                    attendanceData = new AttendanceDto
                    {
                        PersonalId = personalId,
                        AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                        MorningIn = DateTime.Now.TimeOfDay.ToString()
                    };

                }

                if (timeNow > _afternoonOutStart && timeNow < _afternoonOutEnd)
                {
                    attendanceData = new AttendanceDto
                    {
                        PersonalId = personalId,
                        AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                        AfternoonOut = DateTime.Now.TimeOfDay.ToString()
                    };
                }

                if (!hasMorningIn && timeNow > _afternoonInStart && timeNow < _afternoonInEnd)
                {
                    attendanceData = new AttendanceDto
                    {
                        PersonalId = personalId,
                        AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                        AfternoonIn = DateTime.Now.TimeOfDay.ToString()
                    };
                }

                if (hasMorningIn && timeNow > _morningOutStart && timeNow < _morningOutEnd)
                {
                    attendanceData = new AttendanceDto
                    {
                        PersonalId = personalId,
                        AttendanceDate = DateTime.Now.Date.ToString("yyyy-MM-dd"),
                        MorningOut = DateTime.Now.TimeOfDay.ToString()
                    };
                }


                if (attendanceData != null)
                {
                    var result = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiEndpointHelper.Attendance.LogAttendance, attendanceData);

                    if (result.isSuccess)
                    {
                        ToastNotify.Info(result.Data);
                        //MakeReport(result.Data, "INFO");
                        var _employeeInfo = await HttpHelper.GetAsync<ApiResponse<PersonalInformationDto>>(ApiEndpointHelper.Employee.GetPersonalInfoById + personalId);
                        if (_employeeInfo != null)
                        {
                            await ControlsHelper.ConvertByteToImageAsync(_employeeInfo.Data.EmployeeImage, pictureBox2);
                            Invoke((Action)(() =>
                            {
                                NameLabel.Text = $"{_employeeInfo.Data.FirstName} {(string.IsNullOrEmpty(_employeeInfo.Data.MiddleName) ? "" : $"{_employeeInfo.Data.MiddleName[0]}. ")}{_employeeInfo.Data.LastName}";
                            }));
                            PopulateAttendanceView("LAST");

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
                GunaMessage.Warning("No fingerprint scanner found.","WARNING");
            }
            if (this.IsHandleCreated && !_mainForm.StartCaptureAsync(this.OnCaptured))
            {
                GunaMessage.Warning("No fingers captured.", "WARNING");
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
            Invoke((Action)((() => GunaMessage.Error(status, "ERROR"))));
        }

        

        private void BiometricAttPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
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

        
    }
}
