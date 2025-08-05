namespace Winform_UI.Forms.DetainedLicenses
{
    partial class ReleaseLicenseForm
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
            this.btnRelease = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputLicenseID = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.drivingLicenseControl1 = new Winform_UI.Controls.DrivingLicenseControl();
            this.releaseDetainedApplication1 = new Winform_UI.Controls.ReleaseDetainedApplication();
            ((System.ComponentModel.ISupportInitialize)(this.inputLicenseID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRelease
            // 
            this.btnRelease.CheckedState.Parent = this.btnRelease;
            this.btnRelease.CustomImages.Parent = this.btnRelease;
            this.btnRelease.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRelease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRelease.ForeColor = System.Drawing.Color.White;
            this.btnRelease.HoverState.Parent = this.btnRelease;
            this.btnRelease.Location = new System.Drawing.Point(939, 766);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.ShadowDecoration.Parent = this.btnRelease;
            this.btnRelease.Size = new System.Drawing.Size(127, 45);
            this.btnRelease.TabIndex = 30;
            this.btnRelease.Text = "Release";
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(806, 767);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(127, 45);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFind
            // 
            this.btnFind.CheckedState.Parent = this.btnFind;
            this.btnFind.CustomImages.Parent = this.btnFind;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.HoverState.Parent = this.btnFind;
            this.btnFind.Location = new System.Drawing.Point(924, 17);
            this.btnFind.Name = "btnFind";
            this.btnFind.ShadowDecoration.Parent = this.btnFind;
            this.btnFind.Size = new System.Drawing.Size(148, 45);
            this.btnFind.TabIndex = 28;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 27;
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
            this.inputLicenseID.Location = new System.Drawing.Point(191, 17);
            this.inputLicenseID.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.inputLicenseID.Name = "inputLicenseID";
            this.inputLicenseID.ShadowDecoration.Parent = this.inputLicenseID;
            this.inputLicenseID.Size = new System.Drawing.Size(382, 45);
            this.inputLicenseID.TabIndex = 26;
            // 
            // drivingLicenseControl1
            // 
            this.drivingLicenseControl1.Location = new System.Drawing.Point(12, 51);
            this.drivingLicenseControl1.Name = "drivingLicenseControl1";
            this.drivingLicenseControl1.Size = new System.Drawing.Size(1080, 504);
            this.drivingLicenseControl1.TabIndex = 25;
            // 
            // releaseDetainedApplication1
            // 
            this.releaseDetainedApplication1.ApplicationFees = null;
            this.releaseDetainedApplication1.BackColor = System.Drawing.Color.Transparent;
            this.releaseDetainedApplication1.CreatedByUserId = null;
            this.releaseDetainedApplication1.DetainDate = null;
            this.releaseDetainedApplication1.DetainID = null;
            this.releaseDetainedApplication1.FineAmount = null;
            this.releaseDetainedApplication1.LicenseID = null;
            this.releaseDetainedApplication1.Location = new System.Drawing.Point(31, 540);
            this.releaseDetainedApplication1.Name = "releaseDetainedApplication1";
            this.releaseDetainedApplication1.ReleaseApplicationID = null;
            this.releaseDetainedApplication1.Size = new System.Drawing.Size(1039, 219);
            this.releaseDetainedApplication1.TabIndex = 32;
            this.releaseDetainedApplication1.TotalFees = null;
            // 
            // ReleaseLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 819);
            this.Controls.Add(this.releaseDetainedApplication1);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputLicenseID);
            this.Controls.Add(this.drivingLicenseControl1);
            this.Name = "ReleaseLicenseForm";
            this.Text = "ReleaseLicenseForm";
            ((System.ComponentModel.ISupportInitialize)(this.inputLicenseID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnRelease;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown inputLicenseID;
        private Controls.DrivingLicenseControl drivingLicenseControl1;
        private Controls.ReleaseDetainedApplication releaseDetainedApplication1;
    }
}