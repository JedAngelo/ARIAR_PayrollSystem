namespace PayrollSystem.Forms
{
    partial class PayrollCalclulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollCalclulation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.CurrentPageLabel = new Guna.UI2.WinForms.Guna2TextBox();
            this.PageCountLabel = new System.Windows.Forms.Label();
            this.PageLabel = new System.Windows.Forms.Label();
            this.LastPageButton = new Guna.UI2.WinForms.Guna2Button();
            this.NextPageButton = new Guna.UI2.WinForms.Guna2Button();
            this.FirstPageButton = new Guna.UI2.WinForms.Guna2Button();
            this.BackPageButton = new Guna.UI2.WinForms.Guna2Button();
            this.ViewCountComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RefreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.PayrollPeriodLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ViewDetailsButton = new Guna.UI2.WinForms.Guna2Button();
            this.PrintPayslipButton = new Guna.UI2.WinForms.Guna2Button();
            this.CalcPayrollButton = new Guna.UI2.WinForms.Guna2Button();
            this.PayrollRangeButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.EmployeeViewScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.EmployeeTableView = new PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.ColumnHeader = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeeSort = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.ColumnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.CurrentPageLabel);
            this.panel1.Controls.Add(this.PageCountLabel);
            this.panel1.Controls.Add(this.PageLabel);
            this.panel1.Controls.Add(this.LastPageButton);
            this.panel1.Controls.Add(this.NextPageButton);
            this.panel1.Controls.Add(this.FirstPageButton);
            this.panel1.Controls.Add(this.BackPageButton);
            this.panel1.Controls.Add(this.ViewCountComboBox);
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Controls.Add(this.PayrollPeriodLabel);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.ViewDetailsButton);
            this.panel1.Controls.Add(this.PrintPayslipButton);
            this.panel1.Controls.Add(this.CalcPayrollButton);
            this.panel1.Controls.Add(this.PayrollRangeButton);
            this.panel1.Controls.Add(this.guna2Panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 704);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label11.Location = new System.Drawing.Point(851, 670);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 15);
            this.label11.TabIndex = 52;
            this.label11.Text = "Views per page:";
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
            this.CurrentPageLabel.Location = new System.Drawing.Point(514, 663);
            this.CurrentPageLabel.Name = "CurrentPageLabel";
            this.CurrentPageLabel.PasswordChar = '\0';
            this.CurrentPageLabel.PlaceholderText = "";
            this.CurrentPageLabel.SelectedText = "";
            this.CurrentPageLabel.ShadowDecoration.BorderRadius = 11;
            this.CurrentPageLabel.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.CurrentPageLabel.ShadowDecoration.Depth = 15;
            this.CurrentPageLabel.ShadowDecoration.Enabled = true;
            this.CurrentPageLabel.Size = new System.Drawing.Size(48, 30);
            this.CurrentPageLabel.TabIndex = 51;
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
            this.PageCountLabel.Location = new System.Drawing.Point(91, 670);
            this.PageCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PageCountLabel.Name = "PageCountLabel";
            this.PageCountLabel.Size = new System.Drawing.Size(59, 15);
            this.PageCountLabel.TabIndex = 50;
            this.PageCountLabel.Text = "Loading...";
            // 
            // PageLabel
            // 
            this.PageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PageLabel.Location = new System.Drawing.Point(42, 670);
            this.PageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(45, 15);
            this.PageLabel.TabIndex = 49;
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
            this.LastPageButton.Image = global::PayrollSystem.Properties.Resources.arrow_right_double_line;
            this.LastPageButton.ImageSize = new System.Drawing.Size(24, 24);
            this.LastPageButton.IndicateFocus = true;
            this.LastPageButton.Location = new System.Drawing.Point(595, 662);
            this.LastPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.LastPageButton.Name = "LastPageButton";
            this.LastPageButton.PressedColor = System.Drawing.Color.White;
            this.LastPageButton.ShadowDecoration.BorderRadius = 11;
            this.LastPageButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.LastPageButton.ShadowDecoration.Depth = 15;
            this.LastPageButton.Size = new System.Drawing.Size(30, 30);
            this.LastPageButton.TabIndex = 48;
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
            this.NextPageButton.Image = global::PayrollSystem.Properties.Resources.arrow_right_s_line;
            this.NextPageButton.ImageSize = new System.Drawing.Size(24, 24);
            this.NextPageButton.IndicateFocus = true;
            this.NextPageButton.Location = new System.Drawing.Point(565, 662);
            this.NextPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.PressedColor = System.Drawing.Color.White;
            this.NextPageButton.ShadowDecoration.BorderRadius = 11;
            this.NextPageButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.NextPageButton.ShadowDecoration.Depth = 15;
            this.NextPageButton.Size = new System.Drawing.Size(30, 30);
            this.NextPageButton.TabIndex = 47;
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
            this.FirstPageButton.Image = global::PayrollSystem.Properties.Resources.arrow_left_double_line;
            this.FirstPageButton.ImageSize = new System.Drawing.Size(24, 24);
            this.FirstPageButton.IndicateFocus = true;
            this.FirstPageButton.Location = new System.Drawing.Point(451, 663);
            this.FirstPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.FirstPageButton.Name = "FirstPageButton";
            this.FirstPageButton.PressedColor = System.Drawing.Color.White;
            this.FirstPageButton.ShadowDecoration.BorderRadius = 11;
            this.FirstPageButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.FirstPageButton.ShadowDecoration.Depth = 15;
            this.FirstPageButton.Size = new System.Drawing.Size(30, 30);
            this.FirstPageButton.TabIndex = 46;
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
            this.BackPageButton.Image = global::PayrollSystem.Properties.Resources.arrow_left_s_line;
            this.BackPageButton.ImageSize = new System.Drawing.Size(24, 24);
            this.BackPageButton.IndicateFocus = true;
            this.BackPageButton.Location = new System.Drawing.Point(481, 663);
            this.BackPageButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackPageButton.Name = "BackPageButton";
            this.BackPageButton.PressedColor = System.Drawing.Color.White;
            this.BackPageButton.ShadowDecoration.BorderRadius = 11;
            this.BackPageButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.BackPageButton.ShadowDecoration.Depth = 15;
            this.BackPageButton.Size = new System.Drawing.Size(30, 30);
            this.BackPageButton.TabIndex = 45;
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
            this.ViewCountComboBox.Location = new System.Drawing.Point(953, 661);
            this.ViewCountComboBox.Name = "ViewCountComboBox";
            this.ViewCountComboBox.ShadowDecoration.BorderRadius = 11;
            this.ViewCountComboBox.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.ViewCountComboBox.ShadowDecoration.Depth = 15;
            this.ViewCountComboBox.ShadowDecoration.Enabled = true;
            this.ViewCountComboBox.Size = new System.Drawing.Size(66, 31);
            this.ViewCountComboBox.StartIndex = 0;
            this.ViewCountComboBox.TabIndex = 44;
            this.ViewCountComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ViewCountComboBox.SelectedIndexChanged += new System.EventHandler(this.ViewCountComboBox_SelectedIndexChanged);
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
            this.RefreshButton.Image = global::PayrollSystem.Properties.Resources.refresh_line_2_;
            this.RefreshButton.ImageSize = new System.Drawing.Size(24, 24);
            this.RefreshButton.Location = new System.Drawing.Point(988, 86);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(31, 31);
            this.RefreshButton.TabIndex = 43;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // PayrollPeriodLabel
            // 
            this.PayrollPeriodLabel.BackColor = System.Drawing.Color.Transparent;
            this.PayrollPeriodLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayrollPeriodLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PayrollPeriodLabel.Location = new System.Drawing.Point(189, 16);
            this.PayrollPeriodLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PayrollPeriodLabel.Name = "PayrollPeriodLabel";
            this.PayrollPeriodLabel.Size = new System.Drawing.Size(315, 36);
            this.PayrollPeriodLabel.TabIndex = 41;
            this.PayrollPeriodLabel.Text = "--/--/--";
            this.PayrollPeriodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label10.Location = new System.Drawing.Point(40, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 36);
            this.label10.TabIndex = 40;
            this.label10.Text = "Payrol Period:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.SearchBox.Location = new System.Drawing.Point(455, 86);
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
            this.SearchBox.Size = new System.Drawing.Size(518, 31);
            this.SearchBox.TabIndex = 39;
            this.SearchBox.TextOffset = new System.Drawing.Point(5, 0);
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // ViewDetailsButton
            // 
            this.ViewDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewDetailsButton.Animated = true;
            this.ViewDetailsButton.AnimatedGIF = true;
            this.ViewDetailsButton.BackColor = System.Drawing.Color.Transparent;
            this.ViewDetailsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.ViewDetailsButton.BorderRadius = 13;
            this.ViewDetailsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ViewDetailsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ViewDetailsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ViewDetailsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ViewDetailsButton.Enabled = false;
            this.ViewDetailsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.ViewDetailsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDetailsButton.ForeColor = System.Drawing.Color.White;
            this.ViewDetailsButton.Image = global::PayrollSystem.Properties.Resources.draft_line;
            this.ViewDetailsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ViewDetailsButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.ViewDetailsButton.ImageSize = new System.Drawing.Size(18, 18);
            this.ViewDetailsButton.Location = new System.Drawing.Point(724, 16);
            this.ViewDetailsButton.Margin = new System.Windows.Forms.Padding(5);
            this.ViewDetailsButton.Name = "ViewDetailsButton";
            this.ViewDetailsButton.ShadowDecoration.BorderRadius = 15;
            this.ViewDetailsButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.ViewDetailsButton.ShadowDecoration.Depth = 15;
            this.ViewDetailsButton.ShadowDecoration.Enabled = true;
            this.ViewDetailsButton.Size = new System.Drawing.Size(149, 31);
            this.ViewDetailsButton.TabIndex = 38;
            this.ViewDetailsButton.Text = "View/Edit Details";
            this.ViewDetailsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ViewDetailsButton.UseTransparentBackground = true;
            this.ViewDetailsButton.Click += new System.EventHandler(this.ViewDetailsButton_Click);
            // 
            // PrintPayslipButton
            // 
            this.PrintPayslipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintPayslipButton.Animated = true;
            this.PrintPayslipButton.AnimatedGIF = true;
            this.PrintPayslipButton.BackColor = System.Drawing.Color.Transparent;
            this.PrintPayslipButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.PrintPayslipButton.BorderRadius = 13;
            this.PrintPayslipButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PrintPayslipButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PrintPayslipButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrintPayslipButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PrintPayslipButton.Enabled = false;
            this.PrintPayslipButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.PrintPayslipButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPayslipButton.ForeColor = System.Drawing.Color.White;
            this.PrintPayslipButton.Image = global::PayrollSystem.Properties.Resources.cash_line;
            this.PrintPayslipButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PrintPayslipButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.PrintPayslipButton.ImageSize = new System.Drawing.Size(18, 18);
            this.PrintPayslipButton.Location = new System.Drawing.Point(883, 16);
            this.PrintPayslipButton.Margin = new System.Windows.Forms.Padding(5);
            this.PrintPayslipButton.Name = "PrintPayslipButton";
            this.PrintPayslipButton.ShadowDecoration.BorderRadius = 15;
            this.PrintPayslipButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.PrintPayslipButton.ShadowDecoration.Depth = 15;
            this.PrintPayslipButton.ShadowDecoration.Enabled = true;
            this.PrintPayslipButton.Size = new System.Drawing.Size(136, 31);
            this.PrintPayslipButton.TabIndex = 37;
            this.PrintPayslipButton.Text = "Print Payslip";
            this.PrintPayslipButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PrintPayslipButton.UseTransparentBackground = true;
            this.PrintPayslipButton.Click += new System.EventHandler(this.PrintPayslipButton_Click);
            // 
            // CalcPayrollButton
            // 
            this.CalcPayrollButton.Animated = true;
            this.CalcPayrollButton.AnimatedGIF = true;
            this.CalcPayrollButton.BackColor = System.Drawing.Color.Transparent;
            this.CalcPayrollButton.BorderRadius = 8;
            this.CalcPayrollButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CalcPayrollButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CalcPayrollButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CalcPayrollButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CalcPayrollButton.Enabled = false;
            this.CalcPayrollButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.CalcPayrollButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcPayrollButton.ForeColor = System.Drawing.Color.White;
            this.CalcPayrollButton.Image = global::PayrollSystem.Properties.Resources.calendar_2_line;
            this.CalcPayrollButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CalcPayrollButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.CalcPayrollButton.ImageSize = new System.Drawing.Size(18, 18);
            this.CalcPayrollButton.Location = new System.Drawing.Point(247, 86);
            this.CalcPayrollButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.CalcPayrollButton.Name = "CalcPayrollButton";
            this.CalcPayrollButton.ShadowDecoration.BorderRadius = 11;
            this.CalcPayrollButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.CalcPayrollButton.ShadowDecoration.Depth = 15;
            this.CalcPayrollButton.ShadowDecoration.Enabled = true;
            this.CalcPayrollButton.Size = new System.Drawing.Size(186, 31);
            this.CalcPayrollButton.TabIndex = 34;
            this.CalcPayrollButton.Text = "Calculate Payroll";
            this.CalcPayrollButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CalcPayrollButton.UseTransparentBackground = true;
            this.CalcPayrollButton.Click += new System.EventHandler(this.CalcPayrollButton_Click);
            // 
            // PayrollRangeButton
            // 
            this.PayrollRangeButton.Animated = true;
            this.PayrollRangeButton.AnimatedGIF = true;
            this.PayrollRangeButton.BackColor = System.Drawing.Color.Transparent;
            this.PayrollRangeButton.BorderRadius = 8;
            this.PayrollRangeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PayrollRangeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PayrollRangeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PayrollRangeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PayrollRangeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.PayrollRangeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayrollRangeButton.ForeColor = System.Drawing.Color.White;
            this.PayrollRangeButton.Image = global::PayrollSystem.Properties.Resources.calendar_2_line;
            this.PayrollRangeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PayrollRangeButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.PayrollRangeButton.ImageSize = new System.Drawing.Size(18, 18);
            this.PayrollRangeButton.Location = new System.Drawing.Point(45, 86);
            this.PayrollRangeButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.PayrollRangeButton.Name = "PayrollRangeButton";
            this.PayrollRangeButton.ShadowDecoration.BorderRadius = 11;
            this.PayrollRangeButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.PayrollRangeButton.ShadowDecoration.Depth = 15;
            this.PayrollRangeButton.ShadowDecoration.Enabled = true;
            this.PayrollRangeButton.Size = new System.Drawing.Size(186, 31);
            this.PayrollRangeButton.TabIndex = 33;
            this.PayrollRangeButton.Text = "Select Payroll Period";
            this.PayrollRangeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PayrollRangeButton.UseTransparentBackground = true;
            this.PayrollRangeButton.Click += new System.EventHandler(this.PayrollRangeButton_Click);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderRadius = 8;
            this.guna2Panel5.Controls.Add(this.EmployeeViewScrollBar);
            this.guna2Panel5.Controls.Add(this.EmployeeTableView);
            this.guna2Panel5.Controls.Add(this.HeaderPanel);
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel5.Location = new System.Drawing.Point(45, 135);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.guna2Panel5.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel5.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel5.ShadowDecoration.Depth = 15;
            this.guna2Panel5.ShadowDecoration.Enabled = true;
            this.guna2Panel5.Size = new System.Drawing.Size(974, 522);
            this.guna2Panel5.TabIndex = 17;
            this.guna2Panel5.UseTransparentBackground = true;
            // 
            // EmployeeViewScrollBar
            // 
            this.EmployeeViewScrollBar.BindingContainer = this.EmployeeTableView;
            this.EmployeeViewScrollBar.BorderRadius = 5;
            this.EmployeeViewScrollBar.FillColor = System.Drawing.Color.White;
            this.EmployeeViewScrollBar.InUpdate = false;
            this.EmployeeViewScrollBar.LargeChange = 10;
            this.EmployeeViewScrollBar.Location = new System.Drawing.Point(962, 64);
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
            this.EmployeeTableView.AutoScroll = true;
            this.EmployeeTableView.BackColor = System.Drawing.Color.White;
            this.EmployeeTableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeTableView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EmployeeTableView.Location = new System.Drawing.Point(0, 64);
            this.EmployeeTableView.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeTableView.Name = "EmployeeTableView";
            this.EmployeeTableView.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.EmployeeTableView.Size = new System.Drawing.Size(974, 453);
            this.EmployeeTableView.TabIndex = 1;
            this.EmployeeTableView.WrapContents = false;
            this.EmployeeTableView.SizeChanged += new System.EventHandler(this.EmployeeTableView_SizeChanged);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.HeaderPanel.Controls.Add(this.guna2Separator1);
            this.HeaderPanel.Controls.Add(this.ColumnHeader);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.HeaderPanel.Size = new System.Drawing.Size(974, 64);
            this.HeaderPanel.TabIndex = 6;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.SlateGray;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 58);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(979, 10);
            this.guna2Separator1.TabIndex = 2;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.ColumnCount = 9;
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.86597F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.24549F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.89091F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.717F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.89091F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.89091F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.89091F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.89091F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.717F));
            this.ColumnHeader.Controls.Add(this.EmployeeSort, 0, 0);
            this.ColumnHeader.Controls.Add(this.label9, 8, 0);
            this.ColumnHeader.Controls.Add(this.label8, 7, 0);
            this.ColumnHeader.Controls.Add(this.label7, 6, 0);
            this.ColumnHeader.Controls.Add(this.label6, 5, 0);
            this.ColumnHeader.Controls.Add(this.label4, 4, 0);
            this.ColumnHeader.Controls.Add(this.label3, 3, 0);
            this.ColumnHeader.Controls.Add(this.label2, 2, 0);
            this.ColumnHeader.Controls.Add(this.label1, 1, 0);
            this.ColumnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnHeader.Location = new System.Drawing.Point(10, 5);
            this.ColumnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.ColumnHeader.Name = "ColumnHeader";
            this.ColumnHeader.RowCount = 1;
            this.ColumnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ColumnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.ColumnHeader.Size = new System.Drawing.Size(954, 59);
            this.ColumnHeader.TabIndex = 19;
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
            this.EmployeeSort.Size = new System.Drawing.Size(236, 49);
            this.EmployeeSort.TabIndex = 34;
            this.EmployeeSort.Text = "Employee";
            this.EmployeeSort.UseTransparentBackground = true;
            this.EmployeeSort.Click += new System.EventHandler(this.EmployeeSort_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(851, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 49);
            this.label9.TabIndex = 9;
            this.label9.Text = "Net Pay";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(767, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 49);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total Deduction";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(683, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 49);
            this.label7.TabIndex = 7;
            this.label7.Text = "PhilHealth";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(599, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 49);
            this.label6.TabIndex = 6;
            this.label6.Text = "PAG-IBIG";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(515, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 49);
            this.label4.TabIndex = 5;
            this.label4.Text = "SSS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(413, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 49);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gross Pay";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(329, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 49);
            this.label2.TabIndex = 3;
            this.label2.Text = "Daily Rate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(251, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Worked Days";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 11;
            this.guna2Elipse2.TargetControl = this.guna2Panel5;
            // 
            // PayrollCalclulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1062, 704);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PayrollCalclulation";
            this.Text = "PayrollCalclulation";
            this.Load += new System.EventHandler(this.PayrollCalclulation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.ColumnHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2VScrollBar EmployeeViewScrollBar;
        private UserControls.CustomFlowLayoutPanel EmployeeTableView;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.TableLayoutPanel ColumnHeader;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button PayrollRangeButton;
        private Guna.UI2.WinForms.Guna2Button CalcPayrollButton;
        private Guna.UI2.WinForms.Guna2Button ViewDetailsButton;
        private Guna.UI2.WinForms.Guna2Button PrintPayslipButton;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private System.Windows.Forms.Label PayrollPeriodLabel;
        private Guna.UI2.WinForms.Guna2Button RefreshButton;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox CurrentPageLabel;
        private System.Windows.Forms.Label PageCountLabel;
        private System.Windows.Forms.Label PageLabel;
        private Guna.UI2.WinForms.Guna2Button LastPageButton;
        private Guna.UI2.WinForms.Guna2Button NextPageButton;
        private Guna.UI2.WinForms.Guna2Button FirstPageButton;
        private Guna.UI2.WinForms.Guna2Button BackPageButton;
        private Guna.UI2.WinForms.Guna2ComboBox ViewCountComboBox;
        private Guna.UI2.WinForms.Guna2Button EmployeeSort;
    }
}