namespace ARIAR_PayrollSystem.Forms.Modals
{
    partial class FingerPrintEnrollment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FingerPrintEnrollment));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.fingerImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.PersonalIDTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PromptTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CaptureTimer = new System.Windows.Forms.Timer(this.components);
            this.StatusTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fingerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.guna2Panel7);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.PersonalIDTextBox);
            this.guna2Panel1.Controls.Add(this.StatusTextBox);
            this.guna2Panel1.Controls.Add(this.PromptTextBox);
            this.guna2Panel1.Controls.Add(this.StatusLabel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(911, 602);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(681, 528);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Start Capture";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2Panel7.BorderRadius = 5;
            this.guna2Panel7.BorderThickness = 1;
            this.guna2Panel7.Controls.Add(this.fingerImage);
            this.guna2Panel7.FillColor = System.Drawing.Color.White;
            this.guna2Panel7.Location = new System.Drawing.Point(98, 179);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel7.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel7.ShadowDecoration.Depth = 15;
            this.guna2Panel7.Size = new System.Drawing.Size(199, 202);
            this.guna2Panel7.TabIndex = 12;
            // 
            // fingerImage
            // 
            this.fingerImage.BackColor = System.Drawing.Color.Transparent;
            this.fingerImage.BorderRadius = 5;
            this.fingerImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fingerImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("fingerImage.ErrorImage")));
            this.fingerImage.Image = global::ARIAR_PayrollSystem.Properties.Resources.Untitled_design__1_;
            this.fingerImage.ImageRotate = 0F;
            this.fingerImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("fingerImage.InitialImage")));
            this.fingerImage.Location = new System.Drawing.Point(0, 0);
            this.fingerImage.Margin = new System.Windows.Forms.Padding(2);
            this.fingerImage.Name = "fingerImage";
            this.fingerImage.ShadowDecoration.BorderRadius = 11;
            this.fingerImage.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.fingerImage.Size = new System.Drawing.Size(199, 202);
            this.fingerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fingerImage.TabIndex = 11;
            this.fingerImage.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.CustomIconSize = 13F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(854, 13);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 4;
            // 
            // PersonalIDTextBox
            // 
            this.PersonalIDTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PersonalIDTextBox.BorderRadius = 8;
            this.PersonalIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PersonalIDTextBox.DefaultText = "";
            this.PersonalIDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PersonalIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PersonalIDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PersonalIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PersonalIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PersonalIDTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PersonalIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PersonalIDTextBox.Location = new System.Drawing.Point(423, 440);
            this.PersonalIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersonalIDTextBox.Name = "PersonalIDTextBox";
            this.PersonalIDTextBox.PasswordChar = '\0';
            this.PersonalIDTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.PersonalIDTextBox.PlaceholderText = "Personal ID";
            this.PersonalIDTextBox.SelectedText = "";
            this.PersonalIDTextBox.ShadowDecoration.BorderRadius = 11;
            this.PersonalIDTextBox.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.PersonalIDTextBox.ShadowDecoration.Depth = 15;
            this.PersonalIDTextBox.ShadowDecoration.Enabled = true;
            this.PersonalIDTextBox.Size = new System.Drawing.Size(438, 55);
            this.PersonalIDTextBox.TabIndex = 3;
            // 
            // PromptTextBox
            // 
            this.PromptTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PromptTextBox.BorderRadius = 8;
            this.PromptTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PromptTextBox.DefaultText = "";
            this.PromptTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PromptTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PromptTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PromptTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PromptTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PromptTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PromptTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PromptTextBox.Location = new System.Drawing.Point(423, 68);
            this.PromptTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PromptTextBox.Name = "PromptTextBox";
            this.PromptTextBox.PasswordChar = '\0';
            this.PromptTextBox.PlaceholderText = "";
            this.PromptTextBox.SelectedText = "";
            this.PromptTextBox.ShadowDecoration.BorderRadius = 11;
            this.PromptTextBox.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.PromptTextBox.ShadowDecoration.Depth = 15;
            this.PromptTextBox.ShadowDecoration.Enabled = true;
            this.PromptTextBox.Size = new System.Drawing.Size(438, 42);
            this.PromptTextBox.TabIndex = 1;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(24, 479);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(70, 16);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "[STATUS]";
            // 
            // CaptureTimer
            // 
            this.CaptureTimer.Interval = 1000;
            this.CaptureTimer.Tick += new System.EventHandler(this.TimerProcess_Tick);
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.AutoScroll = true;
            this.StatusTextBox.BackColor = System.Drawing.Color.Transparent;
            this.StatusTextBox.BorderRadius = 8;
            this.StatusTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StatusTextBox.DefaultText = "";
            this.StatusTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StatusTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StatusTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StatusTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StatusTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StatusTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusTextBox.Location = new System.Drawing.Point(423, 118);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatusTextBox.Multiline = true;
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.PasswordChar = '\0';
            this.StatusTextBox.PlaceholderText = "";
            this.StatusTextBox.SelectedText = "";
            this.StatusTextBox.ShadowDecoration.BorderRadius = 11;
            this.StatusTextBox.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.StatusTextBox.ShadowDecoration.Depth = 15;
            this.StatusTextBox.ShadowDecoration.Enabled = true;
            this.StatusTextBox.Size = new System.Drawing.Size(438, 314);
            this.StatusTextBox.TabIndex = 2;
            // 
            // FingerPrintEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 602);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FingerPrintEnrollment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FingerPrintEnrollment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FingerPrintEnrollment_FormClosing);
            this.Load += new System.EventHandler(this.FingerPrintEnrollment_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fingerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox PersonalIDTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PromptTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2PictureBox fingerImage;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Timer CaptureTimer;
        private Guna.UI2.WinForms.Guna2TextBox StatusTextBox;
    }
}