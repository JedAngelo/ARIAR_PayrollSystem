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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInformation));
            this.EmployeeInfoPanel = new System.Windows.Forms.Panel();
            this.ProgressCircle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.FilterButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddEmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentPageLabel = new Guna.UI2.WinForms.Guna2TextBox();
            this.PageCountLabel = new System.Windows.Forms.Label();
            this.PageLabel = new System.Windows.Forms.Label();
            this.LastPageButton = new Guna.UI2.WinForms.Guna2Button();
            this.NextPageButton = new Guna.UI2.WinForms.Guna2Button();
            this.FirstPageButton = new Guna.UI2.WinForms.Guna2Button();
            this.BackPageButton = new Guna.UI2.WinForms.Guna2Button();
            this.ViewCountComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.EmployeeTableView = new ARIAR_PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.EmployeeViewScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ColumnHeader = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeeSort = new Guna.UI2.WinForms.Guna2Button();
            this.PositionSort = new Guna.UI2.WinForms.Guna2Button();
            this.ActiveSort = new Guna.UI2.WinForms.Guna2Button();
            this.EmailSort = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RefreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TimerProcess = new System.Windows.Forms.Timer(this.components);
            this.EmployeeInfoPanel.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.ColumnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeInfoPanel
            // 
            this.EmployeeInfoPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmployeeInfoPanel.BackColor = System.Drawing.SystemColors.Control;
            this.EmployeeInfoPanel.Controls.Add(this.ProgressCircle);
            this.EmployeeInfoPanel.Controls.Add(this.guna2Button2);
            this.EmployeeInfoPanel.Controls.Add(this.FilterButton);
            this.EmployeeInfoPanel.Controls.Add(this.AddEmployeeButton);
            this.EmployeeInfoPanel.Controls.Add(this.label4);
            this.EmployeeInfoPanel.Controls.Add(this.CurrentPageLabel);
            this.EmployeeInfoPanel.Controls.Add(this.PageCountLabel);
            this.EmployeeInfoPanel.Controls.Add(this.PageLabel);
            this.EmployeeInfoPanel.Controls.Add(this.LastPageButton);
            this.EmployeeInfoPanel.Controls.Add(this.NextPageButton);
            this.EmployeeInfoPanel.Controls.Add(this.FirstPageButton);
            this.EmployeeInfoPanel.Controls.Add(this.BackPageButton);
            this.EmployeeInfoPanel.Controls.Add(this.ViewCountComboBox);
            this.EmployeeInfoPanel.Controls.Add(this.SearchBox);
            this.EmployeeInfoPanel.Controls.Add(this.TimeLabel);
            this.EmployeeInfoPanel.Controls.Add(this.DateLabel);
            this.EmployeeInfoPanel.Controls.Add(this.guna2Panel5);
            this.EmployeeInfoPanel.Controls.Add(this.RefreshButton);
            this.EmployeeInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeInfoPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.EmployeeInfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeInfoPanel.Name = "EmployeeInfoPanel";
            this.EmployeeInfoPanel.Size = new System.Drawing.Size(990, 704);
            this.EmployeeInfoPanel.TabIndex = 0;
            // 
            // ProgressCircle
            // 
            this.ProgressCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressCircle.Animated = true;
            this.ProgressCircle.BackColor = System.Drawing.Color.Transparent;
            this.ProgressCircle.EnsureVisible = true;
            this.ProgressCircle.FillColor = System.Drawing.Color.Gainsboro;
            this.ProgressCircle.FillThickness = 4;
            this.ProgressCircle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProgressCircle.ForeColor = System.Drawing.Color.White;
            this.ProgressCircle.Location = new System.Drawing.Point(916, 108);
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
            this.ProgressCircle.Visible = false;
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
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::ARIAR_PayrollSystem.Properties.Resources.add_line;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.Location = new System.Drawing.Point(607, 16);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(144, 37);
            this.guna2Button2.TabIndex = 33;
            this.guna2Button2.Text = "Add Employee";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // FilterButton
            // 
            this.FilterButton.Animated = true;
            this.FilterButton.AnimatedGIF = true;
            this.FilterButton.BackColor = System.Drawing.Color.Transparent;
            this.FilterButton.BorderRadius = 8;
            this.FilterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FilterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FilterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FilterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FilterButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.FilterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterButton.ForeColor = System.Drawing.Color.White;
            this.FilterButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.sound_module_line;
            this.FilterButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FilterButton.ImageSize = new System.Drawing.Size(18, 18);
            this.FilterButton.Location = new System.Drawing.Point(46, 104);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.ShadowDecoration.BorderRadius = 11;
            this.FilterButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.FilterButton.ShadowDecoration.Depth = 15;
            this.FilterButton.ShadowDecoration.Enabled = true;
            this.FilterButton.Size = new System.Drawing.Size(90, 31);
            this.FilterButton.TabIndex = 32;
            this.FilterButton.Text = "Filter";
            this.FilterButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FilterButton.UseTransparentBackground = true;
            this.FilterButton.Click += new System.EventHandler(this.SetFilterButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployeeButton.Animated = true;
            this.AddEmployeeButton.AnimatedGIF = true;
            this.AddEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployeeButton.BorderRadius = 8;
            this.AddEmployeeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddEmployeeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddEmployeeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddEmployeeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddEmployeeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.AddEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.AddEmployeeButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.add_line;
            this.AddEmployeeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddEmployeeButton.Location = new System.Drawing.Point(800, 16);
            this.AddEmployeeButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.ShadowDecoration.BorderRadius = 11;
            this.AddEmployeeButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.AddEmployeeButton.ShadowDecoration.Depth = 15;
            this.AddEmployeeButton.ShadowDecoration.Enabled = true;
            this.AddEmployeeButton.Size = new System.Drawing.Size(144, 37);
            this.AddEmployeeButton.TabIndex = 29;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddEmployeeButton.UseTransparentBackground = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
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
            // CurrentPageLabel
            // 
            this.CurrentPageLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CurrentPageLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentPageLabel.BorderRadius = 8;
            this.CurrentPageLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CurrentPageLabel.DefaultText = "1";
            this.CurrentPageLabel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CurrentPageLabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CurrentPageLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CurrentPageLabel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CurrentPageLabel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CurrentPageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CurrentPageLabel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CurrentPageLabel.Location = new System.Drawing.Point(478, 659);
            this.CurrentPageLabel.Name = "CurrentPageLabel";
            this.CurrentPageLabel.PasswordChar = '\0';
            this.CurrentPageLabel.PlaceholderText = "";
            this.CurrentPageLabel.SelectedText = "";
            this.CurrentPageLabel.ShadowDecoration.BorderRadius = 11;
            this.CurrentPageLabel.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.CurrentPageLabel.ShadowDecoration.Depth = 15;
            this.CurrentPageLabel.ShadowDecoration.Enabled = true;
            this.CurrentPageLabel.Size = new System.Drawing.Size(48, 30);
            this.CurrentPageLabel.TabIndex = 26;
            this.CurrentPageLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrentPageLabel.TextChanged += new System.EventHandler(this.CurrentPageLabel_TextChanged);
            this.CurrentPageLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentPageLabel_KeyPress);
            // 
            // PageCountLabel
            // 
            this.PageCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PageCountLabel.AutoSize = true;
            this.PageCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PageCountLabel.Location = new System.Drawing.Point(96, 670);
            this.PageCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PageCountLabel.Name = "PageCountLabel";
            this.PageCountLabel.Size = new System.Drawing.Size(59, 15);
            this.PageCountLabel.TabIndex = 25;
            this.PageCountLabel.Text = "Loading...";
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
            // LastPageButton
            // 
            this.LastPageButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LastPageButton.Animated = true;
            this.LastPageButton.BackColor = System.Drawing.Color.Transparent;
            this.LastPageButton.BorderRadius = 8;
            this.LastPageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LastPageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LastPageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LastPageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LastPageButton.FillColor = System.Drawing.Color.Transparent;
            this.LastPageButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LastPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LastPageButton.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.LastPageButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.arrow_right_double_line;
            this.LastPageButton.ImageSize = new System.Drawing.Size(24, 24);
            this.LastPageButton.IndicateFocus = true;
            this.LastPageButton.Location = new System.Drawing.Point(559, 658);
            this.LastPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.LastPageButton.Name = "LastPageButton";
            this.LastPageButton.PressedColor = System.Drawing.Color.White;
            this.LastPageButton.ShadowDecoration.BorderRadius = 11;
            this.LastPageButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.LastPageButton.ShadowDecoration.Depth = 15;
            this.LastPageButton.Size = new System.Drawing.Size(30, 30);
            this.LastPageButton.TabIndex = 23;
            this.LastPageButton.UseTransparentBackground = true;
            this.LastPageButton.Click += new System.EventHandler(this.LastPageButton_Click);
            // 
            // NextPageButton
            // 
            this.NextPageButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextPageButton.Animated = true;
            this.NextPageButton.BackColor = System.Drawing.Color.Transparent;
            this.NextPageButton.BorderRadius = 8;
            this.NextPageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NextPageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NextPageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NextPageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NextPageButton.FillColor = System.Drawing.Color.Transparent;
            this.NextPageButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.NextPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NextPageButton.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.NextPageButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.arrow_right_s_line;
            this.NextPageButton.ImageSize = new System.Drawing.Size(24, 24);
            this.NextPageButton.IndicateFocus = true;
            this.NextPageButton.Location = new System.Drawing.Point(529, 658);
            this.NextPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.PressedColor = System.Drawing.Color.White;
            this.NextPageButton.ShadowDecoration.BorderRadius = 11;
            this.NextPageButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.NextPageButton.ShadowDecoration.Depth = 15;
            this.NextPageButton.Size = new System.Drawing.Size(30, 30);
            this.NextPageButton.TabIndex = 22;
            this.NextPageButton.UseTransparentBackground = true;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // FirstPageButton
            // 
            this.FirstPageButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FirstPageButton.Animated = true;
            this.FirstPageButton.BackColor = System.Drawing.Color.Transparent;
            this.FirstPageButton.BorderRadius = 8;
            this.FirstPageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FirstPageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FirstPageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FirstPageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FirstPageButton.FillColor = System.Drawing.Color.Transparent;
            this.FirstPageButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FirstPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FirstPageButton.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.FirstPageButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.arrow_left_double_line;
            this.FirstPageButton.ImageSize = new System.Drawing.Size(24, 24);
            this.FirstPageButton.IndicateFocus = true;
            this.FirstPageButton.Location = new System.Drawing.Point(415, 659);
            this.FirstPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.FirstPageButton.Name = "FirstPageButton";
            this.FirstPageButton.PressedColor = System.Drawing.Color.White;
            this.FirstPageButton.ShadowDecoration.BorderRadius = 11;
            this.FirstPageButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.FirstPageButton.ShadowDecoration.Depth = 15;
            this.FirstPageButton.Size = new System.Drawing.Size(30, 30);
            this.FirstPageButton.TabIndex = 21;
            this.FirstPageButton.UseTransparentBackground = true;
            this.FirstPageButton.Click += new System.EventHandler(this.FirstPageButton_Click);
            // 
            // BackPageButton
            // 
            this.BackPageButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackPageButton.Animated = true;
            this.BackPageButton.BackColor = System.Drawing.Color.Transparent;
            this.BackPageButton.BorderRadius = 8;
            this.BackPageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackPageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackPageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackPageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackPageButton.FillColor = System.Drawing.Color.Transparent;
            this.BackPageButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BackPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BackPageButton.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BackPageButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.arrow_left_s_line;
            this.BackPageButton.ImageSize = new System.Drawing.Size(24, 24);
            this.BackPageButton.IndicateFocus = true;
            this.BackPageButton.Location = new System.Drawing.Point(445, 659);
            this.BackPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackPageButton.Name = "BackPageButton";
            this.BackPageButton.PressedColor = System.Drawing.Color.White;
            this.BackPageButton.ShadowDecoration.BorderRadius = 11;
            this.BackPageButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.BackPageButton.ShadowDecoration.Depth = 15;
            this.BackPageButton.Size = new System.Drawing.Size(30, 30);
            this.BackPageButton.TabIndex = 20;
            this.BackPageButton.UseTransparentBackground = true;
            this.BackPageButton.Click += new System.EventHandler(this.BackPageButton_Click);
            // 
            // ViewCountComboBox
            // 
            this.ViewCountComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewCountComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ViewCountComboBox.BorderRadius = 8;
            this.ViewCountComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ViewCountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViewCountComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ViewCountComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ViewCountComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ViewCountComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ViewCountComboBox.IntegralHeight = false;
            this.ViewCountComboBox.ItemHeight = 25;
            this.ViewCountComboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30"});
            this.ViewCountComboBox.Location = new System.Drawing.Point(878, 657);
            this.ViewCountComboBox.Name = "ViewCountComboBox";
            this.ViewCountComboBox.ShadowDecoration.BorderRadius = 11;
            this.ViewCountComboBox.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.ViewCountComboBox.ShadowDecoration.Depth = 15;
            this.ViewCountComboBox.ShadowDecoration.Enabled = true;
            this.ViewCountComboBox.Size = new System.Drawing.Size(66, 31);
            this.ViewCountComboBox.StartIndex = 0;
            this.ViewCountComboBox.TabIndex = 19;
            this.ViewCountComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ViewCountComboBox.SelectedIndexChanged += new System.EventHandler(this.ViewCountComboBox_SelectedIndexChanged);
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
            this.SearchBox.Location = new System.Drawing.Point(148, 104);
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
            this.SearchBox.Size = new System.Drawing.Size(751, 31);
            this.SearchBox.TabIndex = 15;
            this.SearchBox.TextOffset = new System.Drawing.Point(5, 0);
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Consolas", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TimeLabel.Location = new System.Drawing.Point(342, 16);
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
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderRadius = 8;
            this.guna2Panel5.Controls.Add(this.guna2Separator1);
            this.guna2Panel5.Controls.Add(this.EmployeeTableView);
            this.guna2Panel5.Controls.Add(this.EmployeeViewScrollBar);
            this.guna2Panel5.Controls.Add(this.HeaderPanel);
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel5.Location = new System.Drawing.Point(46, 157);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.guna2Panel5.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel5.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel5.ShadowDecoration.Depth = 15;
            this.guna2Panel5.ShadowDecoration.Enabled = true;
            this.guna2Panel5.Size = new System.Drawing.Size(898, 489);
            this.guna2Panel5.TabIndex = 16;
            this.guna2Panel5.UseTransparentBackground = true;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.SlateGray;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 30);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(898, 10);
            this.guna2Separator1.TabIndex = 2;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // EmployeeTableView
            // 
            this.EmployeeTableView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeTableView.AutoScroll = true;
            this.EmployeeTableView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmployeeTableView.BackColor = System.Drawing.Color.White;
            this.EmployeeTableView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EmployeeTableView.Location = new System.Drawing.Point(0, 36);
            this.EmployeeTableView.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeTableView.Name = "EmployeeTableView";
            this.EmployeeTableView.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.EmployeeTableView.Size = new System.Drawing.Size(898, 448);
            this.EmployeeTableView.TabIndex = 1;
            this.EmployeeTableView.WrapContents = false;
            this.EmployeeTableView.SizeChanged += new System.EventHandler(this.EmployeeTableView_SizeChanged);
            // 
            // EmployeeViewScrollBar
            // 
            this.EmployeeViewScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeViewScrollBar.BindingContainer = this.EmployeeTableView;
            this.EmployeeViewScrollBar.BorderRadius = 5;
            this.EmployeeViewScrollBar.FillColor = System.Drawing.Color.White;
            this.EmployeeViewScrollBar.InUpdate = false;
            this.EmployeeViewScrollBar.LargeChange = 10;
            this.EmployeeViewScrollBar.Location = new System.Drawing.Point(886, 75);
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
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.HeaderPanel.Controls.Add(this.ColumnHeader);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Padding = new System.Windows.Forms.Padding(5, 0, 25, 0);
            this.HeaderPanel.Size = new System.Drawing.Size(898, 36);
            this.HeaderPanel.TabIndex = 6;
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.ColumnCount = 5;
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.06904F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.70601F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.16036F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.70379F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.24944F));
            this.ColumnHeader.Controls.Add(this.EmployeeSort, 0, 0);
            this.ColumnHeader.Controls.Add(this.PositionSort, 1, 0);
            this.ColumnHeader.Controls.Add(this.ActiveSort, 3, 0);
            this.ColumnHeader.Controls.Add(this.EmailSort, 2, 0);
            this.ColumnHeader.Controls.Add(this.label6, 4, 0);
            this.ColumnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnHeader.Location = new System.Drawing.Point(5, 0);
            this.ColumnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.ColumnHeader.Name = "ColumnHeader";
            this.ColumnHeader.RowCount = 1;
            this.ColumnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ColumnHeader.Size = new System.Drawing.Size(868, 36);
            this.ColumnHeader.TabIndex = 7;
            // 
            // EmployeeSort
            // 
            this.EmployeeSort.Animated = true;
            this.EmployeeSort.AnimatedGIF = true;
            this.EmployeeSort.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeSort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeSort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmployeeSort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmployeeSort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmployeeSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeSort.FillColor = System.Drawing.Color.Transparent;
            this.EmployeeSort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSort.ForeColor = System.Drawing.Color.White;
            this.EmployeeSort.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeSort.Image")));
            this.EmployeeSort.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EmployeeSort.ImageSize = new System.Drawing.Size(18, 18);
            this.EmployeeSort.Location = new System.Drawing.Point(5, 5);
            this.EmployeeSort.Margin = new System.Windows.Forms.Padding(5);
            this.EmployeeSort.Name = "EmployeeSort";
            this.EmployeeSort.Size = new System.Drawing.Size(259, 26);
            this.EmployeeSort.TabIndex = 33;
            this.EmployeeSort.Text = "Employee";
            this.EmployeeSort.UseTransparentBackground = true;
            this.EmployeeSort.Click += new System.EventHandler(this.EmployeeSort_Click);
            // 
            // PositionSort
            // 
            this.PositionSort.Animated = true;
            this.PositionSort.AnimatedGIF = true;
            this.PositionSort.BackColor = System.Drawing.Color.Transparent;
            this.PositionSort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PositionSort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PositionSort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PositionSort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PositionSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionSort.FillColor = System.Drawing.Color.Transparent;
            this.PositionSort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionSort.ForeColor = System.Drawing.Color.White;
            this.PositionSort.Image = ((System.Drawing.Image)(resources.GetObject("PositionSort.Image")));
            this.PositionSort.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PositionSort.ImageSize = new System.Drawing.Size(18, 18);
            this.PositionSort.Location = new System.Drawing.Point(274, 5);
            this.PositionSort.Margin = new System.Windows.Forms.Padding(5);
            this.PositionSort.Name = "PositionSort";
            this.PositionSort.Size = new System.Drawing.Size(143, 26);
            this.PositionSort.TabIndex = 32;
            this.PositionSort.Text = "Position";
            this.PositionSort.UseTransparentBackground = true;
            this.PositionSort.Click += new System.EventHandler(this.PositionSort_Click);
            // 
            // ActiveSort
            // 
            this.ActiveSort.Animated = true;
            this.ActiveSort.AnimatedGIF = true;
            this.ActiveSort.BackColor = System.Drawing.Color.Transparent;
            this.ActiveSort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ActiveSort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ActiveSort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ActiveSort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ActiveSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveSort.FillColor = System.Drawing.Color.Transparent;
            this.ActiveSort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveSort.ForeColor = System.Drawing.Color.White;
            this.ActiveSort.Image = ((System.Drawing.Image)(resources.GetObject("ActiveSort.Image")));
            this.ActiveSort.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ActiveSort.ImageSize = new System.Drawing.Size(18, 18);
            this.ActiveSort.Location = new System.Drawing.Point(619, 5);
            this.ActiveSort.Margin = new System.Windows.Forms.Padding(5);
            this.ActiveSort.Name = "ActiveSort";
            this.ActiveSort.Size = new System.Drawing.Size(135, 26);
            this.ActiveSort.TabIndex = 31;
            this.ActiveSort.Text = "Active";
            this.ActiveSort.UseTransparentBackground = true;
            this.ActiveSort.Click += new System.EventHandler(this.ActiveSort_Click);
            // 
            // EmailSort
            // 
            this.EmailSort.Animated = true;
            this.EmailSort.AnimatedGIF = true;
            this.EmailSort.BackColor = System.Drawing.Color.Transparent;
            this.EmailSort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmailSort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmailSort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmailSort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmailSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailSort.FillColor = System.Drawing.Color.Transparent;
            this.EmailSort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailSort.ForeColor = System.Drawing.Color.White;
            this.EmailSort.Image = ((System.Drawing.Image)(resources.GetObject("EmailSort.Image")));
            this.EmailSort.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EmailSort.ImageSize = new System.Drawing.Size(18, 18);
            this.EmailSort.Location = new System.Drawing.Point(427, 5);
            this.EmailSort.Margin = new System.Windows.Forms.Padding(5);
            this.EmailSort.Name = "EmailSort";
            this.EmailSort.Size = new System.Drawing.Size(182, 26);
            this.EmailSort.TabIndex = 30;
            this.EmailSort.Text = "Email";
            this.EmailSort.UseTransparentBackground = true;
            this.EmailSort.Click += new System.EventHandler(this.EmailSort_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(764, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Actions";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.Animated = true;
            this.RefreshButton.BorderRadius = 15;
            this.RefreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RefreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RefreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RefreshButton.FillColor = System.Drawing.Color.Transparent;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.refresh_line_2_;
            this.RefreshButton.ImageSize = new System.Drawing.Size(24, 24);
            this.RefreshButton.Location = new System.Drawing.Point(913, 104);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(31, 31);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
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
            this.HeaderPanel.ResumeLayout(false);
            this.ColumnHeader.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressCircle;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button RefreshButton;
        private Guna.UI2.WinForms.Guna2VScrollBar EmployeeViewScrollBar;
        private UserControls.CustomFlowLayoutPanel EmployeeTableView;
        private Guna.UI2.WinForms.Guna2ComboBox ViewCountComboBox;
        private Guna.UI2.WinForms.Guna2Button LastPageButton;
        private Guna.UI2.WinForms.Guna2Button NextPageButton;
        private Guna.UI2.WinForms.Guna2Button FirstPageButton;
        private Guna.UI2.WinForms.Guna2Button BackPageButton;
        private System.Windows.Forms.Label PageCountLabel;
        private System.Windows.Forms.Label PageLabel;
        private Guna.UI2.WinForms.Guna2TextBox CurrentPageLabel;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button AddEmployeeButton;
        private Guna.UI2.WinForms.Guna2Button FilterButton;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.TableLayoutPanel ColumnHeader;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button EmailSort;
        private Guna.UI2.WinForms.Guna2Button EmployeeSort;
        private Guna.UI2.WinForms.Guna2Button PositionSort;
        private Guna.UI2.WinForms.Guna2Button ActiveSort;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}