namespace PayrollSystem.Forms.Modals
{
    partial class AddLeaveModal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label4 = new System.Windows.Forms.Label();
            this.borderlessFormAnimation = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.EmployeeViewScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.EmployeeView = new PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StartDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.EndDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 46);
            this.panel1.TabIndex = 154;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderRadius = 5;
            this.guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox2.CustomIconSize = 13F;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(607, 6);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(31, 31);
            this.guna2ControlBox2.TabIndex = 128;
            this.guna2ControlBox2.UseTransparentBackground = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Size = new System.Drawing.Size(648, 46);
            this.label4.TabIndex = 129;
            this.label4.Text = "Set Employees Leave";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderColor = System.Drawing.Color.LightSlateGray;
            this.guna2Panel5.BorderRadius = 8;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.EmployeeViewScrollBar);
            this.guna2Panel5.Controls.Add(this.EmployeeView);
            this.guna2Panel5.Controls.Add(this.guna2Panel1);
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel5.Location = new System.Drawing.Point(27, 70);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.guna2Panel5.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel5.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel5.ShadowDecoration.Depth = 15;
            this.guna2Panel5.Size = new System.Drawing.Size(338, 478);
            this.guna2Panel5.TabIndex = 155;
            this.guna2Panel5.UseTransparentBackground = true;
            // 
            // EmployeeViewScrollBar
            // 
            this.EmployeeViewScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeViewScrollBar.BindingContainer = this.EmployeeView;
            this.EmployeeViewScrollBar.BorderRadius = 5;
            this.EmployeeViewScrollBar.FillColor = System.Drawing.Color.White;
            this.EmployeeViewScrollBar.InUpdate = false;
            this.EmployeeViewScrollBar.LargeChange = 10;
            this.EmployeeViewScrollBar.Location = new System.Drawing.Point(325, 36);
            this.EmployeeViewScrollBar.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeViewScrollBar.MaximumSize = new System.Drawing.Size(12, 0);
            this.EmployeeViewScrollBar.MinimumSize = new System.Drawing.Size(12, 0);
            this.EmployeeViewScrollBar.Name = "EmployeeViewScrollBar";
            this.EmployeeViewScrollBar.ScrollbarSize = 12;
            this.EmployeeViewScrollBar.Size = new System.Drawing.Size(12, 436);
            this.EmployeeViewScrollBar.TabIndex = 5;
            this.EmployeeViewScrollBar.ThumbColor = System.Drawing.Color.SlateGray;
            this.EmployeeViewScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // EmployeeView
            // 
            this.EmployeeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeView.AutoScroll = true;
            this.EmployeeView.BackColor = System.Drawing.Color.White;
            this.EmployeeView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EmployeeView.Location = new System.Drawing.Point(1, 36);
            this.EmployeeView.Margin = new System.Windows.Forms.Padding(1);
            this.EmployeeView.Name = "EmployeeView";
            this.EmployeeView.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.EmployeeView.Size = new System.Drawing.Size(336, 436);
            this.EmployeeView.TabIndex = 1;
            this.EmployeeView.WrapContents = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.CustomizableEdges.BottomLeft = false;
            this.guna2Panel1.CustomizableEdges.BottomRight = false;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(338, 36);
            this.guna2Panel1.TabIndex = 6;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label8.Size = new System.Drawing.Size(338, 36);
            this.label8.TabIndex = 2;
            this.label8.Text = "Empoyees";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddButton
            // 
            this.AddButton.Animated = true;
            this.AddButton.AnimatedGIF = true;
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BorderRadius = 5;
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(390, 512);
            this.AddButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(234, 36);
            this.AddButton.TabIndex = 156;
            this.AddButton.Text = "Add Leave";
            this.AddButton.UseTransparentBackground = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(397, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 162;
            this.label2.Text = "End Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(397, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 160;
            this.label5.Text = "Start Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.StartDatePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.StartDatePicker.BorderRadius = 5;
            this.StartDatePicker.BorderThickness = 1;
            this.StartDatePicker.Checked = true;
            this.StartDatePicker.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.StartDatePicker.CheckedState.FillColor = System.Drawing.Color.White;
            this.StartDatePicker.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.StartDatePicker.CustomFormat = "MMMM d, yyyy";
            this.StartDatePicker.FillColor = System.Drawing.Color.White;
            this.StartDatePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDatePicker.Location = new System.Drawing.Point(390, 205);
            this.StartDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.StartDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.StartDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(234, 42);
            this.StartDatePicker.TabIndex = 158;
            this.StartDatePicker.UseTransparentBackground = true;
            this.StartDatePicker.Value = new System.DateTime(2024, 9, 25, 14, 36, 7, 477);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.EndDatePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.EndDatePicker.BorderRadius = 5;
            this.EndDatePicker.BorderThickness = 1;
            this.EndDatePicker.Checked = true;
            this.EndDatePicker.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.EndDatePicker.CheckedState.FillColor = System.Drawing.Color.White;
            this.EndDatePicker.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EndDatePicker.CustomFormat = "MMMM d, yyyy";
            this.EndDatePicker.FillColor = System.Drawing.Color.White;
            this.EndDatePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDatePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDatePicker.Location = new System.Drawing.Point(390, 310);
            this.EndDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.EndDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.EndDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(234, 42);
            this.EndDatePicker.TabIndex = 157;
            this.EndDatePicker.UseTransparentBackground = true;
            this.EndDatePicker.Value = new System.DateTime(2024, 9, 25, 14, 36, 7, 477);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Animated = true;
            this.DeleteButton.AnimatedGIF = true;
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BorderRadius = 5;
            this.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteButton.FillColor = System.Drawing.Color.Brown;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(390, 463);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(234, 36);
            this.DeleteButton.TabIndex = 163;
            this.DeleteButton.Text = "Delete Leave";
            this.DeleteButton.UseTransparentBackground = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddLeaveModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(648, 577);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddLeaveModal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddLeaveModal";
            this.Load += new System.EventHandler(this.AddLeaveModal_Load);
            this.panel1.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessFormAnimation;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2VScrollBar EmployeeViewScrollBar;
        private UserControls.CustomFlowLayoutPanel EmployeeView;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker StartDatePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker EndDatePicker;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
    }
}