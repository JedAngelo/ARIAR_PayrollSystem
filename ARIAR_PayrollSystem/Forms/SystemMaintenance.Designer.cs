namespace ARIAR_PayrollSystem.Forms
{
    partial class SystemMaintenance
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemMaintenance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SystemMaintenanceTabs = new Guna.UI2.WinForms.Guna2TabControl();
            this.SystemSettings = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveSettingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EarlyOutAfternoonCutOff = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EarlyOutMorningCutoff = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LateAfternoonCutOff = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LateMorningCutOff = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GenderOptions = new Guna.UI2.WinForms.Guna2Panel();
            this.InOut = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Full = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BiometricsTab = new System.Windows.Forms.TabPage();
            this.panel18 = new System.Windows.Forms.Panel();
            this.RegisterButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label8 = new System.Windows.Forms.Label();
            this.Positions = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ColumnHeader = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddPosition = new Guna.UI2.WinForms.Guna2Button();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.LabelTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.EmployeeViewScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.ListView = new ARIAR_PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.DataView = new ARIAR_PayrollSystem.UserControls.CustomFlowLayoutPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.SystemMaintenanceTabs.SuspendLayout();
            this.SystemSettings.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GenderOptions.SuspendLayout();
            this.BiometricsTab.SuspendLayout();
            this.panel18.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.Positions.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.ColumnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SystemMaintenanceTabs);
            this.LabelTransition.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 746);
            this.panel1.TabIndex = 0;
            // 
            // SystemMaintenanceTabs
            // 
            this.SystemMaintenanceTabs.Controls.Add(this.SystemSettings);
            this.SystemMaintenanceTabs.Controls.Add(this.BiometricsTab);
            this.SystemMaintenanceTabs.Controls.Add(this.Positions);
            this.LabelTransition.SetDecoration(this.SystemMaintenanceTabs, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SystemMaintenanceTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemMaintenanceTabs.ItemSize = new System.Drawing.Size(200, 40);
            this.SystemMaintenanceTabs.Location = new System.Drawing.Point(0, 0);
            this.SystemMaintenanceTabs.Margin = new System.Windows.Forms.Padding(0);
            this.SystemMaintenanceTabs.Name = "SystemMaintenanceTabs";
            this.SystemMaintenanceTabs.SelectedIndex = 0;
            this.SystemMaintenanceTabs.Size = new System.Drawing.Size(1091, 746);
            this.SystemMaintenanceTabs.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.SystemMaintenanceTabs.TabButtonHoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.SystemMaintenanceTabs.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.SystemMaintenanceTabs.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SystemMaintenanceTabs.TabButtonHoverState.InnerColor = System.Drawing.Color.Gainsboro;
            this.SystemMaintenanceTabs.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.SystemMaintenanceTabs.TabButtonIdleState.FillColor = System.Drawing.SystemColors.Control;
            this.SystemMaintenanceTabs.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.SystemMaintenanceTabs.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SystemMaintenanceTabs.TabButtonIdleState.InnerColor = System.Drawing.SystemColors.Control;
            this.SystemMaintenanceTabs.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.SystemMaintenanceTabs.TabButtonSelectedState.FillColor = System.Drawing.SystemColors.Control;
            this.SystemMaintenanceTabs.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.SystemMaintenanceTabs.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SystemMaintenanceTabs.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.SystemMaintenanceTabs.TabButtonSize = new System.Drawing.Size(200, 40);
            this.SystemMaintenanceTabs.TabIndex = 0;
            this.SystemMaintenanceTabs.TabMenuBackColor = System.Drawing.SystemColors.Control;
            this.SystemMaintenanceTabs.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.SystemMaintenanceTabs.SelectedIndexChanged += new System.EventHandler(this.SystemMaintenanceTabs_SelectedIndexChanged);
            // 
            // SystemSettings
            // 
            this.SystemSettings.BackColor = System.Drawing.SystemColors.Control;
            this.SystemSettings.Controls.Add(this.panel2);
            this.LabelTransition.SetDecoration(this.SystemSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SystemSettings.Location = new System.Drawing.Point(4, 44);
            this.SystemSettings.Margin = new System.Windows.Forms.Padding(0);
            this.SystemSettings.Name = "SystemSettings";
            this.SystemSettings.Size = new System.Drawing.Size(1083, 698);
            this.SystemSettings.TabIndex = 0;
            this.SystemSettings.Text = "System Settings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.SaveSettingsButton);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.EarlyOutAfternoonCutOff);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.EarlyOutMorningCutoff);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.LateAfternoonCutOff);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LateMorningCutOff);
            this.panel2.Controls.Add(this.GenderOptions);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.LabelTransition.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 698);
            this.panel2.TabIndex = 0;
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveSettingsButton.Animated = true;
            this.SaveSettingsButton.AnimatedGIF = true;
            this.SaveSettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveSettingsButton.BorderRadius = 5;
            this.LabelTransition.SetDecoration(this.SaveSettingsButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SaveSettingsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveSettingsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveSettingsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveSettingsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveSettingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.SaveSettingsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSettingsButton.ForeColor = System.Drawing.Color.White;
            this.SaveSettingsButton.Location = new System.Drawing.Point(903, 638);
            this.SaveSettingsButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(153, 37);
            this.SaveSettingsButton.TabIndex = 48;
            this.SaveSettingsButton.Text = "Save Settings";
            this.SaveSettingsButton.UseTransparentBackground = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.LabelTransition.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(27, 417);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Early out afternoon cut-off";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EarlyOutAfternoonCutOff
            // 
            this.EarlyOutAfternoonCutOff.BackColor = System.Drawing.Color.Transparent;
            this.EarlyOutAfternoonCutOff.BorderRadius = 5;
            this.LabelTransition.SetDecoration(this.EarlyOutAfternoonCutOff, Guna.UI2.AnimatorNS.DecorationType.None);
            this.EarlyOutAfternoonCutOff.DisabledState.FillColor = System.Drawing.Color.White;
            this.EarlyOutAfternoonCutOff.DisabledState.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.EarlyOutAfternoonCutOff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EarlyOutAfternoonCutOff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EarlyOutAfternoonCutOff.DropDownHeight = 36;
            this.EarlyOutAfternoonCutOff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EarlyOutAfternoonCutOff.FocusedColor = System.Drawing.Color.Empty;
            this.EarlyOutAfternoonCutOff.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.EarlyOutAfternoonCutOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.EarlyOutAfternoonCutOff.IntegralHeight = false;
            this.EarlyOutAfternoonCutOff.ItemHeight = 36;
            this.EarlyOutAfternoonCutOff.Items.AddRange(new object[] {
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM"});
            this.EarlyOutAfternoonCutOff.ItemsAppearance.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.EarlyOutAfternoonCutOff.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EarlyOutAfternoonCutOff.ItemsAppearance.SelectedFont = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.EarlyOutAfternoonCutOff.Location = new System.Drawing.Point(220, 405);
            this.EarlyOutAfternoonCutOff.Margin = new System.Windows.Forms.Padding(0);
            this.EarlyOutAfternoonCutOff.MaxDropDownItems = 5;
            this.EarlyOutAfternoonCutOff.Name = "EarlyOutAfternoonCutOff";
            this.EarlyOutAfternoonCutOff.Size = new System.Drawing.Size(184, 42);
            this.EarlyOutAfternoonCutOff.StartIndex = 0;
            this.EarlyOutAfternoonCutOff.TabIndex = 46;
            this.EarlyOutAfternoonCutOff.TextOffset = new System.Drawing.Point(10, 0);
            this.EarlyOutAfternoonCutOff.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.LabelTransition.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(27, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "Early out morning cut-off";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EarlyOutMorningCutoff
            // 
            this.EarlyOutMorningCutoff.BackColor = System.Drawing.Color.Transparent;
            this.EarlyOutMorningCutoff.BorderRadius = 5;
            this.LabelTransition.SetDecoration(this.EarlyOutMorningCutoff, Guna.UI2.AnimatorNS.DecorationType.None);
            this.EarlyOutMorningCutoff.DisabledState.FillColor = System.Drawing.Color.White;
            this.EarlyOutMorningCutoff.DisabledState.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.EarlyOutMorningCutoff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EarlyOutMorningCutoff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EarlyOutMorningCutoff.DropDownHeight = 36;
            this.EarlyOutMorningCutoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EarlyOutMorningCutoff.FocusedColor = System.Drawing.Color.Empty;
            this.EarlyOutMorningCutoff.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.EarlyOutMorningCutoff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.EarlyOutMorningCutoff.IntegralHeight = false;
            this.EarlyOutMorningCutoff.ItemHeight = 36;
            this.EarlyOutMorningCutoff.Items.AddRange(new object[] {
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM"});
            this.EarlyOutMorningCutoff.ItemsAppearance.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.EarlyOutMorningCutoff.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EarlyOutMorningCutoff.ItemsAppearance.SelectedFont = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.EarlyOutMorningCutoff.Location = new System.Drawing.Point(220, 322);
            this.EarlyOutMorningCutoff.Margin = new System.Windows.Forms.Padding(0);
            this.EarlyOutMorningCutoff.MaxDropDownItems = 5;
            this.EarlyOutMorningCutoff.Name = "EarlyOutMorningCutoff";
            this.EarlyOutMorningCutoff.Size = new System.Drawing.Size(184, 42);
            this.EarlyOutMorningCutoff.StartIndex = 0;
            this.EarlyOutMorningCutoff.TabIndex = 44;
            this.EarlyOutMorningCutoff.TextOffset = new System.Drawing.Point(10, 0);
            this.EarlyOutMorningCutoff.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.LabelTransition.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(27, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Late Afternoon Cut-off";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LateAfternoonCutOff
            // 
            this.LateAfternoonCutOff.BackColor = System.Drawing.Color.Transparent;
            this.LateAfternoonCutOff.BorderRadius = 5;
            this.LabelTransition.SetDecoration(this.LateAfternoonCutOff, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LateAfternoonCutOff.DisabledState.FillColor = System.Drawing.Color.White;
            this.LateAfternoonCutOff.DisabledState.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.LateAfternoonCutOff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LateAfternoonCutOff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LateAfternoonCutOff.DropDownHeight = 36;
            this.LateAfternoonCutOff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LateAfternoonCutOff.FocusedColor = System.Drawing.Color.Empty;
            this.LateAfternoonCutOff.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.LateAfternoonCutOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.LateAfternoonCutOff.IntegralHeight = false;
            this.LateAfternoonCutOff.ItemHeight = 36;
            this.LateAfternoonCutOff.Items.AddRange(new object[] {
            "1:00 PM",
            "1:15 PM",
            "1:30 PM",
            "1:45 PM",
            "2:00 PM"});
            this.LateAfternoonCutOff.ItemsAppearance.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.LateAfternoonCutOff.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LateAfternoonCutOff.ItemsAppearance.SelectedFont = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.LateAfternoonCutOff.Location = new System.Drawing.Point(220, 243);
            this.LateAfternoonCutOff.Margin = new System.Windows.Forms.Padding(0);
            this.LateAfternoonCutOff.MaxDropDownItems = 5;
            this.LateAfternoonCutOff.Name = "LateAfternoonCutOff";
            this.LateAfternoonCutOff.Size = new System.Drawing.Size(184, 42);
            this.LateAfternoonCutOff.StartIndex = 0;
            this.LateAfternoonCutOff.TabIndex = 42;
            this.LateAfternoonCutOff.TextOffset = new System.Drawing.Point(10, 0);
            this.LateAfternoonCutOff.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.LabelTransition.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(27, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Late Morning Cut-off";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LateMorningCutOff
            // 
            this.LateMorningCutOff.BackColor = System.Drawing.Color.Transparent;
            this.LateMorningCutOff.BorderRadius = 5;
            this.LabelTransition.SetDecoration(this.LateMorningCutOff, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LateMorningCutOff.DisabledState.FillColor = System.Drawing.Color.White;
            this.LateMorningCutOff.DisabledState.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.LateMorningCutOff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LateMorningCutOff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LateMorningCutOff.DropDownHeight = 36;
            this.LateMorningCutOff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LateMorningCutOff.FocusedColor = System.Drawing.Color.Empty;
            this.LateMorningCutOff.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.LateMorningCutOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.LateMorningCutOff.IntegralHeight = false;
            this.LateMorningCutOff.ItemHeight = 36;
            this.LateMorningCutOff.Items.AddRange(new object[] {
            "8:00 AM",
            "8:15 AM",
            "8:30 AM",
            "8:45 AM",
            "9:00 AM"});
            this.LateMorningCutOff.ItemsAppearance.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.LateMorningCutOff.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LateMorningCutOff.ItemsAppearance.SelectedFont = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.LateMorningCutOff.Location = new System.Drawing.Point(220, 160);
            this.LateMorningCutOff.Margin = new System.Windows.Forms.Padding(0);
            this.LateMorningCutOff.MaxDropDownItems = 5;
            this.LateMorningCutOff.Name = "LateMorningCutOff";
            this.LateMorningCutOff.Size = new System.Drawing.Size(184, 42);
            this.LateMorningCutOff.StartIndex = 0;
            this.LateMorningCutOff.TabIndex = 40;
            this.LateMorningCutOff.TextOffset = new System.Drawing.Point(10, 0);
            this.LateMorningCutOff.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // GenderOptions
            // 
            this.GenderOptions.BackColor = System.Drawing.Color.Transparent;
            this.GenderOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.GenderOptions.BorderRadius = 5;
            this.GenderOptions.BorderThickness = 1;
            this.GenderOptions.Controls.Add(this.InOut);
            this.GenderOptions.Controls.Add(this.Full);
            this.LabelTransition.SetDecoration(this.GenderOptions, Guna.UI2.AnimatorNS.DecorationType.None);
            this.GenderOptions.FillColor = System.Drawing.Color.White;
            this.GenderOptions.Location = new System.Drawing.Point(220, 77);
            this.GenderOptions.Name = "GenderOptions";
            this.GenderOptions.Size = new System.Drawing.Size(339, 42);
            this.GenderOptions.TabIndex = 39;
            this.GenderOptions.UseTransparentBackground = true;
            // 
            // InOut
            // 
            this.InOut.AutoSize = true;
            this.InOut.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InOut.CheckedState.BorderThickness = 0;
            this.InOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InOut.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LabelTransition.SetDecoration(this.InOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.InOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.InOut.Location = new System.Drawing.Point(73, 12);
            this.InOut.Name = "InOut";
            this.InOut.Size = new System.Drawing.Size(68, 19);
            this.InOut.TabIndex = 17;
            this.InOut.Text = "IN/OUT";
            this.InOut.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.InOut.UncheckedState.BorderThickness = 2;
            this.InOut.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.InOut.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // Full
            // 
            this.Full.AutoSize = true;
            this.Full.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Full.CheckedState.BorderThickness = 0;
            this.Full.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Full.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LabelTransition.SetDecoration(this.Full, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Full.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Full.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Full.Location = new System.Drawing.Point(200, 12);
            this.Full.Name = "Full";
            this.Full.Size = new System.Drawing.Size(52, 19);
            this.Full.TabIndex = 18;
            this.Full.Text = "FULL";
            this.Full.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Full.UncheckedState.BorderThickness = 2;
            this.Full.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Full.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.LabelTransition.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(27, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Attendance Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.LabelTransition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configure System Settings";
            // 
            // BiometricsTab
            // 
            this.BiometricsTab.BackColor = System.Drawing.SystemColors.Control;
            this.BiometricsTab.Controls.Add(this.panel18);
            this.LabelTransition.SetDecoration(this.BiometricsTab, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BiometricsTab.Location = new System.Drawing.Point(4, 44);
            this.BiometricsTab.Margin = new System.Windows.Forms.Padding(0);
            this.BiometricsTab.Name = "BiometricsTab";
            this.BiometricsTab.Size = new System.Drawing.Size(1083, 698);
            this.BiometricsTab.TabIndex = 2;
            this.BiometricsTab.Text = "Biometrics";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.Control;
            this.panel18.Controls.Add(this.RegisterButton);
            this.panel18.Controls.Add(this.guna2Panel5);
            this.LabelTransition.SetDecoration(this.panel18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1083, 698);
            this.panel18.TabIndex = 1;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Animated = true;
            this.RegisterButton.AnimatedGIF = true;
            this.RegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.BorderRadius = 5;
            this.LabelTransition.SetDecoration(this.RegisterButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.RegisterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(60)))));
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Image = global::ARIAR_PayrollSystem.Properties.Resources.fingerprint_line;
            this.RegisterButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RegisterButton.ImageSize = new System.Drawing.Size(18, 18);
            this.RegisterButton.Location = new System.Drawing.Point(462, 67);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(163, 37);
            this.RegisterButton.TabIndex = 21;
            this.RegisterButton.Text = "Register Biometrics";
            this.RegisterButton.TextOffset = new System.Drawing.Point(8, 0);
            this.RegisterButton.UseTransparentBackground = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderRadius = 8;
            this.guna2Panel5.Controls.Add(this.EmployeeViewScrollBar);
            this.guna2Panel5.Controls.Add(this.ListView);
            this.guna2Panel5.Controls.Add(this.guna2Button5);
            this.guna2Panel5.Controls.Add(this.guna2Separator1);
            this.guna2Panel5.Controls.Add(this.label8);
            this.LabelTransition.SetDecoration(this.guna2Panel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel5.Location = new System.Drawing.Point(26, 31);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel5.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel5.ShadowDecoration.Depth = 15;
            this.guna2Panel5.ShadowDecoration.Enabled = true;
            this.guna2Panel5.Size = new System.Drawing.Size(403, 639);
            this.guna2Panel5.TabIndex = 20;
            this.guna2Panel5.UseTransparentBackground = true;
            // 
            // guna2Button5
            // 
            this.guna2Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button5.Animated = true;
            this.LabelTransition.SetDecoration(this.guna2Button5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = global::ARIAR_PayrollSystem.Properties.Resources.refresh_line_2_;
            this.guna2Button5.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button5.Location = new System.Drawing.Point(363, 0);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(40, 35);
            this.guna2Button5.TabIndex = 4;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTransition.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.FillColor = System.Drawing.Color.SlateGray;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 30);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(403, 10);
            this.guna2Separator1.TabIndex = 2;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.LabelTransition.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(403, 36);
            this.label8.TabIndex = 1;
            this.label8.Text = "Empoyee Logs";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Positions
            // 
            this.Positions.BackColor = System.Drawing.SystemColors.Control;
            this.Positions.Controls.Add(this.panel3);
            this.LabelTransition.SetDecoration(this.Positions, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Positions.Location = new System.Drawing.Point(4, 44);
            this.Positions.Name = "Positions";
            this.Positions.Padding = new System.Windows.Forms.Padding(3);
            this.Positions.Size = new System.Drawing.Size(1083, 698);
            this.Positions.TabIndex = 3;
            this.Positions.Text = "Positions Management";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.guna2Panel1);
            this.panel3.Controls.Add(this.AddPosition);
            this.LabelTransition.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1077, 692);
            this.panel3.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.Controls.Add(this.guna2VScrollBar1);
            this.guna2Panel1.Controls.Add(this.guna2Separator2);
            this.guna2Panel1.Controls.Add(this.DataView);
            this.guna2Panel1.Controls.Add(this.HeaderPanel);
            this.LabelTransition.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(41, 110);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.guna2Panel1.ShadowDecoration.BorderRadius = 11;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.SlateGray;
            this.guna2Panel1.ShadowDecoration.Depth = 15;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(994, 526);
            this.guna2Panel1.TabIndex = 23;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.LabelTransition.SetDecoration(this.guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator2.FillColor = System.Drawing.Color.SlateGray;
            this.guna2Separator2.Location = new System.Drawing.Point(0, 30);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(994, 10);
            this.guna2Separator2.TabIndex = 2;
            this.guna2Separator2.UseTransparentBackground = true;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.HeaderPanel.Controls.Add(this.ColumnHeader);
            this.LabelTransition.SetDecoration(this.HeaderPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Padding = new System.Windows.Forms.Padding(5, 0, 17, 0);
            this.HeaderPanel.Size = new System.Drawing.Size(994, 36);
            this.HeaderPanel.TabIndex = 6;
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
            this.ColumnHeader.Controls.Add(this.label13, 5, 0);
            this.ColumnHeader.Controls.Add(this.label12, 3, 0);
            this.ColumnHeader.Controls.Add(this.label11, 2, 0);
            this.ColumnHeader.Controls.Add(this.label10, 1, 0);
            this.ColumnHeader.Controls.Add(this.label9, 0, 0);
            this.ColumnHeader.Controls.Add(this.label7, 4, 0);
            this.LabelTransition.SetDecoration(this.ColumnHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ColumnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnHeader.Location = new System.Drawing.Point(5, 0);
            this.ColumnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.ColumnHeader.Name = "ColumnHeader";
            this.ColumnHeader.RowCount = 1;
            this.ColumnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ColumnHeader.Size = new System.Drawing.Size(972, 36);
            this.ColumnHeader.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.LabelTransition.SetDecoration(this.label13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(824, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 26);
            this.label13.TabIndex = 13;
            this.label13.Text = "Modified Date";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.LabelTransition.SetDecoration(this.label12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(528, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 26);
            this.label12.TabIndex = 12;
            this.label12.Text = "Date Created";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.LabelTransition.SetDecoration(this.label11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(380, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 26);
            this.label11.TabIndex = 11;
            this.label11.Text = "Created By";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.LabelTransition.SetDecoration(this.label10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(210, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 26);
            this.label10.TabIndex = 10;
            this.label10.Text = "Employees";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.LabelTransition.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(195, 26);
            this.label9.TabIndex = 9;
            this.label9.Text = "Position Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.LabelTransition.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(676, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Modified By";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddPosition
            // 
            this.AddPosition.Animated = true;
            this.AddPosition.AnimatedGIF = true;
            this.AddPosition.BackColor = System.Drawing.Color.Transparent;
            this.AddPosition.BorderRadius = 5;
            this.LabelTransition.SetDecoration(this.AddPosition, Guna.UI2.AnimatorNS.DecorationType.None);
            this.AddPosition.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddPosition.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddPosition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddPosition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddPosition.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.AddPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPosition.ForeColor = System.Drawing.Color.White;
            this.AddPosition.Image = global::ARIAR_PayrollSystem.Properties.Resources.add_line;
            this.AddPosition.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddPosition.ImageSize = new System.Drawing.Size(18, 18);
            this.AddPosition.Location = new System.Drawing.Point(42, 24);
            this.AddPosition.Margin = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.AddPosition.Name = "AddPosition";
            this.AddPosition.Size = new System.Drawing.Size(130, 37);
            this.AddPosition.TabIndex = 22;
            this.AddPosition.Text = "Add Position";
            this.AddPosition.TextOffset = new System.Drawing.Point(8, 0);
            this.AddPosition.UseTransparentBackground = true;
            this.AddPosition.Click += new System.EventHandler(this.AddPosition_Click);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog1.Text = null;
            // 
            // LabelTransition
            // 
            this.LabelTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.LabelTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.LabelTransition.DefaultAnimation = animation1;
            this.LabelTransition.Interval = 11;
            this.LabelTransition.TimeStep = 0.1F;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 11;
            this.guna2Elipse2.TargetControl = this.guna2Panel1;
            // 
            // EmployeeViewScrollBar
            // 
            this.EmployeeViewScrollBar.BindingContainer = this.ListView;
            this.EmployeeViewScrollBar.BorderRadius = 3;
            this.LabelTransition.SetDecoration(this.EmployeeViewScrollBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.EmployeeViewScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmployeeViewScrollBar.FillColor = System.Drawing.Color.White;
            this.EmployeeViewScrollBar.InUpdate = false;
            this.EmployeeViewScrollBar.LargeChange = 10;
            this.EmployeeViewScrollBar.Location = new System.Drawing.Point(391, 36);
            this.EmployeeViewScrollBar.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeViewScrollBar.MaximumSize = new System.Drawing.Size(12, 0);
            this.EmployeeViewScrollBar.MinimumSize = new System.Drawing.Size(12, 0);
            this.EmployeeViewScrollBar.Name = "EmployeeViewScrollBar";
            this.EmployeeViewScrollBar.ScrollbarSize = 12;
            this.EmployeeViewScrollBar.Size = new System.Drawing.Size(12, 0);
            this.EmployeeViewScrollBar.TabIndex = 5;
            this.EmployeeViewScrollBar.ThumbColor = System.Drawing.Color.SlateGray;
            this.EmployeeViewScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // ListView
            // 
            this.ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView.AutoScroll = true;
            this.ListView.BackColor = System.Drawing.Color.White;
            this.LabelTransition.SetDecoration(this.ListView, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ListView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ListView.Location = new System.Drawing.Point(0, 36);
            this.ListView.Margin = new System.Windows.Forms.Padding(0);
            this.ListView.Name = "ListView";
            this.ListView.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.ListView.Size = new System.Drawing.Size(403, 603);
            this.ListView.TabIndex = 1;
            this.ListView.WrapContents = false;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2VScrollBar1.BindingContainer = this.DataView;
            this.guna2VScrollBar1.BorderRadius = 5;
            this.LabelTransition.SetDecoration(this.guna2VScrollBar1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.White;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(982, 36);
            this.guna2VScrollBar1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2VScrollBar1.MaximumSize = new System.Drawing.Size(12, 0);
            this.guna2VScrollBar1.MinimumSize = new System.Drawing.Size(12, 0);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 12;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(12, 0);
            this.guna2VScrollBar1.TabIndex = 5;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.SlateGray;
            this.guna2VScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // DataView
            // 
            this.DataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataView.AutoScroll = true;
            this.DataView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DataView.BackColor = System.Drawing.Color.White;
            this.LabelTransition.SetDecoration(this.DataView, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DataView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DataView.Location = new System.Drawing.Point(0, 36);
            this.DataView.Margin = new System.Windows.Forms.Padding(0);
            this.DataView.Name = "DataView";
            this.DataView.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.DataView.Size = new System.Drawing.Size(994, 485);
            this.DataView.TabIndex = 1;
            this.DataView.WrapContents = false;
            this.DataView.SizeChanged += new System.EventHandler(this.DataView_SizeChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 13;
            this.guna2Elipse1.TargetControl = this.ListView;
            // 
            // SystemMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1091, 746);
            this.Controls.Add(this.panel1);
            this.LabelTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SystemMaintenance";
            this.Text = "SystemMaintenance";
            this.Load += new System.EventHandler(this.SystemMaintenance_Load);
            this.panel1.ResumeLayout(false);
            this.SystemMaintenanceTabs.ResumeLayout(false);
            this.SystemSettings.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GenderOptions.ResumeLayout(false);
            this.GenderOptions.PerformLayout();
            this.BiometricsTab.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.Positions.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.ColumnHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TabControl SystemMaintenanceTabs;
        private System.Windows.Forms.TabPage SystemSettings;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2Transition LabelTransition;
        private System.Windows.Forms.TabPage BiometricsTab;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TabPage Positions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel GenderOptions;
        private Guna.UI2.WinForms.Guna2RadioButton InOut;
        private Guna.UI2.WinForms.Guna2RadioButton Full;
        private Guna.UI2.WinForms.Guna2ComboBox LateMorningCutOff;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox LateAfternoonCutOff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox EarlyOutAfternoonCutOff;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox EarlyOutMorningCutoff;
        private Guna.UI2.WinForms.Guna2Button SaveSettingsButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2VScrollBar EmployeeViewScrollBar;
        private UserControls.CustomFlowLayoutPanel ListView;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button RegisterButton;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button AddPosition;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private UserControls.CustomFlowLayoutPanel DataView;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.TableLayoutPanel ColumnHeader;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}