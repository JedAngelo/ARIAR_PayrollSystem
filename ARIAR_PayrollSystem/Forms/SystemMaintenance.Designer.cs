namespace ARIAR_PayrollSystem.Forms
{
    partial class SystemMaintenance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemMaintenance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SystemMaintenanceTabs = new Guna.UI2.WinForms.Guna2TabControl();
            this.EmployeeTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BiometricsTab = new System.Windows.Forms.TabPage();
            this.panel18 = new System.Windows.Forms.Panel();
            this.guna2Panel13 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel15 = new Guna.UI2.WinForms.Guna2Panel();
            this.EmployeeDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.LabelTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.SystemMaintenanceTabs.SuspendLayout();
            this.EmployeeTab.SuspendLayout();
            this.BiometricsTab.SuspendLayout();
            this.panel18.SuspendLayout();
            this.guna2Panel13.SuspendLayout();
            this.guna2Panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SystemMaintenanceTabs);
            this.LabelTransition.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 746);
            this.panel1.TabIndex = 0;
            // 
            // SystemMaintenanceTabs
            // 
            this.SystemMaintenanceTabs.Controls.Add(this.EmployeeTab);
            this.SystemMaintenanceTabs.Controls.Add(this.BiometricsTab);
            this.SystemMaintenanceTabs.Controls.Add(this.tabPage1);
            this.LabelTransition.SetDecoration(this.SystemMaintenanceTabs, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SystemMaintenanceTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemMaintenanceTabs.ItemSize = new System.Drawing.Size(200, 40);
            this.SystemMaintenanceTabs.Location = new System.Drawing.Point(0, 0);
            this.SystemMaintenanceTabs.Margin = new System.Windows.Forms.Padding(0);
            this.SystemMaintenanceTabs.Name = "SystemMaintenanceTabs";
            this.SystemMaintenanceTabs.SelectedIndex = 0;
            this.SystemMaintenanceTabs.Size = new System.Drawing.Size(1091, 746);
            this.SystemMaintenanceTabs.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.SystemMaintenanceTabs.TabButtonHoverState.FillColor = System.Drawing.SystemColors.Control;
            this.SystemMaintenanceTabs.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.SystemMaintenanceTabs.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SystemMaintenanceTabs.TabButtonHoverState.InnerColor = System.Drawing.SystemColors.Control;
            this.SystemMaintenanceTabs.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.SystemMaintenanceTabs.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.SystemMaintenanceTabs.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.SystemMaintenanceTabs.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SystemMaintenanceTabs.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.SystemMaintenanceTabs.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.SystemMaintenanceTabs.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.SystemMaintenanceTabs.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.SystemMaintenanceTabs.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SystemMaintenanceTabs.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.SystemMaintenanceTabs.TabButtonSize = new System.Drawing.Size(200, 40);
            this.SystemMaintenanceTabs.TabIndex = 0;
            this.SystemMaintenanceTabs.TabMenuBackColor = System.Drawing.Color.White;
            this.SystemMaintenanceTabs.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.SystemMaintenanceTabs.SelectedIndexChanged += new System.EventHandler(this.SystemMaintenanceTabs_SelectedIndexChanged);
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.BackColor = System.Drawing.Color.White;
            this.EmployeeTab.Controls.Add(this.panel2);
            this.LabelTransition.SetDecoration(this.EmployeeTab, Guna.UI2.AnimatorNS.DecorationType.None);
            this.EmployeeTab.Location = new System.Drawing.Point(4, 44);
            this.EmployeeTab.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.Size = new System.Drawing.Size(1083, 698);
            this.EmployeeTab.TabIndex = 0;
            this.EmployeeTab.Text = "Users";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.LabelTransition.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 698);
            this.panel2.TabIndex = 0;
            // 
            // BiometricsTab
            // 
            this.BiometricsTab.Controls.Add(this.panel18);
            this.LabelTransition.SetDecoration(this.BiometricsTab, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BiometricsTab.Location = new System.Drawing.Point(4, 44);
            this.BiometricsTab.Name = "BiometricsTab";
            this.BiometricsTab.Padding = new System.Windows.Forms.Padding(3);
            this.BiometricsTab.Size = new System.Drawing.Size(1083, 698);
            this.BiometricsTab.TabIndex = 2;
            this.BiometricsTab.Text = "Biometrics";
            this.BiometricsTab.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.White;
            this.panel18.Controls.Add(this.guna2Panel13);
            this.panel18.Controls.Add(this.guna2Panel15);
            this.LabelTransition.SetDecoration(this.panel18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(3, 3);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1077, 692);
            this.panel18.TabIndex = 1;
            // 
            // guna2Panel13
            // 
            this.guna2Panel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel13.BorderRadius = 8;
            this.guna2Panel13.Controls.Add(this.guna2Button6);
            this.LabelTransition.SetDecoration(this.guna2Panel13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel13.FillColor = System.Drawing.Color.White;
            this.guna2Panel13.Location = new System.Drawing.Point(366, 20);
            this.guna2Panel13.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel13.Name = "guna2Panel13";
            this.guna2Panel13.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel13.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel13.ShadowDecoration.Depth = 15;
            this.guna2Panel13.ShadowDecoration.Enabled = true;
            this.guna2Panel13.Size = new System.Drawing.Size(328, 180);
            this.guna2Panel13.TabIndex = 13;
            this.guna2Panel13.UseTransparentBackground = true;
            // 
            // guna2Button6
            // 
            this.guna2Button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button6.BorderRadius = 5;
            this.LabelTransition.SetDecoration(this.guna2Button6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(96, 70);
            this.guna2Button6.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(144, 36);
            this.guna2Button6.TabIndex = 0;
            this.guna2Button6.Text = "Register Fingerprint";
            this.guna2Button6.UseTransparentBackground = true;
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel15
            // 
            this.guna2Panel15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel15.BorderRadius = 8;
            this.guna2Panel15.Controls.Add(this.EmployeeDataGrid);
            this.LabelTransition.SetDecoration(this.guna2Panel15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel15.FillColor = System.Drawing.Color.White;
            this.guna2Panel15.Location = new System.Drawing.Point(16, 20);
            this.guna2Panel15.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel15.Name = "guna2Panel15";
            this.guna2Panel15.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel15.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel15.ShadowDecoration.Depth = 15;
            this.guna2Panel15.ShadowDecoration.Enabled = true;
            this.guna2Panel15.Size = new System.Drawing.Size(333, 647);
            this.guna2Panel15.TabIndex = 11;
            this.guna2Panel15.UseTransparentBackground = true;
            // 
            // EmployeeDataGrid
            // 
            this.EmployeeDataGrid.AllowUserToAddRows = false;
            this.EmployeeDataGrid.AllowUserToDeleteRows = false;
            this.EmployeeDataGrid.AllowUserToResizeColumns = false;
            this.EmployeeDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeDataGrid.ColumnHeadersHeight = 45;
            this.EmployeeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeName,
            this.ID});
            this.LabelTransition.SetDecoration(this.EmployeeDataGrid, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.EmployeeDataGrid.Location = new System.Drawing.Point(0, 0);
            this.EmployeeDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeDataGrid.MultiSelect = false;
            this.EmployeeDataGrid.Name = "EmployeeDataGrid";
            this.EmployeeDataGrid.ReadOnly = true;
            this.EmployeeDataGrid.RowHeadersVisible = false;
            this.EmployeeDataGrid.RowHeadersWidth = 51;
            this.EmployeeDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EmployeeDataGrid.RowTemplate.Height = 45;
            this.EmployeeDataGrid.Size = new System.Drawing.Size(333, 647);
            this.EmployeeDataGrid.TabIndex = 1;
            this.EmployeeDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.EmployeeDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.EmployeeDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.EmployeeDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeDataGrid.ThemeStyle.HeaderStyle.Height = 45;
            this.EmployeeDataGrid.ThemeStyle.ReadOnly = true;
            this.EmployeeDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.EmployeeDataGrid.ThemeStyle.RowsStyle.Height = 45;
            this.EmployeeDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.EmployeeDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.EmployeeDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EmployeeDataGrid_CellMouseClick);
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "Fullname";
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "PersonalId";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.guna2Button2);
            this.LabelTransition.SetDecoration(this.tabPage1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1083, 698);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Testing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.BorderRadius = 5;
            this.LabelTransition.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(442, 148);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(144, 36);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Open Modal";
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog1.Text = null;
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // LabelTransition
            // 
            this.LabelTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.LabelTransition.Cursor = null;
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
            this.LabelTransition.DefaultAnimation = animation1;
            this.LabelTransition.Interval = 11;
            this.LabelTransition.TimeStep = 0.1F;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 11;
            this.guna2Elipse1.TargetControl = this.EmployeeDataGrid;
            // 
            // SystemMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1091, 746);
            this.Controls.Add(this.panel1);
            this.LabelTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SystemMaintenance";
            this.Text = "SystemMaintenance";
            this.Load += new System.EventHandler(this.SystemMaintenance_Load);
            this.panel1.ResumeLayout(false);
            this.SystemMaintenanceTabs.ResumeLayout(false);
            this.EmployeeTab.ResumeLayout(false);
            this.BiometricsTab.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.guna2Panel13.ResumeLayout(false);
            this.guna2Panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TabControl SystemMaintenanceTabs;
        private System.Windows.Forms.TabPage EmployeeTab;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private Guna.UI2.WinForms.Guna2Transition LabelTransition;
        private System.Windows.Forms.TabPage BiometricsTab;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel18;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel13;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel15;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}