namespace ARIAR_PayrollSystem.Forms.Modals
{
    partial class EmployeeCanvasModal
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeCanvasModal));
            this.MainViewPanel = new System.Windows.Forms.Panel();
            this.thirdStep = new Guna.UI2.WinForms.Guna2Panel();
            this.thirdStepLabel = new System.Windows.Forms.Label();
            this.secondStep = new Guna.UI2.WinForms.Guna2Panel();
            this.secondStepLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.firstStep = new Guna.UI2.WinForms.Guna2Panel();
            this.firstStepLabel = new System.Windows.Forms.Label();
            this.progressLine = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.nextTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.prevTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.borderlessFormAnimation = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.thirdStep.SuspendLayout();
            this.secondStep.SuspendLayout();
            this.panel1.SuspendLayout();
            this.firstStep.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainViewPanel
            // 
            this.prevTransition.SetDecoration(this.MainViewPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nextTransition.SetDecoration(this.MainViewPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MainViewPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainViewPanel.Location = new System.Drawing.Point(0, 56);
            this.MainViewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainViewPanel.Name = "MainViewPanel";
            this.MainViewPanel.Size = new System.Drawing.Size(772, 410);
            this.MainViewPanel.TabIndex = 1;
            // 
            // thirdStep
            // 
            this.thirdStep.BackColor = System.Drawing.Color.Transparent;
            this.thirdStep.BorderRadius = 15;
            this.thirdStep.Controls.Add(this.thirdStepLabel);
            this.prevTransition.SetDecoration(this.thirdStep, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nextTransition.SetDecoration(this.thirdStep, Guna.UI2.AnimatorNS.DecorationType.None);
            this.thirdStep.FillColor = System.Drawing.Color.White;
            this.thirdStep.Location = new System.Drawing.Point(730, 13);
            this.thirdStep.Name = "thirdStep";
            this.thirdStep.Size = new System.Drawing.Size(30, 30);
            this.thirdStep.TabIndex = 5;
            this.thirdStep.UseTransparentBackground = true;
            // 
            // thirdStepLabel
            // 
            this.thirdStepLabel.BackColor = System.Drawing.Color.Transparent;
            this.nextTransition.SetDecoration(this.thirdStepLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.prevTransition.SetDecoration(this.thirdStepLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.thirdStepLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdStepLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdStepLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.thirdStepLabel.Location = new System.Drawing.Point(0, 0);
            this.thirdStepLabel.Name = "thirdStepLabel";
            this.thirdStepLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.thirdStepLabel.Size = new System.Drawing.Size(30, 30);
            this.thirdStepLabel.TabIndex = 0;
            this.thirdStepLabel.Text = "3";
            this.thirdStepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondStep
            // 
            this.secondStep.BackColor = System.Drawing.Color.Transparent;
            this.secondStep.BorderRadius = 15;
            this.secondStep.Controls.Add(this.secondStepLabel);
            this.prevTransition.SetDecoration(this.secondStep, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nextTransition.SetDecoration(this.secondStep, Guna.UI2.AnimatorNS.DecorationType.None);
            this.secondStep.FillColor = System.Drawing.Color.White;
            this.secondStep.Location = new System.Drawing.Point(371, 13);
            this.secondStep.Name = "secondStep";
            this.secondStep.Size = new System.Drawing.Size(30, 30);
            this.secondStep.TabIndex = 6;
            this.secondStep.UseTransparentBackground = true;
            // 
            // secondStepLabel
            // 
            this.secondStepLabel.BackColor = System.Drawing.Color.Transparent;
            this.nextTransition.SetDecoration(this.secondStepLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.prevTransition.SetDecoration(this.secondStepLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.secondStepLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondStepLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondStepLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.secondStepLabel.Location = new System.Drawing.Point(0, 0);
            this.secondStepLabel.Name = "secondStepLabel";
            this.secondStepLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.secondStepLabel.Size = new System.Drawing.Size(30, 30);
            this.secondStepLabel.TabIndex = 0;
            this.secondStepLabel.Text = "2";
            this.secondStepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.secondStep);
            this.panel1.Controls.Add(this.thirdStep);
            this.panel1.Controls.Add(this.firstStep);
            this.panel1.Controls.Add(this.progressLine);
            this.prevTransition.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nextTransition.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 56);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // firstStep
            // 
            this.firstStep.BackColor = System.Drawing.Color.Transparent;
            this.firstStep.BorderRadius = 15;
            this.firstStep.Controls.Add(this.firstStepLabel);
            this.prevTransition.SetDecoration(this.firstStep, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nextTransition.SetDecoration(this.firstStep, Guna.UI2.AnimatorNS.DecorationType.None);
            this.firstStep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(1)))));
            this.firstStep.Location = new System.Drawing.Point(12, 13);
            this.firstStep.Name = "firstStep";
            this.firstStep.Size = new System.Drawing.Size(30, 30);
            this.firstStep.TabIndex = 9;
            this.firstStep.UseTransparentBackground = true;
            // 
            // firstStepLabel
            // 
            this.firstStepLabel.BackColor = System.Drawing.Color.Transparent;
            this.nextTransition.SetDecoration(this.firstStepLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.prevTransition.SetDecoration(this.firstStepLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.firstStepLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstStepLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstStepLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.firstStepLabel.Location = new System.Drawing.Point(0, 0);
            this.firstStepLabel.Name = "firstStepLabel";
            this.firstStepLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.firstStepLabel.Size = new System.Drawing.Size(30, 30);
            this.firstStepLabel.TabIndex = 0;
            this.firstStepLabel.Text = "1";
            this.firstStepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressLine
            // 
            this.prevTransition.SetDecoration(this.progressLine, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nextTransition.SetDecoration(this.progressLine, Guna.UI2.AnimatorNS.DecorationType.None);
            this.progressLine.FillColor = System.Drawing.Color.White;
            this.progressLine.Location = new System.Drawing.Point(28, 26);
            this.progressLine.Maximum = 2;
            this.progressLine.Name = "progressLine";
            this.progressLine.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(1)))));
            this.progressLine.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(1)))));
            this.progressLine.Size = new System.Drawing.Size(715, 5);
            this.progressLine.TabIndex = 0;
            this.progressLine.Text = "guna2ProgressBar1";
            this.progressLine.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressLine.ValueChanged += new System.EventHandler(this.progressLine_ValueChanged);
            // 
            // nextTransition
            // 
            this.nextTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.nextTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.nextTransition.DefaultAnimation = animation2;
            this.nextTransition.TimeStep = 0.05F;
            // 
            // prevTransition
            // 
            this.prevTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.prevTransition.Cursor = null;
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
            this.prevTransition.DefaultAnimation = animation1;
            this.prevTransition.TimeStep = 0.05F;
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
            // EmployeeCanvasModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 466);
            this.Controls.Add(this.MainViewPanel);
            this.Controls.Add(this.panel1);
            this.prevTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nextTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeCanvasModal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeRegister";
            this.Load += new System.EventHandler(this.CanvasModal_Load);
            this.thirdStep.ResumeLayout(false);
            this.secondStep.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.firstStep.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label thirdStepLabel;
        private System.Windows.Forms.Label secondStepLabel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel MainViewPanel;
        public Guna.UI2.WinForms.Guna2Panel thirdStep;
        public Guna.UI2.WinForms.Guna2Panel secondStep;
        public Guna.UI2.WinForms.Guna2Panel firstStep;
        private System.Windows.Forms.Label firstStepLabel;
        private Guna.UI2.WinForms.Guna2Transition nextTransition;
        private Guna.UI2.WinForms.Guna2Transition prevTransition;
        private Guna.UI2.WinForms.Guna2ProgressBar progressLine;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessFormAnimation;
    }
}