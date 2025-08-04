namespace Winform_UI.Forms.DrivingLicense
{
    partial class RenewLocalDrivingLicenseForm
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
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericInput = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.linkLabelHistory = new System.Windows.Forms.LinkLabel();
            this.linkLabelLicense = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnRenew = new Guna.UI2.WinForms.Guna2Button();
            this.renewLicenseApp1 = new Winform_UI.Forms.InternationalLicense.RenewLicenseApp();
            this.drivingLicenseControl = new Winform_UI.Controls.DrivingLicenseControl();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.CheckedState.Parent = this.btnFind;
            this.btnFind.CustomImages.Parent = this.btnFind;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.HoverState.Parent = this.btnFind;
            this.btnFind.Location = new System.Drawing.Point(908, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.ShadowDecoration.Parent = this.btnFind;
            this.btnFind.Size = new System.Drawing.Size(148, 45);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "LicenseID";
            // 
            // numericInput
            // 
            this.numericInput.BackColor = System.Drawing.Color.Transparent;
            this.numericInput.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.numericInput.Location = new System.Drawing.Point(175, 25);
            this.numericInput.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericInput.Name = "numericInput";
            this.numericInput.ShadowDecoration.Parent = this.numericInput;
            this.numericInput.Size = new System.Drawing.Size(382, 45);
            this.numericInput.TabIndex = 14;
            // 
            // linkLabelHistory
            // 
            this.linkLabelHistory.AutoSize = true;
            this.linkLabelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHistory.Location = new System.Drawing.Point(314, 921);
            this.linkLabelHistory.Name = "linkLabelHistory";
            this.linkLabelHistory.Size = new System.Drawing.Size(222, 26);
            this.linkLabelHistory.TabIndex = 18;
            this.linkLabelHistory.TabStop = true;
            this.linkLabelHistory.Text = "Show License Hisotry";
            this.linkLabelHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabelLicense
            // 
            this.linkLabelLicense.AutoSize = true;
            this.linkLabelLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLicense.Location = new System.Drawing.Point(576, 921);
            this.linkLabelLicense.Name = "linkLabelLicense";
            this.linkLabelLicense.Size = new System.Drawing.Size(187, 26);
            this.linkLabelLicense.TabIndex = 18;
            this.linkLabelLicense.TabStop = true;
            this.linkLabelLicense.Text = "Show new license";
            this.linkLabelLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(792, 903);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(127, 45);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.CheckedState.Parent = this.btnRenew;
            this.btnRenew.CustomImages.Parent = this.btnRenew;
            this.btnRenew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRenew.ForeColor = System.Drawing.Color.White;
            this.btnRenew.HoverState.Parent = this.btnRenew;
            this.btnRenew.Location = new System.Drawing.Point(925, 902);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.ShadowDecoration.Parent = this.btnRenew;
            this.btnRenew.Size = new System.Drawing.Size(127, 45);
            this.btnRenew.TabIndex = 19;
            this.btnRenew.Text = "Renew";
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // renewLicenseApp1
            // 
            this.renewLicenseApp1.applicationDate = new System.DateTime(((long)(0)));
            this.renewLicenseApp1.applicationFees = null;
            this.renewLicenseApp1.newLocalApplicationID = null;
            this.renewLicenseApp1.BackColor = System.Drawing.Color.Transparent;
            this.renewLicenseApp1.expirationDate = new System.DateTime(((long)(0)));
            this.renewLicenseApp1.initalized = false;
            this.renewLicenseApp1.issueDate = new System.DateTime(((long)(0)));
            this.renewLicenseApp1.LicenseFees = null;
            this.renewLicenseApp1.Location = new System.Drawing.Point(21, 551);
            this.renewLicenseApp1.Name = "renewLicenseApp1";
            this.renewLicenseApp1.oldLicenseID = null;
            this.renewLicenseApp1.RenewLicenseID = null;
            this.renewLicenseApp1.Size = new System.Drawing.Size(1044, 350);
            this.renewLicenseApp1.TabIndex = 17;
            this.renewLicenseApp1.TotalFees = null;
            this.renewLicenseApp1.userId = null;
            // 
            // drivingLicenseControl
            // 
            this.drivingLicenseControl.Location = new System.Drawing.Point(-2, 57);
            this.drivingLicenseControl.Name = "drivingLicenseControl";
            this.drivingLicenseControl.Size = new System.Drawing.Size(1080, 504);
            this.drivingLicenseControl.TabIndex = 0;
            // 
            // RenewLocalDrivingLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 959);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.linkLabelLicense);
            this.Controls.Add(this.linkLabelHistory);
            this.Controls.Add(this.renewLicenseApp1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericInput);
            this.Controls.Add(this.drivingLicenseControl);
            this.Name = "RenewLocalDrivingLicenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RenewLocalDrivingLicenseForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DrivingLicenseControl drivingLicenseControl;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericInput;
        private InternationalLicense.RenewLicenseApp renewLicenseApp1;
        private System.Windows.Forms.LinkLabel linkLabelHistory;
        private System.Windows.Forms.LinkLabel linkLabelLicense;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnRenew;
    }
}