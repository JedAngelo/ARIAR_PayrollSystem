namespace PayrollSystem.Forms.Modals
{
    partial class AttendanceDateModal
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
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.EmployeeViewScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.EmployeeView = new PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.NullLabel = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ColumnHeader = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SetButton = new Guna.UI2.WinForms.Guna2Button();
            this.RefreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.AddLeaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.ModifyButton = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DayTypeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.ColumnHeader.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderColor = System.Drawing.Color.LightSlateGray;
            this.guna2Panel5.BorderRadius = 8;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.NullLabel);
            this.guna2Panel5.Controls.Add(this.EmployeeView);
            this.guna2Panel5.Controls.Add(this.guna2Panel1);
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel5.Location = new System.Drawing.Point(29, 138);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel5.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel5.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel5.ShadowDecoration.Depth = 15;
            this.guna2Panel5.Size = new System.Drawing.Size(808, 339);
            this.guna2Panel5.TabIndex = 89;
            this.guna2Panel5.UseTransparentBackground = true;
            // 
            // EmployeeViewScrollBar
            // 
            this.EmployeeViewScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeViewScrollBar.BindingContainer = this.EmployeeView;
            this.EmployeeViewScrollBar.BorderRadius = 5;
            this.EmployeeViewScrollBar.FillColor = System.Drawing.Color.White;
            this.EmployeeViewScrollBar.InUpdate = false;
            this.EmployeeViewScrollBar.LargeChange = 10;
            this.EmployeeViewScrollBar.Location = new System.Drawing.Point(795, 48);
            this.EmployeeViewScrollBar.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeViewScrollBar.MaximumSize = new System.Drawing.Size(12, 0);
            this.EmployeeViewScrollBar.MinimumSize = new System.Drawing.Size(12, 0);
            this.EmployeeViewScrollBar.Name = "EmployeeViewScrollBar";
            this.EmployeeViewScrollBar.ScrollbarSize = 12;
            this.EmployeeViewScrollBar.Size = new System.Drawing.Size(12, 284);
            this.EmployeeViewScrollBar.TabIndex = 5;
            this.EmployeeViewScrollBar.ThumbColor = System.Drawing.Color.SlateGray;
            this.EmployeeViewScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // EmployeeView
            // 
            this.EmployeeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeView.AutoScroll = true;
            this.EmployeeView.BackColor = System.Drawing.Color.White;
            this.EmployeeView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EmployeeView.Location = new System.Drawing.Point(1, 48);
            this.EmployeeView.Margin = new System.Windows.Forms.Padding(1);
            this.EmployeeView.Name = "EmployeeView";
            this.EmployeeView.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.EmployeeView.Size = new System.Drawing.Size(806, 284);
            this.EmployeeView.TabIndex = 1;
            this.EmployeeView.WrapContents = false;
            // 
            // NullLabel
            // 
            this.NullLabel.AutoSize = true;
            this.NullLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NullLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.NullLabel.Location = new System.Drawing.Point(363, 155);
            this.NullLabel.Name = "NullLabel";
            this.NullLabel.Size = new System.Drawing.Size(97, 42);
            this.NullLabel.TabIndex = 90;
            this.NullLabel.Text = "No Records\r\nFound\r\n";
            this.NullLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NullLabel.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.Controls.Add(this.ColumnHeader);
            this.guna2Panel1.CustomizableEdges.BottomLeft = false;
            this.guna2Panel1.CustomizableEdges.BottomRight = false;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(808, 47);
            this.guna2Panel1.TabIndex = 6;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.ColumnCount = 7;
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.93974F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5984F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5984F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5984F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5984F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.ColumnHeader.Controls.Add(this.label4, 5, 0);
            this.ColumnHeader.Controls.Add(this.label5, 4, 0);
            this.ColumnHeader.Controls.Add(this.label1, 3, 0);
            this.ColumnHeader.Controls.Add(this.label3, 2, 0);
            this.ColumnHeader.Controls.Add(this.label2, 1, 0);
            this.ColumnHeader.Controls.Add(this.label6, 0, 0);
            this.ColumnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnHeader.Location = new System.Drawing.Point(0, 0);
            this.ColumnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.ColumnHeader.Name = "ColumnHeader";
            this.ColumnHeader.RowCount = 1;
            this.ColumnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ColumnHeader.Size = new System.Drawing.Size(808, 47);
            this.ColumnHeader.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(573, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "Time OUT(PM)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(486, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Time IN(PM)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(389, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Time OUT(AM)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(302, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Time IN(AM)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(116, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 91;
            this.label6.Text = "Employee";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 46);
            this.panel1.TabIndex = 154;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderRadius = 5;
            this.guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox2.CustomIconSize = 13F;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1088, 6);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(31, 31);
            this.guna2ControlBox2.TabIndex = 128;
            this.guna2ControlBox2.UseTransparentBackground = true;
            // 
            // DateLabel
            // 
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(0, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(1129, 46);
            this.DateLabel.TabIndex = 129;
            this.DateLabel.Text = "Friday, December 1, 2024";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetButton
            // 
            this.SetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetButton.Animated = true;
            this.SetButton.AnimatedGIF = true;
            this.SetButton.BackColor = System.Drawing.Color.Transparent;
            this.SetButton.BorderRadius = 8;
            this.SetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SetButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.SetButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetButton.ForeColor = System.Drawing.Color.White;
            this.SetButton.Image = global::PayrollSystem.Properties.Resources.calendar_event_fill;
            this.SetButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SetButton.ImageSize = new System.Drawing.Size(18, 18);
            this.SetButton.Location = new System.Drawing.Point(883, 138);
            this.SetButton.Margin = new System.Windows.Forms.Padding(6, 15, 10, 15);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(204, 45);
            this.SetButton.TabIndex = 155;
            this.SetButton.Text = "Set Day Pay Type";
            this.SetButton.UseTransparentBackground = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Animated = true;
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.RefreshButton.BorderRadius = 15;
            this.RefreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RefreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RefreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RefreshButton.FillColor = System.Drawing.Color.Transparent;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.Image = global::PayrollSystem.Properties.Resources.refresh_line__2_;
            this.RefreshButton.ImageSize = new System.Drawing.Size(24, 24);
            this.RefreshButton.Location = new System.Drawing.Point(40, 144);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(31, 31);
            this.RefreshButton.TabIndex = 99;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.Animated = true;
            this.guna2Button2.AnimatedGIF = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::PayrollSystem.Properties.Resources.time_line;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageSize = new System.Drawing.Size(18, 18);
            this.guna2Button2.Location = new System.Drawing.Point(883, 288);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(6, 15, 10, 15);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(204, 45);
            this.guna2Button2.TabIndex = 96;
            this.guna2Button2.Text = "Log Attendance";
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // AddLeaveButton
            // 
            this.AddLeaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLeaveButton.Animated = true;
            this.AddLeaveButton.AnimatedGIF = true;
            this.AddLeaveButton.BackColor = System.Drawing.Color.Transparent;
            this.AddLeaveButton.BorderRadius = 8;
            this.AddLeaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddLeaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddLeaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddLeaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddLeaveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.AddLeaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLeaveButton.ForeColor = System.Drawing.Color.White;
            this.AddLeaveButton.Image = global::PayrollSystem.Properties.Resources.home_4_line;
            this.AddLeaveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddLeaveButton.ImageSize = new System.Drawing.Size(18, 18);
            this.AddLeaveButton.Location = new System.Drawing.Point(883, 363);
            this.AddLeaveButton.Margin = new System.Windows.Forms.Padding(6, 15, 10, 15);
            this.AddLeaveButton.Name = "AddLeaveButton";
            this.AddLeaveButton.Size = new System.Drawing.Size(204, 45);
            this.AddLeaveButton.TabIndex = 95;
            this.AddLeaveButton.Text = "Add Employee Leave";
            this.AddLeaveButton.UseTransparentBackground = true;
            this.AddLeaveButton.Click += new System.EventHandler(this.AddLeaveButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyButton.Animated = true;
            this.ModifyButton.AnimatedGIF = true;
            this.ModifyButton.BackColor = System.Drawing.Color.Transparent;
            this.ModifyButton.BorderRadius = 8;
            this.ModifyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ModifyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ModifyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ModifyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ModifyButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.ModifyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyButton.ForeColor = System.Drawing.Color.White;
            this.ModifyButton.Image = global::PayrollSystem.Properties.Resources.history_line;
            this.ModifyButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ModifyButton.ImageSize = new System.Drawing.Size(18, 18);
            this.ModifyButton.Location = new System.Drawing.Point(883, 213);
            this.ModifyButton.Margin = new System.Windows.Forms.Padding(6, 15, 10, 15);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(204, 45);
            this.ModifyButton.TabIndex = 94;
            this.ModifyButton.Text = "Modify Attendance";
            this.ModifyButton.UseTransparentBackground = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchBox.BorderRadius = 8;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.DefaultText = "";
            this.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.IconLeftSize = new System.Drawing.Size(25, 25);
            this.SearchBox.IconRight = global::PayrollSystem.Properties.Resources.search_line__1_;
            this.SearchBox.IconRightOffset = new System.Drawing.Point(10, 0);
            this.SearchBox.Location = new System.Drawing.Point(862, 74);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderText = "Search";
            this.SearchBox.SelectedText = "";
            this.SearchBox.ShadowDecoration.BorderRadius = 11;
            this.SearchBox.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.SearchBox.ShadowDecoration.Depth = 55;
            this.SearchBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.SearchBox.Size = new System.Drawing.Size(243, 31);
            this.SearchBox.TabIndex = 156;
            this.SearchBox.TextOffset = new System.Drawing.Point(5, 0);
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.EmployeeView;
            // 
            // DayTypeLabel
            // 
            this.DayTypeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DayTypeLabel.Location = new System.Drawing.Point(29, 74);
            this.DayTypeLabel.Name = "DayTypeLabel";
            this.DayTypeLabel.Size = new System.Drawing.Size(808, 46);
            this.DayTypeLabel.TabIndex = 157;
            this.DayTypeLabel.Text = "REGULAR DAY (PAY RATE: 1.0%)";
            this.DayTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(711, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AttendanceDateModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1129, 501);
            this.Controls.Add(this.DayTypeLabel);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.AddLeaveButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.guna2Panel5);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendanceDateModal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AttendanceDateModal";
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ColumnHeader.ResumeLayout(false);
            this.ColumnHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessFormAnimation;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2VScrollBar EmployeeViewScrollBar;
        private UserControls.CustomFlowLayoutPanel EmployeeView;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label NullLabel;
        private Guna.UI2.WinForms.Guna2Button ModifyButton;
        private Guna.UI2.WinForms.Guna2Button AddLeaveButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button RefreshButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DateLabel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Button SetButton;
        private System.Windows.Forms.TableLayoutPanel ColumnHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private System.Windows.Forms.Label DayTypeLabel;
        private System.Windows.Forms.Label label4;
    }
}