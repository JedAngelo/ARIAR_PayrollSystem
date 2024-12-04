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
            Guna.UI2.AnimatorNS.Animation animation8 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation7 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeCanvasModal));
            this.MainViewPanel = new System.Windows.Forms.Panel();
            this.thirdStep = new Guna.UI2.WinForms.Guna2Panel();
            this.thirdStepLabel = new System.Windows.Forms.Label();
            this.secondStep = new Guna.UI2.WinForms.Guna2Panel();
            this.secondStepLabel = new System.Windows.Forms.Label();
            this.secondToThird = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.firstStep = new Guna.UI2.WinForms.Guna2Panel();
            this.firstStepLabel = new System.Windows.Forms.Label();
            this.firstToSecond = new Guna.UI2.WinForms.Guna2Separator();
            this.nextTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.prevTransition = new Guna.UI2.WinForms.Guna2Transition();
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
            this.thirdStep.Location = new System.Drawing.Point(730, 12);
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
            this.thirdStepLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
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
            this.secondStep.Location = new System.Drawing.Point(368, 12);
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
            this.secondStepLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.secondStepLabel.Location = new System.Drawing.Point(0, 0);
            this.secondStepLabel.Name = "secondStepLabel";
            this.secondStepLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.secondStepLabel.Size = new System.Drawing.Size(30, 30);
            this.secondStepLabel.TabIndex = 0;
            this.secondStepLabel.Text = "2";
            this.secondStepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondToThird
            // 
            this.secondToThird.BackColor = System.Drawing.Color.Transparent;
            this.nextTransition.SetDecoration(this.secondToThird, Guna.UI2.AnimatorNS.DecorationType.None);
            this.prevTransition.SetDecoration(this.secondToThird, Guna.UI2.AnimatorNS.DecorationType.None);
            this.secondToThird.FillColor = System.Drawing.Color.White;
            this.secondToThird.FillThickness = 2;
            this.secondToThird.Location = new System.Drawing.Point(395, 21);
            this.secondToThird.Name = "secondToThird";
            this.secondToThird.Size = new System.Drawing.Size(343, 10);
            this.secondToThird.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.firstStep);
            this.panel1.Controls.Add(this.thirdStep);
            this.panel1.Controls.Add(this.secondStep);
            this.panel1.Controls.Add(this.secondToThird);
            this.panel1.Controls.Add(this.firstToSecond);
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
            this.firstStep.FillColor = System.Drawing.Color.LightSeaGreen;
            this.firstStep.Location = new System.Drawing.Point(12, 12);
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
            this.firstStepLabel.ForeColor = System.Drawing.Color.White;
            this.firstStepLabel.Location = new System.Drawing.Point(0, 0);
            this.firstStepLabel.Name = "firstStepLabel";
            this.firstStepLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.firstStepLabel.Size = new System.Drawing.Size(30, 30);
            this.firstStepLabel.TabIndex = 0;
            this.firstStepLabel.Text = "1";
            this.firstStepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstToSecond
            // 
            this.firstToSecond.BackColor = System.Drawing.Color.Transparent;
            this.nextTransition.SetDecoration(this.firstToSecond, Guna.UI2.AnimatorNS.DecorationType.None);
            this.prevTransition.SetDecoration(this.firstToSecond, Guna.UI2.AnimatorNS.DecorationType.None);
            this.firstToSecond.FillColor = System.Drawing.Color.White;
            this.firstToSecond.FillThickness = 2;
            this.firstToSecond.Location = new System.Drawing.Point(33, 21);
            this.firstToSecond.Name = "firstToSecond";
            this.firstToSecond.Size = new System.Drawing.Size(345, 10);
            this.firstToSecond.TabIndex = 10;
            // 
            // nextTransition
            // 
            this.nextTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.nextTransition.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.nextTransition.DefaultAnimation = animation8;
            this.nextTransition.TimeStep = 0.05F;
            // 
            // prevTransition
            // 
            this.prevTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.prevTransition.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.prevTransition.DefaultAnimation = animation7;
            this.prevTransition.TimeStep = 0.05F;
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
        public Guna.UI2.WinForms.Guna2Separator secondToThird;
        public Guna.UI2.WinForms.Guna2Panel firstStep;
        private System.Windows.Forms.Label firstStepLabel;
        public Guna.UI2.WinForms.Guna2Separator firstToSecond;
        private Guna.UI2.WinForms.Guna2Transition nextTransition;
        private Guna.UI2.WinForms.Guna2Transition prevTransition;
    }
}