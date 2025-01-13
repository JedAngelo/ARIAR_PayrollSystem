namespace ARIAR_PayrollSystem.UserControls
{
    partial class ActiveStatusDropdownView
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
            this.ViewParent = new Guna.UI2.WinForms.Guna2Panel();
            this.CheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ViewParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewParent
            // 
            this.ViewParent.BackColor = System.Drawing.Color.Transparent;
            this.ViewParent.BorderColor = System.Drawing.Color.SlateGray;
            this.ViewParent.Controls.Add(this.CheckBox);
            this.ViewParent.CustomBorderColor = System.Drawing.Color.LightSlateGray;
            this.ViewParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewParent.FillColor = System.Drawing.Color.White;
            this.ViewParent.Location = new System.Drawing.Point(0, 0);
            this.ViewParent.Name = "ViewParent";
            this.ViewParent.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.ViewParent.Size = new System.Drawing.Size(165, 31);
            this.ViewParent.TabIndex = 0;
            this.ViewParent.UseTransparentBackground = true;
            this.ViewParent.MouseEnter += new System.EventHandler(this.ViewParent_MouseEnter);
            this.ViewParent.MouseLeave += new System.EventHandler(this.ViewParent_MouseLeave);
            // 
            // CheckBox
            // 
            this.CheckBox.Animated = true;
            this.CheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox.CheckedState.BorderRadius = 0;
            this.CheckBox.CheckedState.BorderThickness = 0;
            this.CheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CheckBox.Location = new System.Drawing.Point(8, 5);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(149, 21);
            this.CheckBox.TabIndex = 0;
            this.CheckBox.Text = "Active";
            this.CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBox.ThreeState = true;
            this.CheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBox.UncheckedState.BorderRadius = 0;
            this.CheckBox.UncheckedState.BorderThickness = 0;
            this.CheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            this.CheckBox.MouseEnter += new System.EventHandler(this.ViewParent_MouseEnter);
            this.CheckBox.MouseLeave += new System.EventHandler(this.ViewParent_MouseLeave);
            // 
            // ActiveStatusDropdownView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ViewParent);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ActiveStatusDropdownView";
            this.Size = new System.Drawing.Size(165, 31);
            this.ViewParent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ViewParent;
        public Guna.UI2.WinForms.Guna2CheckBox CheckBox;
    }
}
