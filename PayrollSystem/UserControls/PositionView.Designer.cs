namespace PayrollSystem.UserControls
{
    partial class PositionView
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ColumnHeader = new System.Windows.Forms.TableLayoutPanel();
            this.ModifiedDate = new System.Windows.Forms.Label();
            this.DateCreated = new System.Windows.Forms.Label();
            this.CreatedBy = new System.Windows.Forms.Label();
            this.EmployeeCount = new System.Windows.Forms.Label();
            this.PositionName = new System.Windows.Forms.Label();
            this.ModifiedBy = new System.Windows.Forms.Label();
            this.MainView = new Guna.UI2.WinForms.Guna2Panel();
            this.TopView = new Guna.UI2.WinForms.Guna2Panel();
            this.ColumnHeader.SuspendLayout();
            this.MainView.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.ColumnHeader;
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.ColumnCount = 6;
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.16233F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.58068F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.31425F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.31425F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.31425F));
            this.ColumnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.31425F));
            this.ColumnHeader.Controls.Add(this.ModifiedDate, 5, 0);
            this.ColumnHeader.Controls.Add(this.DateCreated, 3, 0);
            this.ColumnHeader.Controls.Add(this.CreatedBy, 2, 0);
            this.ColumnHeader.Controls.Add(this.EmployeeCount, 1, 0);
            this.ColumnHeader.Controls.Add(this.PositionName, 0, 0);
            this.ColumnHeader.Controls.Add(this.ModifiedBy, 4, 0);
            this.ColumnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnHeader.Location = new System.Drawing.Point(0, 0);
            this.ColumnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.ColumnHeader.Name = "ColumnHeader";
            this.ColumnHeader.RowCount = 1;
            this.ColumnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ColumnHeader.Size = new System.Drawing.Size(1028, 46);
            this.ColumnHeader.TabIndex = 8;
            // 
            // ModifiedDate
            // 
            this.ModifiedDate.BackColor = System.Drawing.Color.Transparent;
            this.ModifiedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifiedDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifiedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ModifiedDate.Location = new System.Drawing.Point(873, 5);
            this.ModifiedDate.Margin = new System.Windows.Forms.Padding(5);
            this.ModifiedDate.Name = "ModifiedDate";
            this.ModifiedDate.Size = new System.Drawing.Size(150, 36);
            this.ModifiedDate.TabIndex = 13;
            this.ModifiedDate.Text = "Modified Date";
            this.ModifiedDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateCreated
            // 
            this.DateCreated.BackColor = System.Drawing.Color.Transparent;
            this.DateCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateCreated.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DateCreated.Location = new System.Drawing.Point(559, 5);
            this.DateCreated.Margin = new System.Windows.Forms.Padding(5);
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(147, 36);
            this.DateCreated.TabIndex = 12;
            this.DateCreated.Text = "Date Created";
            this.DateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreatedBy
            // 
            this.CreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.CreatedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CreatedBy.Location = new System.Drawing.Point(402, 5);
            this.CreatedBy.Margin = new System.Windows.Forms.Padding(5);
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Size = new System.Drawing.Size(147, 36);
            this.CreatedBy.TabIndex = 11;
            this.CreatedBy.Text = "Created By";
            this.CreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeCount
            // 
            this.EmployeeCount.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EmployeeCount.Location = new System.Drawing.Point(222, 5);
            this.EmployeeCount.Margin = new System.Windows.Forms.Padding(5);
            this.EmployeeCount.Name = "EmployeeCount";
            this.EmployeeCount.Size = new System.Drawing.Size(170, 36);
            this.EmployeeCount.TabIndex = 10;
            this.EmployeeCount.Text = "Employees";
            this.EmployeeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PositionName
            // 
            this.PositionName.BackColor = System.Drawing.Color.Transparent;
            this.PositionName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PositionName.Location = new System.Drawing.Point(5, 5);
            this.PositionName.Margin = new System.Windows.Forms.Padding(5);
            this.PositionName.Name = "PositionName";
            this.PositionName.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.PositionName.Size = new System.Drawing.Size(207, 36);
            this.PositionName.TabIndex = 9;
            this.PositionName.Text = "Position Name";
            this.PositionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModifiedBy
            // 
            this.ModifiedBy.BackColor = System.Drawing.Color.Transparent;
            this.ModifiedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifiedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifiedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ModifiedBy.Location = new System.Drawing.Point(716, 5);
            this.ModifiedBy.Margin = new System.Windows.Forms.Padding(5);
            this.ModifiedBy.Name = "ModifiedBy";
            this.ModifiedBy.Size = new System.Drawing.Size(147, 36);
            this.ModifiedBy.TabIndex = 8;
            this.ModifiedBy.Text = "Modified By";
            this.ModifiedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.MainView.Size = new System.Drawing.Size(1028, 46);
            this.MainView.TabIndex = 4;
            this.MainView.UseTransparentBackground = true;
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
            this.TopView.Size = new System.Drawing.Size(1028, 46);
            this.TopView.TabIndex = 9;
            this.TopView.UseTransparentBackground = true;
            this.TopView.Click += new System.EventHandler(this.TopView_Click);
            // 
            // PositionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.TopView);
            this.Controls.Add(this.MainView);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PositionView";
            this.Padding = new System.Windows.Forms.Padding(5, 2, 5, 3);
            this.Size = new System.Drawing.Size(1038, 51);
            this.ColumnHeader.ResumeLayout(false);
            this.MainView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel ColumnHeader;
        private System.Windows.Forms.Label ModifiedDate;
        private System.Windows.Forms.Label DateCreated;
        private System.Windows.Forms.Label CreatedBy;
        private System.Windows.Forms.Label EmployeeCount;
        private System.Windows.Forms.Label PositionName;
        private System.Windows.Forms.Label ModifiedBy;
        private Guna.UI2.WinForms.Guna2Panel MainView;
        private Guna.UI2.WinForms.Guna2Panel TopView;
    }
}
