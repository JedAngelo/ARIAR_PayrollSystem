namespace ARIAR_PayrollSystem.Forms
{
    partial class PayrollCalclulation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.EmployeeViewScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.EmployeeTableView = new ARIAR_PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.ProgressCircle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 704);
            this.panel1.TabIndex = 0;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderRadius = 8;
            this.guna2Panel5.Controls.Add(this.EmployeeViewScrollBar);
            this.guna2Panel5.Controls.Add(this.guna2Button1);
            this.guna2Panel5.Controls.Add(this.guna2Separator1);
            this.guna2Panel5.Controls.Add(this.ProgressCircle);
            this.guna2Panel5.Controls.Add(this.LoadingLabel);
            this.guna2Panel5.Controls.Add(this.EmployeeTableView);
            this.guna2Panel5.Controls.Add(this.label5);
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel5.Location = new System.Drawing.Point(45, 201);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel5.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel5.ShadowDecoration.Depth = 15;
            this.guna2Panel5.ShadowDecoration.Enabled = true;
            this.guna2Panel5.Size = new System.Drawing.Size(974, 456);
            this.guna2Panel5.TabIndex = 17;
            this.guna2Panel5.UseTransparentBackground = true;
            // 
            // EmployeeViewScrollBar
            // 
            this.EmployeeViewScrollBar.BindingContainer = this.EmployeeTableView;
            this.EmployeeViewScrollBar.BorderRadius = 3;
            this.EmployeeViewScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmployeeViewScrollBar.FillColor = System.Drawing.Color.White;
            this.EmployeeViewScrollBar.InUpdate = false;
            this.EmployeeViewScrollBar.LargeChange = 10;
            this.EmployeeViewScrollBar.Location = new System.Drawing.Point(962, 36);
            this.EmployeeViewScrollBar.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeViewScrollBar.MaximumSize = new System.Drawing.Size(12, 0);
            this.EmployeeViewScrollBar.MinimumSize = new System.Drawing.Size(12, 0);
            this.EmployeeViewScrollBar.Name = "EmployeeViewScrollBar";
            this.EmployeeViewScrollBar.ScrollbarSize = 12;
            this.EmployeeViewScrollBar.Size = new System.Drawing.Size(12, 420);
            this.EmployeeViewScrollBar.TabIndex = 5;
            this.EmployeeViewScrollBar.ThumbColor = System.Drawing.Color.SlateGray;
            this.EmployeeViewScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // EmployeeTableView
            // 
            this.EmployeeTableView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeTableView.AutoScroll = true;
            this.EmployeeTableView.BackColor = System.Drawing.Color.White;
            this.EmployeeTableView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EmployeeTableView.Location = new System.Drawing.Point(0, 36);
            this.EmployeeTableView.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeTableView.Name = "EmployeeTableView";
            this.EmployeeTableView.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.EmployeeTableView.Size = new System.Drawing.Size(974, 420);
            this.EmployeeTableView.TabIndex = 1;
            this.EmployeeTableView.Visible = false;
            this.EmployeeTableView.WrapContents = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::ARIAR_PayrollSystem.Properties.Resources.refresh_line_2_;
            this.guna2Button1.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button1.Location = new System.Drawing.Point(934, 0);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(40, 35);
            this.guna2Button1.TabIndex = 4;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.SlateGray;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 30);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(974, 10);
            this.guna2Separator1.TabIndex = 2;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // ProgressCircle
            // 
            this.ProgressCircle.Animated = true;
            this.ProgressCircle.BackColor = System.Drawing.Color.Transparent;
            this.ProgressCircle.EnsureVisible = true;
            this.ProgressCircle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ProgressCircle.FillThickness = 4;
            this.ProgressCircle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProgressCircle.ForeColor = System.Drawing.Color.White;
            this.ProgressCircle.Location = new System.Drawing.Point(11, 6);
            this.ProgressCircle.Minimum = 0;
            this.ProgressCircle.Name = "ProgressCircle";
            this.ProgressCircle.ProgressColor = System.Drawing.Color.LightSeaGreen;
            this.ProgressCircle.ProgressColor2 = System.Drawing.Color.LightSeaGreen;
            this.ProgressCircle.ProgressThickness = 4;
            this.ProgressCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressCircle.Size = new System.Drawing.Size(25, 25);
            this.ProgressCircle.TabIndex = 0;
            this.ProgressCircle.Text = "guna2CircleProgressBar1";
            this.ProgressCircle.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.ProgressCircle.UseTransparentBackground = true;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LoadingLabel.Location = new System.Drawing.Point(12, -1);
            this.LoadingLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(206, 36);
            this.LoadingLabel.TabIndex = 3;
            this.LoadingLabel.Text = "Loading employee data...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(974, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "Employee";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PayrollCalclulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1062, 704);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PayrollCalclulation";
            this.Text = "PayrollCalclulation";
            this.panel1.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2VScrollBar EmployeeViewScrollBar;
        private UserControls.CustomFlowLayoutPanel EmployeeTableView;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressCircle;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.Label label5;
    }
}