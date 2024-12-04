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
using System.Management;
using static DPUruNet.Fid;

namespace ARIAR_PayrollSystem.Forms
{
    public partial class MainForm : Form
    {
        private BiometricAttendance _biometricAttendance;
        private EmployeeInformation _employeeInformation;
        private SystemMaintenance _systemMaintenance;
        private Test _testForm;
        private AttendanceManagement _attendanceManagement;
        private bool IsBiometricLoading = false;
        private SplashScreen _splashScreen;
        public System.Threading.Timer _ReaderDetection;
        private bool _isSidebarCol = false;
        private bool isFullscreen = true;
        private bool _isReaderReset = false;
        private ManagementEventWatcher connectWatcher;
        private ManagementEventWatcher disconnectWatcher;
        private ConsoleLogsModal _consoleLogs;


        public MainForm()
        {
            InitializeComponent();

            _testForm = new Test(this);
            //_biometricAttendance = new BiometricAttendance(this);
            _employeeInformation = new EmployeeInformation(this);
            _systemMaintenance = new SystemMaintenance(this);
            _attendanceManagement = new AttendanceManagement(this);
            _splashScreen = new SplashScreen();
            _consoleLogs = new ConsoleLogsModal();
            _consoleLogs.Show();
            _consoleLogs.Hide();

            //ReaderDetector.Start();

            //_ReaderDetection = new System.Threading.Timer(ReaderDetectionEvent, null, 1000, 1000);

            //SetCurrentReader();
            //this.Controls.Add(_splashScreen.SplashScreenTLP);
            //this.tableLayoutPanel1.Visible = false;

            //this.MinimumSize = new Size(1422, 888);
            // Initialize the ManagementEventWatchers for connect and disconnect events
            connectWatcher = new ManagementEventWatcher();
            disconnectWatcher = new ManagementEventWatcher();

            // Set up the event for USB device connection
            connectWatcher.EventArrived += new EventArrivedEventHandler(DeviceConnected);
            connectWatcher.Query = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2");

            // Set up the event for USB device disconnection
            disconnectWatcher.EventArrived += new EventArrivedEventHandler(DeviceDisconnected);
            disconnectWatcher.Query = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3");
            StartListening();


        }
        public void StartListening()
        {
            connectWatcher.Start();
            disconnectWatcher.Start();
            Console.WriteLine("Listening for USB device connect/disconnect events...");

        }

        // Event handler for device connection
        private async void DeviceConnected(object sender, EventArrivedEventArgs e)
        {
            Console.WriteLine("USB Device Connected!");
            if (ReaderCollection.GetReaders().Count == 0)
            {
                await Task.Delay(250);
                Invoke((Action)(() => SetCurrentReader()));
            }
        }

        // Event handler for device disconnection
        private void DeviceDisconnected(object sender, EventArrivedEventArgs e)
        {
            Console.WriteLine("USB Device Disconnected!");
            if (ReaderCollection.GetReaders().Count < 1)
            {
                currentReader = null;
                Invoke((Action)(() => SetCurrentReader()));
            }
        }

        private void DisableButtons()
        {
            EmployeeButton.Enabled = false;
            BiometricButton.Enabled = false;
            AttendanceButton.Enabled = false;
            PayrollButton.Enabled = false;
            BackupButton.Enabled = false;
            ReportButton.Enabled = false;
            SystemButton.Enabled = false;
        }
        private async void DelayEnableButtons()
        {
            await Task.Delay(250);

            EmployeeButton.Enabled = true;
            BiometricButton.Enabled = true;
            AttendanceButton.Enabled = true;
            PayrollButton.Enabled = true;
            BackupButton.Enabled = true;
            ReportButton.Enabled = true;
            SystemButton.Enabled = true;
        }


        private void ReaderDetectionEvent(object state)
        {
            if (currentReader == null)
            {
                Invoke((Action)(() => SetCurrentReader()));

            }
            if (ReaderCollection.GetReaders().Count == 0)
            {
                currentReader = null;
            }
        }
      
        private async void MenuBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            SwitchPanel.Visible = false;
            
            if (!_isSidebarCol)
            {
                SidebarHelper.ChangeColWidth(tableLayoutPanel1, false);
                LogoPanel.Height = 0;
                _isSidebarCol = true;
                //await Task.Delay(1000);
                transition.Show(SwitchPanel);
                //transition.Show(MainPanel);
            }
            else
            {
                SidebarHelper.ChangeColWidth(tableLayoutPanel1, true);
                LogoPanel.Height = 112;
                _isSidebarCol = false;
                //await Task.Delay(1000);
                transition.Show(SwitchPanel);
                //transition.Show(MainPanel);
            }
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
            if (e.KeyCode == Keys.F12)
            {
                var switcher = new ApiSwitcher();
                ControlsHelper.ShowModal(this, switcher);
            }
            if (e.KeyCode == Keys.F4)
            {
                if (!_consoleLogs.Visible) _consoleLogs.Show();
            }

            transition.Show(SwitchPanel);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {

            //this.Bounds = Screen.PrimaryScreen.Bounds;


            await Switcher.SwitchPanelAsync(SwitchPanel, _employeeInformation);
            //Switcher.SwitchPanel(SwitchPanel, _systemMaintenance);
            //Switcher.SwitchPanel(SwitchPanel, _biometricAttendance);
            transition.Show(SwitchPanel);

            Invoke((Action)(() => SetCurrentReader()));

            //waitScreen1.Visible = false;

            //await Task.Delay(5000);
            //_splashScreen.SplashScreenTLP.Visible = false;
            //this.tableLayoutPanel1.Visible = true;
            //this.Controls.Remove(_splashScreen.SplashScreenTLP);
            //_BiometricAttendance.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
        }

        private void FullScreenToggle(object sender, EventArgs e)
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

        private async void LogoutBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            Application.Exit();
            //this.Close();
        }


        private async void EmployeeInformationBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            await Switcher.SwitchPanelAsync(SwitchPanel, _employeeInformation);
            transition.ShowSync(SwitchPanel);
            //elapsedTick = 0;
            //waitClock.Start();
        }       


        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private async void BiometricAttendanceBtn_Click(object sender, EventArgs e)
        {
            
            await Task.Delay(250);
            DisableButtons();
            _biometricAttendance?.Close();

            _biometricAttendance = new BiometricAttendance(this);
            await Switcher.SwitchPanelAsync(SwitchPanel, _biometricAttendance);
            transition.Show(SwitchPanel);
            if (currentReader == null)
            {
                //GunaMessage.WarningMessage(this, "Please connect a fingerprint reader first!", "WARNING");
                ToastNotify.Warning("Please connect a fingerprint reader!");
            }
            else
            {
                await Task.Delay(2000);
                _biometricAttendance.StartCapture();

            }
            DelayEnableButtons();
        }

        private async void SystemMaintenanceBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            _biometricAttendance?.Close();
            await Switcher.SwitchPanelAsync(SwitchPanel, _systemMaintenance);
            transition.Show(SwitchPanel);
        }

        private async void ReportBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            await Switcher.SwitchPanelAsync(SwitchPanel, _testForm);
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
            Console.WriteLine("Detecting for fingerprint reader...");
            ReaderCollection readers = ReaderCollection.GetReaders();

            if (readers.Count > 0)
            {
                CurrentReader = readers[0]; // Set the first available reader

                //GunaMessage.InfoMessage(this, "Fingerprint reader connected successfully", "INFO");
                ToastNotify.Success("Fingerprint reader connected!");

                _isReaderReset = false; // Reset the flag if a reader is found
            }
            else
            {
                if (!_isReaderReset)
                {
                    _isReaderReset = true; // Set the flag to true to prevent further messages
                    //GunaMessage.WarningMessage(this, "No fingerprint readers found, please connect a reader.", "Reader Error");
                    ToastNotify.Warning("No fingerpring readers found");
                }
            }
        }

        public bool OpenReader()
        {
            Constants.ResultCode result = Constants.ResultCode.DP_DEVICE_FAILURE;
            // Open reader
            

            if (currentReader == null)
            {
                GunaMessage.Error("Can't initialized fingerprint reader!", "ERROR");
                return false;
            }
            
            result = currentReader.Open(Constants.CapturePriority.DP_PRIORITY_COOPERATIVE);

            if (result != Constants.ResultCode.DP_SUCCESS)
            {                
                GunaMessage.Error($"Error: {result}", "ERROR");
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
                GunaMessage.Error($"Error: {ex.Message}", "ERROR");
                Console.WriteLine($"Error: {ex.Message}");
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


        //private bool isReaderDetectionInProgress = false;


        //private void ReaderDetector_Tick(object sender, EventArgs e)
        //{
        //    if (!isReaderDetectionInProgress)
        //    {
        //        isReaderDetectionInProgress = true; // Set the flag to true

        //        if (currentReader == null)
        //        {
        //            SetCurrentReader();
        //        }
        //        else
        //        {
        //            ReaderDetector.Stop();
        //        }

        //        isReaderDetectionInProgress = false; // Reset the flag after the check
        //    }
        //}

        private void SwitchPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private async void AttendanceButton_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            await Switcher.SwitchPanelAsync(SwitchPanel, _attendanceManagement);
            transition.Show(SwitchPanel);
        }
    }
}
