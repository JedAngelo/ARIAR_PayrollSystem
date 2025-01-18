namespace PayrollSystem.Forms
{
    partial class ToastNotify
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
            this.IndicatorLight = new System.Windows.Forms.Panel();
            this.CaptionText = new System.Windows.Forms.Label();
            this.MessageText = new System.Windows.Forms.Label();
            this.ToastIcon = new System.Windows.Forms.PictureBox();
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.timerHide = new System.Windows.Forms.Timer(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ToastIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // IndicatorLight
            // 
            this.IndicatorLight.BackColor = System.Drawing.Color.Gold;
            this.IndicatorLight.Dock = System.Windows.Forms.DockStyle.Left;
            this.IndicatorLight.Location = new System.Drawing.Point(0, 0);
            this.IndicatorLight.Margin = new System.Windows.Forms.Padding(0);
            this.IndicatorLight.Name = "IndicatorLight";
            this.IndicatorLight.Size = new System.Drawing.Size(12, 76);
            this.IndicatorLight.TabIndex = 0;
            // 
            // CaptionText
            // 
            this.CaptionText.AutoSize = true;
            this.CaptionText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CaptionText.Location = new System.Drawing.Point(62, 10);
            this.CaptionText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CaptionText.Name = "CaptionText";
            this.CaptionText.Size = new System.Drawing.Size(121, 21);
            this.CaptionText.TabIndex = 2;
            this.CaptionText.Text = "CAPTION TEXT";
            // 
            // MessageText
            // 
            this.MessageText.AutoEllipsis = true;
            this.MessageText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.MessageText.Location = new System.Drawing.Point(63, 32);
            this.MessageText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(246, 36);
            this.MessageText.TabIndex = 3;
            this.MessageText.Text = "MESSAGE TEXT";
            // 
            // ToastIcon
            // 
            this.ToastIcon.Image = global::PayrollSystem.Properties.Resources.alert_fill;
            this.ToastIcon.Location = new System.Drawing.Point(24, 22);
            this.ToastIcon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ToastIcon.Name = "ToastIcon";
            this.ToastIcon.Size = new System.Drawing.Size(27, 30);
            this.ToastIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ToastIcon.TabIndex = 1;
            this.ToastIcon.TabStop = false;
            // 
            // timerShow
            // 
            this.timerShow.Enabled = true;
            this.timerShow.Interval = 10;
            this.timerShow.Tick += new System.EventHandler(this.timerShow_Tick);
            // 
            // timerHide
            // 
            this.timerHide.Interval = 10;
            this.timerHide.Tick += new System.EventHandler(this.timerHide_Tick);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 0;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // ToastNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 76);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.CaptionText);
            this.Controls.Add(this.ToastIcon);
            this.Controls.Add(this.IndicatorLight);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(332, 76);
            this.MinimumSize = new System.Drawing.Size(332, 76);
            this.Name = "ToastNotify";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ToastNotify";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ToastNotify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToastIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel IndicatorLight;
        private System.Windows.Forms.PictureBox ToastIcon;
        private System.Windows.Forms.Label CaptionText;
        private System.Windows.Forms.Label MessageText;
        private System.Windows.Forms.Timer timerShow;
        private System.Windows.Forms.Timer timerHide;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}