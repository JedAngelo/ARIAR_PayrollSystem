namespace ARIAR_PayrollSystem.UserControls
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
            this.MainView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).BeginInit();
            this.SuspendLayout();
            // 
            // Fullname
            // 
            this.Fullname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fullname.AutoSize = true;
            this.Fullname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Fullname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fullname.Location = new System.Drawing.Point(66, 20);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(123, 17);
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
            this.MainView.Controls.Add(this.AbsentCount);
            this.MainView.Controls.Add(this.PresentCount);
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
            this.AbsentCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AbsentCount.BackColor = System.Drawing.Color.Transparent;
            this.AbsentCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbsentCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AbsentCount.Image = global::ARIAR_PayrollSystem.Properties.Resources.circle_fill_1_;
            this.AbsentCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AbsentCount.Location = new System.Drawing.Point(279, 30);
            this.AbsentCount.Margin = new System.Windows.Forms.Padding(0);
            this.AbsentCount.Name = "AbsentCount";
            this.AbsentCount.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.AbsentCount.Size = new System.Drawing.Size(44, 17);
            this.AbsentCount.TabIndex = 8;
            this.AbsentCount.Text = "     0";
            this.AbsentCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PresentCount
            // 
            this.PresentCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PresentCount.BackColor = System.Drawing.Color.Transparent;
            this.PresentCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PresentCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PresentCount.Image = global::ARIAR_PayrollSystem.Properties.Resources.circle_fill;
            this.PresentCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PresentCount.Location = new System.Drawing.Point(279, 13);
            this.PresentCount.Margin = new System.Windows.Forms.Padding(0);
            this.PresentCount.Name = "PresentCount";
            this.PresentCount.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.PresentCount.Size = new System.Drawing.Size(44, 17);
            this.PresentCount.TabIndex = 7;
            this.PresentCount.Text = "     0";
            this.PresentCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmployeePic
            // 
            this.EmployeePic.BackColor = System.Drawing.Color.Transparent;
            this.EmployeePic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeePic.Image = global::ARIAR_PayrollSystem.Properties.Resources.account_circle_fill1;
            this.EmployeePic.ImageRotate = 0F;
            this.EmployeePic.Location = new System.Drawing.Point(14, 9);
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
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox EmployeePic;
        private System.Windows.Forms.Label Fullname;
        private Guna.UI2.WinForms.Guna2Panel MainView;
        private System.Windows.Forms.Label AbsentCount;
        private System.Windows.Forms.Label PresentCount;
    }
}
