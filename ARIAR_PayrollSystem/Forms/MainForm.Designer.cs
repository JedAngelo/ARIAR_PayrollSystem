namespace ARIAR_PayrollSystem.Forms
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeInformationBtn = new System.Windows.Forms.Button();
            this.BiometricAttendanceBtn = new System.Windows.Forms.Button();
            this.AttendanceManagementBtn = new System.Windows.Forms.Button();
            this.PayrollCalculationBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SidebarPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 311F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1312F));
            this.tableLayoutPanel1.Controls.Add(this.SidebarPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 888F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1622, 888);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.SidebarPanel.Controls.Add(this.LogoutBtn);
            this.SidebarPanel.Controls.Add(this.flowLayoutPanel1);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(311, 888);
            this.SidebarPanel.TabIndex = 0;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Image = global::ARIAR_PayrollSystem.Properties.Resources.logout_logo1;
            this.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 828);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(311, 60);
            this.LogoutBtn.TabIndex = 8;
            this.LogoutBtn.Text = "            Logout";
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MenuBtn);
            this.flowLayoutPanel1.Controls.Add(this.LogoPanel);
            this.flowLayoutPanel1.Controls.Add(this.EmployeeInformationBtn);
            this.flowLayoutPanel1.Controls.Add(this.BiometricAttendanceBtn);
            this.flowLayoutPanel1.Controls.Add(this.AttendanceManagementBtn);
            this.flowLayoutPanel1.Controls.Add(this.PayrollCalculationBtn);
            this.flowLayoutPanel1.Controls.Add(this.ReportBtn);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(311, 824);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // MenuBtn
            // 
            this.MenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.ForeColor = System.Drawing.Color.White;
            this.MenuBtn.Image = global::ARIAR_PayrollSystem.Properties.Resources.menu_logo1;
            this.MenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuBtn.Location = new System.Drawing.Point(0, 0);
            this.MenuBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(310, 69);
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Controls.Add(this.label1);
            this.LogoPanel.Location = new System.Drawing.Point(4, 73);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(374, 140);
            this.LogoPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ARIAR_PayrollSystem.Properties.Resources.New_Project__5_;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "_____________________";
            // 
            // EmployeeInformationBtn
            // 
            this.EmployeeInformationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeInformationBtn.FlatAppearance.BorderSize = 0;
            this.EmployeeInformationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeInformationBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeInformationBtn.ForeColor = System.Drawing.Color.White;
            this.EmployeeInformationBtn.Image = global::ARIAR_PayrollSystem.Properties.Resources.group_logo4;
            this.EmployeeInformationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeInformationBtn.Location = new System.Drawing.Point(0, 217);
            this.EmployeeInformationBtn.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeInformationBtn.Name = "EmployeeInformationBtn";
            this.EmployeeInformationBtn.Size = new System.Drawing.Size(310, 69);
            this.EmployeeInformationBtn.TabIndex = 2;
            this.EmployeeInformationBtn.Text = "   Employee Dashboard";
            this.EmployeeInformationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmployeeInformationBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EmployeeInformationBtn.UseVisualStyleBackColor = true;
            this.EmployeeInformationBtn.Click += new System.EventHandler(this.EmployeeInformationBtn_Click);
            // 
            // BiometricAttendanceBtn
            // 
            this.BiometricAttendanceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BiometricAttendanceBtn.FlatAppearance.BorderSize = 0;
            this.BiometricAttendanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BiometricAttendanceBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiometricAttendanceBtn.ForeColor = System.Drawing.Color.White;
            this.BiometricAttendanceBtn.Image = global::ARIAR_PayrollSystem.Properties.Resources.fingerprint_logo1;
            this.BiometricAttendanceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BiometricAttendanceBtn.Location = new System.Drawing.Point(0, 286);
            this.BiometricAttendanceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.BiometricAttendanceBtn.Name = "BiometricAttendanceBtn";
            this.BiometricAttendanceBtn.Size = new System.Drawing.Size(310, 69);
            this.BiometricAttendanceBtn.TabIndex = 3;
            this.BiometricAttendanceBtn.Text = "   Biometric Attendance";
            this.BiometricAttendanceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BiometricAttendanceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BiometricAttendanceBtn.UseVisualStyleBackColor = true;
            this.BiometricAttendanceBtn.Click += new System.EventHandler(this.BiometricAttendanceBtn_Click);
            // 
            // AttendanceManagementBtn
            // 
            this.AttendanceManagementBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AttendanceManagementBtn.FlatAppearance.BorderSize = 0;
            this.AttendanceManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttendanceManagementBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceManagementBtn.ForeColor = System.Drawing.Color.White;
            this.AttendanceManagementBtn.Image = global::ARIAR_PayrollSystem.Properties.Resources.schedule_logo1;
            this.AttendanceManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AttendanceManagementBtn.Location = new System.Drawing.Point(0, 355);
            this.AttendanceManagementBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AttendanceManagementBtn.Name = "AttendanceManagementBtn";
            this.AttendanceManagementBtn.Size = new System.Drawing.Size(310, 69);
            this.AttendanceManagementBtn.TabIndex = 4;
            this.AttendanceManagementBtn.Text = "   Attendance Management";
            this.AttendanceManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AttendanceManagementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AttendanceManagementBtn.UseVisualStyleBackColor = true;
            // 
            // PayrollCalculationBtn
            // 
            this.PayrollCalculationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PayrollCalculationBtn.FlatAppearance.BorderSize = 0;
            this.PayrollCalculationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayrollCalculationBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayrollCalculationBtn.ForeColor = System.Drawing.Color.White;
            this.PayrollCalculationBtn.Image = global::ARIAR_PayrollSystem.Properties.Resources.calculate_logo1;
            this.PayrollCalculationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PayrollCalculationBtn.Location = new System.Drawing.Point(0, 424);
            this.PayrollCalculationBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PayrollCalculationBtn.Name = "PayrollCalculationBtn";
            this.PayrollCalculationBtn.Size = new System.Drawing.Size(310, 69);
            this.PayrollCalculationBtn.TabIndex = 5;
            this.PayrollCalculationBtn.Text = "   Payroll Calculation";
            this.PayrollCalculationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PayrollCalculationBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PayrollCalculationBtn.UseVisualStyleBackColor = true;
            // 
            // ReportBtn
            // 
            this.ReportBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportBtn.FlatAppearance.BorderSize = 0;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.ForeColor = System.Drawing.Color.White;
            this.ReportBtn.Image = global::ARIAR_PayrollSystem.Properties.Resources.description_logo1;
            this.ReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportBtn.Location = new System.Drawing.Point(0, 493);
            this.ReportBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(310, 69);
            this.ReportBtn.TabIndex = 6;
            this.ReportBtn.Text = "   Report";
            this.ReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReportBtn.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 562);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(310, 69);
            this.button6.TabIndex = 7;
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(315, 4);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1304, 880);
            this.MainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1622, 888);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1622, 888);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeInformation";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SidebarPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EmployeeInformationBtn;
        private System.Windows.Forms.Button BiometricAttendanceBtn;
        private System.Windows.Forms.Button AttendanceManagementBtn;
        private System.Windows.Forms.Button PayrollCalculationBtn;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button button6;
        internal System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button LogoutBtn;
    }
}