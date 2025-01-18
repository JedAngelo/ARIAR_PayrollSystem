namespace PayrollSystem.Forms.Modals
{
    partial class ApiSwitcher
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
            this.UriComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DoneButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.borderlessFormAnimation = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.CustomButton = new Guna.UI2.WinForms.Guna2Button();
            this.CustomURIBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CurrentUriLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UriComboBox
            // 
            this.UriComboBox.BackColor = System.Drawing.Color.Transparent;
            this.UriComboBox.BorderRadius = 5;
            this.UriComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.UriComboBox.DropDownHeight = 100;
            this.UriComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UriComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UriComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UriComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.UriComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UriComboBox.IntegralHeight = false;
            this.UriComboBox.ItemHeight = 30;
            this.UriComboBox.Items.AddRange(new object[] {
            "http://localhost:2410",
            "https://localhost:44376"});
            this.UriComboBox.Location = new System.Drawing.Point(26, 62);
            this.UriComboBox.Name = "UriComboBox";
            this.UriComboBox.Size = new System.Drawing.Size(260, 36);
            this.UriComboBox.StartIndex = 0;
            this.UriComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select API URI";
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.Animated = true;
            this.DoneButton.BackColor = System.Drawing.Color.Transparent;
            this.DoneButton.BorderRadius = 5;
            this.DoneButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DoneButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DoneButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DoneButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DoneButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.DoneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(202, 132);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(2);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(84, 27);
            this.DoneButton.TabIndex = 3;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseTransparentBackground = true;
            this.DoneButton.Click += new System.EventHandler(this.CustomButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 46);
            this.panel1.TabIndex = 157;
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(270, 6);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(31, 31);
            this.guna2ControlBox2.TabIndex = 128;
            this.guna2ControlBox2.UseTransparentBackground = true;
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
            // CustomButton
            // 
            this.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomButton.Animated = true;
            this.CustomButton.BackColor = System.Drawing.Color.Transparent;
            this.CustomButton.BorderRadius = 5;
            this.CustomButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CustomButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CustomButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CustomButton.FillColor = System.Drawing.Color.SteelBlue;
            this.CustomButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomButton.ForeColor = System.Drawing.Color.White;
            this.CustomButton.Location = new System.Drawing.Point(26, 132);
            this.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.CustomButton.Name = "CustomButton";
            this.CustomButton.Size = new System.Drawing.Size(119, 27);
            this.CustomButton.TabIndex = 158;
            this.CustomButton.Text = "Custom URI";
            this.CustomButton.UseTransparentBackground = true;
            this.CustomButton.Click += new System.EventHandler(this.CustomButton_Click_1);
            // 
            // CustomURIBox
            // 
            this.CustomURIBox.BorderRadius = 5;
            this.CustomURIBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomURIBox.DefaultText = "";
            this.CustomURIBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomURIBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomURIBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomURIBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomURIBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomURIBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomURIBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CustomURIBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomURIBox.Location = new System.Drawing.Point(26, 62);
            this.CustomURIBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomURIBox.Name = "CustomURIBox";
            this.CustomURIBox.PasswordChar = '\0';
            this.CustomURIBox.PlaceholderText = "Input custom URI";
            this.CustomURIBox.SelectedText = "";
            this.CustomURIBox.Size = new System.Drawing.Size(260, 36);
            this.CustomURIBox.TabIndex = 159;
            // 
            // CurrentUriLabel
            // 
            this.CurrentUriLabel.AutoSize = true;
            this.CurrentUriLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUriLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.CurrentUriLabel.Location = new System.Drawing.Point(30, 101);
            this.CurrentUriLabel.Name = "CurrentUriLabel";
            this.CurrentUriLabel.Size = new System.Drawing.Size(180, 13);
            this.CurrentUriLabel.TabIndex = 129;
            this.CurrentUriLabel.Text = "Current URI: http://localhost:2410";
            // 
            // ApiSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(311, 175);
            this.Controls.Add(this.CurrentUriLabel);
            this.Controls.Add(this.CustomButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.UriComboBox);
            this.Controls.Add(this.CustomURIBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApiSwitcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ApiSwitcher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox UriComboBox;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button DoneButton;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessFormAnimation;
        public Guna.UI2.WinForms.Guna2Button CustomButton;
        private Guna.UI2.WinForms.Guna2TextBox CustomURIBox;
        private System.Windows.Forms.Label CurrentUriLabel;
    }
}