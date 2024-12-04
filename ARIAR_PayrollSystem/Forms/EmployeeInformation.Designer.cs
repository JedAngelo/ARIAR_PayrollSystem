namespace ARIAR_PayrollSystem.Forms
{
    partial class EmployeeInformation
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
            this.EmployeeInfoPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PageLabel = new System.Windows.Forms.Label();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.EmployeeViewScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.EmployeeTableView = new ARIAR_PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.ProgressCircle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TimerProcess = new System.Windows.Forms.Timer(this.components);
            this.AddEmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmployeeInfoPanel.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeInfoPanel
            // 
            this.EmployeeInfoPanel.BackColor = System.Drawing.Color.White;
            this.EmployeeInfoPanel.Controls.Add(this.AddEmployeeButton);
            this.EmployeeInfoPanel.Controls.Add(this.label4);
            this.EmployeeInfoPanel.Controls.Add(this.guna2TextBox2);
            this.EmployeeInfoPanel.Controls.Add(this.label3);
            this.EmployeeInfoPanel.Controls.Add(this.PageLabel);
            this.EmployeeInfoPanel.Controls.Add(this.guna2Button2);
            this.EmployeeInfoPanel.Controls.Add(this.guna2Button3);
            this.EmployeeInfoPanel.Controls.Add(this.guna2Button4);
            this.EmployeeInfoPanel.Controls.Add(this.guna2Button5);
            this.EmployeeInfoPanel.Controls.Add(this.guna2ComboBox2);
            this.EmployeeInfoPanel.Controls.Add(this.label2);
            this.EmployeeInfoPanel.Controls.Add(this.guna2ComboBox1);
            this.EmployeeInfoPanel.Controls.Add(this.guna2Panel5);
            this.EmployeeInfoPanel.Controls.Add(this.SearchBox);
            this.EmployeeInfoPanel.Controls.Add(this.TimeLabel);
            this.EmployeeInfoPanel.Controls.Add(this.DateLabel);
            this.EmployeeInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeInfoPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.EmployeeInfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeInfoPanel.Name = "EmployeeInfoPanel";
            this.EmployeeInfoPanel.Size = new System.Drawing.Size(990, 704);
            this.EmployeeInfoPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(776, 666);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 27;
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
            this.guna2TextBox2.Location = new System.Drawing.Point(478, 659);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.BorderRadius = 11;
            this.guna2TextBox2.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2TextBox2.ShadowDecoration.Depth = 15;
            this.guna2TextBox2.ShadowDecoration.Enabled = true;
            this.guna2TextBox2.Size = new System.Drawing.Size(48, 30);
            this.guna2TextBox2.TabIndex = 26;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(96, 670);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "1 - 10 of 21";
            // 
            // PageLabel
            // 
            this.PageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PageLabel.Location = new System.Drawing.Point(47, 670);
            this.PageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(45, 15);
            this.PageLabel.TabIndex = 24;
            this.PageLabel.Text = "Result:";
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
            this.guna2ComboBox2.Location = new System.Drawing.Point(878, 657);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.ShadowDecoration.BorderRadius = 11;
            this.guna2ComboBox2.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2ComboBox2.ShadowDecoration.Depth = 15;
            this.guna2ComboBox2.ShadowDecoration.Enabled = true;
            this.guna2ComboBox2.Size = new System.Drawing.Size(66, 31);
            this.guna2ComboBox2.StartIndex = 0;
            this.guna2ComboBox2.TabIndex = 19;
            this.guna2ComboBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(50, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 18;
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
            this.guna2ComboBox1.Location = new System.Drawing.Point(110, 104);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.BorderRadius = 11;
            this.guna2ComboBox1.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2ComboBox1.ShadowDecoration.Depth = 15;
            this.guna2ComboBox1.ShadowDecoration.Enabled = true;
            this.guna2ComboBox1.Size = new System.Drawing.Size(176, 31);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.TabIndex = 17;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
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
            this.guna2Panel5.Controls.Add(this.ProgressCircle);
            this.guna2Panel5.Controls.Add(this.LoadingLabel);
            this.guna2Panel5.Controls.Add(this.EmployeeTableView);
            this.guna2Panel5.Controls.Add(this.label5);
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel5.Location = new System.Drawing.Point(46, 157);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel5.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel5.ShadowDecoration.Depth = 15;
            this.guna2Panel5.ShadowDecoration.Enabled = true;
            this.guna2Panel5.Size = new System.Drawing.Size(898, 489);
            this.guna2Panel5.TabIndex = 16;
            this.guna2Panel5.UseTransparentBackground = true;
            // 
            // EmployeeViewScrollBar
            // 
            this.EmployeeViewScrollBar.BindingContainer = this.EmployeeTableView;
            this.EmployeeViewScrollBar.BorderRadius = 3;
            this.EmployeeViewScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmployeeViewScrollBar.FillColor = System.Drawing.Color.White;
            this.EmployeeViewScrollBar.InUpdate = false;
            this.EmployeeViewScrollBar.LargeChange = 10;
            this.EmployeeViewScrollBar.Location = new System.Drawing.Point(886, 36);
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
            // EmployeeTableView
            // 
            this.EmployeeTableView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeTableView.AutoScroll = true;
            this.EmployeeTableView.BackColor = System.Drawing.Color.White;
            this.EmployeeTableView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EmployeeTableView.Location = new System.Drawing.Point(0, 36);
            this.EmployeeTableView.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeTableView.Name = "EmployeeTableView";
            this.EmployeeTableView.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.EmployeeTableView.Size = new System.Drawing.Size(898, 453);
            this.EmployeeTableView.TabIndex = 1;
            this.EmployeeTableView.Visible = false;
            this.EmployeeTableView.WrapContents = false;
            this.EmployeeTableView.SizeChanged += new System.EventHandler(this.EmployeeTableView_SizeChanged);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.SlateGray;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 30);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(898, 10);
            this.guna2Separator1.TabIndex = 2;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // ProgressCircle
            // 
            this.ProgressCircle.Animated = true;
            this.ProgressCircle.BackColor = System.Drawing.Color.Transparent;
            this.ProgressCircle.EnsureVisible = true;
            this.ProgressCircle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ProgressCircle.FillThickness = 4;
            this.ProgressCircle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProgressCircle.ForeColor = System.Drawing.Color.White;
            this.ProgressCircle.Location = new System.Drawing.Point(11, 6);
            this.ProgressCircle.Minimum = 0;
            this.ProgressCircle.Name = "ProgressCircle";
            this.ProgressCircle.ProgressColor = System.Drawing.Color.LightSeaGreen;
            this.ProgressCircle.ProgressColor2 = System.Drawing.Color.LightSeaGreen;
            this.ProgressCircle.ProgressThickness = 4;
            this.ProgressCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressCircle.Size = new System.Drawing.Size(25, 25);
            this.ProgressCircle.TabIndex = 0;
            this.ProgressCircle.Text = "guna2CircleProgressBar1";
            this.ProgressCircle.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.ProgressCircle.UseTransparentBackground = true;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LoadingLabel.Location = new System.Drawing.Point(12, -1);
            this.LoadingLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(206, 36);
            this.LoadingLabel.TabIndex = 3;
            this.LoadingLabel.Text = "Loading employee data...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(898, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "Employee";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Consolas", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TimeLabel.Location = new System.Drawing.Point(309, 16);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(204, 37);
            this.TimeLabel.TabIndex = 9;
            this.TimeLabel.Text = "11:11:11 AM";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DateLabel.Location = new System.Drawing.Point(41, 12);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(264, 41);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "JANUARY 1, 2024\r\n";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 11;
            this.guna2Elipse1.TargetControl = this.guna2Panel5;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 11;
            // 
            // TimerProcess
            // 
            this.TimerProcess.Interval = 1000;
            this.TimerProcess.Tick += new System.EventHandler(this.TimerProcess_Tick);
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
            this.AddEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.AddEmployeeButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.add_line;
            this.AddEmployeeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddEmployeeButton.Location = new System.Drawing.Point(800, 16);
            this.AddEmployeeButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(144, 37);
            this.AddEmployeeButton.TabIndex = 29;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddEmployeeButton.UseTransparentBackground = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button2.Image = global::ARIAR_PayrollSystem.Properties.Resources.arrow_right_double_line;
            this.guna2Button2.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button2.IndicateFocus = true;
            this.guna2Button2.Location = new System.Drawing.Point(559, 658);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.White;
            this.guna2Button2.ShadowDecoration.BorderRadius = 11;
            this.guna2Button2.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button2.ShadowDecoration.Depth = 15;
            this.guna2Button2.Size = new System.Drawing.Size(30, 30);
            this.guna2Button2.TabIndex = 23;
            this.guna2Button2.UseTransparentBackground = true;
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
            this.guna2Button3.Image = global::ARIAR_PayrollSystem.Properties.Resources.arrow_right_s_line;
            this.guna2Button3.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button3.IndicateFocus = true;
            this.guna2Button3.Location = new System.Drawing.Point(529, 658);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.Color.White;
            this.guna2Button3.ShadowDecoration.BorderRadius = 11;
            this.guna2Button3.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button3.ShadowDecoration.Depth = 15;
            this.guna2Button3.Size = new System.Drawing.Size(30, 30);
            this.guna2Button3.TabIndex = 22;
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
            this.guna2Button4.Image = global::ARIAR_PayrollSystem.Properties.Resources.arrow_left_double_line;
            this.guna2Button4.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button4.IndicateFocus = true;
            this.guna2Button4.Location = new System.Drawing.Point(415, 659);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.White;
            this.guna2Button4.ShadowDecoration.BorderRadius = 11;
            this.guna2Button4.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button4.ShadowDecoration.Depth = 15;
            this.guna2Button4.Size = new System.Drawing.Size(30, 30);
            this.guna2Button4.TabIndex = 21;
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
            this.guna2Button5.Image = global::ARIAR_PayrollSystem.Properties.Resources.arrow_left_s_line;
            this.guna2Button5.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button5.IndicateFocus = true;
            this.guna2Button5.Location = new System.Drawing.Point(445, 659);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.PressedColor = System.Drawing.Color.White;
            this.guna2Button5.ShadowDecoration.BorderRadius = 11;
            this.guna2Button5.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button5.ShadowDecoration.Depth = 15;
            this.guna2Button5.Size = new System.Drawing.Size(30, 30);
            this.guna2Button5.TabIndex = 20;
            this.guna2Button5.UseTransparentBackground = true;
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
            this.guna2Button1.Location = new System.Drawing.Point(858, 0);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(40, 35);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.SearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.IconLeftSize = new System.Drawing.Size(25, 25);
            this.SearchBox.IconRight = global::ARIAR_PayrollSystem.Properties.Resources.search_line__1_;
            this.SearchBox.IconRightOffset = new System.Drawing.Point(10, 0);
            this.SearchBox.Location = new System.Drawing.Point(298, 104);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderText = "Search";
            this.SearchBox.SelectedText = "";
            this.SearchBox.ShadowDecoration.BorderRadius = 11;
            this.SearchBox.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.SearchBox.ShadowDecoration.Depth = 55;
            this.SearchBox.ShadowDecoration.Enabled = true;
            this.SearchBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.SearchBox.Size = new System.Drawing.Size(646, 31);
            this.SearchBox.TabIndex = 15;
            this.SearchBox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // EmployeeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(990, 704);
            this.Controls.Add(this.EmployeeInfoPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeInformation";
            this.Text = "EmployeeInformation";
            this.Load += new System.EventHandler(this.EmployeeInformation_Load);
            this.EmployeeInfoPanel.ResumeLayout(false);
            this.EmployeeInfoPanel.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel EmployeeInfoPanel;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Timer TimerProcess;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label LoadingLabel;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressCircle;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2VScrollBar EmployeeViewScrollBar;
        private UserControls.CustomFlowLayoutPanel EmployeeTableView;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PageLabel;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button AddEmployeeButton;
    }
}