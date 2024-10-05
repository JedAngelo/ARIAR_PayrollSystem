using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public MainForm()
        {
            InitializeComponent();

            _testForm = new Test(this);
            _biometricAttendance = new BiometricAttendance(this);
            _employeeInformation = new EmployeeInformation(this);
            _systemMaintenance = new SystemMaintenance(this);
            _splashScreen = new SplashScreen();
            //this.Controls.Add(_splashScreen.SplashScreenTLP);
            //this.tableLayoutPanel1.Visible = false;
            
            this.MinimumSize = new Size(1422, 888);

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

                    this.FormBorderStyle = FormBorderStyle.Sizable;
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
            transition.Show(SwitchPanel);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            this.Bounds = Screen.PrimaryScreen.Bounds;


            Switcher.SwitchPanel(SwitchPanel, _employeeInformation);
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

                    this.FormBorderStyle = FormBorderStyle.Sizable;
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
            Switcher.SwitchPanel(SwitchPanel, _biometricAttendance);
            transition.Show(SwitchPanel);

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
    }
}
