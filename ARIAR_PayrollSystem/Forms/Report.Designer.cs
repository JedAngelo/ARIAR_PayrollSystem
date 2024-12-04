namespace ARIAR_PayrollSystem.Forms
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.EmployeeViewScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.ReportView = new ARIAR_PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label5 = new System.Windows.Forms.Label();
            this.AddEmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PageLabel = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.guna2Button7);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.guna2TextBox2);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.PageLabel);
            this.MainPanel.Controls.Add(this.guna2Button3);
            this.MainPanel.Controls.Add(this.guna2Button4);
            this.MainPanel.Controls.Add(this.guna2Button5);
            this.MainPanel.Controls.Add(this.guna2Button6);
            this.MainPanel.Controls.Add(this.guna2ComboBox2);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.guna2ComboBox1);
            this.MainPanel.Controls.Add(this.guna2Button2);
            this.MainPanel.Controls.Add(this.AddEmployeeButton);
            this.MainPanel.Controls.Add(this.guna2Panel5);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1040, 640);
            this.MainPanel.TabIndex = 0;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderRadius = 8;
            this.guna2Panel5.Controls.Add(this.EmployeeViewScrollBar);
            this.guna2Panel5.Controls.Add(this.guna2Button1);
            this.guna2Panel5.Controls.Add(this.guna2Separator1);
            this.guna2Panel5.Controls.Add(this.ReportView);
            this.guna2Panel5.Controls.Add(this.label5);
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel5.Location = new System.Drawing.Point(42, 121);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel5.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel5.ShadowDecoration.Depth = 15;
            this.guna2Panel5.ShadowDecoration.Enabled = true;
            this.guna2Panel5.Size = new System.Drawing.Size(955, 461);
            this.guna2Panel5.TabIndex = 17;
            this.guna2Panel5.UseTransparentBackground = true;
            // 
            // EmployeeViewScrollBar
            // 
            this.EmployeeViewScrollBar.BindingContainer = this.ReportView;
            this.EmployeeViewScrollBar.BorderRadius = 3;
            this.EmployeeViewScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmployeeViewScrollBar.FillColor = System.Drawing.Color.White;
            this.EmployeeViewScrollBar.InUpdate = false;
            this.EmployeeViewScrollBar.LargeChange = 10;
            this.EmployeeViewScrollBar.Location = new System.Drawing.Point(943, 36);
            this.EmployeeViewScrollBar.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeViewScrollBar.MaximumSize = new System.Drawing.Size(12, 0);
            this.EmployeeViewScrollBar.MinimumSize = new System.Drawing.Size(12, 0);
            this.EmployeeViewScrollBar.Name = "EmployeeViewScrollBar";
            this.EmployeeViewScrollBar.ScrollbarSize = 12;
            this.EmployeeViewScrollBar.Size = new System.Drawing.Size(12, 425);
            this.EmployeeViewScrollBar.TabIndex = 5;
            this.EmployeeViewScrollBar.ThumbColor = System.Drawing.Color.SlateGray;
            this.EmployeeViewScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // ReportView
            // 
            this.ReportView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportView.AutoScroll = true;
            this.ReportView.BackColor = System.Drawing.Color.White;
            this.ReportView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ReportView.Location = new System.Drawing.Point(0, 36);
            this.ReportView.Margin = new System.Windows.Forms.Padding(0);
            this.ReportView.Name = "ReportView";
            this.ReportView.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.ReportView.Size = new System.Drawing.Size(955, 425);
            this.ReportView.TabIndex = 1;
            this.ReportView.Visible = false;
            this.ReportView.WrapContents = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::ARIAR_PayrollSystem.Properties.Resources.refresh_line_2_;
            this.guna2Button1.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button1.Location = new System.Drawing.Point(915, 0);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(40, 35);
            this.guna2Button1.TabIndex = 4;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.SlateGray;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 30);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(955, 10);
            this.guna2Separator1.TabIndex = 2;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(955, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "Reports";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployeeButton.Animated = true;
            this.AddEmployeeButton.AnimatedGIF = true;
            this.AddEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployeeButton.BorderRadius = 5;
            this.AddEmployeeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddEmployeeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddEmployeeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddEmployeeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddEmployeeButton.FillColor = System.Drawing.Color.DodgerBlue;
            this.AddEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.AddEmployeeButton.Image = ((System.Drawing.Image)(resources.GetObject("AddEmployeeButton.Image")));
            this.AddEmployeeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddEmployeeButton.ImageSize = new System.Drawing.Size(24, 24);
            this.AddEmployeeButton.Location = new System.Drawing.Point(549, 79);
            this.AddEmployeeButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(216, 37);
            this.AddEmployeeButton.TabIndex = 30;
            this.AddEmployeeButton.Text = "Generate Attendance Report";
            this.AddEmployeeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddEmployeeButton.UseTransparentBackground = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.Animated = true;
            this.guna2Button2.AnimatedGIF = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button2.Location = new System.Drawing.Point(317, 79);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(216, 37);
            this.guna2Button2.TabIndex = 31;
            this.guna2Button2.Text = "Generate Payroll Report";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(43, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Sort by:";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 8;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.IntegralHeight = false;
            this.guna2ComboBox1.ItemHeight = 25;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Name (descending)",
            "Name (ascending)"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(103, 85);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.BorderRadius = 11;
            this.guna2ComboBox1.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2ComboBox1.ShadowDecoration.Depth = 15;
            this.guna2ComboBox1.ShadowDecoration.Enabled = true;
            this.guna2ComboBox1.Size = new System.Drawing.Size(176, 31);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(829, 603);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Views per page:";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2TextBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.BorderRadius = 8;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "1";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(487, 595);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.BorderRadius = 11;
            this.guna2TextBox2.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2TextBox2.ShadowDecoration.Depth = 15;
            this.guna2TextBox2.ShadowDecoration.Enabled = true;
            this.guna2TextBox2.Size = new System.Drawing.Size(48, 30);
            this.guna2TextBox2.TabIndex = 41;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(88, 605);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "1 - 10 of 21";
            // 
            // PageLabel
            // 
            this.PageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PageLabel.Location = new System.Drawing.Point(39, 605);
            this.PageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(45, 15);
            this.PageLabel.TabIndex = 39;
            this.PageLabel.Text = "Result:";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 8;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button3.Image = global::ARIAR_PayrollSystem.Properties.Resources.arrow_right_double_line;
            this.guna2Button3.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button3.IndicateFocus = true;
            this.guna2Button3.Location = new System.Drawing.Point(568, 595);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.Color.White;
            this.guna2Button3.ShadowDecoration.BorderRadius = 11;
            this.guna2Button3.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button3.ShadowDecoration.Depth = 15;
            this.guna2Button3.Size = new System.Drawing.Size(30, 30);
            this.guna2Button3.TabIndex = 38;
            this.guna2Button3.UseTransparentBackground = true;
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Button4.Animated = true;
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 8;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button4.Image = global::ARIAR_PayrollSystem.Properties.Resources.arrow_right_s_line;
            this.guna2Button4.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button4.IndicateFocus = true;
            this.guna2Button4.Location = new System.Drawing.Point(538, 595);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.White;
            this.guna2Button4.ShadowDecoration.BorderRadius = 11;
            this.guna2Button4.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button4.ShadowDecoration.Depth = 15;
            this.guna2Button4.Size = new System.Drawing.Size(30, 30);
            this.guna2Button4.TabIndex = 37;
            this.guna2Button4.UseTransparentBackground = true;
            // 
            // guna2Button5
            // 
            this.guna2Button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Button5.Animated = true;
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 8;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Button5.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button5.Image = global::ARIAR_PayrollSystem.Properties.Resources.arrow_left_double_line;
            this.guna2Button5.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button5.IndicateFocus = true;
            this.guna2Button5.Location = new System.Drawing.Point(424, 595);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.PressedColor = System.Drawing.Color.White;
            this.guna2Button5.ShadowDecoration.BorderRadius = 11;
            this.guna2Button5.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button5.ShadowDecoration.Depth = 15;
            this.guna2Button5.Size = new System.Drawing.Size(30, 30);
            this.guna2Button5.TabIndex = 36;
            this.guna2Button5.UseTransparentBackground = true;
            // 
            // guna2Button6
            // 
            this.guna2Button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Button6.Animated = true;
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderRadius = 8;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Button6.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button6.Image = global::ARIAR_PayrollSystem.Properties.Resources.arrow_left_s_line;
            this.guna2Button6.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button6.IndicateFocus = true;
            this.guna2Button6.Location = new System.Drawing.Point(454, 595);
            this.guna2Button6.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.PressedColor = System.Drawing.Color.White;
            this.guna2Button6.ShadowDecoration.BorderRadius = 11;
            this.guna2Button6.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button6.ShadowDecoration.Depth = 15;
            this.guna2Button6.Size = new System.Drawing.Size(30, 30);
            this.guna2Button6.TabIndex = 35;
            this.guna2Button6.UseTransparentBackground = true;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderRadius = 8;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.IntegralHeight = false;
            this.guna2ComboBox2.ItemHeight = 25;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "10",
            "20",
            "30"});
            this.guna2ComboBox2.Location = new System.Drawing.Point(931, 594);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.ShadowDecoration.BorderRadius = 11;
            this.guna2ComboBox2.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2ComboBox2.ShadowDecoration.Depth = 15;
            this.guna2ComboBox2.ShadowDecoration.Enabled = true;
            this.guna2ComboBox2.Size = new System.Drawing.Size(66, 31);
            this.guna2ComboBox2.StartIndex = 0;
            this.guna2ComboBox2.TabIndex = 34;
            this.guna2ComboBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Button7
            // 
            this.guna2Button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button7.Animated = true;
            this.guna2Button7.AnimatedGIF = true;
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderRadius = 5;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button7.Image")));
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button7.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button7.Location = new System.Drawing.Point(781, 79);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(216, 37);
            this.guna2Button7.TabIndex = 43;
            this.guna2Button7.Text = "Generate Annual Report";
            this.guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.UseTransparentBackground = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2VScrollBar EmployeeViewScrollBar;
        private UserControls.CustomFlowLayoutPanel ReportView;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button AddEmployeeButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PageLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
    }
}