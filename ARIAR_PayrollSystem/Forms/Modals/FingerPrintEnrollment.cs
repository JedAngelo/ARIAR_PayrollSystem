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
using static ARIAR_PayrollSystem.Forms.SystemMaintenance;
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
        private readonly PersonalInformationDisplayDto _employee;




        // Connection string to your database
        //private string connectionString = "YourConnectionStringHere";

        public FingerPrintEnrollment(MainForm mainForm, PersonalInformationDisplayDto employee)
        {
            InitializeComponent();
            preenrollmentFmds = new List<Fmd>();
            count = 0;
            _mainForm = mainForm;
            _employee = employee;
            NameLabel.Text = $"{_employee.FirstName} {(string.IsNullOrEmpty(_employee.MiddleName) ? "" : $"{_employee.MiddleName[0]}. ")}{_employee.LastName}";
            NameUnderline.Width = NameLabel.Width;



            //InitCapturer();
        }

        

        protected void UpdateStatus()
        {
            //SetStatus(String.Format("Fingerprint sample needed {0}", _enroller.FeaturesNeeded));

        }
        protected void SetPrompt(string prompt)
        {
            Invoke((Action)(() => PrompLabel.Text = prompt));
        }

        protected void SetStatus(string status)
        {
            Invoke((Action)(() => ToastNotify.Info(status)));
        }

        protected void MakeReport(string message)
        {
            Invoke((Action)(() => Console.WriteLine(message)));
        }







        private async Task SaveFingerprintEnrollment(Fmd enrollmentFmd)
        {
            try
            {
                // Prepare the DTO
                var empployeeBiometric = new EmployeeBiometricsDto
                {
                    BiometricData = enrollmentFmd.Bytes,
                    PersonalId = _employee.PersonalId,
                    RecordDate = DateTime.Now,
                };

                var _result = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiEndpoint.Biometric.AddBiometric, empployeeBiometric);
                if (_result.isSuccess)
                {
                    GunaMessage.Info(_result.Data, "INFO");
                    Invoke((Action)(() => this.Close()));
                }
                else
                {
                    GunaMessage.Error( _result.ErrorMessage, "ERROR");
                }
            }
            catch (Exception ex)
            {
                GunaMessage.Error("Error while saving fingerprint enrollment: " + ex.Message, "ERROR");
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

                if (count <= 4)
                {
                    if (count > 1) progressLine.Value++;
                    if (count == 1) firstStep.FillColor = Color.FromArgb(255, 188, 1);
                }



                DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(captureResult.Data, Constants.Formats.Fmd.ANSI);

                // Update the report and prompt on the UI thread
                MakeReport($"A finger was captured. \r\nCount: {count}\r\n");
                //DrawPicture(_mainForm.ConvertToBitmap(captureResult));

                if (resultConversion.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    throw new Exception(resultConversion.ResultCode.ToString());
                }

                preenrollmentFmds.Add(resultConversion.Data);

                if (count >= 3)
                {
                    DataResult<Fmd> resultEnrollment = Enrollment.CreateEnrollmentFmd(Constants.Formats.Fmd.ANSI, preenrollmentFmds);

                    if (resultEnrollment.ResultCode == Constants.ResultCode.DP_SUCCESS)
                    {
                        MakeReport("An enrollment FMD was successfully created.\r\n");
                        SetPrompt("Fingerprint scan complete.");
                        preenrollmentFmds.Clear();
                        count = 0;
                        await SaveFingerprintEnrollment(resultEnrollment.Data);
                        return;

                    }
                    else if (resultEnrollment.ResultCode == Constants.ResultCode.DP_ENROLLMENT_INVALID_SET)
                    {
                        MakeReport("Enrollment was unsuccessful. Please try again.");
                        SetPrompt("Start scanning when you're ready, just place your finger on the scanner.");
                        preenrollmentFmds.Clear();
                        count = 0;
                        return;
                    }
                }

                switch (count)
                {
                    case 1:
                        SetPrompt($"Now place the same finger on the scanner again for the 2nd time.");
                        break;
                    case 2:
                        SetPrompt($"Now place the same finger on the scanner again for the 3rd time.");
                        break;
                    case 3:
                        SetPrompt($"Now place the same finger on the scanner again for the last time.");
                        break;
                    default:
                        SetPrompt($"Now place the same finger on the scanner again.");
                        break;
                }


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
            SetPrompt("Start scanning when you're ready, just place your finger on the scanner.");
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

        private void StopCapture()
        {
            // Clear any temporary data
            preenrollmentFmds.Clear(); // Clear the list of captured fingerprints
            count = 0; // Reset the count of captured fingerprints

            // Optionally, you might want to reset any UI elements
            PrompLabel.Text = "Exiting...";
            fingerImage.Image = null; // Clear the displayed fingerprint image//StopCapture();

        }
        private void FingerPrintEnrollment_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.CancelCaptureAndCloseReader(this.OnCaptured);
        }

        private void PersonalIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressLine_ValueChanged(object sender, EventArgs e)
        {
            switch (progressLine.Value)
            {
                case 0:
                    firstStep.FillColor = Color.White;
                    secondStep.FillColor = Color.White;
                    thirdStep.FillColor = Color.White;
                    return;
                case 1:
                    secondStep.FillColor = Color.FromArgb(255, 188, 1);
                    return;
                case 2:
                    thirdStep.FillColor = Color.FromArgb(255, 188, 1);
                    return;
                case 3:
                    fourthStep.FillColor = Color.FromArgb(255, 188, 1);
                    return;
            }


        }
    }
}