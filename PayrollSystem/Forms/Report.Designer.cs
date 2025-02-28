namespace PayrollSystem.Forms
{
    partial class Report
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DateRangePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.EndDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.StartDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Date1Box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ReportType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MainPanel.SuspendLayout();
            this.DateRangePanel.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Controls.Add(this.DateRangePanel);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.Date1Box);
            this.MainPanel.Controls.Add(this.ReportButton);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.ReportType);
            this.MainPanel.Controls.Add(this.guna2Panel5);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1040, 640);
            this.MainPanel.TabIndex = 0;
            // 
            // DateRangePanel
            // 
            this.DateRangePanel.Controls.Add(this.label3);
            this.DateRangePanel.Controls.Add(this.EndDatePicker);
            this.DateRangePanel.Controls.Add(this.StartDatePicker);
            this.DateRangePanel.Controls.Add(this.label2);
            this.DateRangePanel.Location = new System.Drawing.Point(421, 9);
            this.DateRangePanel.Name = "DateRangePanel";
            this.DateRangePanel.Size = new System.Drawing.Size(386, 62);
            this.DateRangePanel.TabIndex = 43;
            this.DateRangePanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 161;
            this.label3.Text = "Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.EndDatePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.EndDatePicker.BorderRadius = 5;
            this.EndDatePicker.BorderThickness = 1;
            this.EndDatePicker.Checked = true;
            this.EndDatePicker.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.EndDatePicker.CheckedState.FillColor = System.Drawing.Color.White;
            this.EndDatePicker.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EndDatePicker.CustomFormat = "";
            this.EndDatePicker.FillColor = System.Drawing.Color.White;
            this.EndDatePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDatePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDatePicker.Location = new System.Drawing.Point(227, 12);
            this.EndDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.EndDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.EndDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.ShadowDecoration.BorderRadius = 11;
            this.EndDatePicker.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.EndDatePicker.ShadowDecoration.Depth = 15;
            this.EndDatePicker.ShadowDecoration.Enabled = true;
            this.EndDatePicker.Size = new System.Drawing.Size(140, 36);
            this.EndDatePicker.TabIndex = 159;
            this.EndDatePicker.UseTransparentBackground = true;
            this.EndDatePicker.Value = new System.DateTime(2025, 2, 8, 0, 0, 0, 0);
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
            this.StartDatePicker.CustomFormat = "";
            this.StartDatePicker.FillColor = System.Drawing.Color.White;
            this.StartDatePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(59, 12);
            this.StartDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.StartDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.StartDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.ShadowDecoration.BorderRadius = 11;
            this.StartDatePicker.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.StartDatePicker.ShadowDecoration.Depth = 15;
            this.StartDatePicker.ShadowDecoration.Enabled = true;
            this.StartDatePicker.Size = new System.Drawing.Size(140, 36);
            this.StartDatePicker.TabIndex = 158;
            this.StartDatePicker.UseTransparentBackground = true;
            this.StartDatePicker.Value = new System.DateTime(2025, 2, 8, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(201, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 37);
            this.label2.TabIndex = 160;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(459, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Year";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Date1Box
            // 
            this.Date1Box.BackColor = System.Drawing.Color.Transparent;
            this.Date1Box.BorderRadius = 8;
            this.Date1Box.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.Date1Box.DisabledState.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.Date1Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Date1Box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Date1Box.DropDownHeight = 120;
            this.Date1Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Date1Box.FocusedColor = System.Drawing.Color.Empty;
            this.Date1Box.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Date1Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Date1Box.IntegralHeight = false;
            this.Date1Box.ItemHeight = 30;
            this.Date1Box.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date1Box.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Date1Box.ItemsAppearance.SelectedFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date1Box.Location = new System.Drawing.Point(499, 21);
            this.Date1Box.Margin = new System.Windows.Forms.Padding(0);
            this.Date1Box.Name = "Date1Box";
            this.Date1Box.ShadowDecoration.BorderRadius = 11;
            this.Date1Box.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.Date1Box.ShadowDecoration.Depth = 15;
            this.Date1Box.ShadowDecoration.Enabled = true;
            this.Date1Box.Size = new System.Drawing.Size(131, 36);
            this.Date1Box.TabIndex = 41;
            this.Date1Box.TextOffset = new System.Drawing.Point(25, 0);
            this.Date1Box.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // ReportButton
            // 
            this.ReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportButton.Animated = true;
            this.ReportButton.AnimatedGIF = true;
            this.ReportButton.BackColor = System.Drawing.Color.Transparent;
            this.ReportButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.ReportButton.BorderRadius = 8;
            this.ReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.ReportButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.Image = global::PayrollSystem.Properties.Resources.article_line_1_;
            this.ReportButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ReportButton.ImageOffset = new System.Drawing.Point(3, 0);
            this.ReportButton.ImageSize = new System.Drawing.Size(24, 24);
            this.ReportButton.Location = new System.Drawing.Point(815, 21);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(5);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.ShadowDecoration.BorderRadius = 11;
            this.ReportButton.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.ReportButton.ShadowDecoration.Depth = 11;
            this.ReportButton.ShadowDecoration.Enabled = true;
            this.ReportButton.Size = new System.Drawing.Size(201, 36);
            this.ReportButton.TabIndex = 40;
            this.ReportButton.Text = "Generate Report";
            this.ReportButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReportButton.TextOffset = new System.Drawing.Point(20, 0);
            this.ReportButton.UseTransparentBackground = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(24, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Report Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportType
            // 
            this.ReportType.BackColor = System.Drawing.Color.Transparent;
            this.ReportType.BorderRadius = 8;
            this.ReportType.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.ReportType.DisabledState.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.ReportType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ReportType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ReportType.DropDownHeight = 120;
            this.ReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReportType.FocusedColor = System.Drawing.Color.Empty;
            this.ReportType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ReportType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ReportType.IntegralHeight = false;
            this.ReportType.ItemHeight = 30;
            this.ReportType.Items.AddRange(new object[] {
            "Summary Payroll Report",
            "Annual Payroll Report"});
            this.ReportType.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportType.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ReportType.ItemsAppearance.SelectedFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportType.Location = new System.Drawing.Point(116, 21);
            this.ReportType.Margin = new System.Windows.Forms.Padding(0);
            this.ReportType.Name = "ReportType";
            this.ReportType.ShadowDecoration.BorderRadius = 11;
            this.ReportType.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.ReportType.ShadowDecoration.Depth = 15;
            this.ReportType.ShadowDecoration.Enabled = true;
            this.ReportType.Size = new System.Drawing.Size(285, 36);
            this.ReportType.StartIndex = 0;
            this.ReportType.TabIndex = 35;
            this.ReportType.TextOffset = new System.Drawing.Point(25, 0);
            this.ReportType.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.ReportType.SelectedIndexChanged += new System.EventHandler(this.ReportType_SelectedIndexChanged);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderRadius = 8;
            this.guna2Panel5.Controls.Add(this.ReportViewer);
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel5.Location = new System.Drawing.Point(24, 77);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(15);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.guna2Panel5.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel5.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel5.ShadowDecoration.Depth = 15;
            this.guna2Panel5.ShadowDecoration.Enabled = true;
            this.guna2Panel5.Size = new System.Drawing.Size(992, 539);
            this.guna2Panel5.TabIndex = 35;
            this.guna2Panel5.UseTransparentBackground = true;
            // 
            // ReportViewer
            // 
            this.ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewer.Location = new System.Drawing.Point(0, 3);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.ServerReport.BearerToken = null;
            this.ReportViewer.Size = new System.Drawing.Size(992, 533);
            this.ReportViewer.TabIndex = 34;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 11;
            this.guna2Elipse1.TargetControl = this.guna2Panel5;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.DateRangePanel.ResumeLayout(false);
            this.DateRangePanel.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox ReportType;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button ReportButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox Date1Box;
        private System.Windows.Forms.Panel DateRangePanel;
        private Guna.UI2.WinForms.Guna2DateTimePicker StartDatePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}