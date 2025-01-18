namespace PayrollSystem.Forms.Modals
{
    partial class SetFilterModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetFilterModal));
            this.borderlessFormAnimation = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PositionDropDown = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.PositionsFlowView = new PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.transition = new Guna.UI2.WinForms.Guna2Transition();
            this.label1 = new System.Windows.Forms.Label();
            this.ActiveDropDown = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.GendersFlowView = new PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.SexDropDown = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.label4 = new System.Windows.Forms.Label();
            this.ActiveFlowView = new PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.MaritalDropDown = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.label5 = new System.Windows.Forms.Label();
            this.MaritalFlowView = new PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.ApplyButton = new Guna.UI2.WinForms.Guna2Button();
            this.ClearAllButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.PositionDropDown.SuspendLayout();
            this.ActiveDropDown.SuspendLayout();
            this.SexDropDown.SuspendLayout();
            this.MaritalDropDown.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderlessFormAnimation
            // 
            this.borderlessFormAnimation.AnimateWindow = true;
            this.borderlessFormAnimation.AnimationInterval = 150;
            this.borderlessFormAnimation.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_POSITIVE;
            this.borderlessFormAnimation.BorderRadius = 15;
            this.borderlessFormAnimation.ContainerControl = this;
            this.borderlessFormAnimation.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessFormAnimation.DragForm = false;
            this.borderlessFormAnimation.DragStartTransparencyValue = 1D;
            this.borderlessFormAnimation.HasFormShadow = false;
            this.borderlessFormAnimation.ResizeForm = false;
            this.borderlessFormAnimation.TransparentWhileDrag = true;
            // 
            // PositionDropDown
            // 
            this.PositionDropDown.AutoScroll = true;
            this.PositionDropDown.BackColor = System.Drawing.Color.Transparent;
            this.PositionDropDown.BorderColor = System.Drawing.Color.LightSlateGray;
            this.PositionDropDown.BorderRadius = 5;
            this.PositionDropDown.BorderThickness = 1;
            this.PositionDropDown.Controls.Add(this.guna2Separator2);
            this.PositionDropDown.Controls.Add(this.label2);
            this.PositionDropDown.Controls.Add(this.PositionsFlowView);
            this.transition.SetDecoration(this.PositionDropDown, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PositionDropDown.FillColor = System.Drawing.Color.White;
            this.PositionDropDown.Location = new System.Drawing.Point(15, 52);
            this.PositionDropDown.Margin = new System.Windows.Forms.Padding(5);
            this.PositionDropDown.Name = "PositionDropDown";
            this.PositionDropDown.Padding = new System.Windows.Forms.Padding(1, 30, 1, 3);
            this.PositionDropDown.Size = new System.Drawing.Size(160, 138);
            this.PositionDropDown.TabIndex = 86;
            this.PositionDropDown.UseTransparentBackground = true;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator2.FillColor = System.Drawing.Color.SlateGray;
            this.guna2Separator2.Location = new System.Drawing.Point(0, 29);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(160, 3);
            this.guna2Separator2.TabIndex = 87;
            this.guna2Separator2.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "Positions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PositionsFlowView
            // 
            this.PositionsFlowView.AutoScroll = true;
            this.transition.SetDecoration(this.PositionsFlowView, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PositionsFlowView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionsFlowView.Location = new System.Drawing.Point(1, 30);
            this.PositionsFlowView.Margin = new System.Windows.Forms.Padding(0);
            this.PositionsFlowView.Name = "PositionsFlowView";
            this.PositionsFlowView.Size = new System.Drawing.Size(158, 105);
            this.PositionsFlowView.TabIndex = 0;
            // 
            // transition
            // 
            this.transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.transition.Cursor = null;
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
            animation1.TransparencyCoeff = 0F;
            this.transition.DefaultAnimation = animation1;
            this.transition.Interval = 1;
            this.transition.TimeStep = 0.1F;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(712, 46);
            this.label1.TabIndex = 85;
            this.label1.Text = "SET FILTERS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActiveDropDown
            // 
            this.ActiveDropDown.AutoScroll = true;
            this.ActiveDropDown.BackColor = System.Drawing.Color.Transparent;
            this.ActiveDropDown.BorderColor = System.Drawing.Color.LightSlateGray;
            this.ActiveDropDown.BorderRadius = 5;
            this.ActiveDropDown.BorderThickness = 1;
            this.ActiveDropDown.Controls.Add(this.guna2Separator1);
            this.ActiveDropDown.Controls.Add(this.label3);
            this.ActiveDropDown.Controls.Add(this.GendersFlowView);
            this.transition.SetDecoration(this.ActiveDropDown, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ActiveDropDown.FillColor = System.Drawing.Color.White;
            this.ActiveDropDown.Location = new System.Drawing.Point(185, 52);
            this.ActiveDropDown.Margin = new System.Windows.Forms.Padding(5);
            this.ActiveDropDown.Name = "ActiveDropDown";
            this.ActiveDropDown.Padding = new System.Windows.Forms.Padding(1, 30, 1, 3);
            this.ActiveDropDown.Size = new System.Drawing.Size(160, 138);
            this.ActiveDropDown.TabIndex = 88;
            this.ActiveDropDown.UseTransparentBackground = true;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.FillColor = System.Drawing.Color.SlateGray;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 29);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(160, 3);
            this.guna2Separator1.TabIndex = 10;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Gender";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GendersFlowView
            // 
            this.GendersFlowView.AutoScroll = true;
            this.transition.SetDecoration(this.GendersFlowView, Guna.UI2.AnimatorNS.DecorationType.None);
            this.GendersFlowView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GendersFlowView.Location = new System.Drawing.Point(1, 30);
            this.GendersFlowView.Margin = new System.Windows.Forms.Padding(0);
            this.GendersFlowView.Name = "GendersFlowView";
            this.GendersFlowView.Size = new System.Drawing.Size(158, 105);
            this.GendersFlowView.TabIndex = 0;
            // 
            // SexDropDown
            // 
            this.SexDropDown.AutoScroll = true;
            this.SexDropDown.BackColor = System.Drawing.Color.Transparent;
            this.SexDropDown.BorderColor = System.Drawing.Color.LightSlateGray;
            this.SexDropDown.BorderRadius = 5;
            this.SexDropDown.BorderThickness = 1;
            this.SexDropDown.Controls.Add(this.guna2Separator3);
            this.SexDropDown.Controls.Add(this.label4);
            this.SexDropDown.Controls.Add(this.ActiveFlowView);
            this.transition.SetDecoration(this.SexDropDown, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SexDropDown.FillColor = System.Drawing.Color.White;
            this.SexDropDown.Location = new System.Drawing.Point(355, 52);
            this.SexDropDown.Margin = new System.Windows.Forms.Padding(5);
            this.SexDropDown.Name = "SexDropDown";
            this.SexDropDown.Padding = new System.Windows.Forms.Padding(1, 30, 1, 3);
            this.SexDropDown.Size = new System.Drawing.Size(160, 138);
            this.SexDropDown.TabIndex = 90;
            this.SexDropDown.UseTransparentBackground = true;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator3.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.guna2Separator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator3.FillColor = System.Drawing.Color.SlateGray;
            this.guna2Separator3.Location = new System.Drawing.Point(0, 29);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(160, 3);
            this.guna2Separator3.TabIndex = 88;
            this.guna2Separator3.UseTransparentBackground = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Active";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActiveFlowView
            // 
            this.ActiveFlowView.AutoScroll = true;
            this.transition.SetDecoration(this.ActiveFlowView, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ActiveFlowView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveFlowView.Location = new System.Drawing.Point(1, 30);
            this.ActiveFlowView.Margin = new System.Windows.Forms.Padding(0);
            this.ActiveFlowView.Name = "ActiveFlowView";
            this.ActiveFlowView.Size = new System.Drawing.Size(158, 105);
            this.ActiveFlowView.TabIndex = 0;
            // 
            // MaritalDropDown
            // 
            this.MaritalDropDown.AutoScroll = true;
            this.MaritalDropDown.BackColor = System.Drawing.Color.Transparent;
            this.MaritalDropDown.BorderColor = System.Drawing.Color.LightSlateGray;
            this.MaritalDropDown.BorderRadius = 5;
            this.MaritalDropDown.BorderThickness = 1;
            this.MaritalDropDown.Controls.Add(this.guna2Separator4);
            this.MaritalDropDown.Controls.Add(this.label5);
            this.MaritalDropDown.Controls.Add(this.MaritalFlowView);
            this.transition.SetDecoration(this.MaritalDropDown, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MaritalDropDown.FillColor = System.Drawing.Color.White;
            this.MaritalDropDown.Location = new System.Drawing.Point(525, 52);
            this.MaritalDropDown.Margin = new System.Windows.Forms.Padding(5);
            this.MaritalDropDown.Name = "MaritalDropDown";
            this.MaritalDropDown.Padding = new System.Windows.Forms.Padding(1, 30, 1, 3);
            this.MaritalDropDown.Size = new System.Drawing.Size(171, 138);
            this.MaritalDropDown.TabIndex = 92;
            this.MaritalDropDown.UseTransparentBackground = true;
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator4.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.guna2Separator4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator4.FillColor = System.Drawing.Color.SlateGray;
            this.guna2Separator4.Location = new System.Drawing.Point(0, 29);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(171, 3);
            this.guna2Separator4.TabIndex = 90;
            this.guna2Separator4.UseTransparentBackground = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Marital Status";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaritalFlowView
            // 
            this.MaritalFlowView.AutoScroll = true;
            this.transition.SetDecoration(this.MaritalFlowView, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MaritalFlowView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaritalFlowView.Location = new System.Drawing.Point(1, 30);
            this.MaritalFlowView.Margin = new System.Windows.Forms.Padding(0);
            this.MaritalFlowView.Name = "MaritalFlowView";
            this.MaritalFlowView.Size = new System.Drawing.Size(169, 105);
            this.MaritalFlowView.TabIndex = 0;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Animated = true;
            this.ApplyButton.AnimatedGIF = true;
            this.ApplyButton.BackColor = System.Drawing.Color.Transparent;
            this.ApplyButton.BorderRadius = 5;
            this.transition.SetDecoration(this.ApplyButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ApplyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ApplyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ApplyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ApplyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ApplyButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.ApplyButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyButton.ForeColor = System.Drawing.Color.White;
            this.ApplyButton.Location = new System.Drawing.Point(592, 200);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(104, 28);
            this.ApplyButton.TabIndex = 94;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseTransparentBackground = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Animated = true;
            this.ClearAllButton.AnimatedGIF = true;
            this.ClearAllButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearAllButton.BorderRadius = 8;
            this.transition.SetDecoration(this.ClearAllButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ClearAllButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearAllButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearAllButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearAllButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearAllButton.FillColor = System.Drawing.Color.Transparent;
            this.ClearAllButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAllButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.ClearAllButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClearAllButton.ImageSize = new System.Drawing.Size(18, 18);
            this.ClearAllButton.Location = new System.Drawing.Point(16, 204);
            this.ClearAllButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(86, 24);
            this.ClearAllButton.TabIndex = 97;
            this.ClearAllButton.Text = "CLEAR ALL";
            this.ClearAllButton.UseTransparentBackground = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.label1);
            this.transition.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 46);
            this.panel1.TabIndex = 154;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderRadius = 5;
            this.guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox2.CustomIconSize = 13F;
            this.transition.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(671, 6);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(31, 31);
            this.guna2ControlBox2.TabIndex = 128;
            this.guna2ControlBox2.UseTransparentBackground = true;
            // 
            // SetFilterModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 239);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.MaritalDropDown);
            this.Controls.Add(this.SexDropDown);
            this.Controls.Add(this.ActiveDropDown);
            this.Controls.Add(this.PositionDropDown);
            this.transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetFilterModal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SetFilterModal";
            this.Load += new System.EventHandler(this.SetFilterModal_Load);
            this.PositionDropDown.ResumeLayout(false);
            this.ActiveDropDown.ResumeLayout(false);
            this.SexDropDown.ResumeLayout(false);
            this.MaritalDropDown.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessFormAnimation;
        private Guna.UI2.WinForms.Guna2Panel PositionDropDown;
        private UserControls.CustomFlowLayoutPanel PositionsFlowView;
        private Guna.UI2.WinForms.Guna2Transition transition;
        private Guna.UI2.WinForms.Guna2Panel ActiveDropDown;
        private UserControls.CustomFlowLayoutPanel GendersFlowView;
        private Guna.UI2.WinForms.Guna2Panel SexDropDown;
        private UserControls.CustomFlowLayoutPanel ActiveFlowView;
        private Guna.UI2.WinForms.Guna2Panel MaritalDropDown;
        private UserControls.CustomFlowLayoutPanel MaritalFlowView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Button ApplyButton;
        private Guna.UI2.WinForms.Guna2Button ClearAllButton;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}