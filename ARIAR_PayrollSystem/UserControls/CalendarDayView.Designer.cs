namespace ARIAR_PayrollSystem.UserControls
{
    partial class CalendarDayView
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
            this.components = new System.ComponentModel.Container();
            this.DayLabel = new System.Windows.Forms.Label();
            this.PresentCount = new System.Windows.Forms.Label();
            this.AbsentCount = new System.Windows.Forms.Label();
            this.LeaveCount = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MainView = new Guna.UI2.WinForms.Guna2Panel();
            this.MainView.SuspendLayout();
            this.SuspendLayout();
            // 
            // DayLabel
            // 
            this.DayLabel.BackColor = System.Drawing.Color.Transparent;
            this.DayLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DayLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DayLabel.Location = new System.Drawing.Point(0, 0);
            this.DayLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Padding = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.DayLabel.Size = new System.Drawing.Size(142, 33);
            this.DayLabel.TabIndex = 0;
            this.DayLabel.Text = "01";
            this.DayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.DayLabel.Click += new System.EventHandler(this.Control_Click);
            this.DayLabel.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.DayLabel.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // PresentCount
            // 
            this.PresentCount.BackColor = System.Drawing.Color.Transparent;
            this.PresentCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.PresentCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PresentCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PresentCount.Image = global::ARIAR_PayrollSystem.Properties.Resources.circle_fill;
            this.PresentCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PresentCount.Location = new System.Drawing.Point(0, 33);
            this.PresentCount.Margin = new System.Windows.Forms.Padding(0);
            this.PresentCount.Name = "PresentCount";
            this.PresentCount.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.PresentCount.Size = new System.Drawing.Size(142, 17);
            this.PresentCount.TabIndex = 1;
            this.PresentCount.Text = "     Present";
            this.PresentCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PresentCount.Click += new System.EventHandler(this.Control_Click);
            this.PresentCount.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.PresentCount.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // AbsentCount
            // 
            this.AbsentCount.BackColor = System.Drawing.Color.Transparent;
            this.AbsentCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.AbsentCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbsentCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AbsentCount.Image = global::ARIAR_PayrollSystem.Properties.Resources.circle_fill_1_;
            this.AbsentCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AbsentCount.Location = new System.Drawing.Point(0, 67);
            this.AbsentCount.Margin = new System.Windows.Forms.Padding(0);
            this.AbsentCount.Name = "AbsentCount";
            this.AbsentCount.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.AbsentCount.Size = new System.Drawing.Size(142, 17);
            this.AbsentCount.TabIndex = 2;
            this.AbsentCount.Text = "     Absent";
            this.AbsentCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AbsentCount.Click += new System.EventHandler(this.Control_Click);
            this.AbsentCount.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.AbsentCount.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // LeaveCount
            // 
            this.LeaveCount.BackColor = System.Drawing.Color.Transparent;
            this.LeaveCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeaveCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LeaveCount.Image = global::ARIAR_PayrollSystem.Properties.Resources.circle_fill_2_;
            this.LeaveCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LeaveCount.Location = new System.Drawing.Point(0, 50);
            this.LeaveCount.Margin = new System.Windows.Forms.Padding(0);
            this.LeaveCount.Name = "LeaveCount";
            this.LeaveCount.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.LeaveCount.Size = new System.Drawing.Size(142, 17);
            this.LeaveCount.TabIndex = 3;
            this.LeaveCount.Text = "     Leave";
            this.LeaveCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LeaveCount.Click += new System.EventHandler(this.Control_Click);
            this.LeaveCount.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.LeaveCount.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // MainView
            // 
            this.MainView.BackColor = System.Drawing.Color.Transparent;
            this.MainView.BorderRadius = 5;
            this.MainView.Controls.Add(this.AbsentCount);
            this.MainView.Controls.Add(this.LeaveCount);
            this.MainView.Controls.Add(this.PresentCount);
            this.MainView.Controls.Add(this.DayLabel);
            this.MainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainView.FillColor = System.Drawing.Color.White;
            this.MainView.Location = new System.Drawing.Point(2, 2);
            this.MainView.Name = "MainView";
            this.MainView.ShadowDecoration.BorderRadius = 10;
            this.MainView.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.MainView.ShadowDecoration.Depth = 15;
            this.MainView.ShadowDecoration.Enabled = true;
            this.MainView.Size = new System.Drawing.Size(142, 98);
            this.MainView.TabIndex = 10;
            this.MainView.Click += new System.EventHandler(this.Control_Click);
            this.MainView.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.MainView.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // CalendarDayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.MainView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CalendarDayView";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(146, 102);
            this.MainView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Label LeaveCount;
        private System.Windows.Forms.Label AbsentCount;
        private System.Windows.Forms.Label PresentCount;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel MainView;
    }
}
