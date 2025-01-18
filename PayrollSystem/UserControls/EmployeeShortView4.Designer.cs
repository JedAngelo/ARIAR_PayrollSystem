namespace PayrollSystem.UserControls
{
    partial class EmployeeShortView4
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
            this.Fullname = new System.Windows.Forms.Label();
            this.EmployeePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.MainView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainView
            // 
            this.MainView.BackColor = System.Drawing.Color.Transparent;
            this.MainView.BorderColor = System.Drawing.Color.SlateGray;
            this.MainView.BorderRadius = 10;
            this.MainView.BorderThickness = 1;
            this.MainView.Controls.Add(this.Fullname);
            this.MainView.Controls.Add(this.EmployeePic);
            this.MainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainView.FillColor = System.Drawing.Color.White;
            this.MainView.Location = new System.Drawing.Point(5, 3);
            this.MainView.Name = "MainView";
            this.MainView.ShadowDecoration.BorderRadius = 15;
            this.MainView.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.MainView.ShadowDecoration.Depth = 15;
            this.MainView.Size = new System.Drawing.Size(330, 48);
            this.MainView.TabIndex = 3;
            this.MainView.UseTransparentBackground = true;
            this.MainView.Click += new System.EventHandler(this.MainView_Click);
            // 
            // Fullname
            // 
            this.Fullname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fullname.AutoSize = true;
            this.Fullname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Fullname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fullname.Location = new System.Drawing.Point(65, 15);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(123, 17);
            this.Fullname.TabIndex = 6;
            this.Fullname.Text = "Jed Angelo M. Tan";
            // 
            // EmployeePic
            // 
            this.EmployeePic.BackColor = System.Drawing.Color.Transparent;
            this.EmployeePic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeePic.Image = global::PayrollSystem.Properties.Resources.account_circle_fill1;
            this.EmployeePic.ImageRotate = 0F;
            this.EmployeePic.Location = new System.Drawing.Point(15, 6);
            this.EmployeePic.Name = "EmployeePic";
            this.EmployeePic.ShadowDecoration.BorderRadius = 11;
            this.EmployeePic.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.EmployeePic.ShadowDecoration.Depth = 15;
            this.EmployeePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EmployeePic.Size = new System.Drawing.Size(35, 35);
            this.EmployeePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmployeePic.TabIndex = 5;
            this.EmployeePic.TabStop = false;
            this.EmployeePic.UseTransparentBackground = true;
            // 
            // EmployeeShortView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.MainView);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EmployeeShortView";
            this.Padding = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.Size = new System.Drawing.Size(340, 53);
            this.MainView.ResumeLayout(false);
            this.MainView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MainView;
        private System.Windows.Forms.Label Fullname;
        private Guna.UI2.WinForms.Guna2CirclePictureBox EmployeePic;
    }
}
