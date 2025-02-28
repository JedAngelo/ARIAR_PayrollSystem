namespace PayrollSystem.UserControls
{
    partial class EmployeeAttendanceLogView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainView = new Guna.UI2.WinForms.Guna2Panel();
            this.ColumnHeader = new System.Windows.Forms.TableLayoutPanel();
            this.AttendanceType = new System.Windows.Forms.Label();
            this.AfternoonOutLabel = new System.Windows.Forms.Label();
            this.AfternoonInLabel = new System.Windows.Forms.Label();
            this.MorningOutLabel = new System.Windows.Forms.Label();
            this.MorningInLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fullname = new System.Windows.Forms.Label();
            this.EmployeePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LeaveLabel = new System.Windows.Forms.Label();
            this.TopView = new Guna.UI2.WinForms.Guna2Panel();
            this.MainView.SuspendLayout();
            this.ColumnHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).BeginInit();
            this.TopView.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainView
            // 
            this.MainView.BackColor = System.Drawing.Color.Transparent;
            this.MainView.BorderColor = System.Drawing.Color.SlateGray;
            this.MainView.BorderRadius = 10;
            this.MainView.Controls.Add(this.ColumnHeader);
            this.MainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainView.FillColor = System.Drawing.Color.White;
            this.MainView.Location = new System.Drawing.Point(5, 2);
            this.MainView.Name = "MainView";
            this.MainView.ShadowDecoration.BorderRadius = 15;
            this.MainView.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.MainView.ShadowDecoration.Depth = 15;
            this.MainView.Size = new System.Drawing.Size(1081, 49);
            this.MainView.TabIndex = 4;
            this.MainView.UseTransparentBackground = true;
            this.MainView.Click += new System.EventHandler(this.MainView_Click);
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.BackColor = System.Drawing.Color.Transparent;
            this.ColumnHeader.ColumnCount = 6;
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.93974F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5984F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5984F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5984F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5984F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.ColumnHeader.Controls.Add(this.AttendanceType, 5, 0);
            this.ColumnHeader.Controls.Add(this.AfternoonOutLabel, 4, 0);
            this.ColumnHeader.Controls.Add(this.AfternoonInLabel, 3, 0);
            this.ColumnHeader.Controls.Add(this.MorningOutLabel, 2, 0);
            this.ColumnHeader.Controls.Add(this.MorningInLabel, 1, 0);
            this.ColumnHeader.Controls.Add(this.panel1, 0, 0);
            this.ColumnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnHeader.Location = new System.Drawing.Point(0, 0);
            this.ColumnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.ColumnHeader.Name = "ColumnHeader";
            this.ColumnHeader.RowCount = 1;
            this.ColumnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ColumnHeader.Size = new System.Drawing.Size(1081, 49);
            this.ColumnHeader.TabIndex = 5;
            this.ColumnHeader.Click += new System.EventHandler(this.MainView_Click);
            // 
            // AttendanceType
            // 
            this.AttendanceType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttendanceType.AutoSize = true;
            this.AttendanceType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.AttendanceType.Location = new System.Drawing.Point(975, 17);
            this.AttendanceType.Name = "AttendanceType";
            this.AttendanceType.Size = new System.Drawing.Size(29, 15);
            this.AttendanceType.TabIndex = 97;
            this.AttendanceType.Text = "N/A";
            this.AttendanceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AfternoonOutLabel
            // 
            this.AfternoonOutLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AfternoonOutLabel.AutoSize = true;
            this.AfternoonOutLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfternoonOutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.AfternoonOutLabel.Location = new System.Drawing.Point(821, 17);
            this.AfternoonOutLabel.Name = "AfternoonOutLabel";
            this.AfternoonOutLabel.Size = new System.Drawing.Size(30, 15);
            this.AfternoonOutLabel.TabIndex = 95;
            this.AfternoonOutLabel.Text = "--:--";
            this.AfternoonOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AfternoonOutLabel.Click += new System.EventHandler(this.MainView_Click);
            // 
            // AfternoonInLabel
            // 
            this.AfternoonInLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AfternoonInLabel.AutoSize = true;
            this.AfternoonInLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfternoonInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.AfternoonInLabel.Location = new System.Drawing.Point(696, 17);
            this.AfternoonInLabel.Name = "AfternoonInLabel";
            this.AfternoonInLabel.Size = new System.Drawing.Size(30, 15);
            this.AfternoonInLabel.TabIndex = 94;
            this.AfternoonInLabel.Text = "--:--";
            this.AfternoonInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AfternoonInLabel.Click += new System.EventHandler(this.MainView_Click);
            // 
            // MorningOutLabel
            // 
            this.MorningOutLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MorningOutLabel.AutoSize = true;
            this.MorningOutLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MorningOutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.MorningOutLabel.Location = new System.Drawing.Point(571, 17);
            this.MorningOutLabel.Name = "MorningOutLabel";
            this.MorningOutLabel.Size = new System.Drawing.Size(30, 15);
            this.MorningOutLabel.TabIndex = 93;
            this.MorningOutLabel.Text = "--:--";
            this.MorningOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MorningOutLabel.Click += new System.EventHandler(this.MainView_Click);
            // 
            // MorningInLabel
            // 
            this.MorningInLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MorningInLabel.AutoSize = true;
            this.MorningInLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MorningInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.MorningInLabel.Location = new System.Drawing.Point(446, 17);
            this.MorningInLabel.Name = "MorningInLabel";
            this.MorningInLabel.Size = new System.Drawing.Size(30, 15);
            this.MorningInLabel.TabIndex = 92;
            this.MorningInLabel.Text = "--:--";
            this.MorningInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MorningInLabel.Click += new System.EventHandler(this.MainView_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Fullname);
            this.panel1.Controls.Add(this.EmployeePic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 43);
            this.panel1.TabIndex = 96;
            this.panel1.Click += new System.EventHandler(this.MainView_Click);
            // 
            // Fullname
            // 
            this.Fullname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fullname.AutoSize = true;
            this.Fullname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Fullname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fullname.Location = new System.Drawing.Point(43, 14);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(107, 15);
            this.Fullname.TabIndex = 7;
            this.Fullname.Text = "Jed Angelo M. Tan";
            this.Fullname.Click += new System.EventHandler(this.MainView_Click);
            // 
            // EmployeePic
            // 
            this.EmployeePic.BackColor = System.Drawing.Color.Transparent;
            this.EmployeePic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeePic.Image = global::PayrollSystem.Properties.Resources.account_circle_fill1;
            this.EmployeePic.ImageRotate = 0F;
            this.EmployeePic.Location = new System.Drawing.Point(5, 4);
            this.EmployeePic.Name = "EmployeePic";
            this.EmployeePic.ShadowDecoration.BorderRadius = 11;
            this.EmployeePic.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.EmployeePic.ShadowDecoration.Depth = 15;
            this.EmployeePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EmployeePic.Size = new System.Drawing.Size(35, 35);
            this.EmployeePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmployeePic.TabIndex = 6;
            this.EmployeePic.TabStop = false;
            this.EmployeePic.UseTransparentBackground = true;
            this.EmployeePic.Click += new System.EventHandler(this.MainView_Click);
            // 
            // LeaveLabel
            // 
            this.LeaveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LeaveLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.LeaveLabel.Location = new System.Drawing.Point(337, 7);
            this.LeaveLabel.Name = "LeaveLabel";
            this.LeaveLabel.Size = new System.Drawing.Size(740, 35);
            this.LeaveLabel.TabIndex = 96;
            this.LeaveLabel.Text = "ON LEAVE";
            this.LeaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LeaveLabel.Visible = false;
            this.LeaveLabel.Click += new System.EventHandler(this.MainView_Click);
            // 
            // TopView
            // 
            this.TopView.BackColor = System.Drawing.Color.Transparent;
            this.TopView.BorderColor = System.Drawing.Color.SlateGray;
            this.TopView.BorderRadius = 10;
            this.TopView.BorderThickness = 1;
            this.TopView.Controls.Add(this.LeaveLabel);
            this.TopView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopView.Location = new System.Drawing.Point(5, 2);
            this.TopView.Name = "TopView";
            this.TopView.Padding = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.TopView.ShadowDecoration.BorderRadius = 15;
            this.TopView.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.TopView.ShadowDecoration.Depth = 15;
            this.TopView.Size = new System.Drawing.Size(1081, 49);
            this.TopView.TabIndex = 6;
            this.TopView.UseTransparentBackground = true;
            this.TopView.Click += new System.EventHandler(this.MainView_Click);
            // 
            // EmployeeAttendanceLogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.TopView);
            this.Controls.Add(this.MainView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EmployeeAttendanceLogView";
            this.Padding = new System.Windows.Forms.Padding(5, 2, 5, 3);
            this.Size = new System.Drawing.Size(1091, 54);
            this.MainView.ResumeLayout(false);
            this.ColumnHeader.ResumeLayout(false);
            this.ColumnHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).EndInit();
            this.TopView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MainView;
        private System.Windows.Forms.TableLayoutPanel ColumnHeader;
        private System.Windows.Forms.Label AfternoonOutLabel;
        private System.Windows.Forms.Label AfternoonInLabel;
        private System.Windows.Forms.Label MorningOutLabel;
        private System.Windows.Forms.Label MorningInLabel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox EmployeePic;
        private System.Windows.Forms.Label Fullname;
        private Guna.UI2.WinForms.Guna2Panel TopView;
        private System.Windows.Forms.Label LeaveLabel;
        private System.Windows.Forms.Label AttendanceType;
    }
}
