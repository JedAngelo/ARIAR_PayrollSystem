namespace ARIAR_PayrollSystem.Forms
{
    partial class AttendanceManagement
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
            this.AttendanceManagementPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MonthComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.YearComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.CalendarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.DayOfTheWeekTLP = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalendarView = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.AttendanceManagementPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CalendarPanel.SuspendLayout();
            this.DayOfTheWeekTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // AttendanceManagementPanel
            // 
            this.AttendanceManagementPanel.BackColor = System.Drawing.Color.White;
            this.AttendanceManagementPanel.Controls.Add(this.panel1);
            this.AttendanceManagementPanel.Controls.Add(this.guna2Button2);
            this.AttendanceManagementPanel.Controls.Add(this.guna2Button3);
            this.AttendanceManagementPanel.Controls.Add(this.guna2Button1);
            this.AttendanceManagementPanel.Controls.Add(this.guna2Button4);
            this.AttendanceManagementPanel.Controls.Add(this.CalendarPanel);
            this.AttendanceManagementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttendanceManagementPanel.Location = new System.Drawing.Point(0, 0);
            this.AttendanceManagementPanel.Margin = new System.Windows.Forms.Padding(0);
            this.AttendanceManagementPanel.Name = "AttendanceManagementPanel";
            this.AttendanceManagementPanel.Size = new System.Drawing.Size(990, 599);
            this.AttendanceManagementPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.MonthComboBox);
            this.panel1.Controls.Add(this.YearComboBox);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(339, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 44);
            this.panel1.TabIndex = 18;
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthComboBox.BackColor = System.Drawing.Color.Transparent;
            this.MonthComboBox.BorderThickness = 0;
            this.MonthComboBox.DisabledState.FillColor = System.Drawing.Color.White;
            this.MonthComboBox.DisabledState.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.MonthComboBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MonthComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MonthComboBox.DropDownHeight = 40;
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.MonthComboBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MonthComboBox.IntegralHeight = false;
            this.MonthComboBox.ItemHeight = 38;
            this.MonthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthComboBox.ItemsAppearance.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.MonthComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MonthComboBox.ItemsAppearance.SelectedFont = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.MonthComboBox.Location = new System.Drawing.Point(0, 0);
            this.MonthComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(172, 44);
            this.MonthComboBox.StartIndex = 0;
            this.MonthComboBox.TabIndex = 16;
            this.MonthComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MonthComboBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.MonthComboBox.SelectedIndexChanged += new System.EventHandler(this.MonthComboBox_SelectedIndexChanged);
            // 
            // YearComboBox
            // 
            this.YearComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YearComboBox.BackColor = System.Drawing.Color.Transparent;
            this.YearComboBox.BorderThickness = 0;
            this.YearComboBox.DisabledState.FillColor = System.Drawing.Color.White;
            this.YearComboBox.DisabledState.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.YearComboBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.YearComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.YearComboBox.DropDownHeight = 40;
            this.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.YearComboBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.YearComboBox.IntegralHeight = false;
            this.YearComboBox.ItemHeight = 38;
            this.YearComboBox.Items.AddRange(new object[] {
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070",
            "2071",
            "2072",
            "2073",
            "2074",
            "2075",
            "2076",
            "2077",
            "2078",
            "2079",
            "2080",
            "2081",
            "2082",
            "2083",
            "2084",
            "2085",
            "2086",
            "2087",
            "2088",
            "2089",
            "2090",
            "2091",
            "2092",
            "2093",
            "2094",
            "2095",
            "2096",
            "2097",
            "2098",
            "2099"});
            this.YearComboBox.ItemsAppearance.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.YearComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.YearComboBox.ItemsAppearance.SelectedFont = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.YearComboBox.Location = new System.Drawing.Point(154, 0);
            this.YearComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.YearComboBox.MaxDropDownItems = 5;
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(128, 44);
            this.YearComboBox.StartIndex = 0;
            this.YearComboBox.TabIndex = 17;
            this.YearComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.YearComboBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.YearComboBox.SelectedIndexChanged += new System.EventHandler(this.YearComboBox_SelectedIndexChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.guna2Button2.Location = new System.Drawing.Point(741, 20);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.White;
            this.guna2Button2.ShadowDecoration.BorderRadius = 11;
            this.guna2Button2.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button2.ShadowDecoration.Depth = 15;
            this.guna2Button2.Size = new System.Drawing.Size(39, 44);
            this.guna2Button2.TabIndex = 15;
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.guna2Button3.Location = new System.Drawing.Point(697, 20);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.Color.White;
            this.guna2Button3.ShadowDecoration.BorderRadius = 11;
            this.guna2Button3.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button3.ShadowDecoration.Depth = 15;
            this.guna2Button3.Size = new System.Drawing.Size(39, 44);
            this.guna2Button3.TabIndex = 14;
            this.guna2Button3.UseTransparentBackground = true;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button1.Image = global::ARIAR_PayrollSystem.Properties.Resources.arrow_left_double_line;
            this.guna2Button1.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(206, 20);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.White;
            this.guna2Button1.ShadowDecoration.BorderRadius = 11;
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button1.ShadowDecoration.Depth = 15;
            this.guna2Button1.Size = new System.Drawing.Size(39, 44);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button4
            // 
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
            this.guna2Button4.Image = global::ARIAR_PayrollSystem.Properties.Resources.arrow_left_s_line;
            this.guna2Button4.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button4.IndicateFocus = true;
            this.guna2Button4.Location = new System.Drawing.Point(250, 20);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.White;
            this.guna2Button4.ShadowDecoration.BorderRadius = 11;
            this.guna2Button4.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button4.ShadowDecoration.Depth = 15;
            this.guna2Button4.Size = new System.Drawing.Size(39, 44);
            this.guna2Button4.TabIndex = 12;
            this.guna2Button4.UseTransparentBackground = true;
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalendarPanel.BackColor = System.Drawing.Color.Transparent;
            this.CalendarPanel.Controls.Add(this.DayOfTheWeekTLP);
            this.CalendarPanel.Controls.Add(this.CalendarView);
            this.CalendarPanel.FillColor = System.Drawing.SystemColors.Control;
            this.CalendarPanel.Location = new System.Drawing.Point(24, 100);
            this.CalendarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.ShadowDecoration.BorderRadius = 0;
            this.CalendarPanel.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.CalendarPanel.ShadowDecoration.Depth = 15;
            this.CalendarPanel.ShadowDecoration.Enabled = true;
            this.CalendarPanel.Size = new System.Drawing.Size(941, 475);
            this.CalendarPanel.TabIndex = 10;
            this.CalendarPanel.UseTransparentBackground = true;
            // 
            // DayOfTheWeekTLP
            // 
            this.DayOfTheWeekTLP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DayOfTheWeekTLP.BackColor = System.Drawing.SystemColors.Control;
            this.DayOfTheWeekTLP.ColumnCount = 7;
            this.DayOfTheWeekTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.DayOfTheWeekTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.DayOfTheWeekTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.DayOfTheWeekTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.DayOfTheWeekTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.DayOfTheWeekTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.DayOfTheWeekTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.DayOfTheWeekTLP.Controls.Add(this.label1, 0, 0);
            this.DayOfTheWeekTLP.Controls.Add(this.label7, 6, 0);
            this.DayOfTheWeekTLP.Controls.Add(this.label6, 5, 0);
            this.DayOfTheWeekTLP.Controls.Add(this.label5, 4, 0);
            this.DayOfTheWeekTLP.Controls.Add(this.label4, 3, 0);
            this.DayOfTheWeekTLP.Controls.Add(this.label3, 2, 0);
            this.DayOfTheWeekTLP.Controls.Add(this.label2, 1, 0);
            this.DayOfTheWeekTLP.Location = new System.Drawing.Point(0, 0);
            this.DayOfTheWeekTLP.Margin = new System.Windows.Forms.Padding(0);
            this.DayOfTheWeekTLP.Name = "DayOfTheWeekTLP";
            this.DayOfTheWeekTLP.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.DayOfTheWeekTLP.RowCount = 1;
            this.DayOfTheWeekTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DayOfTheWeekTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.DayOfTheWeekTLP.Size = new System.Drawing.Size(941, 34);
            this.DayOfTheWeekTLP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sunday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label7.Location = new System.Drawing.Point(803, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saturday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label6.Location = new System.Drawing.Point(670, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Friday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(537, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thursday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(404, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wednesday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(271, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuesday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(138, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monday";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalendarView
            // 
            this.CalendarView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalendarView.BackColor = System.Drawing.SystemColors.Control;
            this.CalendarView.ColumnCount = 7;
            this.CalendarView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendarView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendarView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendarView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendarView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendarView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendarView.Location = new System.Drawing.Point(0, 34);
            this.CalendarView.Margin = new System.Windows.Forms.Padding(0);
            this.CalendarView.Name = "CalendarView";
            this.CalendarView.Padding = new System.Windows.Forms.Padding(2);
            this.CalendarView.RowCount = 6;
            this.CalendarView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalendarView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalendarView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalendarView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalendarView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalendarView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalendarView.Size = new System.Drawing.Size(941, 441);
            this.CalendarView.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this.DayOfTheWeekTLP;
            // 
            // AttendanceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(990, 599);
            this.Controls.Add(this.AttendanceManagementPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendanceManagement";
            this.Text = "AttendanceLog";
            this.AttendanceManagementPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.CalendarPanel.ResumeLayout(false);
            this.DayOfTheWeekTLP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AttendanceManagementPanel;
        private System.Windows.Forms.TableLayoutPanel CalendarView;
        private Guna.UI2.WinForms.Guna2Panel CalendarPanel;
        private System.Windows.Forms.TableLayoutPanel DayOfTheWeekTLP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox MonthComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox YearComboBox;
        private System.Windows.Forms.Panel panel1;
    }
}