using ARIAR_PayrollSystem.Forms.Modals;
using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
using DPUruNet;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;

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


        public BiometricAttendance(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }



        private async void GetEmployeeBiometrics()
        {
            try
            {
                var _employeeInfo = await HttpHelper.GetAsync<ApiResponse<List<EmployeeBiometrics>>>(ApiHelper.ApiGetBiometric);

                if (_employeeInfo == null)
                {
                    GunaMessage.ErrorMessage(_mainForm, "Can't retrieve employee info!", "ERROR");
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
                GunaMessage.ErrorMessage(ParentForm, $"Error retrieving employee biometrics: {ex.Message}", "ERROR");
            }
        }




        private void OnCaptured(CaptureResult captureResult)
        {
            try
            {
                // Check capture quality and throw an error if bad.
                if (!_mainForm.CheckCaptureResult(captureResult)) return;

                MakeReport("A finger was captured.");

                DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(captureResult.Data, Constants.Formats.Fmd.ANSI);
                if (captureResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    throw new Exception(captureResult.ResultCode.ToString());
                }

                attendanceFmd = resultConversion.Data;

                // See the SDK documentation for an explanation on threshold scores.
                int thresholdScore = DPFJ_PROBABILITY_ONE * 1 / 100000;

                if (employeeFmds == null)
                {
                    MakeReport("No employee biometrics data found");
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
                        matchedEmployeeIds.Add(employeeFmds.Keys.ElementAt(index[0])); // Assuming index[0] is the index in the employeeFmds
                    }

                    MakeReport($"Matched employee IDs: {string.Join(", ", matchedEmployeeIds.Select(id => id.ToString()))}");
                }
                else
                {
                    MakeReport("No employee matched with fingerprint data.");
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
                    MakeReport(ex.Message);
                }
                //_mainForm.ReaderDetector.Start();
                // Send error message, then close form
            }

        }


        public void StartCapture()
        {
            GetEmployeeBiometrics();
            SetPrompt("Place a finger on the scanner");
            if (!_mainForm.OpenReader())
            {
                GunaMessage.WarningMessage(ParentForm,"No fingerprint scanner found.","WARNING");
            }
            if (!_mainForm.StartCaptureAsync(this.OnCaptured))
            {
                GunaMessage.WarningMessage(ParentForm, "No fingers captures.", "WARNING");
            }
        }

        protected void SetPrompt(string prompt)
        {
            Invoke((Action)(() => PromptLabel.Text = prompt));
        }

        protected void MakeReport(string message)
        {
            Invoke((Action)(() => ReportLabel.Text += $"{message} \r\n")); 
        }

        protected void SendStatus(string status)
        {
            Invoke((Action)((() => GunaMessage.ErrorMessage(ParentForm, status, "ERROR"))));
        }

        private void BiometricAttPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TimerProcess.Start();
        }

        private void TimerProcess_Tick(object sender, EventArgs e)
        {
            //StartCapture();
        }

        private void BiometricAttendance_Load(object sender, EventArgs e)
        {
            //StartCapture();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StartCapture();
        }
    }
}
