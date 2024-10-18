using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
using DPUruNet;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DPUruNet.Fid;
using FeatureExtraction = DPUruNet.FeatureExtraction;

namespace ARIAR_PayrollSystem.Forms.Modals
{
    public partial class FingerPrintEnrollment : Form
    {
        public readonly HttpClient client = new HttpClient();


        //private Reader currentReader;
        private List<Fmd> preenrollmentFmds;
        private int count;
        public MainForm _mainForm;

        

        // Connection string to your database
        //private string connectionString = "YourConnectionStringHere";

        public FingerPrintEnrollment(MainForm mainForm)
        {
            InitializeComponent();
            preenrollmentFmds = new List<Fmd>();
            count = 0;
            _mainForm = mainForm;
            //InitCapturer();
        }

        

        protected void UpdateStatus()
        {
            //SetStatus(String.Format("Fingerprint sample needed {0}", _enroller.FeaturesNeeded));

        }
        protected void SetPrompt(string prompt)
        {
            Invoke((Action)(() => PromptTextBox.Text = prompt));
        }

        protected void SetStatus(string status)
        {
            Invoke((Action)(() => StatusLabel.Text = status));
        }

        protected void MakeReport(string message)
        {
            Invoke((Action)(() => StatusTextBox.Text += message));
        }


        


        
        private async Task SaveFingerprintEnrollment(Fmd enrollmentFmd, Guid personalId)
        {
            try
            {
                // Prepare the DTO
                var empployeeBiometric = new EmployeeBiometrics
                {
                    BiometricData = enrollmentFmd.Bytes,
                    PersonalId = personalId,
                    RecordDate = DateTime.Now,
                };

                var _result = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiHelper.ApiAddBiometric, empployeeBiometric);
                if (_result.isSuccess)
                {
                    GunaMessage.InfoMessage(ParentForm, _result.Data, "INFO");
                }
                else
                {
                    GunaMessage.ErrorMessage(ParentForm, _result.ErrorMessage, "ERROR");
                }
            }
            catch (Exception ex)
            {
                GunaMessage.ErrorMessage(ParentForm, "Error while saving fingerprint enrollment: " + ex.Message, "ERROR");
            }
        }


        private void DrawPicture(Bitmap bitmap)
        {
            fingerImage.Image = new Bitmap(bitmap, fingerImage.Size);
        }

        

        

        private async void OnCaptured(CaptureResult captureResult)
        {
            try
            {
                // Check capture quality and throw an error if bad.
                if (!_mainForm.CheckCaptureResult(captureResult)) return;

                count++;

                DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(captureResult.Data, Constants.Formats.Fmd.ANSI);

                // Update the report and prompt on the UI thread
                MakeReport($"A finger was captured. \r\nCount: {count}\r\n");
                DrawPicture(_mainForm.ConvertToBitmap(captureResult));

                if (resultConversion.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    throw new Exception(resultConversion.ResultCode.ToString());
                }

                preenrollmentFmds.Add(resultConversion.Data);

                if (count >= 4)
                {
                    DataResult<Fmd> resultEnrollment = Enrollment.CreateEnrollmentFmd(Constants.Formats.Fmd.ANSI, preenrollmentFmds);

                    if (resultEnrollment.ResultCode == Constants.ResultCode.DP_SUCCESS)
                    {
                        MakeReport("An enrollment FMD was successfully created.\r\n");
                        SetPrompt("Place a finger on the reader.");
                        preenrollmentFmds.Clear();
                        count = 0;
                        await SaveFingerprintEnrollment(resultEnrollment.Data, Guid.Parse(PersonalIDTextBox.Text));
                        return;

                    }
                    else if (resultEnrollment.ResultCode == Constants.ResultCode.DP_ENROLLMENT_INVALID_SET)
                    {
                        MakeReport("Enrollment was unsuccessful. Please try again.");
                        SetPrompt("Place a finger on the reader.");
                        preenrollmentFmds.Clear();
                        count = 0;
                        return;
                    }
                }

                SetPrompt("Now place the same finger on the reader.");
            }
            catch (Exception ex)
            {
                // Send error message, then close form
                SetStatus($"Error: {ex.Message}");
            }
        }




        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //CaptureTimer.Start();
        }

        private void TimerProcess_Tick(object sender, EventArgs e)
        {
        }

        private void FingerPrintEnrollment_Load(object sender, EventArgs e)
        {
            count = 0;
            preenrollmentFmds = new List<Fmd>();
            SetPrompt("Place a finger on the scanner");
            if (!_mainForm.OpenReader())
            {
                //SetStatus("No fingerprint scanner found.");
                //GunaMessage.ErrorMessage(this, "Can't initialized fingerprint reader!", "ERROR");
                this.Close();
            }
            if (!_mainForm.StartCaptureAsync(this.OnCaptured))
            {
                SetStatus("No fingers captures.");
            }

        }

        private void StartCapture()
        {
            
        }


        private void StopCapture()
        {
            // Clear any temporary data
            preenrollmentFmds.Clear(); // Clear the list of captured fingerprints
            count = 0; // Reset the count of captured fingerprints

            // Optionally, you might want to reset any UI elements
            PromptTextBox.Clear();
            StatusLabel.Text = string.Empty;
            fingerImage.Image = null; // Clear the displayed fingerprint image//StopCapture();

        }
        private void FingerPrintEnrollment_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.CancelCaptureAndCloseReader(this.OnCaptured);
        }
    }
}