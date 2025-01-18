namespace PayrollSystem.UserControls
{
    partial class EmployeeBiometricsView
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
            this.MainView = new Guna.UI2.WinForms.Guna2Panel();
            this.ColumnHeader = new System.Windows.Forms.TableLayoutPanel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.TopView = new Guna.UI2.WinForms.Guna2Panel();
            this.MainView.SuspendLayout();
            this.ColumnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainView
            // 
            this.MainView.BackColor = System.Drawing.Color.Transparent;
            this.MainView.BorderColor = System.Drawing.Color.SlateGray;
            this.MainView.BorderRadius = 10;
            this.MainView.Controls.Add(this.ColumnHeader);
            this.MainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainView.FillColor = System.Drawing.Color.White;
            this.MainView.Location = new System.Drawing.Point(5, 2);
            this.MainView.Name = "MainView";
            this.MainView.ShadowDecoration.BorderRadius = 15;
            this.MainView.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.MainView.ShadowDecoration.Depth = 15;
            this.MainView.Size = new System.Drawing.Size(450, 46);
            this.MainView.TabIndex = 5;
            this.MainView.UseTransparentBackground = true;
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.ColumnCount = 2;
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.49999F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.50001F));
            this.ColumnHeader.Controls.Add(this.DateLabel, 1, 0);
            this.ColumnHeader.Controls.Add(this.IdLabel, 0, 0);
            this.ColumnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnHeader.Location = new System.Drawing.Point(0, 0);
            this.ColumnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.ColumnHeader.Name = "ColumnHeader";
            this.ColumnHeader.RowCount = 1;
            this.ColumnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ColumnHeader.Size = new System.Drawing.Size(450, 46);
            this.ColumnHeader.TabIndex = 1;
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DateLabel.Location = new System.Drawing.Point(274, 16);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(69, 13);
            this.DateLabel.TabIndex = 95;
            this.DateLabel.Text = "Date Added";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IdLabel.Location = new System.Drawing.Point(49, 16);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(70, 13);
            this.IdLabel.TabIndex = 94;
            this.IdLabel.Text = "Biometric ID";
            this.IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TopView
            // 
            this.TopView.BackColor = System.Drawing.Color.Transparent;
            this.TopView.BorderColor = System.Drawing.Color.SlateGray;
            this.TopView.BorderRadius = 10;
            this.TopView.BorderThickness = 1;
            this.TopView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopView.Location = new System.Drawing.Point(5, 2);
            this.TopView.Name = "TopView";
            this.TopView.Padding = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.TopView.ShadowDecoration.BorderRadius = 15;
            this.TopView.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.TopView.ShadowDecoration.Depth = 15;
            this.TopView.Size = new System.Drawing.Size(450, 46);
            this.TopView.TabIndex = 7;
            this.TopView.UseTransparentBackground = true;
            this.TopView.Click += new System.EventHandler(this.TopView_Click);
            // 
            // EmployeeBiometricsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.TopView);
            this.Controls.Add(this.MainView);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EmployeeBiometricsView";
            this.Padding = new System.Windows.Forms.Padding(5, 2, 5, 3);
            this.Size = new System.Drawing.Size(460, 51);
            this.MainView.ResumeLayout(false);
            this.ColumnHeader.ResumeLayout(false);
            this.ColumnHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MainView;
        private System.Windows.Forms.TableLayoutPanel ColumnHeader;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label IdLabel;
        private Guna.UI2.WinForms.Guna2Panel TopView;
    }
}
