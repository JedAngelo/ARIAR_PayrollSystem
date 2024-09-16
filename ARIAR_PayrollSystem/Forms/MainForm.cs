using ARIAR_PayrollSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.Forms
{
    public partial class MainForm : Form
    {
        private BiometricAttendance _BiometricAttendance;
        private bool _isSidebarCol = false;
        private bool isFullscreen = true;
        public MainForm()
        {
            InitializeComponent();
            _BiometricAttendance = new BiometricAttendance(this);
            Switcher.SwitchPanel(MainPanel, _BiometricAttendance.BiometricAttPanel);
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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
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
    }
}
