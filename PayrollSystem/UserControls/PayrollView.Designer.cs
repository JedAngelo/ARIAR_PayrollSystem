﻿namespace PayrollSystem.UserControls
{
    partial class PayrollView
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
            this.ParentView = new Guna.UI2.WinForms.Guna2Panel();
            this.ColumnView = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fullname = new System.Windows.Forms.Label();
            this.NetLabel = new System.Windows.Forms.Label();
            this.TotalDeductionLabel = new System.Windows.Forms.Label();
            this.AbsentLabel = new System.Windows.Forms.Label();
            this.LateLabel = new System.Windows.Forms.Label();
            this.UndertimeLabel = new System.Windows.Forms.Label();
            this.GrossLabel = new System.Windows.Forms.Label();
            this.DailyLabel = new System.Windows.Forms.Label();
            this.WorkDaysLabel = new System.Windows.Forms.Label();
            this.TopView = new Guna.UI2.WinForms.Guna2Panel();
            this.EmployeePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ParentView.SuspendLayout();
            this.ColumnView.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).BeginInit();
            this.SuspendLayout();
            // 
            // ParentView
            // 
            this.ParentView.BackColor = System.Drawing.Color.Transparent;
            this.ParentView.BorderColor = System.Drawing.Color.SlateGray;
            this.ParentView.BorderRadius = 10;
            this.ParentView.Controls.Add(this.ColumnView);
            this.ParentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentView.FillColor = System.Drawing.Color.White;
            this.ParentView.Location = new System.Drawing.Point(10, 3);
            this.ParentView.Margin = new System.Windows.Forms.Padding(0);
            this.ParentView.Name = "ParentView";
            this.ParentView.ShadowDecoration.BorderRadius = 15;
            this.ParentView.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.ParentView.ShadowDecoration.Depth = 15;
            this.ParentView.Size = new System.Drawing.Size(1236, 47);
            this.ParentView.TabIndex = 1;
            this.ParentView.UseTransparentBackground = true;
            // 
            // ColumnView
            // 
            this.ColumnView.ColumnCount = 9;
            this.ColumnView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.90223F));
            this.ColumnView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.257523F));
            this.ColumnView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.907328F));
            this.ColumnView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.73678F));
            this.ColumnView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.977006F));
            this.ColumnView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.667699F));
            this.ColumnView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.907328F));
            this.ColumnView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.907328F));
            this.ColumnView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.73678F));
            this.ColumnView.Controls.Add(this.panel1, 0, 0);
            this.ColumnView.Controls.Add(this.NetLabel, 8, 0);
            this.ColumnView.Controls.Add(this.TotalDeductionLabel, 7, 0);
            this.ColumnView.Controls.Add(this.AbsentLabel, 6, 0);
            this.ColumnView.Controls.Add(this.LateLabel, 5, 0);
            this.ColumnView.Controls.Add(this.UndertimeLabel, 4, 0);
            this.ColumnView.Controls.Add(this.GrossLabel, 3, 0);
            this.ColumnView.Controls.Add(this.DailyLabel, 2, 0);
            this.ColumnView.Controls.Add(this.WorkDaysLabel, 1, 0);
            this.ColumnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnView.Location = new System.Drawing.Point(0, 0);
            this.ColumnView.Margin = new System.Windows.Forms.Padding(0);
            this.ColumnView.Name = "ColumnView";
            this.ColumnView.RowCount = 1;
            this.ColumnView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ColumnView.Size = new System.Drawing.Size(1236, 47);
            this.ColumnView.TabIndex = 19;
            this.ColumnView.Click += new System.EventHandler(this.View_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Fullname);
            this.panel1.Controls.Add(this.EmployeePic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 41);
            this.panel1.TabIndex = 97;
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
            // 
            // NetLabel
            // 
            this.NetLabel.BackColor = System.Drawing.Color.Transparent;
            this.NetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NetLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NetLabel.Location = new System.Drawing.Point(1106, 5);
            this.NetLabel.Margin = new System.Windows.Forms.Padding(5);
            this.NetLabel.Name = "NetLabel";
            this.NetLabel.Size = new System.Drawing.Size(125, 37);
            this.NetLabel.TabIndex = 9;
            this.NetLabel.Text = "---";
            this.NetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NetLabel.Click += new System.EventHandler(this.View_Click);
            // 
            // TotalDeductionLabel
            // 
            this.TotalDeductionLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalDeductionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalDeductionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDeductionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TotalDeductionLabel.Location = new System.Drawing.Point(996, 5);
            this.TotalDeductionLabel.Margin = new System.Windows.Forms.Padding(5);
            this.TotalDeductionLabel.Name = "TotalDeductionLabel";
            this.TotalDeductionLabel.Size = new System.Drawing.Size(100, 37);
            this.TotalDeductionLabel.TabIndex = 8;
            this.TotalDeductionLabel.Text = "---";
            this.TotalDeductionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalDeductionLabel.Click += new System.EventHandler(this.View_Click);
            // 
            // AbsentLabel
            // 
            this.AbsentLabel.BackColor = System.Drawing.Color.Transparent;
            this.AbsentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AbsentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AbsentLabel.Location = new System.Drawing.Point(886, 5);
            this.AbsentLabel.Margin = new System.Windows.Forms.Padding(5);
            this.AbsentLabel.Name = "AbsentLabel";
            this.AbsentLabel.Size = new System.Drawing.Size(100, 37);
            this.AbsentLabel.TabIndex = 7;
            this.AbsentLabel.Text = "---";
            this.AbsentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AbsentLabel.Click += new System.EventHandler(this.View_Click);
            // 
            // LateLabel
            // 
            this.LateLabel.BackColor = System.Drawing.Color.Transparent;
            this.LateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LateLabel.Location = new System.Drawing.Point(792, 5);
            this.LateLabel.Margin = new System.Windows.Forms.Padding(5);
            this.LateLabel.Name = "LateLabel";
            this.LateLabel.Size = new System.Drawing.Size(84, 37);
            this.LateLabel.TabIndex = 6;
            this.LateLabel.Text = "---";
            this.LateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LateLabel.Click += new System.EventHandler(this.View_Click);
            // 
            // UndertimeLabel
            // 
            this.UndertimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.UndertimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UndertimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UndertimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.UndertimeLabel.Location = new System.Drawing.Point(669, 5);
            this.UndertimeLabel.Margin = new System.Windows.Forms.Padding(5);
            this.UndertimeLabel.Name = "UndertimeLabel";
            this.UndertimeLabel.Size = new System.Drawing.Size(113, 37);
            this.UndertimeLabel.TabIndex = 5;
            this.UndertimeLabel.Text = "---";
            this.UndertimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UndertimeLabel.Click += new System.EventHandler(this.View_Click);
            // 
            // GrossLabel
            // 
            this.GrossLabel.BackColor = System.Drawing.Color.Transparent;
            this.GrossLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrossLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrossLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GrossLabel.Location = new System.Drawing.Point(537, 5);
            this.GrossLabel.Margin = new System.Windows.Forms.Padding(5);
            this.GrossLabel.Name = "GrossLabel";
            this.GrossLabel.Size = new System.Drawing.Size(122, 37);
            this.GrossLabel.TabIndex = 4;
            this.GrossLabel.Text = "---";
            this.GrossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GrossLabel.Click += new System.EventHandler(this.View_Click);
            // 
            // DailyLabel
            // 
            this.DailyLabel.BackColor = System.Drawing.Color.Transparent;
            this.DailyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DailyLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DailyLabel.Location = new System.Drawing.Point(427, 5);
            this.DailyLabel.Margin = new System.Windows.Forms.Padding(5);
            this.DailyLabel.Name = "DailyLabel";
            this.DailyLabel.Size = new System.Drawing.Size(100, 37);
            this.DailyLabel.TabIndex = 3;
            this.DailyLabel.Text = "---";
            this.DailyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DailyLabel.Click += new System.EventHandler(this.View_Click);
            // 
            // WorkDaysLabel
            // 
            this.WorkDaysLabel.BackColor = System.Drawing.Color.Transparent;
            this.WorkDaysLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkDaysLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkDaysLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.WorkDaysLabel.Location = new System.Drawing.Point(325, 5);
            this.WorkDaysLabel.Margin = new System.Windows.Forms.Padding(5);
            this.WorkDaysLabel.Name = "WorkDaysLabel";
            this.WorkDaysLabel.Size = new System.Drawing.Size(92, 37);
            this.WorkDaysLabel.TabIndex = 2;
            this.WorkDaysLabel.Text = "---";
            this.WorkDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WorkDaysLabel.Click += new System.EventHandler(this.View_Click);
            // 
            // TopView
            // 
            this.TopView.BackColor = System.Drawing.Color.Transparent;
            this.TopView.BorderColor = System.Drawing.Color.SlateGray;
            this.TopView.BorderRadius = 10;
            this.TopView.BorderThickness = 1;
            this.TopView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopView.Location = new System.Drawing.Point(10, 3);
            this.TopView.Margin = new System.Windows.Forms.Padding(0);
            this.TopView.Name = "TopView";
            this.TopView.ShadowDecoration.BorderRadius = 15;
            this.TopView.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.TopView.ShadowDecoration.Depth = 15;
            this.TopView.Size = new System.Drawing.Size(1236, 47);
            this.TopView.TabIndex = 20;
            this.TopView.UseTransparentBackground = true;
            this.TopView.Click += new System.EventHandler(this.View_Click);
            // 
            // EmployeePic
            // 
            this.EmployeePic.BackColor = System.Drawing.Color.Transparent;
            this.EmployeePic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeePic.Image = global::PayrollSystem.Properties.Resources.account_circle_fill;
            this.EmployeePic.ImageRotate = 0F;
            this.EmployeePic.Location = new System.Drawing.Point(5, 5);
            this.EmployeePic.Name = "EmployeePic";
            this.EmployeePic.ShadowDecoration.BorderRadius = 11;
            this.EmployeePic.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.EmployeePic.ShadowDecoration.Depth = 15;
            this.EmployeePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EmployeePic.Size = new System.Drawing.Size(30, 30);
            this.EmployeePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmployeePic.TabIndex = 6;
            this.EmployeePic.TabStop = false;
            this.EmployeePic.UseTransparentBackground = true;
            // 
            // PayrollView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.TopView);
            this.Controls.Add(this.ParentView);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Name = "PayrollView";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 15, 3);
            this.Size = new System.Drawing.Size(1261, 53);
            this.ParentView.ResumeLayout(false);
            this.ColumnView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ParentView;
        private System.Windows.Forms.TableLayoutPanel ColumnView;
        private System.Windows.Forms.Label NetLabel;
        private System.Windows.Forms.Label TotalDeductionLabel;
        private System.Windows.Forms.Label AbsentLabel;
        private System.Windows.Forms.Label LateLabel;
        private System.Windows.Forms.Label UndertimeLabel;
        private System.Windows.Forms.Label GrossLabel;
        private System.Windows.Forms.Label DailyLabel;
        private System.Windows.Forms.Label WorkDaysLabel;
        private Guna.UI2.WinForms.Guna2Panel TopView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Fullname;
        private Guna.UI2.WinForms.Guna2CirclePictureBox EmployeePic;
    }
}
