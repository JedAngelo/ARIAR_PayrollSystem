namespace PayrollSystem.UserControls
{
    partial class EmployeeView
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
            this.MainView = new Guna.UI2.WinForms.Guna2Panel();
            this.ActionsOptions = new Guna.UI2.WinForms.Guna2Panel();
            this.FingerprintButton = new Guna.UI2.WinForms.Guna2Button();
            this.ExportButton = new Guna.UI2.WinForms.Guna2Button();
            this.EditButton = new Guna.UI2.WinForms.Guna2Button();
            this.ViewButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.hideActionButton = new Guna.UI2.WinForms.Guna2Button();
            this.ColumnHeader = new System.Windows.Forms.TableLayoutPanel();
            this.ActiveChip = new Guna.UI2.WinForms.Guna2Panel();
            this.ActiveLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Fullname = new System.Windows.Forms.Label();
            this.ActionsButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MainView.SuspendLayout();
            this.ActionsOptions.SuspendLayout();
            this.ColumnHeader.SuspendLayout();
            this.ActiveChip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainView
            // 
            this.MainView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainView.BackColor = System.Drawing.Color.Transparent;
            this.MainView.BorderColor = System.Drawing.Color.SlateGray;
            this.MainView.BorderRadius = 10;
            this.MainView.BorderThickness = 1;
            this.MainView.Controls.Add(this.ActionsOptions);
            this.MainView.Controls.Add(this.ColumnHeader);
            this.MainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainView.FillColor = System.Drawing.Color.White;
            this.MainView.Location = new System.Drawing.Point(5, 2);
            this.MainView.Margin = new System.Windows.Forms.Padding(0);
            this.MainView.Name = "MainView";
            this.MainView.Padding = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.MainView.ShadowDecoration.BorderRadius = 15;
            this.MainView.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.MainView.ShadowDecoration.Depth = 15;
            this.MainView.Size = new System.Drawing.Size(1307, 51);
            this.MainView.TabIndex = 0;
            this.MainView.UseTransparentBackground = true;
            // 
            // ActionsOptions
            // 
            this.ActionsOptions.BackColor = System.Drawing.Color.Transparent;
            this.ActionsOptions.BorderColor = System.Drawing.Color.SlateGray;
            this.ActionsOptions.BorderRadius = 8;
            this.ActionsOptions.BorderThickness = 1;
            this.ActionsOptions.Controls.Add(this.FingerprintButton);
            this.ActionsOptions.Controls.Add(this.ExportButton);
            this.ActionsOptions.Controls.Add(this.EditButton);
            this.ActionsOptions.Controls.Add(this.ViewButton);
            this.ActionsOptions.Controls.Add(this.DeleteButton);
            this.ActionsOptions.Controls.Add(this.hideActionButton);
            this.ActionsOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.ActionsOptions.FillColor = System.Drawing.Color.White;
            this.ActionsOptions.Location = new System.Drawing.Point(1055, 3);
            this.ActionsOptions.Margin = new System.Windows.Forms.Padding(0);
            this.ActionsOptions.Name = "ActionsOptions";
            this.ActionsOptions.ShadowDecoration.BorderRadius = 10;
            this.ActionsOptions.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.ActionsOptions.ShadowDecoration.Depth = 15;
            this.ActionsOptions.Size = new System.Drawing.Size(247, 45);
            this.ActionsOptions.TabIndex = 15;
            this.ActionsOptions.UseTransparentBackground = true;
            // 
            // FingerprintButton
            // 
            this.FingerprintButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FingerprintButton.BorderRadius = 5;
            this.FingerprintButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FingerprintButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FingerprintButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FingerprintButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FingerprintButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.FingerprintButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FingerprintButton.ForeColor = System.Drawing.Color.White;
            this.FingerprintButton.Image = global::PayrollSystem.Properties.Resources.fingerprint_fill;
            this.FingerprintButton.ImageSize = new System.Drawing.Size(18, 18);
            this.FingerprintButton.Location = new System.Drawing.Point(87, 8);
            this.FingerprintButton.Name = "FingerprintButton";
            this.FingerprintButton.Size = new System.Drawing.Size(30, 30);
            this.FingerprintButton.TabIndex = 24;
            this.FingerprintButton.UseTransparentBackground = true;
            this.FingerprintButton.Visible = false;
            this.FingerprintButton.Click += new System.EventHandler(this.FingerprintButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExportButton.BorderRadius = 5;
            this.ExportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExportButton.FillColor = System.Drawing.Color.SlateGray;
            this.ExportButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.Image = global::PayrollSystem.Properties.Resources.download_line;
            this.ExportButton.ImageSize = new System.Drawing.Size(16, 16);
            this.ExportButton.Location = new System.Drawing.Point(48, 8);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(30, 30);
            this.ExportButton.TabIndex = 22;
            this.ExportButton.UseTransparentBackground = true;
            this.ExportButton.Visible = false;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EditButton.BorderRadius = 5;
            this.EditButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditButton.FillColor = System.Drawing.Color.LightSeaGreen;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Image = global::PayrollSystem.Properties.Resources.pencil_line;
            this.EditButton.ImageSize = new System.Drawing.Size(18, 18);
            this.EditButton.Location = new System.Drawing.Point(165, 8);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(30, 30);
            this.EditButton.TabIndex = 21;
            this.EditButton.UseTransparentBackground = true;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ViewButton.BorderRadius = 5;
            this.ViewButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ViewButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ViewButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ViewButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ViewButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ViewButton.ForeColor = System.Drawing.Color.White;
            this.ViewButton.Image = global::PayrollSystem.Properties.Resources.eye_line;
            this.ViewButton.ImageSize = new System.Drawing.Size(18, 18);
            this.ViewButton.Location = new System.Drawing.Point(126, 8);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(30, 30);
            this.ViewButton.TabIndex = 19;
            this.ViewButton.UseTransparentBackground = true;
            this.ViewButton.Visible = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DeleteButton.BorderRadius = 5;
            this.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteButton.FillColor = System.Drawing.Color.IndianRed;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Image = global::PayrollSystem.Properties.Resources.delete_bin_line;
            this.DeleteButton.ImageSize = new System.Drawing.Size(18, 18);
            this.DeleteButton.Location = new System.Drawing.Point(204, 8);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(30, 30);
            this.DeleteButton.TabIndex = 20;
            this.DeleteButton.UseTransparentBackground = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // hideActionButton
            // 
            this.hideActionButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hideActionButton.BorderRadius = 5;
            this.hideActionButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hideActionButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hideActionButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hideActionButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hideActionButton.FillColor = System.Drawing.Color.White;
            this.hideActionButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hideActionButton.ForeColor = System.Drawing.Color.White;
            this.hideActionButton.Image = global::PayrollSystem.Properties.Resources.close_line_2_;
            this.hideActionButton.ImageSize = new System.Drawing.Size(18, 18);
            this.hideActionButton.Location = new System.Drawing.Point(7, 8);
            this.hideActionButton.Name = "hideActionButton";
            this.hideActionButton.Size = new System.Drawing.Size(30, 30);
            this.hideActionButton.TabIndex = 23;
            this.hideActionButton.UseTransparentBackground = true;
            this.hideActionButton.Click += new System.EventHandler(this.hideActionButton_Click);
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.BackColor = System.Drawing.Color.White;
            this.ColumnHeader.ColumnCount = 5;
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.06904F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.70601F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.16036F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.70379F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.24944F));
            this.ColumnHeader.Controls.Add(this.ActiveChip, 3, 0);
            this.ColumnHeader.Controls.Add(this.EmailLabel, 2, 0);
            this.ColumnHeader.Controls.Add(this.PositionLabel, 1, 0);
            this.ColumnHeader.Controls.Add(this.panel1, 0, 0);
            this.ColumnHeader.Controls.Add(this.ActionsButton, 4, 0);
            this.ColumnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnHeader.Location = new System.Drawing.Point(3, 3);
            this.ColumnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.ColumnHeader.Name = "ColumnHeader";
            this.ColumnHeader.RowCount = 1;
            this.ColumnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ColumnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.ColumnHeader.Size = new System.Drawing.Size(1299, 45);
            this.ColumnHeader.TabIndex = 22;
            // 
            // ActiveChip
            // 
            this.ActiveChip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActiveChip.BackColor = System.Drawing.Color.Transparent;
            this.ActiveChip.BorderRadius = 12;
            this.ActiveChip.Controls.Add(this.ActiveLabel);
            this.ActiveChip.FillColor = System.Drawing.Color.DodgerBlue;
            this.ActiveChip.Location = new System.Drawing.Point(983, 10);
            this.ActiveChip.Name = "ActiveChip";
            this.ActiveChip.Size = new System.Drawing.Size(94, 25);
            this.ActiveChip.TabIndex = 22;
            this.ActiveChip.UseTransparentBackground = true;
            // 
            // ActiveLabel
            // 
            this.ActiveLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveLabel.ForeColor = System.Drawing.Color.White;
            this.ActiveLabel.Location = new System.Drawing.Point(0, 0);
            this.ActiveLabel.Name = "ActiveLabel";
            this.ActiveLabel.Size = new System.Drawing.Size(94, 25);
            this.ActiveLabel.TabIndex = 19;
            this.ActiveLabel.Text = "Active";
            this.ActiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EmailLabel.Location = new System.Drawing.Point(690, 13);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(5);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(175, 19);
            this.EmailLabel.TabIndex = 20;
            this.EmailLabel.Text = "tanjedangelo@gmail.com";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PositionLabel
            // 
            this.PositionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PositionLabel.Location = new System.Drawing.Point(481, 13);
            this.PositionLabel.Margin = new System.Windows.Forms.Padding(5);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(75, 19);
            this.PositionLabel.TabIndex = 19;
            this.PositionLabel.Text = "Developer";
            this.PositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EmployeePic);
            this.panel1.Controls.Add(this.Fullname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 39);
            this.panel1.TabIndex = 9;
            // 
            // EmployeePic
            // 
            this.EmployeePic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmployeePic.BackColor = System.Drawing.Color.Transparent;
            this.EmployeePic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeePic.Image = global::PayrollSystem.Properties.Resources.account_circle_fill1;
            this.EmployeePic.ImageRotate = 0F;
            this.EmployeePic.Location = new System.Drawing.Point(9, 1);
            this.EmployeePic.Name = "EmployeePic";
            this.EmployeePic.ShadowDecoration.BorderRadius = 11;
            this.EmployeePic.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.EmployeePic.ShadowDecoration.Depth = 15;
            this.EmployeePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EmployeePic.Size = new System.Drawing.Size(37, 37);
            this.EmployeePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmployeePic.TabIndex = 7;
            this.EmployeePic.TabStop = false;
            this.EmployeePic.UseTransparentBackground = true;
            // 
            // Fullname
            // 
            this.Fullname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fullname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Fullname.Location = new System.Drawing.Point(0, 0);
            this.Fullname.Margin = new System.Windows.Forms.Padding(5);
            this.Fullname.Name = "Fullname";
            this.Fullname.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Fullname.Size = new System.Drawing.Size(398, 39);
            this.Fullname.TabIndex = 8;
            this.Fullname.Text = "Jed Angelo M. Tan";
            this.Fullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActionsButton
            // 
            this.ActionsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActionsButton.BorderColor = System.Drawing.Color.LightSlateGray;
            this.ActionsButton.BorderRadius = 8;
            this.ActionsButton.BorderThickness = 1;
            this.ActionsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ActionsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ActionsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ActionsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ActionsButton.FillColor = System.Drawing.Color.White;
            this.ActionsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ActionsButton.Location = new System.Drawing.Point(1180, 7);
            this.ActionsButton.Name = "ActionsButton";
            this.ActionsButton.Size = new System.Drawing.Size(78, 30);
            this.ActionsButton.TabIndex = 23;
            this.ActionsButton.Text = "Actions";
            this.ActionsButton.Click += new System.EventHandler(this.ActionsButton_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.ColumnHeader;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EmployeeView";
            this.Padding = new System.Windows.Forms.Padding(5, 2, 5, 3);
            this.Size = new System.Drawing.Size(1317, 56);
            this.SizeChanged += new System.EventHandler(this.EmployeeView_SizeChanged);
            this.MainView.ResumeLayout(false);
            this.ActionsOptions.ResumeLayout(false);
            this.ColumnHeader.ResumeLayout(false);
            this.ColumnHeader.PerformLayout();
            this.ActiveChip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel MainView;
        private Guna.UI2.WinForms.Guna2Panel ActionsOptions;
        private Guna.UI2.WinForms.Guna2Button ExportButton;
        private Guna.UI2.WinForms.Guna2Button EditButton;
        private Guna.UI2.WinForms.Guna2Button ViewButton;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private Guna.UI2.WinForms.Guna2Button hideActionButton;
        private System.Windows.Forms.TableLayoutPanel ColumnHeader;
        private System.Windows.Forms.Label PositionLabel;
        private Guna.UI2.WinForms.Guna2Panel ActiveChip;
        private System.Windows.Forms.Label ActiveLabel;
        private System.Windows.Forms.Label EmailLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button ActionsButton;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox EmployeePic;
        private System.Windows.Forms.Label Fullname;
        private Guna.UI2.WinForms.Guna2Button FingerprintButton;
    }
}
