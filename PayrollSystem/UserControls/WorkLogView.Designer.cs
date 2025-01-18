namespace PayrollSystem.UserControls
{
    partial class WorkLogView
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
            this.Fullname = new System.Windows.Forms.Label();
            this.MainView = new Guna.UI2.WinForms.Guna2Panel();
            this.AbsentCount = new System.Windows.Forms.Label();
            this.PresentCount = new System.Windows.Forms.Label();
            this.EmployeePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.MainView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fullname
            // 
            this.Fullname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fullname.AutoSize = true;
            this.Fullname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Fullname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fullname.Location = new System.Drawing.Point(66, 8);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(107, 15);
            this.Fullname.TabIndex = 6;
            this.Fullname.Text = "Jed Angelo M. Tan";
            this.Fullname.Click += new System.EventHandler(this.MainView_Click);
            // 
            // MainView
            // 
            this.MainView.BackColor = System.Drawing.Color.Transparent;
            this.MainView.BorderColor = System.Drawing.Color.SlateGray;
            this.MainView.BorderRadius = 10;
            this.MainView.BorderThickness = 1;
            this.MainView.Controls.Add(this.guna2Panel2);
            this.MainView.Controls.Add(this.Fullname);
            this.MainView.Controls.Add(this.EmployeePic);
            this.MainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainView.FillColor = System.Drawing.Color.White;
            this.MainView.Location = new System.Drawing.Point(5, 3);
            this.MainView.Name = "MainView";
            this.MainView.ShadowDecoration.BorderRadius = 15;
            this.MainView.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.MainView.ShadowDecoration.Depth = 15;
            this.MainView.Size = new System.Drawing.Size(330, 60);
            this.MainView.TabIndex = 2;
            this.MainView.UseTransparentBackground = true;
            this.MainView.Click += new System.EventHandler(this.MainView_Click);
            // 
            // AbsentCount
            // 
            this.AbsentCount.BackColor = System.Drawing.Color.Transparent;
            this.AbsentCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.AbsentCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbsentCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsentCount.ForeColor = System.Drawing.Color.White;
            this.AbsentCount.Image = global::PayrollSystem.Properties.Resources.circle_fill_1_;
            this.AbsentCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AbsentCount.Location = new System.Drawing.Point(0, 0);
            this.AbsentCount.Margin = new System.Windows.Forms.Padding(0);
            this.AbsentCount.Name = "AbsentCount";
            this.AbsentCount.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.AbsentCount.Size = new System.Drawing.Size(111, 23);
            this.AbsentCount.TabIndex = 8;
            this.AbsentCount.Text = "     0 Absents";
            this.AbsentCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AbsentCount.Click += new System.EventHandler(this.MainView_Click);
            // 
            // PresentCount
            // 
            this.PresentCount.BackColor = System.Drawing.Color.Transparent;
            this.PresentCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.PresentCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PresentCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentCount.ForeColor = System.Drawing.Color.White;
            this.PresentCount.Image = global::PayrollSystem.Properties.Resources.circle_fill;
            this.PresentCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PresentCount.Location = new System.Drawing.Point(121, 0);
            this.PresentCount.Margin = new System.Windows.Forms.Padding(0);
            this.PresentCount.Name = "PresentCount";
            this.PresentCount.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.PresentCount.Size = new System.Drawing.Size(107, 23);
            this.PresentCount.TabIndex = 7;
            this.PresentCount.Text = "     0 Presents";
            this.PresentCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PresentCount.Click += new System.EventHandler(this.MainView_Click);
            // 
            // EmployeePic
            // 
            this.EmployeePic.BackColor = System.Drawing.Color.Transparent;
            this.EmployeePic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeePic.Image = global::PayrollSystem.Properties.Resources.account_circle_fill;
            this.EmployeePic.ImageRotate = 0F;
            this.EmployeePic.Location = new System.Drawing.Point(9, 9);
            this.EmployeePic.Name = "EmployeePic";
            this.EmployeePic.ShadowDecoration.BorderRadius = 11;
            this.EmployeePic.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.EmployeePic.ShadowDecoration.Depth = 15;
            this.EmployeePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EmployeePic.Size = new System.Drawing.Size(40, 40);
            this.EmployeePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmployeePic.TabIndex = 5;
            this.EmployeePic.TabStop = false;
            this.EmployeePic.UseTransparentBackground = true;
            this.EmployeePic.Click += new System.EventHandler(this.MainView_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.Controls.Add(this.PresentCount);
            this.guna2Panel2.Controls.Add(this.guna2VSeparator1);
            this.guna2Panel2.Controls.Add(this.AbsentCount);
            this.guna2Panel2.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Panel2.Location = new System.Drawing.Point(67, 29);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(228, 23);
            this.guna2Panel2.TabIndex = 11;
            this.guna2Panel2.Click += new System.EventHandler(this.MainView_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.White;
            this.guna2VSeparator1.Location = new System.Drawing.Point(111, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 23);
            this.guna2VSeparator1.TabIndex = 12;
            this.guna2VSeparator1.UseTransparentBackground = true;
            this.guna2VSeparator1.Click += new System.EventHandler(this.MainView_Click);
            // 
            // WorkLogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.MainView);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WorkLogView";
            this.Padding = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.Size = new System.Drawing.Size(340, 65);
            this.MainView.ResumeLayout(false);
            this.MainView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox EmployeePic;
        private System.Windows.Forms.Label Fullname;
        private Guna.UI2.WinForms.Guna2Panel MainView;
        private System.Windows.Forms.Label AbsentCount;
        private System.Windows.Forms.Label PresentCount;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
    }
}
