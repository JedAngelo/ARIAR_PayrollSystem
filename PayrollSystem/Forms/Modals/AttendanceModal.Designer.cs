namespace PayrollSystem.Forms.Modals
{
    partial class AttendanceModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceModal));
            this.borderlessFormAnimation = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SubLabel = new System.Windows.Forms.Label();
            this.TimeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AttendanceButton = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.FullnameLabel = new System.Windows.Forms.Label();
            this.EmployeePictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.EmployeeView = new PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.EmployeeViewScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ClearAllButton = new Guna.UI2.WinForms.Guna2Button();
            this.SelectAllButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePictureBox)).BeginInit();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
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
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(629, 46);
            this.TitleLabel.TabIndex = 87;
            this.TitleLabel.Text = "Manual Time IN (AM)";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubLabel
            // 
            this.SubLabel.AutoSize = true;
            this.SubLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SubLabel.Location = new System.Drawing.Point(371, 326);
            this.SubLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubLabel.Name = "SubLabel";
            this.SubLabel.Size = new System.Drawing.Size(91, 18);
            this.SubLabel.TabIndex = 90;
            this.SubLabel.Text = "Time IN (AM)";
            this.SubLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.BorderRadius = 8;
            this.TimeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeTextBox.DefaultText = "";
            this.TimeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TimeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TimeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TimeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TimeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeTextBox.Location = new System.Drawing.Point(479, 316);
            this.TimeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.PasswordChar = '\0';
            this.TimeTextBox.PlaceholderText = "08:00";
            this.TimeTextBox.SelectedText = "";
            this.TimeTextBox.Size = new System.Drawing.Size(131, 37);
            this.TimeTextBox.TabIndex = 91;
            this.TimeTextBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // AttendanceButton
            // 
            this.AttendanceButton.Animated = true;
            this.AttendanceButton.AnimatedGIF = true;
            this.AttendanceButton.BackColor = System.Drawing.Color.Transparent;
            this.AttendanceButton.BorderRadius = 8;
            this.AttendanceButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AttendanceButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AttendanceButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AttendanceButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AttendanceButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(60)))));
            this.AttendanceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceButton.ForeColor = System.Drawing.Color.White;
            this.AttendanceButton.Image = global::PayrollSystem.Properties.Resources.time_line;
            this.AttendanceButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AttendanceButton.ImageSize = new System.Drawing.Size(18, 18);
            this.AttendanceButton.Location = new System.Drawing.Point(373, 375);
            this.AttendanceButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.AttendanceButton.Name = "AttendanceButton";
            this.AttendanceButton.Size = new System.Drawing.Size(237, 37);
            this.AttendanceButton.TabIndex = 93;
            this.AttendanceButton.Text = "TIME IN";
            this.AttendanceButton.UseTransparentBackground = true;
            this.AttendanceButton.Click += new System.EventHandler(this.AttendanceButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.SearchBox.Location = new System.Drawing.Point(373, 63);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderText = "Search";
            this.SearchBox.SelectedText = "";
            this.SearchBox.ShadowDecoration.BorderRadius = 11;
            this.SearchBox.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.SearchBox.ShadowDecoration.Depth = 55;
            this.SearchBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.SearchBox.Size = new System.Drawing.Size(237, 31);
            this.SearchBox.TabIndex = 92;
            this.SearchBox.TextOffset = new System.Drawing.Point(5, 0);
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // FullnameLabel
            // 
            this.FullnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FullnameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FullnameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.FullnameLabel.Location = new System.Drawing.Point(373, 261);
            this.FullnameLabel.Margin = new System.Windows.Forms.Padding(2, 5, 2, 0);
            this.FullnameLabel.Name = "FullnameLabel";
            this.FullnameLabel.Size = new System.Drawing.Size(237, 25);
            this.FullnameLabel.TabIndex = 95;
            this.FullnameLabel.Text = "---";
            this.FullnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeePictureBox
            // 
            this.EmployeePictureBox.BackColor = System.Drawing.Color.White;
            this.EmployeePictureBox.BorderRadius = 5;
            this.EmployeePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeePictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("EmployeePictureBox.ErrorImage")));
            this.EmployeePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EmployeePictureBox.Image")));
            this.EmployeePictureBox.ImageRotate = 0F;
            this.EmployeePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("EmployeePictureBox.InitialImage")));
            this.EmployeePictureBox.Location = new System.Drawing.Point(3, 3);
            this.EmployeePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeePictureBox.Name = "EmployeePictureBox";
            this.EmployeePictureBox.ShadowDecoration.BorderRadius = 11;
            this.EmployeePictureBox.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.EmployeePictureBox.Size = new System.Drawing.Size(124, 125);
            this.EmployeePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmployeePictureBox.TabIndex = 11;
            this.EmployeePictureBox.TabStop = false;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2Panel7.BorderRadius = 8;
            this.guna2Panel7.BorderThickness = 1;
            this.guna2Panel7.Controls.Add(this.EmployeePictureBox);
            this.guna2Panel7.FillColor = System.Drawing.Color.White;
            this.guna2Panel7.Location = new System.Drawing.Point(428, 119);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Padding = new System.Windows.Forms.Padding(3);
            this.guna2Panel7.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel7.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel7.ShadowDecoration.Depth = 15;
            this.guna2Panel7.Size = new System.Drawing.Size(130, 131);
            this.guna2Panel7.TabIndex = 94;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.EmployeeView;
            // 
            // EmployeeView
            // 
            this.EmployeeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeView.AutoScroll = true;
            this.EmployeeView.BackColor = System.Drawing.Color.White;
            this.EmployeeView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EmployeeView.Location = new System.Drawing.Point(1, 36);
            this.EmployeeView.Margin = new System.Windows.Forms.Padding(1);
            this.EmployeeView.Name = "EmployeeView";
            this.EmployeeView.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.EmployeeView.Size = new System.Drawing.Size(338, 307);
            this.EmployeeView.TabIndex = 1;
            this.EmployeeView.WrapContents = false;
            // 
            // EmployeeViewScrollBar
            // 
            this.EmployeeViewScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeViewScrollBar.BindingContainer = this.EmployeeView;
            this.EmployeeViewScrollBar.BorderRadius = 5;
            this.EmployeeViewScrollBar.FillColor = System.Drawing.Color.White;
            this.EmployeeViewScrollBar.InUpdate = false;
            this.EmployeeViewScrollBar.LargeChange = 10;
            this.EmployeeViewScrollBar.Location = new System.Drawing.Point(327, 36);
            this.EmployeeViewScrollBar.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeViewScrollBar.MaximumSize = new System.Drawing.Size(12, 0);
            this.EmployeeViewScrollBar.MinimumSize = new System.Drawing.Size(12, 0);
            this.EmployeeViewScrollBar.Name = "EmployeeViewScrollBar";
            this.EmployeeViewScrollBar.ScrollbarSize = 12;
            this.EmployeeViewScrollBar.Size = new System.Drawing.Size(12, 0);
            this.EmployeeViewScrollBar.TabIndex = 5;
            this.EmployeeViewScrollBar.ThumbColor = System.Drawing.Color.SlateGray;
            this.EmployeeViewScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderColor = System.Drawing.Color.LightSlateGray;
            this.guna2Panel5.BorderRadius = 8;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.EmployeeViewScrollBar);
            this.guna2Panel5.Controls.Add(this.EmployeeView);
            this.guna2Panel5.Controls.Add(this.guna2Panel1);
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel5.Location = new System.Drawing.Point(18, 63);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.guna2Panel5.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel5.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel5.ShadowDecoration.Depth = 15;
            this.guna2Panel5.Size = new System.Drawing.Size(340, 349);
            this.guna2Panel5.TabIndex = 88;
            this.guna2Panel5.UseTransparentBackground = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.CustomizableEdges.BottomLeft = false;
            this.guna2Panel1.CustomizableEdges.BottomRight = false;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(340, 36);
            this.guna2Panel1.TabIndex = 6;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label8.Size = new System.Drawing.Size(340, 36);
            this.label8.TabIndex = 2;
            this.label8.Text = "Empoyees";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Animated = true;
            this.ClearAllButton.AnimatedGIF = true;
            this.ClearAllButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearAllButton.BorderRadius = 8;
            this.ClearAllButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearAllButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearAllButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearAllButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearAllButton.FillColor = System.Drawing.Color.Transparent;
            this.ClearAllButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAllButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.ClearAllButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClearAllButton.ImageSize = new System.Drawing.Size(18, 18);
            this.ClearAllButton.Location = new System.Drawing.Point(19, 417);
            this.ClearAllButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(86, 24);
            this.ClearAllButton.TabIndex = 96;
            this.ClearAllButton.Text = "CLEAR ALL";
            this.ClearAllButton.UseTransparentBackground = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Animated = true;
            this.SelectAllButton.AnimatedGIF = true;
            this.SelectAllButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectAllButton.BorderRadius = 8;
            this.SelectAllButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectAllButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectAllButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectAllButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectAllButton.FillColor = System.Drawing.Color.Transparent;
            this.SelectAllButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAllButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.SelectAllButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SelectAllButton.ImageSize = new System.Drawing.Size(18, 18);
            this.SelectAllButton.Location = new System.Drawing.Point(112, 417);
            this.SelectAllButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(92, 24);
            this.SelectAllButton.TabIndex = 97;
            this.SelectAllButton.Text = "SELECT ALL";
            this.SelectAllButton.UseTransparentBackground = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 46);
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(588, 6);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(31, 31);
            this.guna2ControlBox2.TabIndex = 128;
            this.guna2ControlBox2.UseTransparentBackground = true;
            // 
            // AttendanceModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(629, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.FullnameLabel);
            this.Controls.Add(this.guna2Panel7);
            this.Controls.Add(this.AttendanceButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.SubLabel);
            this.Controls.Add(this.guna2Panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendanceModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AttendanceModal";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePictureBox)).EndInit();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessFormAnimation;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubLabel;
        private Guna.UI2.WinForms.Guna2TextBox TimeTextBox;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private Guna.UI2.WinForms.Guna2Button AttendanceButton;
        private System.Windows.Forms.Label FullnameLabel;
        private Guna.UI2.WinForms.Guna2PictureBox EmployeePictureBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2VScrollBar EmployeeViewScrollBar;
        private UserControls.CustomFlowLayoutPanel EmployeeView;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button SelectAllButton;
        private Guna.UI2.WinForms.Guna2Button ClearAllButton;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}