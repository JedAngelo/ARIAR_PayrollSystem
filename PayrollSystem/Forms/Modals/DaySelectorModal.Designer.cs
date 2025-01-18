namespace PayrollSystem.Forms.Modals
{
    partial class DaySelectorModal
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
            this.borderlessFormAnimation = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DayType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MultiplierTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new Guna.UI2.WinForms.Guna2Button();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 46);
            this.panel1.TabIndex = 158;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(11, 11);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 5, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 21);
            this.label21.TabIndex = 131;
            this.label21.Text = "Set Day Type";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.CustomIconSize = 13F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(281, 6);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(31, 31);
            this.guna2ControlBox1.TabIndex = 128;
            this.guna2ControlBox1.UseTransparentBackground = true;
            // 
            // DayType
            // 
            this.DayType.BackColor = System.Drawing.Color.Transparent;
            this.DayType.BorderRadius = 8;
            this.DayType.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.DayType.DisabledState.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.DayType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DayType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DayType.DropDownHeight = 120;
            this.DayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayType.FocusedColor = System.Drawing.Color.Empty;
            this.DayType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.DayType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DayType.IntegralHeight = false;
            this.DayType.ItemHeight = 30;
            this.DayType.Items.AddRange(new object[] {
            "REGULAR PAY",
            "HOLIDAY PAY",
            "PREMIUM PAY"});
            this.DayType.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayType.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DayType.ItemsAppearance.SelectedFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayType.Location = new System.Drawing.Point(91, 64);
            this.DayType.Margin = new System.Windows.Forms.Padding(15);
            this.DayType.Name = "DayType";
            this.DayType.ShadowDecoration.BorderRadius = 11;
            this.DayType.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.DayType.ShadowDecoration.Depth = 15;
            this.DayType.Size = new System.Drawing.Size(207, 36);
            this.DayType.StartIndex = 0;
            this.DayType.TabIndex = 132;
            this.DayType.TextOffset = new System.Drawing.Point(15, 0);
            this.DayType.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 159;
            this.label1.Text = "Day Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultiplierTextBox
            // 
            this.MultiplierTextBox.BorderRadius = 8;
            this.MultiplierTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MultiplierTextBox.DefaultText = "";
            this.MultiplierTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MultiplierTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MultiplierTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MultiplierTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MultiplierTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MultiplierTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplierTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MultiplierTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MultiplierTextBox.Location = new System.Drawing.Point(136, 118);
            this.MultiplierTextBox.Name = "MultiplierTextBox";
            this.MultiplierTextBox.PasswordChar = '\0';
            this.MultiplierTextBox.PlaceholderText = "1.0";
            this.MultiplierTextBox.SelectedText = "";
            this.MultiplierTextBox.Size = new System.Drawing.Size(162, 36);
            this.MultiplierTextBox.TabIndex = 160;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(11, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 5, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 161;
            this.label2.Text = "Pay Mulplier(%)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BorderRadius = 5;
            this.SaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(184, 173);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(114, 31);
            this.SaveButton.TabIndex = 167;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseTransparentBackground = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DaySelectorModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(322, 220);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MultiplierTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DayType);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DaySelectorModal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DaySelectorModal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessFormAnimation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox DayType;
        private Guna.UI2.WinForms.Guna2TextBox MultiplierTextBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button SaveButton;
    }
}