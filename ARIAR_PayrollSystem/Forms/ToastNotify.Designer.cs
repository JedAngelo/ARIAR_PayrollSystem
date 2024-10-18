namespace ARIAR_PayrollSystem.Forms
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
            this.IndicatorLight = new System.Windows.Forms.Panel();
            this.IconAlert = new System.Windows.Forms.PictureBox();
            this.CaptionText = new System.Windows.Forms.Label();
            this.MessageText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // IndicatorLight
            // 
            this.IndicatorLight.BackColor = System.Drawing.Color.LimeGreen;
            this.IndicatorLight.Dock = System.Windows.Forms.DockStyle.Left;
            this.IndicatorLight.Location = new System.Drawing.Point(0, 0);
            this.IndicatorLight.Margin = new System.Windows.Forms.Padding(0);
            this.IndicatorLight.Name = "IndicatorLight";
            this.IndicatorLight.Size = new System.Drawing.Size(12, 76);
            this.IndicatorLight.TabIndex = 0;
            // 
            // IconAlert
            // 
            this.IconAlert.Image = global::ARIAR_PayrollSystem.Properties.Resources.checkbox_circle_fill__1_;
            this.IconAlert.Location = new System.Drawing.Point(24, 22);
            this.IconAlert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IconAlert.Name = "IconAlert";
            this.IconAlert.Size = new System.Drawing.Size(27, 30);
            this.IconAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconAlert.TabIndex = 1;
            this.IconAlert.TabStop = false;
            // 
            // CaptionText
            // 
            this.CaptionText.AutoSize = true;
            this.CaptionText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CaptionText.Location = new System.Drawing.Point(62, 6);
            this.CaptionText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CaptionText.Name = "CaptionText";
            this.CaptionText.Size = new System.Drawing.Size(144, 25);
            this.CaptionText.TabIndex = 2;
            this.CaptionText.Text = "CAPTION TEXT";
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.MessageText.Location = new System.Drawing.Point(63, 40);
            this.MessageText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(108, 19);
            this.MessageText.TabIndex = 3;
            this.MessageText.Text = "MESSAGE TEXT";
            // 
            // ToastNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(332, 76);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.CaptionText);
            this.Controls.Add(this.IconAlert);
            this.Controls.Add(this.IndicatorLight);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(332, 76);
            this.MinimumSize = new System.Drawing.Size(332, 76);
            this.Name = "ToastNotify";
            this.Text = "ToastNotify";
            ((System.ComponentModel.ISupportInitialize)(this.IconAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel IndicatorLight;
        private System.Windows.Forms.PictureBox IconAlert;
        private System.Windows.Forms.Label CaptionText;
        private System.Windows.Forms.Label MessageText;
    }
}