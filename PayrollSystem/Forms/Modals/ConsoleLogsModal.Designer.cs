namespace PayrollSystem.Forms.Modals
{
    partial class ConsoleLogsModal
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ConsoleLogs = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.borderlessFormAnimation = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.SlateGray;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.ConsoleLogs);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Panel1.Location = new System.Drawing.Point(22, 59);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(13);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(13, 8, 13, 8);
            this.guna2Panel1.Size = new System.Drawing.Size(735, 346);
            this.guna2Panel1.TabIndex = 6;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // ConsoleLogs
            // 
            this.ConsoleLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ConsoleLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleLogs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ConsoleLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleLogs.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleLogs.ForeColor = System.Drawing.Color.White;
            this.ConsoleLogs.Location = new System.Drawing.Point(13, 8);
            this.ConsoleLogs.Name = "ConsoleLogs";
            this.ConsoleLogs.ReadOnly = true;
            this.ConsoleLogs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ConsoleLogs.Size = new System.Drawing.Size(709, 330);
            this.ConsoleLogs.TabIndex = 0;
            this.ConsoleLogs.Text = "Starting program...\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 46);
            this.panel1.TabIndex = 155;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BorderRadius = 5;
            this.CloseButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.CloseButton.CustomClick = true;
            this.CloseButton.CustomIconSize = 13F;
            this.CloseButton.FillColor = System.Drawing.Color.Transparent;
            this.CloseButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(738, 6);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(31, 31);
            this.CloseButton.TabIndex = 128;
            this.CloseButton.UseTransparentBackground = true;
            this.CloseButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(0, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(779, 46);
            this.DateLabel.TabIndex = 129;
            this.DateLabel.Text = "CONSOLE LOGS";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borderlessFormAnimation
            // 
            this.borderlessFormAnimation.AnimateWindow = true;
            this.borderlessFormAnimation.AnimationInterval = 150;
            this.borderlessFormAnimation.BorderRadius = 15;
            this.borderlessFormAnimation.ContainerControl = this;
            this.borderlessFormAnimation.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessFormAnimation.DragForm = false;
            this.borderlessFormAnimation.DragStartTransparencyValue = 1D;
            this.borderlessFormAnimation.ResizeForm = false;
            this.borderlessFormAnimation.TransparentWhileDrag = true;
            // 
            // dragControl
            // 
            this.dragControl.DockIndicatorTransparencyValue = 0.6D;
            this.dragControl.DragStartTransparencyValue = 1D;
            this.dragControl.TargetControl = this.DateLabel;
            this.dragControl.UseTransparentDrag = true;
            // 
            // ConsoleLogsModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 427);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ConsoleLogsModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsoleLogsModal";
            this.Load += new System.EventHandler(this.ConsoleLogsModal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsoleLogsModal_KeyDown);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox CloseButton;
        private System.Windows.Forms.Label DateLabel;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessFormAnimation;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private System.Windows.Forms.RichTextBox ConsoleLogs;
    }
}