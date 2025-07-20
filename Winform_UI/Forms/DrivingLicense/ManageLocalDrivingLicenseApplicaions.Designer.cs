namespace Winform_UI.Forms.DrivingLicense
{
    partial class ManageLocalDrivingLicenseApplicaions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filterCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelCountRecords = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteApplicatioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoryTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practicalTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicensefirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHisotryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterStatusCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.filterNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.filterTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(1019, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(151, 40);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "Filter by";
            // 
            // filterCombo
            // 
            this.filterCombo.BackColor = System.Drawing.Color.Transparent;
            this.filterCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterCombo.FocusedColor = System.Drawing.Color.Empty;
            this.filterCombo.FocusedState.Parent = this.filterCombo;
            this.filterCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filterCombo.FormattingEnabled = true;
            this.filterCombo.HoverState.Parent = this.filterCombo;
            this.filterCombo.ItemHeight = 30;
            this.filterCombo.ItemsAppearance.Parent = this.filterCombo;
            this.filterCombo.Location = new System.Drawing.Point(173, 122);
            this.filterCombo.Name = "filterCombo";
            this.filterCombo.ShadowDecoration.Parent = this.filterCombo;
            this.filterCombo.Size = new System.Drawing.Size(249, 36);
            this.filterCombo.TabIndex = 19;
            this.filterCombo.SelectedIndexChanged += new System.EventHandler(this.filterCombo_SelectedIndexChanged);
            // 
            // labelCountRecords
            // 
            this.labelCountRecords.AutoSize = true;
            this.labelCountRecords.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountRecords.Location = new System.Drawing.Point(47, 534);
            this.labelCountRecords.Name = "labelCountRecords";
            this.labelCountRecords.Size = new System.Drawing.Size(173, 33);
            this.labelCountRecords.TabIndex = 18;
            this.labelCountRecords.Text = "# Records: xx";
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Gray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(1019, 534);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(151, 40);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(951, 72);
            this.label1.TabIndex = 16;
            this.label1.Text = "Local Driving License Applications";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.ColumnHeadersHeight = 40;
            this.dgvData.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvData.Location = new System.Drawing.Point(53, 170);
            this.dgvData.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1117, 356);
            this.dgvData.TabIndex = 15;
            this.dgvData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvData.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvData.ThemeStyle.ReadOnly = true;
            this.dgvData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvData.ThemeStyle.RowsStyle.Height = 28;
            this.dgvData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteApplicatioToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.scheduleTestToolStripMenuItem,
            this.toolStripMenuItem4,
            this.issueDrivingLicensefirstTimeToolStripMenuItem,
            this.toolStripMenuItem3,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHisotryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(359, 285);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = global::Winform_UI.Properties.Resources.patient_information;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(358, 32);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(355, 6);
            // 
            // deleteApplicatioToolStripMenuItem
            // 
            this.deleteApplicatioToolStripMenuItem.Image = global::Winform_UI.Properties.Resources.trash_can;
            this.deleteApplicatioToolStripMenuItem.Name = "deleteApplicatioToolStripMenuItem";
            this.deleteApplicatioToolStripMenuItem.Size = new System.Drawing.Size(358, 32);
            this.deleteApplicatioToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicatioToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicatioToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::Winform_UI.Properties.Resources.cancel;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(358, 32);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(355, 6);
            // 
            // scheduleTestToolStripMenuItem
            // 
            this.scheduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.theoryTestToolStripMenuItem,
            this.practicalTestToolStripMenuItem});
            this.scheduleTestToolStripMenuItem.Image = global::Winform_UI.Properties.Resources._event;
            this.scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            this.scheduleTestToolStripMenuItem.Size = new System.Drawing.Size(358, 32);
            this.scheduleTestToolStripMenuItem.Text = "Schedule Test";
            // 
            // visionTestToolStripMenuItem
            // 
            this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            this.visionTestToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.visionTestToolStripMenuItem.Text = "Vision Test";
            this.visionTestToolStripMenuItem.Click += new System.EventHandler(this.visionTestToolStripMenuItem_Click);
            // 
            // theoryTestToolStripMenuItem
            // 
            this.theoryTestToolStripMenuItem.Name = "theoryTestToolStripMenuItem";
            this.theoryTestToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.theoryTestToolStripMenuItem.Text = "Theory Test";
            this.theoryTestToolStripMenuItem.Click += new System.EventHandler(this.theoryTestToolStripMenuItem_Click);
            // 
            // practicalTestToolStripMenuItem
            // 
            this.practicalTestToolStripMenuItem.Name = "practicalTestToolStripMenuItem";
            this.practicalTestToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.practicalTestToolStripMenuItem.Text = "Practical Test";
            this.practicalTestToolStripMenuItem.Click += new System.EventHandler(this.practicalTestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(355, 6);
            // 
            // issueDrivingLicensefirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicensefirstTimeToolStripMenuItem.Image = global::Winform_UI.Properties.Resources.add;
            this.issueDrivingLicensefirstTimeToolStripMenuItem.Name = "issueDrivingLicensefirstTimeToolStripMenuItem";
            this.issueDrivingLicensefirstTimeToolStripMenuItem.Size = new System.Drawing.Size(358, 32);
            this.issueDrivingLicensefirstTimeToolStripMenuItem.Text = "Issue Driving License (first time)";
            this.issueDrivingLicensefirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicensefirstTimeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(355, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::Winform_UI.Properties.Resources.crm;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(358, 32);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            // 
            // showPersonLicenseHisotryToolStripMenuItem
            // 
            this.showPersonLicenseHisotryToolStripMenuItem.Image = global::Winform_UI.Properties.Resources.history;
            this.showPersonLicenseHisotryToolStripMenuItem.Name = "showPersonLicenseHisotryToolStripMenuItem";
            this.showPersonLicenseHisotryToolStripMenuItem.Size = new System.Drawing.Size(358, 32);
            this.showPersonLicenseHisotryToolStripMenuItem.Text = "Show Person License Hisotry";
            // 
            // filterStatusCombo
            // 
            this.filterStatusCombo.BackColor = System.Drawing.Color.Transparent;
            this.filterStatusCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterStatusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterStatusCombo.FocusedColor = System.Drawing.Color.Empty;
            this.filterStatusCombo.FocusedState.Parent = this.filterStatusCombo;
            this.filterStatusCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterStatusCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filterStatusCombo.FormattingEnabled = true;
            this.filterStatusCombo.HoverState.Parent = this.filterStatusCombo;
            this.filterStatusCombo.ItemHeight = 30;
            this.filterStatusCombo.ItemsAppearance.Parent = this.filterStatusCombo;
            this.filterStatusCombo.Location = new System.Drawing.Point(440, 122);
            this.filterStatusCombo.Name = "filterStatusCombo";
            this.filterStatusCombo.ShadowDecoration.Parent = this.filterStatusCombo;
            this.filterStatusCombo.Size = new System.Drawing.Size(163, 36);
            this.filterStatusCombo.TabIndex = 24;
            this.filterStatusCombo.SelectedIndexChanged += new System.EventHandler(this.filterStatusCombo_SelectedIndexChanged);
            // 
            // filterNumber
            // 
            this.filterNumber.BackColor = System.Drawing.Color.Transparent;
            this.filterNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filterNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.filterNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.filterNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filterNumber.DisabledState.Parent = this.filterNumber;
            this.filterNumber.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.filterNumber.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.filterNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterNumber.FocusedState.Parent = this.filterNumber;
            this.filterNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.filterNumber.Location = new System.Drawing.Point(440, 122);
            this.filterNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.filterNumber.Name = "filterNumber";
            this.filterNumber.ShadowDecoration.Parent = this.filterNumber;
            this.filterNumber.Size = new System.Drawing.Size(300, 36);
            this.filterNumber.TabIndex = 23;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filterTextBox.DefaultText = "";
            this.filterTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.filterTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.filterTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filterTextBox.DisabledState.Parent = this.filterTextBox;
            this.filterTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filterTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterTextBox.FocusedState.Parent = this.filterTextBox;
            this.filterTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterTextBox.HoverState.Parent = this.filterTextBox;
            this.filterTextBox.Location = new System.Drawing.Point(465, 122);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.PasswordChar = '\0';
            this.filterTextBox.PlaceholderText = "";
            this.filterTextBox.SelectedText = "";
            this.filterTextBox.ShadowDecoration.Parent = this.filterTextBox;
            this.filterTextBox.Size = new System.Drawing.Size(300, 36);
            this.filterTextBox.TabIndex = 22;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // ManageLocalDrivingLicenseApplicaions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 582);
            this.Controls.Add(this.filterStatusCombo);
            this.Controls.Add(this.filterNumber);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterCombo);
            this.Controls.Add(this.labelCountRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.Name = "ManageLocalDrivingLicenseApplicaions";
            this.Text = "ManageLocalDrivingLicenseApplicaions";
            this.Load += new System.EventHandler(this.ManageLocalDrivingLicenseApplicaions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox filterCombo;
        private System.Windows.Forms.Label labelCountRecords;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvData;
        private Guna.UI2.WinForms.Guna2ComboBox filterStatusCombo;
        private Guna.UI2.WinForms.Guna2NumericUpDown filterNumber;
        private Guna.UI2.WinForms.Guna2TextBox filterTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicatioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoryTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practicalTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicensefirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHisotryToolStripMenuItem;
    }
}