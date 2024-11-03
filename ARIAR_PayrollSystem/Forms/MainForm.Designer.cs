namespace ARIAR_PayrollSystem.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuButton = new Guna.UI2.WinForms.Guna2Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.BiometricButton = new Guna.UI2.WinForms.Guna2Button();
            this.AttendanceButton = new Guna.UI2.WinForms.Guna2Button();
            this.PayrollButton = new Guna.UI2.WinForms.Guna2Button();
            this.ReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.BackupButton = new Guna.UI2.WinForms.Guna2Button();
            this.SystemButton = new Guna.UI2.WinForms.Guna2Button();
            this.LogoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SwitchPanel = new System.Windows.Forms.Panel();
            this.transition = new Guna.UI2.WinForms.Guna2Transition();
            this.tableLayoutPanel1.SuspendLayout();
            this.SidebarPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1087F));
            this.tableLayoutPanel1.Controls.Add(this.SidebarPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainPanel, 1, 0);
            this.transition.SetDecoration(this.tableLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1091, 772);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.SidebarPanel.Controls.Add(this.flowLayoutPanel1);
            this.SidebarPanel.Controls.Add(this.LogoutButton);
            this.transition.SetDecoration(this.SidebarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(247, 772);
            this.SidebarPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MenuButton);
            this.flowLayoutPanel1.Controls.Add(this.LogoPanel);
            this.flowLayoutPanel1.Controls.Add(this.EmployeeButton);
            this.flowLayoutPanel1.Controls.Add(this.BiometricButton);
            this.flowLayoutPanel1.Controls.Add(this.AttendanceButton);
            this.flowLayoutPanel1.Controls.Add(this.PayrollButton);
            this.flowLayoutPanel1.Controls.Add(this.ReportButton);
            this.flowLayoutPanel1.Controls.Add(this.BackupButton);
            this.flowLayoutPanel1.Controls.Add(this.SystemButton);
            this.transition.SetDecoration(this.flowLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(247, 700);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // MenuButton
            // 
            this.MenuButton.Animated = true;
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.MenuButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MenuButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MenuButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MenuButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MenuButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MenuButton.FillColor = System.Drawing.Color.SteelBlue;
            this.MenuButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.MenuButton.ForeColor = System.Drawing.Color.White;
            this.MenuButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.menu_logo1;
            this.MenuButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MenuButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.MenuButton.ImageSize = new System.Drawing.Size(25, 25);
            this.MenuButton.Location = new System.Drawing.Point(0, 0);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(248, 46);
            this.MenuButton.TabIndex = 20;
            this.MenuButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MenuButton.TextOffset = new System.Drawing.Point(10, 0);
            this.MenuButton.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPanel.Controls.Add(this.guna2Separator1);
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.transition.SetDecoration(this.LogoPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoPanel.Location = new System.Drawing.Point(3, 49);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LogoPanel.Size = new System.Drawing.Size(245, 112);
            this.LogoPanel.TabIndex = 1;
            // 
            // guna2Separator1
            // 
            this.transition.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(8, 86);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(229, 26);
            this.guna2Separator1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.transition.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Animated = true;
            this.EmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.EmployeeButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.EmployeeButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.EmployeeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeButton.DisabledState.FillColor = System.Drawing.Color.SteelBlue;
            this.EmployeeButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.EmployeeButton.FillColor = System.Drawing.Color.SteelBlue;
            this.EmployeeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.EmployeeButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.group_logo4;
            this.EmployeeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmployeeButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.EmployeeButton.ImageSize = new System.Drawing.Size(25, 25);
            this.EmployeeButton.Location = new System.Drawing.Point(0, 164);
            this.EmployeeButton.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(248, 55);
            this.EmployeeButton.TabIndex = 19;
            this.EmployeeButton.Text = "Employee Dashboard";
            this.EmployeeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmployeeButton.TextOffset = new System.Drawing.Point(10, 0);
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeInformationBtn_Click);
            // 
            // BiometricButton
            // 
            this.BiometricButton.Animated = true;
            this.BiometricButton.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.BiometricButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BiometricButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.BiometricButton.DisabledState.FillColor = System.Drawing.Color.SteelBlue;
            this.BiometricButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.BiometricButton.FillColor = System.Drawing.Color.SteelBlue;
            this.BiometricButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BiometricButton.ForeColor = System.Drawing.Color.White;
            this.BiometricButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.fingerprint_logo1;
            this.BiometricButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BiometricButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.BiometricButton.ImageSize = new System.Drawing.Size(25, 25);
            this.BiometricButton.Location = new System.Drawing.Point(0, 219);
            this.BiometricButton.Margin = new System.Windows.Forms.Padding(0);
            this.BiometricButton.Name = "BiometricButton";
            this.BiometricButton.Size = new System.Drawing.Size(248, 55);
            this.BiometricButton.TabIndex = 20;
            this.BiometricButton.Text = "Biometric Attendance";
            this.BiometricButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BiometricButton.TextOffset = new System.Drawing.Point(10, 0);
            this.BiometricButton.Click += new System.EventHandler(this.BiometricAttendanceBtn_Click);
            // 
            // AttendanceButton
            // 
            this.AttendanceButton.Animated = true;
            this.AttendanceButton.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.AttendanceButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.AttendanceButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.AttendanceButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AttendanceButton.DisabledState.FillColor = System.Drawing.Color.SteelBlue;
            this.AttendanceButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.AttendanceButton.FillColor = System.Drawing.Color.SteelBlue;
            this.AttendanceButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.AttendanceButton.ForeColor = System.Drawing.Color.White;
            this.AttendanceButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.schedule_logo1;
            this.AttendanceButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AttendanceButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.AttendanceButton.ImageSize = new System.Drawing.Size(25, 25);
            this.AttendanceButton.Location = new System.Drawing.Point(0, 274);
            this.AttendanceButton.Margin = new System.Windows.Forms.Padding(0);
            this.AttendanceButton.Name = "AttendanceButton";
            this.AttendanceButton.Size = new System.Drawing.Size(248, 55);
            this.AttendanceButton.TabIndex = 21;
            this.AttendanceButton.Text = "Attendance Management";
            this.AttendanceButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AttendanceButton.TextOffset = new System.Drawing.Point(10, 0);
            this.AttendanceButton.Click += new System.EventHandler(this.AttendanceButton_Click);
            // 
            // PayrollButton
            // 
            this.PayrollButton.Animated = true;
            this.PayrollButton.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.PayrollButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PayrollButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.PayrollButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PayrollButton.DisabledState.FillColor = System.Drawing.Color.SteelBlue;
            this.PayrollButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.PayrollButton.FillColor = System.Drawing.Color.SteelBlue;
            this.PayrollButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.PayrollButton.ForeColor = System.Drawing.Color.White;
            this.PayrollButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.cash_logo;
            this.PayrollButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PayrollButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.PayrollButton.ImageSize = new System.Drawing.Size(25, 25);
            this.PayrollButton.Location = new System.Drawing.Point(0, 329);
            this.PayrollButton.Margin = new System.Windows.Forms.Padding(0);
            this.PayrollButton.Name = "PayrollButton";
            this.PayrollButton.Size = new System.Drawing.Size(248, 55);
            this.PayrollButton.TabIndex = 22;
            this.PayrollButton.Text = "Payroll";
            this.PayrollButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PayrollButton.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // ReportButton
            // 
            this.ReportButton.Animated = true;
            this.ReportButton.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.ReportButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ReportButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.ReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReportButton.DisabledState.FillColor = System.Drawing.Color.SteelBlue;
            this.ReportButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.ReportButton.FillColor = System.Drawing.Color.SteelBlue;
            this.ReportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.description_logo1;
            this.ReportButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReportButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.ReportButton.ImageSize = new System.Drawing.Size(25, 25);
            this.ReportButton.Location = new System.Drawing.Point(0, 384);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(248, 55);
            this.ReportButton.TabIndex = 23;
            this.ReportButton.Text = "Report";
            this.ReportButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReportButton.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // BackupButton
            // 
            this.BackupButton.Animated = true;
            this.BackupButton.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.BackupButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BackupButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.BackupButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackupButton.DisabledState.FillColor = System.Drawing.Color.SteelBlue;
            this.BackupButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.BackupButton.FillColor = System.Drawing.Color.SteelBlue;
            this.BackupButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BackupButton.ForeColor = System.Drawing.Color.White;
            this.BackupButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.database_logo;
            this.BackupButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BackupButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.BackupButton.ImageSize = new System.Drawing.Size(25, 25);
            this.BackupButton.Location = new System.Drawing.Point(0, 439);
            this.BackupButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(248, 55);
            this.BackupButton.TabIndex = 24;
            this.BackupButton.Text = "Backup";
            this.BackupButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BackupButton.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // SystemButton
            // 
            this.SystemButton.Animated = true;
            this.SystemButton.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.SystemButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SystemButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.SystemButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SystemButton.DisabledState.FillColor = System.Drawing.Color.SteelBlue;
            this.SystemButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.SystemButton.FillColor = System.Drawing.Color.SteelBlue;
            this.SystemButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SystemButton.ForeColor = System.Drawing.Color.White;
            this.SystemButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.config_logo2;
            this.SystemButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SystemButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.SystemButton.ImageSize = new System.Drawing.Size(25, 25);
            this.SystemButton.Location = new System.Drawing.Point(0, 494);
            this.SystemButton.Margin = new System.Windows.Forms.Padding(0);
            this.SystemButton.Name = "SystemButton";
            this.SystemButton.Size = new System.Drawing.Size(248, 55);
            this.SystemButton.TabIndex = 25;
            this.SystemButton.Text = "System Maintenance";
            this.SystemButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SystemButton.TextOffset = new System.Drawing.Point(10, 0);
            this.SystemButton.Click += new System.EventHandler(this.SystemMaintenanceBtn_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Animated = true;
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.LogoutButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogoutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogoutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogoutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoutButton.FillColor = System.Drawing.Color.SteelBlue;
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.logout_logo1;
            this.LogoutButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogoutButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.LogoutButton.ImageSize = new System.Drawing.Size(25, 25);
            this.LogoutButton.Location = new System.Drawing.Point(0, 717);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(247, 55);
            this.LogoutButton.TabIndex = 26;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogoutButton.TextOffset = new System.Drawing.Point(10, 0);
            this.LogoutButton.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.SwitchPanel);
            this.transition.SetDecoration(this.MainPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(247, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1087, 772);
            this.MainPanel.TabIndex = 1;
            // 
            // SwitchPanel
            // 
            this.SwitchPanel.BackColor = System.Drawing.Color.White;
            this.transition.SetDecoration(this.SwitchPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SwitchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwitchPanel.Location = new System.Drawing.Point(0, 0);
            this.SwitchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchPanel.Name = "SwitchPanel";
            this.SwitchPanel.Size = new System.Drawing.Size(1087, 772);
            this.SwitchPanel.TabIndex = 0;
            this.SwitchPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.SwitchPanel_ControlAdded);
            this.SwitchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SwitchPanel_Paint);
            // 
            // transition
            // 
            this.transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.transition.DefaultAnimation = animation1;
            this.transition.TimeStep = 0.1F;           
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1091, 772);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1086, 589);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeInformation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SidebarPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Transition transition;
        internal System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SwitchPanel;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button EmployeeButton;
        private Guna.UI2.WinForms.Guna2Button BackupButton;
        private Guna.UI2.WinForms.Guna2Button ReportButton;
        private Guna.UI2.WinForms.Guna2Button PayrollButton;
        private Guna.UI2.WinForms.Guna2Button AttendanceButton;
        private Guna.UI2.WinForms.Guna2Button BiometricButton;
        private Guna.UI2.WinForms.Guna2Button SystemButton;
        private Guna.UI2.WinForms.Guna2Button LogoutButton;
        private Guna.UI2.WinForms.Guna2Button MenuButton;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}