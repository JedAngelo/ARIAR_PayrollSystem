using ARIAR_PayrollSystem.Forms.Modals;
using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.UserControls;
using DPUruNet;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static DPUruNet.Fid;

namespace ARIAR_PayrollSystem.Forms
{
    public partial class MainForm : Form
    {
        private BiometricAttendance _biometricAttendance;
        private EmployeeInformation _employeeInformation;
        private SystemMaintenance _systemMaintenance;
        private Test _testForm;

        private SplashScreen _splashScreen;
        private bool _isSidebarCol = false;
        private bool isFullscreen = true;
        private bool _isReaderReset = false;

        public MainForm()
        {
            InitializeComponent();

            _testForm = new Test(this);
            _biometricAttendance = new BiometricAttendance(this);
            _employeeInformation = new EmployeeInformation(this);
            _systemMaintenance = new SystemMaintenance(this);
            _splashScreen = new SplashScreen();

            ReaderDetector.Start();
            //SetCurrentReader();
            //this.Controls.Add(_splashScreen.SplashScreenTLP);
            //this.tableLayoutPanel1.Visible = false;

            //this.MinimumSize = new Size(1422, 888);


        }

      
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            if (!_isSidebarCol)
            {
                SidebarHelper.ChangeColWidth(tableLayoutPanel1, false);
                LogoPanel.Height = 0;
                _isSidebarCol = true;
            }
            else
            {
                SidebarHelper.ChangeColWidth(tableLayoutPanel1, true);
                LogoPanel.Height = 112;
                _isSidebarCol = false;
            }
            transition.Show(SwitchPanel);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (isFullscreen)
                {

                    //this.FormBorderStyle = FormBorderStyle.Sizable;
                    this.WindowState = FormWindowState.Maximized;
                    isFullscreen = false;
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Normal;
                    //this.Bounds = Screen.FromControl(this).Bounds;
                    
                    isFullscreen = true;
                }
            }
            transition.Show(SwitchPanel);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            //this.Bounds = Screen.PrimaryScreen.Bounds;


            Switcher.SwitchPanel(SwitchPanel, _employeeInformation);
            Switcher.SwitchPanel(SwitchPanel, _systemMaintenance);
            //Switcher.SwitchPanel(SwitchPanel, _biometricAttendance);
            transition.Show(SwitchPanel);
            

            //waitScreen1.Visible = false;

            //await Task.Delay(5000);
            //_splashScreen.SplashScreenTLP.Visible = false;
            //this.tableLayoutPanel1.Visible = true;
            //this.Controls.Remove(_splashScreen.SplashScreenTLP);
            //_BiometricAttendance.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
                if (isFullscreen)
                {

                    //this.FormBorderStyle = FormBorderStyle.Sizable;
                    this.WindowState = FormWindowState.Maximized;
                    isFullscreen = false;
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Normal;
                    this.Bounds = Screen.FromControl(this).Bounds;
                    isFullscreen = true;
                }
            }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void EmployeeInformationBtn_Click(object sender, EventArgs e)
        {

            Switcher.SwitchPanel(SwitchPanel, _employeeInformation);
            transition.Show(SwitchPanel);
            //elapsedTick = 0;
            //waitClock.Start();
        }

        

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BiometricAttendanceBtn_Click(object sender, EventArgs e)
        {
            if (currentReader == null)
            {
                GunaMessage.WarningMessage(this, "Please connect a fingerprint reader first!", "WARNING");
            }
            else
            {
                Switcher.SwitchPanel(SwitchPanel, _biometricAttendance);
                transition.Show(SwitchPanel);
            }


        }

        private void SystemMaintenanceBtn_Click(object sender, EventArgs e)
        {
            Switcher.SwitchPanel(SwitchPanel, _systemMaintenance);
            transition.Show(SwitchPanel);
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            Switcher.SwitchPanel(SwitchPanel, _testForm);
            transition.Show(SwitchPanel);

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }







        #region Fingerprint init


        public Reader CurrentReader
        {
            get { return currentReader; }
            set
            {
                currentReader = value;
            }
        }
        private Reader currentReader;

        private void SetCurrentReader()
        {
            ReaderCollection readers = ReaderCollection.GetReaders();

            if (readers.Count > 0)
            {
                CurrentReader = readers[0]; // Set the first available reader
                _isReaderReset = false; // Reset the flag if a reader is found
            }
            else
            {
                if (!_isReaderReset)
                {
                    GunaMessage.ErrorMessage(this, "No fingerprint readers found, please connect a reader.", "Reader Error");
                    _isReaderReset = true; // Set the flag to true to prevent further messages
                }
            }
        }

        public bool OpenReader()
        {
            Constants.ResultCode result = Constants.ResultCode.DP_DEVICE_FAILURE;
            // Open reader
            

            if (currentReader == null)
            {
                GunaMessage.ErrorMessage(this, "Can't initialized fingerprint reader!", "ERROR");
                return false;
            }
            
            result = currentReader.Open(Constants.CapturePriority.DP_PRIORITY_COOPERATIVE);

            if (result != Constants.ResultCode.DP_SUCCESS)
            {
                GunaMessage.ErrorMessage(ParentForm, $"Error: {result}", "ERROR");
                return false;
            }

            return true;
        }

        public bool StartCaptureAsync(Reader.CaptureCallback OnCaptured)
        {
            if (currentReader == null)
            {
                return false;
            }
            // Activate capture handler
            currentReader.On_Captured += new Reader.CaptureCallback(OnCaptured);

            // Call capture
            if (!CaptureFingerAsync())
            {
                return false;
            }

            return true;
        }

        public void CancelCaptureAndCloseReader(Reader.CaptureCallback OnCaptured)
        {
            if (currentReader != null)
            {
                currentReader.CancelCapture();
                // Dispose of reader handle and unhook reader events.
                currentReader.Dispose();
            }
        }

        public Bitmap ConvertToBitmap(CaptureResult captureResult)
        {
            // Assuming captureResult.Data contains the raw fingerprint image data.
            Fid fid = captureResult.Data; // CaptureResult.Data returns a Fid object in DPUrUNet.

            // Get the first image view from the Fid data
            Fiv fiv = fid.Views[0];

            // Extract image information
            int width = fiv.Width;
            int height = fiv.Height;
            byte[] imageData = fiv.RawImage;

            // Convert the raw data to a bitmap
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            // Lock the bitmap data
            BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                                                 ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            // Create RGB bytes from grayscale fingerprint data (duplicate for R, G, B channels)
            byte[] rgbBytes = new byte[imageData.Length * 3];
            for (int i = 0; i < imageData.Length; i++)
            {
                rgbBytes[i * 3] = imageData[i];
                rgbBytes[i * 3 + 1] = imageData[i];
                rgbBytes[i * 3 + 2] = imageData[i];
            }

            // Copy the RGB values to the bitmap
            for (int i = 0; i < height; i++)
            {
                IntPtr rowPointer = new IntPtr(bmpData.Scan0.ToInt64() + (i * bmpData.Stride));
                System.Runtime.InteropServices.Marshal.Copy(rgbBytes, i * width * 3, rowPointer, width * 3);
            }

            // Unlock the bits to finish the conversion
            bitmap.UnlockBits(bmpData);

            return bitmap;
        }

        public void GetStatus()
        {
            Constants.ResultCode result = currentReader.GetStatus();

            if ((result != Constants.ResultCode.DP_SUCCESS))
            {
                throw new Exception("" + result);
            }

            if ((currentReader.Status.Status == Constants.ReaderStatuses.DP_STATUS_BUSY))
            {
                Thread.Sleep(50);
            }
            else if ((currentReader.Status.Status == Constants.ReaderStatuses.DP_STATUS_NEED_CALIBRATION))
            {
                currentReader.Calibrate();
            }
            else if ((currentReader.Status.Status != Constants.ReaderStatuses.DP_STATUS_READY))
            {
                throw new Exception("Reader Status - " + currentReader.Status.Status);
            }
        }

        

        public bool CaptureFingerAsync()
        {
            
            try
            {
                GetStatus();

                Constants.ResultCode captureResult = currentReader.CaptureAsync(Constants.Formats.Fid.ANSI, Constants.CaptureProcessing.DP_IMG_PROC_DEFAULT, currentReader.Capabilities.Resolutions[0]);
                if (captureResult != Constants.ResultCode.DP_SUCCESS)
                {
                    throw new Exception("" + captureResult);
                }

                return true;
            }
            catch (Exception ex)
            {
                GunaMessage.ErrorMessage(ParentForm, $"Error: {ex.Message}", "ERROR");
                return false;
            }
        }

        public bool CheckCaptureResult(CaptureResult captureResult)
        {
            if (captureResult.Data == null)
            {
                if (captureResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    throw new Exception(captureResult.ResultCode.ToString());
                }

                // Send message if quality shows fake finger
                if ((captureResult.Quality != Constants.CaptureQuality.DP_QUALITY_CANCELED))
                {
                    throw new Exception("Quality - " + captureResult.Quality);
                }
                return false;
            }

            return true;
        }

       



        #endregion

        private void SwitchPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            //if (SwitchPanel.Controls[0] == _biometricAttendance)
            //{
            //    _biometricAttendance.Close();
            //}
        }


        private bool isReaderDetectionInProgress = false;

        private void ReaderDetector_Tick(object sender, EventArgs e)
        {
            if (!isReaderDetectionInProgress)
            {
                isReaderDetectionInProgress = true; // Set the flag to true

                if (currentReader == null)
                {
                    SetCurrentReader();
                }
                else
                {
                    ReaderDetector.Stop();
                }

                isReaderDetectionInProgress = false; // Reset the flag after the check
            }
        }


    }
}
