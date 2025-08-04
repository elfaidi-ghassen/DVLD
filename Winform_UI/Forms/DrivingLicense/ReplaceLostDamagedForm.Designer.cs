namespace Winform_UI.Forms.DrivingLicense
{
    partial class ReplaceLostDamagedForm
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
            this.btnRenew = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabelLicense = new System.Windows.Forms.LinkLabel();
            this.linkLabelHistory = new System.Windows.Forms.LinkLabel();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericInput = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.drivingLicenseControl = new Winform_UI.Controls.DrivingLicenseControl();
            this.radLost = new System.Windows.Forms.RadioButton();
            this.radDamaged = new System.Windows.Forms.RadioButton();
            this.LostDamagedApplicationControl = new Winform_UI.Controls.ReplaceLostDamagedApplicationForm();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenew
            // 
            this.btnRenew.CheckedState.Parent = this.btnRenew;
            this.btnRenew.CustomImages.Parent = this.btnRenew;
            this.btnRenew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRenew.ForeColor = System.Drawing.Color.White;
            this.btnRenew.HoverState.Parent = this.btnRenew;
            this.btnRenew.Location = new System.Drawing.Point(936, 730);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.ShadowDecoration.Parent = this.btnRenew;
            this.btnRenew.Size = new System.Drawing.Size(127, 45);
            this.btnRenew.TabIndex = 26;
            this.btnRenew.Text = "Renew";
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(803, 731);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(127, 45);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // linkLabelLicense
            // 
            this.linkLabelLicense.AutoSize = true;
            this.linkLabelLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLicense.Location = new System.Drawing.Point(593, 740);
            this.linkLabelLicense.Name = "linkLabelLicense";
            this.linkLabelLicense.Size = new System.Drawing.Size(187, 26);
            this.linkLabelLicense.TabIndex = 24;
            this.linkLabelLicense.TabStop = true;
            this.linkLabelLicense.Text = "Show new license";
            this.linkLabelLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLicense_LinkClicked);
            // 
            // linkLabelHistory
            // 
            this.linkLabelHistory.AutoSize = true;
            this.linkLabelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHistory.Location = new System.Drawing.Point(331, 740);
            this.linkLabelHistory.Name = "linkLabelHistory";
            this.linkLabelHistory.Size = new System.Drawing.Size(222, 26);
            this.linkLabelHistory.TabIndex = 25;
            this.linkLabelHistory.TabStop = true;
            this.linkLabelHistory.Text = "Show License Hisotry";
            this.linkLabelHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHistory_LinkClicked);
            // 
            // btnFind
            // 
            this.btnFind.CheckedState.Parent = this.btnFind;
            this.btnFind.CustomImages.Parent = this.btnFind;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.HoverState.Parent = this.btnFind;
            this.btnFind.Location = new System.Drawing.Point(396, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.ShadowDecoration.Parent = this.btnFind;
            this.btnFind.Size = new System.Drawing.Size(148, 45);
            this.btnFind.TabIndex = 23;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 22;
            this.label1.Text = "LicenseID";
            // 
            // numericInput
            // 
            this.numericInput.BackColor = System.Drawing.Color.Transparent;
            this.numericInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numericInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numericInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numericInput.DisabledState.Parent = this.numericInput;
            this.numericInput.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numericInput.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numericInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numericInput.FocusedState.Parent = this.numericInput;
            this.numericInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numericInput.Location = new System.Drawing.Point(179, 22);
            this.numericInput.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericInput.Name = "numericInput";
            this.numericInput.ShadowDecoration.Parent = this.numericInput;
            this.numericInput.Size = new System.Drawing.Size(211, 45);
            this.numericInput.TabIndex = 21;
            // 
            // drivingLicenseControl
            // 
            this.drivingLicenseControl.Location = new System.Drawing.Point(2, 54);
            this.drivingLicenseControl.Name = "drivingLicenseControl";
            this.drivingLicenseControl.Size = new System.Drawing.Size(1080, 504);
            this.drivingLicenseControl.TabIndex = 20;
            // 
            // radLost
            // 
            this.radLost.AutoSize = true;
            this.radLost.Checked = true;
            this.radLost.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLost.Location = new System.Drawing.Point(619, 29);
            this.radLost.Name = "radLost";
            this.radLost.Size = new System.Drawing.Size(161, 31);
            this.radLost.TabIndex = 28;
            this.radLost.TabStop = true;
            this.radLost.Text = "Lost License";
            this.radLost.UseVisualStyleBackColor = true;
            this.radLost.CheckedChanged += new System.EventHandler(this.radLost_CheckedChanged);
            // 
            // radDamaged
            // 
            this.radDamaged.AutoSize = true;
            this.radDamaged.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDamaged.Location = new System.Drawing.Point(794, 29);
            this.radDamaged.Name = "radDamaged";
            this.radDamaged.Size = new System.Drawing.Size(220, 31);
            this.radDamaged.TabIndex = 28;
            this.radDamaged.Text = "Damaged License";
            this.radDamaged.UseVisualStyleBackColor = true;
            this.radDamaged.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // replaceLostDamagedApplicationForm1
            // 
            this.LostDamagedApplicationControl.ApplicationDate = new System.DateTime(((long)(0)));
            this.LostDamagedApplicationControl.ApplicationFees = null;
            this.LostDamagedApplicationControl.BackColor = System.Drawing.Color.Transparent;
            this.LostDamagedApplicationControl.ExpirationDate = new System.DateTime(((long)(0)));
            this.LostDamagedApplicationControl.Initialized = false;
            this.LostDamagedApplicationControl.Location = new System.Drawing.Point(13, 544);
            this.LostDamagedApplicationControl.Name = "replaceLostDamagedApplicationForm1";
            this.LostDamagedApplicationControl.NewLocalApplicationID = null;
            this.LostDamagedApplicationControl.OldLicenseID = null;
            this.LostDamagedApplicationControl.ReplacedLicenseID = null;
            this.LostDamagedApplicationControl.Size = new System.Drawing.Size(1050, 180);
            this.LostDamagedApplicationControl.TabIndex = 29;
            this.LostDamagedApplicationControl.UserId = null;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(794, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(220, 31);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.Text = "Damaged License";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ReplaceLostDamagedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 786);
            this.Controls.Add(this.LostDamagedApplicationControl);
            this.Controls.Add(this.radDamaged);
            this.Controls.Add(this.radLost);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.linkLabelLicense);
            this.Controls.Add(this.linkLabelHistory);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericInput);
            this.Controls.Add(this.drivingLicenseControl);
            this.Name = "ReplaceLostDamagedForm";
            this.Text = "ReplaceLostDamagedForm";
            this.Load += new System.EventHandler(this.ReplaceLostDamagedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnRenew;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.LinkLabel linkLabelLicense;
        private System.Windows.Forms.LinkLabel linkLabelHistory;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericInput;
        private Controls.DrivingLicenseControl drivingLicenseControl;
        private System.Windows.Forms.RadioButton radLost;
        private System.Windows.Forms.RadioButton radDamaged;
        private Controls.ReplaceLostDamagedApplicationForm LostDamagedApplicationControl;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}