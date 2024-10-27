namespace ARIAR_PayrollSystem.Forms
{
    partial class BiometricAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BiometricAttPanel = new System.Windows.Forms.Panel();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.ReportLabel = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.PromptLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.AttendanceDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TimerProcess = new System.Windows.Forms.Timer(this.components);
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BiometricAttPanel.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDataGrid)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BiometricAttPanel
            // 
            this.BiometricAttPanel.BackColor = System.Drawing.Color.White;
            this.BiometricAttPanel.Controls.Add(this.SearchBox);
            this.BiometricAttPanel.Controls.Add(this.guna2Panel5);
            this.BiometricAttPanel.Controls.Add(this.guna2Panel4);
            this.BiometricAttPanel.Controls.Add(this.guna2Panel1);
            this.BiometricAttPanel.Controls.Add(this.tableLayoutPanel1);
            this.BiometricAttPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BiometricAttPanel.Location = new System.Drawing.Point(0, 0);
            this.BiometricAttPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BiometricAttPanel.Name = "BiometricAttPanel";
            this.BiometricAttPanel.Size = new System.Drawing.Size(990, 749);
            this.BiometricAttPanel.TabIndex = 0;
            this.BiometricAttPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BiometricAttPanel_Paint);
            // 
            // SearchBox
            // 
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
            this.SearchBox.IconRightOffset = new System.Drawing.Point(8, 0);
            this.SearchBox.Location = new System.Drawing.Point(12, 285);
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
            this.SearchBox.Size = new System.Drawing.Size(436, 31);
            this.SearchBox.TabIndex = 16;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderRadius = 8;
            this.guna2Panel5.Controls.Add(this.NameLabel);
            this.guna2Panel5.Controls.Add(this.guna2Panel7);
            this.guna2Panel5.Controls.Add(this.guna2Panel6);
            this.guna2Panel5.Controls.Add(this.label6);
            this.guna2Panel5.Controls.Add(this.pictureBox2);
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Location = new System.Drawing.Point(462, 16);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel5.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel5.ShadowDecoration.Depth = 15;
            this.guna2Panel5.ShadowDecoration.Enabled = true;
            this.guna2Panel5.Size = new System.Drawing.Size(508, 717);
            this.guna2Panel5.TabIndex = 11;
            this.guna2Panel5.UseTransparentBackground = true;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NameLabel.Location = new System.Drawing.Point(0, 345);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(508, 44);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "...";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel7.AutoScroll = true;
            this.guna2Panel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel7.BorderRadius = 8;
            this.guna2Panel7.Controls.Add(this.ReportLabel);
            this.guna2Panel7.FillColor = System.Drawing.Color.White;
            this.guna2Panel7.Location = new System.Drawing.Point(10, 487);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel7.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel7.ShadowDecoration.Depth = 15;
            this.guna2Panel7.ShadowDecoration.Enabled = true;
            this.guna2Panel7.Size = new System.Drawing.Size(490, 207);
            this.guna2Panel7.TabIndex = 14;
            this.guna2Panel7.UseTransparentBackground = true;
            // 
            // ReportLabel
            // 
            this.ReportLabel.AutoScroll = true;
            this.ReportLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReportLabel.DefaultText = "";
            this.ReportLabel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ReportLabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ReportLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReportLabel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReportLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportLabel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReportLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLabel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReportLabel.Location = new System.Drawing.Point(0, 0);
            this.ReportLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReportLabel.Multiline = true;
            this.ReportLabel.Name = "ReportLabel";
            this.ReportLabel.PasswordChar = '\0';
            this.ReportLabel.PlaceholderText = "";
            this.ReportLabel.SelectedText = "";
            this.ReportLabel.Size = new System.Drawing.Size(490, 207);
            this.ReportLabel.TabIndex = 0;
            this.ReportLabel.TextChanged += new System.EventHandler(this.ReportLabel_TextChanged);
            this.ReportLabel.Leave += new System.EventHandler(this.ReportLabel_Leave);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderRadius = 8;
            this.guna2Panel6.Controls.Add(this.PromptLabel);
            this.guna2Panel6.FillColor = System.Drawing.Color.White;
            this.guna2Panel6.Location = new System.Drawing.Point(10, 430);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel6.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel6.ShadowDecoration.Depth = 15;
            this.guna2Panel6.ShadowDecoration.Enabled = true;
            this.guna2Panel6.Size = new System.Drawing.Size(490, 43);
            this.guna2Panel6.TabIndex = 13;
            this.guna2Panel6.UseTransparentBackground = true;
            // 
            // PromptLabel
            // 
            this.PromptLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PromptLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromptLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PromptLabel.Location = new System.Drawing.Point(0, 0);
            this.PromptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Size = new System.Drawing.Size(490, 43);
            this.PromptLabel.TabIndex = 1;
            this.PromptLabel.Text = "AFTERNOON";
            this.PromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(0, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(508, 44);
            this.label6.TabIndex = 4;
            this.label6.Text = "SCAN NOW";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::ARIAR_PayrollSystem.Properties.Resources.Untitled_design__1_;
            this.pictureBox2.Location = new System.Drawing.Point(153, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 8;
            this.guna2Panel4.Controls.Add(this.AttendanceDataGrid);
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel4.Location = new System.Drawing.Point(12, 322);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel4.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel4.ShadowDecoration.Depth = 15;
            this.guna2Panel4.ShadowDecoration.Enabled = true;
            this.guna2Panel4.Size = new System.Drawing.Size(435, 411);
            this.guna2Panel4.TabIndex = 10;
            this.guna2Panel4.UseTransparentBackground = true;
            // 
            // AttendanceDataGrid
            // 
            this.AttendanceDataGrid.AllowUserToAddRows = false;
            this.AttendanceDataGrid.AllowUserToDeleteRows = false;
            this.AttendanceDataGrid.AllowUserToResizeColumns = false;
            this.AttendanceDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Empty;
            this.AttendanceDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AttendanceDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AttendanceDataGrid.ColumnHeadersHeight = 35;
            this.AttendanceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Log,
            this.Type});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendanceDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.AttendanceDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttendanceDataGrid.GridColor = System.Drawing.Color.White;
            this.AttendanceDataGrid.Location = new System.Drawing.Point(0, 0);
            this.AttendanceDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.AttendanceDataGrid.MultiSelect = false;
            this.AttendanceDataGrid.Name = "AttendanceDataGrid";
            this.AttendanceDataGrid.ReadOnly = true;
            this.AttendanceDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AttendanceDataGrid.RowHeadersVisible = false;
            this.AttendanceDataGrid.RowHeadersWidth = 51;
            this.AttendanceDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AttendanceDataGrid.RowTemplate.Height = 35;
            this.AttendanceDataGrid.Size = new System.Drawing.Size(435, 411);
            this.AttendanceDataGrid.TabIndex = 1;
            this.AttendanceDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.AttendanceDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Lavender;
            this.AttendanceDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AttendanceDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AttendanceDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AttendanceDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AttendanceDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.AttendanceDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.AttendanceDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AttendanceDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AttendanceDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AttendanceDataGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.AttendanceDataGrid.ThemeStyle.ReadOnly = true;
            this.AttendanceDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.AttendanceDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AttendanceDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AttendanceDataGrid.ThemeStyle.RowsStyle.Height = 35;
            this.AttendanceDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.AttendanceDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.AttendanceDataGrid.Leave += new System.EventHandler(this.AttendanceDataGrid_Leave);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.Controls.Add(this.DateLabel);
            this.guna2Panel1.Controls.Add(this.TimeLabel);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 16);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel1.ShadowDecoration.Depth = 15;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(435, 138);
            this.guna2Panel1.TabIndex = 9;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DateLabel.Location = new System.Drawing.Point(2, 78);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(430, 44);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "JANUARY 1, 2001 MONDAY";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TimeLabel.Location = new System.Drawing.Point(2, 16);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(430, 44);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "11:11:11 AM";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 166);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(436, 107);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Panel2.Location = new System.Drawing.Point(223, 5);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel2.ShadowDecoration.Depth = 15;
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.Size = new System.Drawing.Size(213, 43);
            this.guna2Panel2.TabIndex = 12;
            this.guna2Panel2.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "AFTERNOON";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 8;
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 5);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel3.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel3.ShadowDecoration.Depth = 15;
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.Size = new System.Drawing.Size(213, 43);
            this.guna2Panel3.TabIndex = 11;
            this.guna2Panel3.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "MORNING";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.guna2Button4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.guna2Button3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(223, 48);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(213, 59);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 8;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button4.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.IndicateFocus = true;
            this.guna2Button4.Location = new System.Drawing.Point(111, 5);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.BorderRadius = 11;
            this.guna2Button4.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button4.ShadowDecoration.Depth = 15;
            this.guna2Button4.ShadowDecoration.Enabled = true;
            this.guna2Button4.Size = new System.Drawing.Size(102, 54);
            this.guna2Button4.TabIndex = 8;
            this.guna2Button4.Text = "Time Out";
            this.guna2Button4.UseTransparentBackground = true;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 8;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button3.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.IndicateFocus = true;
            this.guna2Button3.Location = new System.Drawing.Point(0, 5);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.BorderRadius = 11;
            this.guna2Button3.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button3.ShadowDecoration.Depth = 15;
            this.guna2Button3.ShadowDecoration.Enabled = true;
            this.guna2Button3.Size = new System.Drawing.Size(101, 54);
            this.guna2Button3.TabIndex = 7;
            this.guna2Button3.Text = "Time In";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.guna2Button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.guna2Button2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(218, 59);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button1.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(0, 5);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.BorderRadius = 11;
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button1.ShadowDecoration.Depth = 15;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.Size = new System.Drawing.Size(101, 54);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Time In";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button2.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.IndicateFocus = true;
            this.guna2Button2.Location = new System.Drawing.Point(111, 5);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.BorderRadius = 11;
            this.guna2Button2.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Button2.ShadowDecoration.Depth = 15;
            this.guna2Button2.ShadowDecoration.Enabled = true;
            this.guna2Button2.Size = new System.Drawing.Size(102, 54);
            this.guna2Button2.TabIndex = 7;
            this.guna2Button2.Text = "Time Out";
            this.guna2Button2.UseTransparentBackground = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 11;
            this.guna2Elipse1.TargetControl = this.AttendanceDataGrid;
            // 
            // TimerProcess
            // 
            this.TimerProcess.Interval = 1000;
            this.TimerProcess.Tick += new System.EventHandler(this.TimerProcess_Tick);
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "Name";
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Log
            // 
            this.Log.DataPropertyName = "Log";
            this.Log.FillWeight = 60F;
            this.Log.HeaderText = "Log";
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.FillWeight = 115F;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // BiometricAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(990, 749);
            this.Controls.Add(this.BiometricAttPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BiometricAttendance";
            this.Text = "BiometricAttendance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BiometricAttendance_FormClosing);
            this.Load += new System.EventHandler(this.BiometricAttendance_Load);
            this.BiometricAttPanel.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDataGrid)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.Panel BiometricAttPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private System.Windows.Forms.Timer TimerProcess;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label PromptLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2TextBox ReportLabel;
        private System.Windows.Forms.Label NameLabel;
        private Guna.UI2.WinForms.Guna2DataGridView AttendanceDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Log;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}