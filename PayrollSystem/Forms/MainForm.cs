using PayrollSystem.Forms.Modals;
using PayrollSystem.Helpers;
using PayrollSystem.UserControls;
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
using PayrollSystem.Models;
using System.Web.UI.WebControls;
using Image = System.Drawing.Image;
using System.Runtime.InteropServices.WindowsRuntime;
using Newtonsoft.Json;
using System.Net.Http;
using System.Xml.Xsl;

namespace PayrollSystem.Forms
{
    public partial class MainForm : Form
    {
        private BiometricAttendance _biometricAttendance;
        private EmployeeManagement _employeeInformation;
        private SystemMaintenance _systemMaintenance;
        private Test _testForm;
        private WorklogManagement _attendanceManagement;
        private SplashScreen _splashScreen;
        private PayrollDetails _payrollCalclulation;
        private Report _report;
        private Backup _backup;


        private bool IsBiometricLoading = false;
        public System.Threading.Timer _ReaderDetection;
        private bool _isSidebarCol = false;
        private bool isFullscreen = true;
        private bool _isReaderReset = false;
        private ManagementEventWatcher connectWatcher;
        private ManagementEventWatcher disconnectWatcher;
        private ConsoleLogsModal _consoleLogs;
        private Image _oldIcon;
        private Color _defaultColor = System.Drawing.SystemColors.Control;
        private UserLoginDto _userData;
        private bool _attendanceOnly;

        //Api Data
        private List<PersonalInformationDisplayDto> _employeeInfo;
        public List<PersonalInformationDisplayDto> EmployeeInfo
        {
            get { return _employeeInfo; }
            set
            {
                _employeeInfo = value;
            }
        }

        public UserLoginDto UserData
        {
            get { return _userData; }
            set
            {
                _userData = value;
                Console.WriteLine(JsonConvert.SerializeObject(value, Formatting.Indented));
                //_ = SetAccessView();
            }
        }

        public SystemSettingsDto Settings { get; set; }


        public MainForm(bool attendanceOnly)
        {
            LoadSettings();
            InitializeComponent();
            _attendanceOnly = attendanceOnly;
            _employeeInformation = new EmployeeManagement(this) { AutoScaleMode = AutoScaleMode.None };
            if (_attendanceOnly)
            {
                AttendanceOnlyView();
            }
            else
            {

                DisableButtons();
                //_testForm = new Test(this);
                //_biometricAttendance = new BiometricAttendance(this);
                AutoScaleMode = AutoScaleMode.None;
                _systemMaintenance = new SystemMaintenance(this) { AutoScaleMode = AutoScaleMode.None };
                _attendanceManagement = new WorklogManagement(this) { AutoScaleMode = AutoScaleMode.None };
                _payrollCalclulation = new PayrollDetails(this) { AutoScaleMode = AutoScaleMode.None };
                _backup = new Backup(this) { AutoScaleMode = AutoScaleMode.None };
                _report = new Report(this) { AutoScaleMode = AutoScaleMode.None };


                _splashScreen = new SplashScreen();
                
            }

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

        public async Task GetSettingsAsync()
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<SystemSettingsDto>>(ApiEndpoint.Settings.GetSettings);

                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " returned null");

                if (apiData.isSuccess)
                {
                    Console.WriteLine("Successfully retrieved settings data");
                    Settings = apiData.Data;
                }
                else
                {
                    Console.WriteLine("Failed retrieving settings data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async void LoadSettings()
        {
            await GetSettingsAsync();
        }

        private async void AttendanceOnlyView()
        {
            LoadEmployeeData();
            MainView.Visible = false;
            TopPanel.BringToFront();
            _biometricAttendance?.Close();
            _biometricAttendance = new BiometricAttendance(this, true);
            await Switcher.SwitchPanelAsync(TopPanel, _biometricAttendance);
            transition.Show(TopPanel);
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
            AttendanceButton.Enabled = false;
            WorkLogButton.Enabled = false;
            PayrollButton.Enabled = false;
            BackupButton.Enabled = false;
            ReportButton.Enabled = false;
            SystemButton.Enabled = false;
        }
        private async void DelayEnableButtons()
        {
            await Task.Delay(250);

            EmployeeButton.Enabled = true;
            AttendanceButton.Enabled = true;
            WorkLogButton.Enabled = true;
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

            SidebarHelper.ChangeColWidth(MainView, _isSidebarCol);
            LogoPanel.Height = _isSidebarCol == false ? 0 : 138;
            DateTimePanel.Visible = _isSidebarCol;
            _isSidebarCol = !_isSidebarCol;
            transition.Show(SwitchPanel);


            //if (!_isSidebarCol)
            //{
            //    SidebarHelper.ChangeColWidth(tableLayoutPanel1, false);
            //    LogoPanel.Height = 0;
            //    _isSidebarCol = true;
            //    //await Task.Delay(1000);
            //    transition.Show(SwitchPanel);
            //    //transition.Show(MainPanel);
            //}
            //else
            //{
            //    SidebarHelper.ChangeColWidth(tableLayoutPanel1, true);
            //    LogoPanel.Height = 112;
            //    _isSidebarCol = false;
            //    //await Task.Delay(1000);
            //    transition.Show(SwitchPanel);
            //    //transition.Show(MainPanel);
            //}
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (isFullscreen)
                {

                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    this.WindowState = FormWindowState.Normal;
                    isFullscreen = false;
                }
                else
                {
                    if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
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
                if (!UserData.UserRole.Contains("AdminRole")) return;
                if (!_consoleLogs.Visible) _consoleLogs.Show();
            }

            transition.Show(SwitchPanel);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            CurrentDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
            CurrentTime.Text = DateTime.Now.ToString("T");
            if (!_attendanceOnly)
            {
                TopPanel.SendToBack();
                GunaMessage.Info($"Welcome {UserData.UserName.ToUpper()}!", "SUCCESS");
                UserLabel.Text = UserData.UserName.ToUpper();
                _consoleLogs = new ConsoleLogsModal();
                var handle = _consoleLogs.Handle;
                _consoleLogs.RedirectConsoleToTextBox();
                //this.Bounds = Screen.PrimaryScreen.Bounds;

                await SetAccessView();
                DelayEnableButtons();
            }
            Invoke((Action)(() => SetCurrentReader()));
        }



        private async Task ShutdownApplication()
        {
            try
            {
                // Stop listening for device events
                StopListening();


                // Dispose of biometric form
                if (_biometricAttendance != null)
                {
                    _biometricAttendance.Close();
                    _biometricAttendance.Dispose();
                }
                if (_employeeInformation != null)
                {
                    _employeeInformation.Close();
                    _employeeInformation.Dispose();
                }
                if (_consoleLogs != null)
                {
                    _consoleLogs.Close();
                    _consoleLogs.Dispose();
                }

                // Stop and dispose timer
                if (_ReaderDetection != null)
                {
                    _ReaderDetection.Dispose();
                }

                // Close all opened modals
                _consoleLogs?.Close();
                _consoleLogs?.Dispose();

                // Stop and Dispose of Event Watchers
                StopListening();

                await Task.Delay(100);

                //Close the application, all resources should be disposed
                HttpHelper.DeleteAccessToken();
                this.Hide();
                this.Dispose();
                Application.Restart();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void StopListening()
        {
            connectWatcher?.Stop();
            disconnectWatcher?.Stop();
        }

        //  Logout Button Click
        private async void LogoutBtn_Click(object sender, EventArgs e)
        {
            await ShutdownApplication();
        }

        public async void Logout()
        {
            await ShutdownApplication();
        }


        private async void EmployeeInformationBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);

            RemoveSelected();
            EmployeeButton.Checked = true;

            _biometricAttendance?.Close();
            await Switcher.SwitchPanelAsync(SwitchPanel, _employeeInformation);
            transition.Show(SwitchPanel);
            //elapsedTick = 0;
            //waitClock.Start();
        }


        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //private void SetAndUpdateButton(Image oldIcon, Image newIcon, Guna2Button button)
        //{
        //    _oldIcon = oldIcon;
        //    button.Image = newIcon;
        //    button.FillColor = _defaultColor;
        //    button.ForeColor = Color.FromArgb(45, 45, 45);
        //}

        private async void BiometricAttendanceBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            if (EmployeeInfo == null)
            {
                ToastNotify.Info("Please wait for employee information to load");
                return;
            }

            RemoveSelected();
            AttendanceButton.Checked = true;

            DisableButtons();
            _biometricAttendance?.Close();

            _biometricAttendance = new BiometricAttendance(this, false);
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
            if (EmployeeInfo == null)
            {
                ToastNotify.Info("Please wait for employee information to load");
                return;
            }
            RemoveSelected();
            SystemButton.Checked = true;

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
                    ToastNotify.Warning("No fingerprint readers found");
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

        private void SwitchPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private async void AttendanceButton_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            _biometricAttendance?.Close();
            if (EmployeeInfo == null)
            {
                ToastNotify.Info("Please wait for employee information to load");
                return;
            }
            RemoveSelected();
            WorkLogButton.Checked = true;

            await Switcher.SwitchPanelAsync(SwitchPanel, _attendanceManagement);
            transition.Show(SwitchPanel);
        }

        private async void PayrollButton_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            _biometricAttendance?.Close();
            if (EmployeeInfo == null)
            {
                ToastNotify.Info("Please wait for employee information to load");
                return;
            }
            RemoveSelected();
            PayrollButton.Checked = true;

            await Switcher.SwitchPanelAsync(SwitchPanel, _payrollCalclulation);
            transition.Show(SwitchPanel);
        }

        private async void BackupButton_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            await Task.Run(() =>
            {
                RemoveSelected();
                _oldIcon = BackupButton.Image;
                BackupButton.Image = Properties.Resources.database_2_line;
                BackupButton.FillColor = _defaultColor;
                BackupButton.ForeColor = Color.FromArgb(45, 45, 45);
            });

            await Switcher.SwitchPanelAsync(SwitchPanel, _backup);
            transition.Show(SwitchPanel);
        }

        private async void ReportButton_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            _biometricAttendance?.Close();
            if (EmployeeInfo == null)
            {
                ToastNotify.Info("Please wait for employee information to load");
                return;
            }
            
            RemoveSelected();
            ReportButton.Checked = true;

            await Switcher.SwitchPanelAsync(SwitchPanel, _report);
            transition.Show(SwitchPanel);
        }

        public void RemoveSelected()
        {
            var control = AccessView.Controls.OfType<Guna2Button>().FirstOrDefault(x => x.Checked);
            control.Checked = false;
        }

        public async Task SetAccessView()
        {
            var permissions = UserData.Permissions;
            await Task.Run(() =>
            {
                BeginInvoke((Action)(() =>
                {
                    if (permissions.Contains("*")) return;
                    if (!permissions.Contains("EMPLOYEE")) AccessView.Controls.Remove(EmployeeButton);
                    if (!permissions.Contains("ATTENDANCE")) AccessView.Controls.Remove(AttendanceButton);
                    if (!permissions.Contains("WORKLOG")) AccessView.Controls.Remove(WorkLogButton);
                    if (!permissions.Contains("PAYROLL")) AccessView.Controls.Remove(PayrollButton);
                    if (!permissions.Contains("REPORT")) AccessView.Controls.Remove(ReportButton);
                    if (!permissions.Contains("SYSTEM")) AccessView.Controls.Remove(SystemButton);

                    //reverse
                }));
            });
            InitView();
            ShowView();
        }

        public async void LoadEmployeeData()
        {
            var employeeData = await _employeeInformation.RetrieveEmployeeData();
            if (employeeData.isSuccess)
            {
                EmployeeInfo = employeeData.Data;
            }
            else
            {
                ToastNotify.Warning(employeeData.ErrorMessage);
            }
        }

        public void RefreshEmployeeInformationView()
        {
            _employeeInformation.RefreshView();
        }

        private async void InitView()
        {
            var permissions = UserData.Permissions;
            switch (true)
            {
                case bool _ when permissions.Contains("*"):
                case bool _ when permissions.Contains("EMPLOYEE"):
                    EmployeeButton.Checked = true;
                    await Switcher.SwitchPanelAsync(SwitchPanel, _employeeInformation);
                    transition.Show(SwitchPanel);
                    break;
                case bool _ when permissions.Contains("ATTENDANCE"):
                    LoadEmployeeData();
                    AttendanceButton.Checked = true;
                    _biometricAttendance?.Close();
                    _biometricAttendance = new BiometricAttendance(this, false);
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
                    break;
                case bool _ when permissions.Contains("WORKLOG"):
                    LoadEmployeeData();
                    WorkLogButton.Checked = true;
                    await Switcher.SwitchPanelAsync(SwitchPanel, _attendanceManagement);
                    transition.Show(SwitchPanel);
                    break;
                case bool _ when permissions.Contains("PAYROLL"):
                    LoadEmployeeData();
                    PayrollButton.Checked = true;
                    await Switcher.SwitchPanelAsync(SwitchPanel, _payrollCalclulation);
                    transition.Show(SwitchPanel);
                    break;
                case bool _ when permissions.Contains("REPORT"):
                    LoadEmployeeData();
                    ReportButton.Checked = true;
                    await Switcher.SwitchPanelAsync(SwitchPanel, _report);
                    transition.Show(SwitchPanel);
                    break;
                case bool _ when permissions.Contains("SYSTEM"):
                    LoadEmployeeData();
                    SystemButton.Checked = true;
                    await Switcher.SwitchPanelAsync(SwitchPanel, _systemMaintenance);
                    transition.Show(SwitchPanel);
                    break;
                    //other conditions I have yet to finished
            }
        }

        private void ShowView()
        {
            var permissions = UserData.Permissions;
            if (permissions.Contains("*"))
            {
                EmployeeButton.Visible = true;
                AttendanceButton.Visible = true;
                WorkLogButton.Visible = true;
                PayrollButton.Visible = true;
                ReportButton.Visible = true;
                SystemButton.Visible = true;
            }
            else
            {
                if (permissions.Contains("EMPLOYEE")) EmployeeButton.Visible = true;
                if (permissions.Contains("ATTENDANCE")) AttendanceButton.Visible = true;
                if (permissions.Contains("WORKLOG")) WorkLogButton.Visible = true;
                if (permissions.Contains("PAYROLL")) PayrollButton.Visible = true;
                if (permissions.Contains("REPORT")) ReportButton.Visible = true;
                if (permissions.Contains("SYSTEM")) SystemButton.Visible = true;
            }
        }

        private void CurrentTimeTick_Tick(object sender, EventArgs e)
        {
            CurrentTime.Text = DateTime.Now.ToString("T");
        }
    }
}
