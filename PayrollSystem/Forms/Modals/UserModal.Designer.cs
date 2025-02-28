namespace PayrollSystem.Forms.Modals
{
    partial class UserModal
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
            this.borderlessFormAnimation = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SystemCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ReportCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.PayrollCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.WorklogCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.AttendanceCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.EmployeeCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.AllCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.RegisterButton = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderlessFormAnimation
            // 
            this.borderlessFormAnimation.AnimateWindow = true;
            this.borderlessFormAnimation.AnimationInterval = 150;
            this.borderlessFormAnimation.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_POSITIVE;
            this.borderlessFormAnimation.BorderRadius = 15;
            this.borderlessFormAnimation.ContainerControl = this;
            this.borderlessFormAnimation.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessFormAnimation.DragForm = false;
            this.borderlessFormAnimation.DragStartTransparencyValue = 1D;
            this.borderlessFormAnimation.HasFormShadow = false;
            this.borderlessFormAnimation.ResizeForm = false;
            this.borderlessFormAnimation.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 46);
            this.panel1.TabIndex = 151;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(11, 11);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 5, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(149, 21);
            this.label21.TabIndex = 131;
            this.label21.Text = "Register New User";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.CustomIconSize = 13F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(330, 6);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(31, 31);
            this.guna2ControlBox1.TabIndex = 128;
            this.guna2ControlBox1.UseTransparentBackground = true;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.guna2Panel1);
            this.TopPanel.Controls.Add(this.RegisterButton);
            this.TopPanel.Controls.Add(this.PasswordTextBox);
            this.TopPanel.Controls.Add(this.UsernameTextBox);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(0, 46);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(371, 456);
            this.TopPanel.TabIndex = 156;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(54, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 156;
            this.label1.Text = "Permission(s)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.SlateGray;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.SystemCheck);
            this.guna2Panel1.Controls.Add(this.ReportCheck);
            this.guna2Panel1.Controls.Add(this.PayrollCheck);
            this.guna2Panel1.Controls.Add(this.WorklogCheck);
            this.guna2Panel1.Controls.Add(this.AttendanceCheck);
            this.guna2Panel1.Controls.Add(this.EmployeeCheck);
            this.guna2Panel1.Controls.Add(this.AllCheck);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(162, 170);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(157, 202);
            this.guna2Panel1.TabIndex = 160;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // SystemCheck
            // 
            this.SystemCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SystemCheck.CheckedState.BorderRadius = 0;
            this.SystemCheck.CheckedState.BorderThickness = 0;
            this.SystemCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SystemCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SystemCheck.Location = new System.Drawing.Point(12, 171);
            this.SystemCheck.Name = "SystemCheck";
            this.SystemCheck.Size = new System.Drawing.Size(133, 21);
            this.SystemCheck.TabIndex = 7;
            this.SystemCheck.Text = "SETTINGS";
            this.SystemCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SystemCheck.UncheckedState.BorderRadius = 0;
            this.SystemCheck.UncheckedState.BorderThickness = 0;
            this.SystemCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // ReportCheck
            // 
            this.ReportCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReportCheck.CheckedState.BorderRadius = 0;
            this.ReportCheck.CheckedState.BorderThickness = 0;
            this.ReportCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReportCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ReportCheck.Location = new System.Drawing.Point(12, 144);
            this.ReportCheck.Name = "ReportCheck";
            this.ReportCheck.Size = new System.Drawing.Size(133, 21);
            this.ReportCheck.TabIndex = 6;
            this.ReportCheck.Text = "REPORT";
            this.ReportCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ReportCheck.UncheckedState.BorderRadius = 0;
            this.ReportCheck.UncheckedState.BorderThickness = 0;
            this.ReportCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // PayrollCheck
            // 
            this.PayrollCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PayrollCheck.CheckedState.BorderRadius = 0;
            this.PayrollCheck.CheckedState.BorderThickness = 0;
            this.PayrollCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PayrollCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayrollCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PayrollCheck.Location = new System.Drawing.Point(12, 117);
            this.PayrollCheck.Name = "PayrollCheck";
            this.PayrollCheck.Size = new System.Drawing.Size(133, 21);
            this.PayrollCheck.TabIndex = 5;
            this.PayrollCheck.Text = "PAYROLL";
            this.PayrollCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.PayrollCheck.UncheckedState.BorderRadius = 0;
            this.PayrollCheck.UncheckedState.BorderThickness = 0;
            this.PayrollCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // WorklogCheck
            // 
            this.WorklogCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.WorklogCheck.CheckedState.BorderRadius = 0;
            this.WorklogCheck.CheckedState.BorderThickness = 0;
            this.WorklogCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.WorklogCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorklogCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.WorklogCheck.Location = new System.Drawing.Point(12, 90);
            this.WorklogCheck.Name = "WorklogCheck";
            this.WorklogCheck.Size = new System.Drawing.Size(133, 21);
            this.WorklogCheck.TabIndex = 4;
            this.WorklogCheck.Text = "WORKLOG";
            this.WorklogCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.WorklogCheck.UncheckedState.BorderRadius = 0;
            this.WorklogCheck.UncheckedState.BorderThickness = 0;
            this.WorklogCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // AttendanceCheck
            // 
            this.AttendanceCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AttendanceCheck.CheckedState.BorderRadius = 0;
            this.AttendanceCheck.CheckedState.BorderThickness = 0;
            this.AttendanceCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AttendanceCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AttendanceCheck.Location = new System.Drawing.Point(12, 63);
            this.AttendanceCheck.Name = "AttendanceCheck";
            this.AttendanceCheck.Size = new System.Drawing.Size(133, 21);
            this.AttendanceCheck.TabIndex = 3;
            this.AttendanceCheck.Text = "ATTENDANCE";
            this.AttendanceCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AttendanceCheck.UncheckedState.BorderRadius = 0;
            this.AttendanceCheck.UncheckedState.BorderThickness = 0;
            this.AttendanceCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // EmployeeCheck
            // 
            this.EmployeeCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeCheck.CheckedState.BorderRadius = 0;
            this.EmployeeCheck.CheckedState.BorderThickness = 0;
            this.EmployeeCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EmployeeCheck.Location = new System.Drawing.Point(12, 36);
            this.EmployeeCheck.Name = "EmployeeCheck";
            this.EmployeeCheck.Size = new System.Drawing.Size(133, 21);
            this.EmployeeCheck.TabIndex = 2;
            this.EmployeeCheck.Text = "EMPLOYEE";
            this.EmployeeCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.EmployeeCheck.UncheckedState.BorderRadius = 0;
            this.EmployeeCheck.UncheckedState.BorderThickness = 0;
            this.EmployeeCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // AllCheck
            // 
            this.AllCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllCheck.CheckedState.BorderRadius = 0;
            this.AllCheck.CheckedState.BorderThickness = 0;
            this.AllCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllCheck.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AllCheck.Location = new System.Drawing.Point(12, 9);
            this.AllCheck.Name = "AllCheck";
            this.AllCheck.Size = new System.Drawing.Size(133, 21);
            this.AllCheck.TabIndex = 1;
            this.AllCheck.Text = "ALL(*)";
            this.AllCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AllCheck.UncheckedState.BorderRadius = 0;
            this.AllCheck.UncheckedState.BorderThickness = 0;
            this.AllCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.BorderRadius = 5;
            this.RegisterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(51, 394);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(268, 36);
            this.RegisterButton.TabIndex = 159;
            this.RegisterButton.Text = "Register User";
            this.RegisterButton.UseTransparentBackground = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTextBox.BorderRadius = 5;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.IconLeft = global::PayrollSystem.Properties.Resources.lock_2_line;
            this.PasswordTextBox.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.PasswordTextBox.Location = new System.Drawing.Point(51, 98);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.ShadowDecoration.BorderRadius = 11;
            this.PasswordTextBox.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.PasswordTextBox.ShadowDecoration.Depth = 15;
            this.PasswordTextBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.PasswordTextBox.Size = new System.Drawing.Size(268, 42);
            this.PasswordTextBox.TabIndex = 158;
            this.PasswordTextBox.TextOffset = new System.Drawing.Point(5, 0);
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.UsernameTextBox.BorderRadius = 5;
            this.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextBox.DefaultText = "";
            this.UsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UsernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextBox.IconLeft = global::PayrollSystem.Properties.Resources.user_line;
            this.UsernameTextBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.UsernameTextBox.Location = new System.Drawing.Point(51, 26);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PasswordChar = '\0';
            this.UsernameTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.UsernameTextBox.PlaceholderText = "Username";
            this.UsernameTextBox.SelectedText = "";
            this.UsernameTextBox.ShadowDecoration.BorderRadius = 11;
            this.UsernameTextBox.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.UsernameTextBox.ShadowDecoration.Depth = 15;
            this.UsernameTextBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.UsernameTextBox.Size = new System.Drawing.Size(268, 42);
            this.UsernameTextBox.TabIndex = 157;
            this.UsernameTextBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // UserModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(371, 502);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserModal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserView";
            this.Load += new System.EventHandler(this.UserModal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessFormAnimation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CheckBox SystemCheck;
        private Guna.UI2.WinForms.Guna2CheckBox ReportCheck;
        private Guna.UI2.WinForms.Guna2CheckBox PayrollCheck;
        private Guna.UI2.WinForms.Guna2CheckBox WorklogCheck;
        private Guna.UI2.WinForms.Guna2CheckBox AttendanceCheck;
        private Guna.UI2.WinForms.Guna2CheckBox EmployeeCheck;
        private Guna.UI2.WinForms.Guna2CheckBox AllCheck;
        private Guna.UI2.WinForms.Guna2Button RegisterButton;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTextBox;
    }
}