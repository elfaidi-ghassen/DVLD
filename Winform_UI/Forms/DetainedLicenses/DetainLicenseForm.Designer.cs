namespace Winform_UI.Forms.DetainedLicenses
{
    partial class DetainLicenseForm
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
            this.inputLicenseID = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnDetain = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabelHistory = new System.Windows.Forms.LinkLabel();
            this.detainInfo1 = new Winform_UI.Controls.DetainInfo();
            this.drivingLicenseControl1 = new Winform_UI.Controls.DrivingLicenseControl();
            ((System.ComponentModel.ISupportInitialize)(this.inputLicenseID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.CheckedState.Parent = this.btnFind;
            this.btnFind.CustomImages.Parent = this.btnFind;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.HoverState.Parent = this.btnFind;
            this.btnFind.Location = new System.Drawing.Point(914, 18);
            this.btnFind.Name = "btnFind";
            this.btnFind.ShadowDecoration.Parent = this.btnFind;
            this.btnFind.Size = new System.Drawing.Size(148, 45);
            this.btnFind.TabIndex = 17;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "LicenseID";
            // 
            // inputLicenseID
            // 
            this.inputLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.inputLicenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputLicenseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputLicenseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputLicenseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputLicenseID.DisabledState.Parent = this.inputLicenseID;
            this.inputLicenseID.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.inputLicenseID.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.inputLicenseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputLicenseID.FocusedState.Parent = this.inputLicenseID;
            this.inputLicenseID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.inputLicenseID.Location = new System.Drawing.Point(181, 18);
            this.inputLicenseID.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.inputLicenseID.Name = "inputLicenseID";
            this.inputLicenseID.ShadowDecoration.Parent = this.inputLicenseID;
            this.inputLicenseID.Size = new System.Drawing.Size(382, 45);
            this.inputLicenseID.TabIndex = 15;
            // 
            // btnDetain
            // 
            this.btnDetain.CheckedState.Parent = this.btnDetain;
            this.btnDetain.CustomImages.Parent = this.btnDetain;
            this.btnDetain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnDetain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetain.ForeColor = System.Drawing.Color.White;
            this.btnDetain.HoverState.Parent = this.btnDetain;
            this.btnDetain.Location = new System.Drawing.Point(933, 744);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.ShadowDecoration.Parent = this.btnDetain;
            this.btnDetain.Size = new System.Drawing.Size(127, 45);
            this.btnDetain.TabIndex = 22;
            this.btnDetain.Text = "Detain";
            this.btnDetain.Click += new System.EventHandler(this.DetainButtonClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(800, 745);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(127, 45);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // linkLabelHistory
            // 
            this.linkLabelHistory.AutoSize = true;
            this.linkLabelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHistory.Location = new System.Drawing.Point(572, 763);
            this.linkLabelHistory.Name = "linkLabelHistory";
            this.linkLabelHistory.Size = new System.Drawing.Size(222, 26);
            this.linkLabelHistory.TabIndex = 21;
            this.linkLabelHistory.TabStop = true;
            this.linkLabelHistory.Text = "Show License Hisotry";
            this.linkLabelHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHistory_LinkClicked);
            // 
            // detainInfo1
            // 
            this.detainInfo1.BackColor = System.Drawing.Color.Transparent;
            this.detainInfo1.CreatedByUserId = null;
            this.detainInfo1.DetainDate = null;
            this.detainInfo1.DetainID = null;
            this.detainInfo1.LicenseID = null;
            this.detainInfo1.Location = new System.Drawing.Point(22, 545);
            this.detainInfo1.Name = "detainInfo1";
            this.detainInfo1.Size = new System.Drawing.Size(1042, 249);
            this.detainInfo1.TabIndex = 24;
            // 
            // drivingLicenseControl1
            // 
            this.drivingLicenseControl1.Location = new System.Drawing.Point(2, 52);
            this.drivingLicenseControl1.Name = "drivingLicenseControl1";
            this.drivingLicenseControl1.Size = new System.Drawing.Size(1080, 504);
            this.drivingLicenseControl1.TabIndex = 14;
            // 
            // DetainLicenseForm
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 802);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.linkLabelHistory);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputLicenseID);
            this.Controls.Add(this.detainInfo1);
            this.Controls.Add(this.drivingLicenseControl1);
            this.Name = "DetainLicenseForm";
            this.Text = "DetainLicenseForm";
            ((System.ComponentModel.ISupportInitialize)(this.inputLicenseID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnFind;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown inputLicenseID;
        private Controls.DrivingLicenseControl drivingLicenseControl1;
        private Guna.UI2.WinForms.Guna2Button btnDetain;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.LinkLabel linkLabelHistory;
        private Controls.DetainInfo detainInfo1;
    }
}