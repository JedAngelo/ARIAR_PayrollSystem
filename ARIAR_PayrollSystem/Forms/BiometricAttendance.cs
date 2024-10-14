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
        private List<Fmd> employeeFmds;
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

                // Initialize the list to hold Fmd objects
                employeeFmds = new List<Fmd>();

                // Iterate through the retrieved employee biometric data
                foreach (var employee in _employeeInfo.Data)
                {
                    // Assuming BiometricData is a byte array (or byte[] equivalent)
                    byte[] biometricData = employee.BiometricData;

                    int ConversionFormate = Convert.ToInt32(Constants.Formats.Fmd.ANSI);

                    Fmd fmd = new Fmd(biometricData, ConversionFormate, Constants.WRAPPER_VERSION);

                    // Add the Fmd object to the list
                    employeeFmds.Add(fmd);

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

                IdentifyResult identifyResult = Comparison.Identify(attendanceFmd, 0, employeeFmds, thresholdScore, 2);
                if (identifyResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    throw new Exception(identifyResult.ResultCode.ToString());
                }


                if (identifyResult.Indexes.Length > 0)
                {
                    MakeReport("Fingerprint matched with one of the employee");
                }
                else
                {
                    MakeReport("No employee matched with fingerprint data");
                }

            }
            catch (Exception ex)
            {
                MakeReport(ex.Message);
                
                //_mainForm.ReaderDetector.Start();
                // Send error message, then close form
            }

        }


        private void StartCapture()
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
            StartCapture();
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
    }
}
