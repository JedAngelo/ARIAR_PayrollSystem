namespace ARIAR_PayrollSystem.UserControls
{
    partial class FingerprintListView
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
            this.LabelPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.MainView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).BeginInit();
            this.LabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainView
            // 
            this.MainView.BackColor = System.Drawing.Color.Transparent;
            this.MainView.BorderColor = System.Drawing.Color.SlateGray;
            this.MainView.BorderRadius = 10;
            this.MainView.BorderThickness = 1;
            this.MainView.Controls.Add(this.LabelPanel);
            this.MainView.Controls.Add(this.Fullname);
            this.MainView.Controls.Add(this.EmployeePic);
            this.MainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainView.FillColor = System.Drawing.Color.White;
            this.MainView.Location = new System.Drawing.Point(5, 3);
            this.MainView.Name = "MainView";
            this.MainView.ShadowDecoration.BorderRadius = 15;
            this.MainView.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.MainView.ShadowDecoration.Depth = 15;
            this.MainView.Size = new System.Drawing.Size(344, 52);
            this.MainView.TabIndex = 4;
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
            this.Fullname.Location = new System.Drawing.Point(61, 17);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(123, 17);
            this.Fullname.TabIndex = 6;
            this.Fullname.Text = "Jed Angelo M. Tan";
            this.Fullname.Click += new System.EventHandler(this.MainView_Click);
            // 
            // EmployeePic
            // 
            this.EmployeePic.BackColor = System.Drawing.Color.Transparent;
            this.EmployeePic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeePic.Image = global::ARIAR_PayrollSystem.Properties.Resources.account_circle_fill1;
            this.EmployeePic.ImageRotate = 0F;
            this.EmployeePic.Location = new System.Drawing.Point(15, 9);
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
            this.EmployeePic.Click += new System.EventHandler(this.MainView_Click);
            // 
            // LabelPanel
            // 
            this.LabelPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelPanel.BackColor = System.Drawing.Color.Transparent;
            this.LabelPanel.BorderRadius = 9;
            this.LabelPanel.Controls.Add(this.label3);
            this.LabelPanel.FillColor = System.Drawing.Color.IndianRed;
            this.LabelPanel.Location = new System.Drawing.Point(232, 16);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(100, 20);
            this.LabelPanel.TabIndex = 25;
            this.LabelPanel.UseTransparentBackground = true;
            this.LabelPanel.Click += new System.EventHandler(this.MainView_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "UNREGISTERED";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FingerprintListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.MainView);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FingerprintListView";
            this.Padding = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.Size = new System.Drawing.Size(354, 57);
            this.MainView.ResumeLayout(false);
            this.MainView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).EndInit();
            this.LabelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MainView;
        private System.Windows.Forms.Label Fullname;
        private Guna.UI2.WinForms.Guna2CirclePictureBox EmployeePic;
        private Guna.UI2.WinForms.Guna2Panel LabelPanel;
        private System.Windows.Forms.Label label3;
    }
}
