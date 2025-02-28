namespace PayrollSystem.Forms
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
            this.transition = new Guna.UI2.WinForms.Guna2Transition();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SwitchPanel = new System.Windows.Forms.Panel();
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.AccessView = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuButton = new Guna.UI2.WinForms.Guna2Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.UserLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.AttendanceButton = new Guna.UI2.WinForms.Guna2Button();
            this.WorkLogButton = new Guna.UI2.WinForms.Guna2Button();
            this.PayrollButton = new Guna.UI2.WinForms.Guna2Button();
            this.ReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.SystemButton = new Guna.UI2.WinForms.Guna2Button();
            this.BackupButton = new Guna.UI2.WinForms.Guna2Button();
            this.LogoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.MainView = new System.Windows.Forms.TableLayoutPanel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.DateTimePanel = new System.Windows.Forms.Panel();
            this.CurrentDate = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.CurrentTimeTick = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            this.SidebarPanel.SuspendLayout();
            this.AccessView.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainView.SuspendLayout();
            this.DateTimePanel.SuspendLayout();
            this.SuspendLayout();
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
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Controls.Add(this.SwitchPanel);
            this.transition.SetDecoration(this.MainPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(247, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(953, 749);
            this.MainPanel.TabIndex = 1;
            // 
            // SwitchPanel
            // 
            this.SwitchPanel.BackColor = System.Drawing.SystemColors.Control;
            this.transition.SetDecoration(this.SwitchPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SwitchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwitchPanel.Location = new System.Drawing.Point(0, 0);
            this.SwitchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchPanel.Name = "SwitchPanel";
            this.SwitchPanel.Size = new System.Drawing.Size(953, 749);
            this.SwitchPanel.TabIndex = 0;
            this.SwitchPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.SwitchPanel_ControlAdded);
            this.SwitchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SwitchPanel_Paint);
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.SidebarPanel.Controls.Add(this.DateTimePanel);
            this.SidebarPanel.Controls.Add(this.AccessView);
            this.SidebarPanel.Controls.Add(this.LogoutButton);
            this.transition.SetDecoration(this.SidebarPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(247, 749);
            this.SidebarPanel.TabIndex = 0;
            // 
            // AccessView
            // 
            this.AccessView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccessView.Controls.Add(this.MenuButton);
            this.AccessView.Controls.Add(this.LogoPanel);
            this.AccessView.Controls.Add(this.EmployeeButton);
            this.AccessView.Controls.Add(this.AttendanceButton);
            this.AccessView.Controls.Add(this.WorkLogButton);
            this.AccessView.Controls.Add(this.PayrollButton);
            this.AccessView.Controls.Add(this.ReportButton);
            this.AccessView.Controls.Add(this.SystemButton);
            this.AccessView.Controls.Add(this.BackupButton);
            this.transition.SetDecoration(this.AccessView, Guna.UI2.AnimatorNS.DecorationType.None);
            this.AccessView.Location = new System.Drawing.Point(0, 0);
            this.AccessView.Margin = new System.Windows.Forms.Padding(0);
            this.AccessView.Name = "AccessView";
            this.AccessView.Size = new System.Drawing.Size(247, 555);
            this.AccessView.TabIndex = 1;
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
            this.MenuButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.MenuButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.MenuButton.ForeColor = System.Drawing.Color.White;
            this.MenuButton.Image = global::PayrollSystem.Properties.Resources.menu_logo1;
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
            this.LogoPanel.Controls.Add(this.UserLabel);
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.transition.SetDecoration(this.LogoPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoPanel.Location = new System.Drawing.Point(0, 46);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LogoPanel.Size = new System.Drawing.Size(248, 138);
            this.LogoPanel.TabIndex = 1;
            // 
            // UserLabel
            // 
            this.UserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UserLabel.BackColor = System.Drawing.SystemColors.Control;
            this.transition.SetDecoration(this.UserLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.UserLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.UserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UserLabel.Location = new System.Drawing.Point(-2, 89);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(251, 32);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "USER";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.transition.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::PayrollSystem.Properties.Resources.New_Project_1_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeButton.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.EmployeeButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EmployeeButton.CheckedState.Image = global::PayrollSystem.Properties.Resources.group_line1;
            this.transition.SetDecoration(this.EmployeeButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.EmployeeButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.EmployeeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.EmployeeButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.EmployeeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.EmployeeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.EmployeeButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeButton.Image = global::PayrollSystem.Properties.Resources.group_line_1_;
            this.EmployeeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmployeeButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.EmployeeButton.ImageSize = new System.Drawing.Size(24, 24);
            this.EmployeeButton.Location = new System.Drawing.Point(0, 184);
            this.EmployeeButton.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(248, 55);
            this.EmployeeButton.TabIndex = 19;
            this.EmployeeButton.Text = "Employee";
            this.EmployeeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmployeeButton.TextOffset = new System.Drawing.Point(10, 0);
            this.EmployeeButton.Visible = false;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeInformationBtn_Click);
            // 
            // AttendanceButton
            // 
            this.AttendanceButton.BackColor = System.Drawing.Color.Transparent;
            this.AttendanceButton.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.AttendanceButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AttendanceButton.CheckedState.Image = global::PayrollSystem.Properties.Resources.fingerprint_line_1_;
            this.transition.SetDecoration(this.AttendanceButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.AttendanceButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.AttendanceButton.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.AttendanceButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AttendanceButton.DisabledState.Image = global::PayrollSystem.Properties.Resources.fingerprint_line_1_;
            this.AttendanceButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.AttendanceButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.AttendanceButton.ForeColor = System.Drawing.Color.White;
            this.AttendanceButton.Image = global::PayrollSystem.Properties.Resources.fingerprint_line_2_;
            this.AttendanceButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AttendanceButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.AttendanceButton.ImageSize = new System.Drawing.Size(24, 24);
            this.AttendanceButton.Location = new System.Drawing.Point(0, 239);
            this.AttendanceButton.Margin = new System.Windows.Forms.Padding(0);
            this.AttendanceButton.Name = "AttendanceButton";
            this.AttendanceButton.Size = new System.Drawing.Size(248, 55);
            this.AttendanceButton.TabIndex = 20;
            this.AttendanceButton.Text = "Attendance";
            this.AttendanceButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AttendanceButton.TextOffset = new System.Drawing.Point(10, 0);
            this.AttendanceButton.Visible = false;
            this.AttendanceButton.Click += new System.EventHandler(this.BiometricAttendanceBtn_Click);
            // 
            // WorkLogButton
            // 
            this.WorkLogButton.BackColor = System.Drawing.Color.Transparent;
            this.WorkLogButton.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.WorkLogButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.WorkLogButton.CheckedState.Image = global::PayrollSystem.Properties.Resources.calendar_schedule_line;
            this.transition.SetDecoration(this.WorkLogButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.WorkLogButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.WorkLogButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WorkLogButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.WorkLogButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.WorkLogButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.WorkLogButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.WorkLogButton.ForeColor = System.Drawing.Color.White;
            this.WorkLogButton.Image = global::PayrollSystem.Properties.Resources.calendar_schedule_line_1_;
            this.WorkLogButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.WorkLogButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.WorkLogButton.ImageSize = new System.Drawing.Size(24, 24);
            this.WorkLogButton.Location = new System.Drawing.Point(0, 294);
            this.WorkLogButton.Margin = new System.Windows.Forms.Padding(0);
            this.WorkLogButton.Name = "WorkLogButton";
            this.WorkLogButton.Size = new System.Drawing.Size(248, 55);
            this.WorkLogButton.TabIndex = 21;
            this.WorkLogButton.Text = "Work Logs";
            this.WorkLogButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.WorkLogButton.TextOffset = new System.Drawing.Point(10, 0);
            this.WorkLogButton.Visible = false;
            this.WorkLogButton.Click += new System.EventHandler(this.AttendanceButton_Click);
            // 
            // PayrollButton
            // 
            this.PayrollButton.BackColor = System.Drawing.Color.Transparent;
            this.PayrollButton.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.PayrollButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PayrollButton.CheckedState.Image = global::PayrollSystem.Properties.Resources.money_dollar_circle_line_1_;
            this.transition.SetDecoration(this.PayrollButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PayrollButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.PayrollButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PayrollButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.PayrollButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.PayrollButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.PayrollButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.PayrollButton.ForeColor = System.Drawing.Color.White;
            this.PayrollButton.Image = global::PayrollSystem.Properties.Resources.money_dollar_circle_line;
            this.PayrollButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PayrollButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.PayrollButton.ImageSize = new System.Drawing.Size(24, 24);
            this.PayrollButton.Location = new System.Drawing.Point(0, 349);
            this.PayrollButton.Margin = new System.Windows.Forms.Padding(0);
            this.PayrollButton.Name = "PayrollButton";
            this.PayrollButton.Size = new System.Drawing.Size(248, 55);
            this.PayrollButton.TabIndex = 22;
            this.PayrollButton.Text = "Payroll";
            this.PayrollButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PayrollButton.TextOffset = new System.Drawing.Point(10, 0);
            this.PayrollButton.Visible = false;
            this.PayrollButton.Click += new System.EventHandler(this.PayrollButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.Color.Transparent;
            this.ReportButton.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.ReportButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ReportButton.CheckedState.Image = global::PayrollSystem.Properties.Resources.article_line;
            this.transition.SetDecoration(this.ReportButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ReportButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.ReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.ReportButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.ReportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.ReportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.Image = global::PayrollSystem.Properties.Resources.article_line_1_;
            this.ReportButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReportButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.ReportButton.ImageSize = new System.Drawing.Size(24, 24);
            this.ReportButton.Location = new System.Drawing.Point(0, 404);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(248, 55);
            this.ReportButton.TabIndex = 23;
            this.ReportButton.Text = "Reports";
            this.ReportButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReportButton.TextOffset = new System.Drawing.Point(10, 0);
            this.ReportButton.Visible = false;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // SystemButton
            // 
            this.SystemButton.BackColor = System.Drawing.Color.Transparent;
            this.SystemButton.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.SystemButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SystemButton.CheckedState.Image = global::PayrollSystem.Properties.Resources.settings_3_line;
            this.transition.SetDecoration(this.SystemButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SystemButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.SystemButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SystemButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.SystemButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.SystemButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.SystemButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SystemButton.ForeColor = System.Drawing.Color.White;
            this.SystemButton.Image = global::PayrollSystem.Properties.Resources.settings_3_line_1_;
            this.SystemButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SystemButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.SystemButton.ImageSize = new System.Drawing.Size(24, 24);
            this.SystemButton.Location = new System.Drawing.Point(0, 459);
            this.SystemButton.Margin = new System.Windows.Forms.Padding(0);
            this.SystemButton.Name = "SystemButton";
            this.SystemButton.Size = new System.Drawing.Size(248, 55);
            this.SystemButton.TabIndex = 25;
            this.SystemButton.Text = "Maintenance";
            this.SystemButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SystemButton.TextOffset = new System.Drawing.Point(10, 0);
            this.SystemButton.Visible = false;
            this.SystemButton.Click += new System.EventHandler(this.SystemMaintenanceBtn_Click);
            // 
            // BackupButton
            // 
            this.BackupButton.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.BackupButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BackupButton.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.BackupButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackupButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.BackupButton.DisabledState.ForeColor = System.Drawing.Color.White;
            this.BackupButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.BackupButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BackupButton.ForeColor = System.Drawing.Color.White;
            this.BackupButton.Image = global::PayrollSystem.Properties.Resources.database_2_line_1_;
            this.BackupButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BackupButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.BackupButton.ImageSize = new System.Drawing.Size(24, 24);
            this.BackupButton.Location = new System.Drawing.Point(0, 514);
            this.BackupButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(248, 55);
            this.BackupButton.TabIndex = 24;
            this.BackupButton.Text = "Backup";
            this.BackupButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BackupButton.TextOffset = new System.Drawing.Point(10, 0);
            this.BackupButton.Visible = false;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
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
            this.LogoutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Image = global::PayrollSystem.Properties.Resources.logout_box_line;
            this.LogoutButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogoutButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.LogoutButton.ImageSize = new System.Drawing.Size(24, 24);
            this.LogoutButton.Location = new System.Drawing.Point(0, 694);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(247, 55);
            this.LogoutButton.TabIndex = 26;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogoutButton.TextOffset = new System.Drawing.Point(10, 0);
            this.LogoutButton.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // MainView
            // 
            this.MainView.ColumnCount = 2;
            this.MainView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.MainView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainView.Controls.Add(this.SidebarPanel, 0, 0);
            this.MainView.Controls.Add(this.MainPanel, 1, 0);
            this.transition.SetDecoration(this.MainView, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainView.Location = new System.Drawing.Point(0, 0);
            this.MainView.Margin = new System.Windows.Forms.Padding(0);
            this.MainView.Name = "MainView";
            this.MainView.RowCount = 1;
            this.MainView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainView.Size = new System.Drawing.Size(1200, 749);
            this.MainView.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.transition.SetDecoration(this.TopPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1200, 749);
            this.TopPanel.TabIndex = 0;
            // 
            // DateTimePanel
            // 
            this.DateTimePanel.Controls.Add(this.CurrentTime);
            this.DateTimePanel.Controls.Add(this.CurrentDate);
            this.transition.SetDecoration(this.DateTimePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DateTimePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DateTimePanel.Location = new System.Drawing.Point(0, 594);
            this.DateTimePanel.Margin = new System.Windows.Forms.Padding(0);
            this.DateTimePanel.Name = "DateTimePanel";
            this.DateTimePanel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.DateTimePanel.Size = new System.Drawing.Size(247, 100);
            this.DateTimePanel.TabIndex = 27;
            // 
            // CurrentDate
            // 
            this.CurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentDate.AutoSize = true;
            this.transition.SetDecoration(this.CurrentDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CurrentDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDate.ForeColor = System.Drawing.Color.White;
            this.CurrentDate.Location = new System.Drawing.Point(18, 22);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(210, 20);
            this.CurrentDate.TabIndex = 0;
            this.CurrentDate.Text = "Thursday, February 15, 2025";
            // 
            // CurrentTime
            // 
            this.CurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentTime.AutoSize = true;
            this.transition.SetDecoration(this.CurrentTime, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CurrentTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime.ForeColor = System.Drawing.Color.White;
            this.CurrentTime.Location = new System.Drawing.Point(54, 46);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(138, 30);
            this.CurrentTime.TabIndex = 1;
            this.CurrentTime.Text = "11:56:00 AM";
            // 
            // CurrentTimeTick
            // 
            this.CurrentTimeTick.Enabled = true;
            this.CurrentTimeTick.Tick += new System.EventHandler(this.CurrentTimeTick_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.MainView);
            this.Controls.Add(this.TopPanel);
            this.transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1200, 675);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AR-AR Hardware Payroll";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.MainPanel.ResumeLayout(false);
            this.SidebarPanel.ResumeLayout(false);
            this.AccessView.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainView.ResumeLayout(false);
            this.DateTimePanel.ResumeLayout(false);
            this.DateTimePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Transition transition;
        internal System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SwitchPanel;
        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.FlowLayoutPanel AccessView;
        private Guna.UI2.WinForms.Guna2Button MenuButton;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button EmployeeButton;
        private Guna.UI2.WinForms.Guna2Button AttendanceButton;
        private Guna.UI2.WinForms.Guna2Button WorkLogButton;
        private Guna.UI2.WinForms.Guna2Button PayrollButton;
        private Guna.UI2.WinForms.Guna2Button ReportButton;
        private Guna.UI2.WinForms.Guna2Button BackupButton;
        private Guna.UI2.WinForms.Guna2Button SystemButton;
        private Guna.UI2.WinForms.Guna2Button LogoutButton;
        public System.Windows.Forms.TableLayoutPanel MainView;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel DateTimePanel;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Label CurrentDate;
        private System.Windows.Forms.Timer CurrentTimeTick;
    }
}