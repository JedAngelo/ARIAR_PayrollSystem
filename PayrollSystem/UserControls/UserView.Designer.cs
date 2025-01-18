namespace PayrollSystem.UserControls
{
    partial class UserView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ActionsOptions = new Guna.UI2.WinForms.Guna2Panel();
            this.EditButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.Permissions = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MainView.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ActionsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainView
            // 
            this.MainView.BackColor = System.Drawing.Color.Transparent;
            this.MainView.BorderColor = System.Drawing.Color.SlateGray;
            this.MainView.BorderRadius = 10;
            this.MainView.BorderThickness = 1;
            this.MainView.Controls.Add(this.tableLayoutPanel1);
            this.MainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainView.FillColor = System.Drawing.Color.White;
            this.MainView.Location = new System.Drawing.Point(5, 2);
            this.MainView.Name = "MainView";
            this.MainView.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MainView.ShadowDecoration.BorderRadius = 15;
            this.MainView.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.MainView.ShadowDecoration.Depth = 15;
            this.MainView.Size = new System.Drawing.Size(1422, 50);
            this.MainView.TabIndex = 5;
            this.MainView.UseTransparentBackground = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.19753F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.56379F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ActionsOptions, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Permissions, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Username, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserId, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1418, 40);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // ActionsOptions
            // 
            this.ActionsOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActionsOptions.BackColor = System.Drawing.Color.Transparent;
            this.ActionsOptions.BorderColor = System.Drawing.Color.SlateGray;
            this.ActionsOptions.BorderRadius = 8;
            this.ActionsOptions.Controls.Add(this.EditButton);
            this.ActionsOptions.Controls.Add(this.DeleteButton);
            this.ActionsOptions.FillColor = System.Drawing.Color.White;
            this.ActionsOptions.Location = new System.Drawing.Point(1283, 0);
            this.ActionsOptions.Margin = new System.Windows.Forms.Padding(0);
            this.ActionsOptions.Name = "ActionsOptions";
            this.ActionsOptions.ShadowDecoration.BorderRadius = 10;
            this.ActionsOptions.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.ActionsOptions.ShadowDecoration.Depth = 15;
            this.ActionsOptions.Size = new System.Drawing.Size(111, 40);
            this.ActionsOptions.TabIndex = 16;
            this.ActionsOptions.UseTransparentBackground = true;
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
            this.EditButton.Location = new System.Drawing.Point(22, 6);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(30, 30);
            this.EditButton.TabIndex = 21;
            this.EditButton.UseTransparentBackground = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
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
            this.DeleteButton.Location = new System.Drawing.Point(62, 6);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(30, 30);
            this.DeleteButton.TabIndex = 20;
            this.DeleteButton.UseTransparentBackground = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // Permissions
            // 
            this.Permissions.BackColor = System.Drawing.Color.Transparent;
            this.Permissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Permissions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Permissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Permissions.Location = new System.Drawing.Point(793, 5);
            this.Permissions.Margin = new System.Windows.Forms.Padding(5);
            this.Permissions.Name = "Permissions";
            this.Permissions.Size = new System.Drawing.Size(461, 30);
            this.Permissions.TabIndex = 11;
            this.Permissions.Text = "Permissions";
            this.Permissions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Username.Location = new System.Drawing.Point(559, 5);
            this.Username.Margin = new System.Windows.Forms.Padding(5);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(224, 30);
            this.Username.TabIndex = 10;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserId
            // 
            this.UserId.BackColor = System.Drawing.Color.Transparent;
            this.UserId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UserId.Location = new System.Drawing.Point(5, 5);
            this.UserId.Margin = new System.Windows.Forms.Padding(5);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(544, 30);
            this.UserId.TabIndex = 9;
            this.UserId.Text = "User ID";
            this.UserId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.tableLayoutPanel1;
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.MainView);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserView";
            this.Padding = new System.Windows.Forms.Padding(5, 2, 5, 3);
            this.Size = new System.Drawing.Size(1432, 55);
            this.MainView.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ActionsOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MainView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Permissions;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label UserId;
        private Guna.UI2.WinForms.Guna2Button EditButton;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private Guna.UI2.WinForms.Guna2Panel ActionsOptions;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
