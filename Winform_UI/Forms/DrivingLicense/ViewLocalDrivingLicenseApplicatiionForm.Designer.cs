namespace Winform_UI.Forms.DrivingLicense
{
    partial class ViewLocalDrivingLicenseApplicatiionForm
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
            this.applicationInfo1 = new Winform_UI.Controls.ApplicationInfo();
            this.drivingLicenseApplicationForm1 = new Winform_UI.Controls.DrivingLicenseApplicationForm();
            this.SuspendLayout();
            // 
            // applicationInfo1
            // 
            this.applicationInfo1.BackColor = System.Drawing.Color.Transparent;
            this.applicationInfo1.Location = new System.Drawing.Point(12, 12);
            this.applicationInfo1.Name = "applicationInfo1";
            this.applicationInfo1.Size = new System.Drawing.Size(952, 370);
            this.applicationInfo1.TabIndex = 0;
            this.applicationInfo1.Load += new System.EventHandler(this.applicationInfo1_Load);
            // 
            // drivingLicenseApplicationForm1
            // 
            this.drivingLicenseApplicationForm1.Location = new System.Drawing.Point(12, 363);
            this.drivingLicenseApplicationForm1.Name = "drivingLicenseApplicationForm1";
            this.drivingLicenseApplicationForm1.Size = new System.Drawing.Size(949, 201);
            this.drivingLicenseApplicationForm1.TabIndex = 1;
            this.drivingLicenseApplicationForm1.Load += new System.EventHandler(this.drivingLicenseApplicationForm1_Load);
            // 
            // ViewLocalDrivingLicenseApplicatiionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 570);
            this.Controls.Add(this.drivingLicenseApplicationForm1);
            this.Controls.Add(this.applicationInfo1);
            this.Name = "ViewLocalDrivingLicenseApplicatiionForm";
            this.Text = "ViewLocalDrivingLicenseApplicatiionForm";
            this.Load += new System.EventHandler(this.ViewLocalDrivingLicenseApplicatiionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ApplicationInfo applicationInfo1;
        private Controls.DrivingLicenseApplicationForm drivingLicenseApplicationForm1;
    }
}