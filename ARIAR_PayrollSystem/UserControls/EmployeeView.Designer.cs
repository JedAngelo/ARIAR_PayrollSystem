namespace ARIAR_PayrollSystem.UserControls
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ContactNo = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.Address = new System.Windows.Forms.Label();
            this.Fullname = new System.Windows.Forms.Label();
            this.EmployeePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.SlateGray;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.ContactNo);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.Address);
            this.guna2Panel1.Controls.Add(this.Fullname);
            this.guna2Panel1.Controls.Add(this.EmployeePic);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(5, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 15;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel1.ShadowDecoration.Depth = 15;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(330, 79);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // ContactNo
            // 
            this.ContactNo.AutoSize = true;
            this.ContactNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ContactNo.Location = new System.Drawing.Point(98, 25);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(104, 13);
            this.ContactNo.TabIndex = 7;
            this.ContactNo.Text = "(+63) 912 633 3500";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Location = new System.Drawing.Point(101, 17);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 9;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Address.Location = new System.Drawing.Point(98, 39);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(204, 30);
            this.Address.TabIndex = 8;
            this.Address.Text = "Purok Malipayon, General Santos City, South Cotabato";
            // 
            // Fullname
            // 
            this.Fullname.AutoSize = true;
            this.Fullname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullname.Location = new System.Drawing.Point(98, 3);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(123, 17);
            this.Fullname.TabIndex = 6;
            this.Fullname.Text = "Jed Angelo M. Tan";
            // 
            // EmployeePic
            // 
            this.EmployeePic.BackColor = System.Drawing.Color.Transparent;
            this.EmployeePic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmployeePic.Image = global::ARIAR_PayrollSystem.Properties.Resources.close_circle_fill;
            this.EmployeePic.ImageRotate = 0F;
            this.EmployeePic.Location = new System.Drawing.Point(29, 12);
            this.EmployeePic.Name = "EmployeePic";
            this.EmployeePic.ShadowDecoration.BorderRadius = 11;
            this.EmployeePic.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.EmployeePic.ShadowDecoration.Depth = 15;
            this.EmployeePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EmployeePic.Size = new System.Drawing.Size(45, 45);
            this.EmployeePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmployeePic.TabIndex = 5;
            this.EmployeePic.TabStop = false;
            this.EmployeePic.UseTransparentBackground = true;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeeView";
            this.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Size = new System.Drawing.Size(340, 83);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label ContactNo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Fullname;
        private Guna.UI2.WinForms.Guna2CirclePictureBox EmployeePic;
    }
}
