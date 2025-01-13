namespace ARIAR_PayrollSystem.Forms.Modals
{
    partial class AddAttendanceModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAttendanceModal));
            this.borderlessFormAnimation = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.FullnameLabel = new System.Windows.Forms.Label();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.EmployeePictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.TimeOutPmTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeInPmTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeOutAmTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeInAmTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SubLabel = new System.Windows.Forms.Label();
            this.SelectAllButton = new Guna.UI2.WinForms.Guna2Button();
            this.ClearAllButton = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProgressCircle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.EmployeeViewScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.EmployeeView = new ARIAR_PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePictureBox)).BeginInit();
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
            // FullnameLabel
            // 
            this.FullnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FullnameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FullnameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.FullnameLabel.Location = new System.Drawing.Point(387, 262);
            this.FullnameLabel.Margin = new System.Windows.Forms.Padding(2, 5, 2, 0);
            this.FullnameLabel.Name = "FullnameLabel";
            this.FullnameLabel.Size = new System.Drawing.Size(237, 25);
            this.FullnameLabel.TabIndex = 99;
            this.FullnameLabel.Text = "---";
            this.FullnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2Panel7.BorderRadius = 8;
            this.guna2Panel7.BorderThickness = 1;
            this.guna2Panel7.Controls.Add(this.EmployeePictureBox);
            this.guna2Panel7.FillColor = System.Drawing.Color.White;
            this.guna2Panel7.Location = new System.Drawing.Point(439, 120);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Padding = new System.Windows.Forms.Padding(3);
            this.guna2Panel7.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel7.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel7.ShadowDecoration.Depth = 15;
            this.guna2Panel7.Size = new System.Drawing.Size(130, 131);
            this.guna2Panel7.TabIndex = 98;
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
            this.guna2Panel5.Location = new System.Drawing.Point(25, 66);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.guna2Panel5.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel5.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel5.ShadowDecoration.Depth = 15;
            this.guna2Panel5.Size = new System.Drawing.Size(338, 481);
            this.guna2Panel5.TabIndex = 96;
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
            this.guna2Panel1.Size = new System.Drawing.Size(338, 36);
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
            this.label8.Size = new System.Drawing.Size(338, 36);
            this.label8.TabIndex = 2;
            this.label8.Text = "Empoyees";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddButton
            // 
            this.AddButton.Animated = true;
            this.AddButton.AnimatedGIF = true;
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BorderRadius = 5;
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(390, 516);
            this.AddButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(234, 31);
            this.AddButton.TabIndex = 113;
            this.AddButton.Text = "Save";
            this.AddButton.UseTransparentBackground = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TimeOutPmTextBox
            // 
            this.TimeOutPmTextBox.BorderRadius = 8;
            this.TimeOutPmTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeOutPmTextBox.DefaultText = "";
            this.TimeOutPmTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TimeOutPmTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TimeOutPmTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeOutPmTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeOutPmTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeOutPmTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TimeOutPmTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TimeOutPmTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeOutPmTextBox.Location = new System.Drawing.Point(493, 438);
            this.TimeOutPmTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeOutPmTextBox.Name = "TimeOutPmTextBox";
            this.TimeOutPmTextBox.PasswordChar = '\0';
            this.TimeOutPmTextBox.PlaceholderText = "5:00";
            this.TimeOutPmTextBox.SelectedText = "";
            this.TimeOutPmTextBox.Size = new System.Drawing.Size(131, 37);
            this.TimeOutPmTextBox.TabIndex = 112;
            this.TimeOutPmTextBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(385, 448);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 111;
            this.label3.Text = "Time OUT (PM)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeInPmTextBox
            // 
            this.TimeInPmTextBox.BorderRadius = 8;
            this.TimeInPmTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeInPmTextBox.DefaultText = "";
            this.TimeInPmTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TimeInPmTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TimeInPmTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeInPmTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeInPmTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeInPmTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TimeInPmTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TimeInPmTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeInPmTextBox.Location = new System.Drawing.Point(493, 393);
            this.TimeInPmTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeInPmTextBox.Name = "TimeInPmTextBox";
            this.TimeInPmTextBox.PasswordChar = '\0';
            this.TimeInPmTextBox.PlaceholderText = "1:00";
            this.TimeInPmTextBox.SelectedText = "";
            this.TimeInPmTextBox.Size = new System.Drawing.Size(131, 37);
            this.TimeInPmTextBox.TabIndex = 110;
            this.TimeInPmTextBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(385, 403);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 109;
            this.label2.Text = "Time IN (PM)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeOutAmTextBox
            // 
            this.TimeOutAmTextBox.BorderRadius = 8;
            this.TimeOutAmTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeOutAmTextBox.DefaultText = "";
            this.TimeOutAmTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TimeOutAmTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TimeOutAmTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeOutAmTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeOutAmTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeOutAmTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TimeOutAmTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TimeOutAmTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeOutAmTextBox.Location = new System.Drawing.Point(493, 348);
            this.TimeOutAmTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeOutAmTextBox.Name = "TimeOutAmTextBox";
            this.TimeOutAmTextBox.PasswordChar = '\0';
            this.TimeOutAmTextBox.PlaceholderText = "12:00";
            this.TimeOutAmTextBox.SelectedText = "";
            this.TimeOutAmTextBox.Size = new System.Drawing.Size(131, 37);
            this.TimeOutAmTextBox.TabIndex = 108;
            this.TimeOutAmTextBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(385, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 107;
            this.label1.Text = "Time OUT (AM)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeInAmTextBox
            // 
            this.TimeInAmTextBox.BorderRadius = 8;
            this.TimeInAmTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeInAmTextBox.DefaultText = "";
            this.TimeInAmTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TimeInAmTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TimeInAmTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeInAmTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeInAmTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeInAmTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TimeInAmTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TimeInAmTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeInAmTextBox.Location = new System.Drawing.Point(493, 303);
            this.TimeInAmTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeInAmTextBox.Name = "TimeInAmTextBox";
            this.TimeInAmTextBox.PasswordChar = '\0';
            this.TimeInAmTextBox.PlaceholderText = "8:00";
            this.TimeInAmTextBox.SelectedText = "";
            this.TimeInAmTextBox.Size = new System.Drawing.Size(131, 37);
            this.TimeInAmTextBox.TabIndex = 106;
            this.TimeInAmTextBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // SubLabel
            // 
            this.SubLabel.AutoSize = true;
            this.SubLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SubLabel.Location = new System.Drawing.Point(385, 313);
            this.SubLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SubLabel.Name = "SubLabel";
            this.SubLabel.Size = new System.Drawing.Size(91, 18);
            this.SubLabel.TabIndex = 105;
            this.SubLabel.Text = "Time IN (AM)";
            this.SubLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.SelectAllButton.Location = new System.Drawing.Point(118, 551);
            this.SelectAllButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(92, 24);
            this.SelectAllButton.TabIndex = 115;
            this.SelectAllButton.Text = "SELECT ALL";
            this.SelectAllButton.UseTransparentBackground = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.ClearAllButton.Location = new System.Drawing.Point(25, 551);
            this.ClearAllButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(86, 24);
            this.ClearAllButton.TabIndex = 114;
            this.ClearAllButton.Text = "CLEAR ALL";
            this.ClearAllButton.UseTransparentBackground = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
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
            this.SearchBox.IconRight = global::ARIAR_PayrollSystem.Properties.Resources.search_line__1_;
            this.SearchBox.IconRightOffset = new System.Drawing.Point(10, 0);
            this.SearchBox.Location = new System.Drawing.Point(381, 66);
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
            this.SearchBox.TabIndex = 97;
            this.SearchBox.TextOffset = new System.Drawing.Point(5, 0);
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // ProgressCircle
            // 
            this.ProgressCircle.Animated = true;
            this.ProgressCircle.BackColor = System.Drawing.Color.Transparent;
            this.ProgressCircle.EnsureVisible = true;
            this.ProgressCircle.FillColor = System.Drawing.Color.White;
            this.ProgressCircle.FillThickness = 3;
            this.ProgressCircle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProgressCircle.ForeColor = System.Drawing.Color.White;
            this.ProgressCircle.Location = new System.Drawing.Point(401, 522);
            this.ProgressCircle.Minimum = 0;
            this.ProgressCircle.Name = "ProgressCircle";
            this.ProgressCircle.ProgressColor = System.Drawing.Color.LightSeaGreen;
            this.ProgressCircle.ProgressColor2 = System.Drawing.Color.LightSeaGreen;
            this.ProgressCircle.ProgressThickness = 3;
            this.ProgressCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressCircle.Size = new System.Drawing.Size(20, 20);
            this.ProgressCircle.TabIndex = 116;
            this.ProgressCircle.Text = "guna2CircleProgressBar1";
            this.ProgressCircle.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.ProgressCircle.UseTransparentBackground = true;
            this.ProgressCircle.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 46);
            this.panel1.TabIndex = 153;
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(607, 6);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(31, 31);
            this.guna2ControlBox2.TabIndex = 128;
            this.guna2ControlBox2.UseTransparentBackground = true;
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
            this.EmployeeViewScrollBar.Location = new System.Drawing.Point(325, 36);
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
            this.EmployeeView.Size = new System.Drawing.Size(336, 439);
            this.EmployeeView.TabIndex = 1;
            this.EmployeeView.WrapContents = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Size = new System.Drawing.Size(648, 46);
            this.label4.TabIndex = 129;
            this.label4.Text = "LOG ATTENDANCE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddAttendanceModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(648, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProgressCircle);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TimeOutPmTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeInPmTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeOutAmTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeInAmTextBox);
            this.Controls.Add(this.SubLabel);
            this.Controls.Add(this.FullnameLabel);
            this.Controls.Add(this.guna2Panel7);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.guna2Panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAttendanceModal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddAttendanceModal";
            this.guna2Panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePictureBox)).EndInit();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessFormAnimation;
        private System.Windows.Forms.Label FullnameLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2PictureBox EmployeePictureBox;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2VScrollBar EmployeeViewScrollBar;
        private UserControls.CustomFlowLayoutPanel EmployeeView;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2TextBox TimeOutPmTextBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TimeInPmTextBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TimeOutAmTextBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TimeInAmTextBox;
        private System.Windows.Forms.Label SubLabel;
        private Guna.UI2.WinForms.Guna2Button SelectAllButton;
        private Guna.UI2.WinForms.Guna2Button ClearAllButton;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressCircle;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Label label4;
    }
}