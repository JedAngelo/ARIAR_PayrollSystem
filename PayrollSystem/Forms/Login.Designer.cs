namespace PayrollSystem.Forms
{
    partial class Login
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Transition = new Guna.UI2.WinForms.Guna2Transition();
            this.LoginPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.AttendanceButton = new Guna.UI2.WinForms.Guna2Button();
            this.ProgressCircle = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.LoginMessage = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LogoPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Transition
            // 
            this.Transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.Transition.DefaultAnimation = animation1;
            this.Transition.TimeStep = 0.075F;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanel.BorderRadius = 5;
            this.LoginPanel.Controls.Add(this.AttendanceButton);
            this.LoginPanel.Controls.Add(this.ProgressCircle);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.guna2ImageButton1);
            this.LoginPanel.Controls.Add(this.PasswordTextBox);
            this.LoginPanel.Controls.Add(this.UsernameTextBox);
            this.Transition.SetDecoration(this.LoginPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LoginPanel.FillColor = System.Drawing.SystemColors.Control;
            this.LoginPanel.Location = new System.Drawing.Point(501, 12);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(10);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.ShadowDecoration.BorderRadius = 8;
            this.LoginPanel.ShadowDecoration.Depth = 25;
            this.LoginPanel.ShadowDecoration.Enabled = true;
            this.LoginPanel.Size = new System.Drawing.Size(271, 437);
            this.LoginPanel.TabIndex = 3;
            this.LoginPanel.UseTransparentBackground = true;
            // 
            // AttendanceButton
            // 
            this.AttendanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttendanceButton.BackColor = System.Drawing.Color.Transparent;
            this.AttendanceButton.BorderRadius = 5;
            this.Transition.SetDecoration(this.AttendanceButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.AttendanceButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AttendanceButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AttendanceButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AttendanceButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AttendanceButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.AttendanceButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceButton.ForeColor = System.Drawing.Color.White;
            this.AttendanceButton.Location = new System.Drawing.Point(61, 377);
            this.AttendanceButton.Margin = new System.Windows.Forms.Padding(2);
            this.AttendanceButton.Name = "AttendanceButton";
            this.AttendanceButton.Size = new System.Drawing.Size(148, 36);
            this.AttendanceButton.TabIndex = 15;
            this.AttendanceButton.Text = "Attendance Only";
            this.AttendanceButton.UseTransparentBackground = true;
            this.AttendanceButton.Click += new System.EventHandler(this.AttendanceButton_Click);
            // 
            // ProgressCircle
            // 
            this.ProgressCircle.AutoStart = true;
            this.Transition.SetDecoration(this.ProgressCircle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ProgressCircle.Location = new System.Drawing.Point(29, 323);
            this.ProgressCircle.Name = "ProgressCircle";
            this.ProgressCircle.ProgressColor = System.Drawing.Color.LightSeaGreen;
            this.ProgressCircle.Size = new System.Drawing.Size(25, 25);
            this.ProgressCircle.TabIndex = 14;
            this.ProgressCircle.UseTransparentBackground = true;
            this.ProgressCircle.Visible = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BorderRadius = 5;
            this.Transition.SetDecoration(this.LoginButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(61, 318);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(148, 36);
            this.LoginButton.TabIndex = 12;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseTransparentBackground = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 100;
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.LogoPicture;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // LoginMessage
            // 
            this.LoginMessage.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.LoginMessage.Caption = null;
            this.LoginMessage.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.LoginMessage.Parent = null;
            this.LoginMessage.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.LoginMessage.Text = null;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.AnimatedGIF = true;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Transition.SetDecoration(this.guna2ImageButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Image = global::PayrollSystem.Properties.Resources.exit_logo_big;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(235, 3);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Size = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.TabIndex = 11;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTextBox.BorderRadius = 5;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.PasswordTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.IconLeft = global::PayrollSystem.Properties.Resources.lock_2_line;
            this.PasswordTextBox.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.PasswordTextBox.Location = new System.Drawing.Point(20, 202);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.ShadowDecoration.BorderRadius = 11;
            this.PasswordTextBox.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.PasswordTextBox.ShadowDecoration.Depth = 15;
            this.PasswordTextBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.PasswordTextBox.Size = new System.Drawing.Size(231, 42);
            this.PasswordTextBox.TabIndex = 9;
            this.PasswordTextBox.TextOffset = new System.Drawing.Point(5, 0);
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.UsernameTextBox.BorderRadius = 5;
            this.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.UsernameTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.UsernameTextBox.DefaultText = "";
            this.UsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UsernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextBox.IconLeft = global::PayrollSystem.Properties.Resources.user_line;
            this.UsernameTextBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.UsernameTextBox.Location = new System.Drawing.Point(20, 137);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PasswordChar = '\0';
            this.UsernameTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.UsernameTextBox.PlaceholderText = "Username";
            this.UsernameTextBox.SelectedText = "";
            this.UsernameTextBox.ShadowDecoration.BorderRadius = 11;
            this.UsernameTextBox.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.UsernameTextBox.ShadowDecoration.Depth = 15;
            this.UsernameTextBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.UsernameTextBox.Size = new System.Drawing.Size(231, 42);
            this.UsernameTextBox.TabIndex = 7;
            this.UsernameTextBox.TextOffset = new System.Drawing.Point(5, 0);
            this.UsernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Transition.SetDecoration(this.LogoPicture, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LogoPicture.Image = global::PayrollSystem.Properties.Resources.PAYROLL_SYSTEM_1_1;
            this.LogoPicture.ImageRotate = 0F;
            this.LogoPicture.Location = new System.Drawing.Point(0, 0);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(780, 460);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 2;
            this.LogoPicture.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(56)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(780, 460);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.LogoPicture);
            this.Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(780, 460);
            this.MinimumSize = new System.Drawing.Size(780, 460);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.LoginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Transition Transition;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2MessageDialog LoginMessage;
        private Guna.UI2.WinForms.Guna2PictureBox LogoPicture;
        private Guna.UI2.WinForms.Guna2Panel LoginPanel;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTextBox;
        private Guna.UI2.WinForms.Guna2ProgressIndicator ProgressCircle;
        private Guna.UI2.WinForms.Guna2Button AttendanceButton;
    }
}