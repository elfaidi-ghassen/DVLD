namespace Winform_UI.Forms.DrivingLicense
{
    partial class ShowDrivingLicenseForm
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
            this.drivingLicenseControl1 = new Winform_UI.Controls.DrivingLicenseControl();
            this.SuspendLayout();
            // 
            // drivingLicenseControl1
            // 
            this.drivingLicenseControl1.Location = new System.Drawing.Point(-10, -12);
            this.drivingLicenseControl1.Name = "drivingLicenseControl1";
            this.drivingLicenseControl1.Size = new System.Drawing.Size(1080, 504);
            this.drivingLicenseControl1.TabIndex = 0;
            // 
            // ShowDrivingLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 482);
            this.Controls.Add(this.drivingLicenseControl1);
            this.Name = "ShowDrivingLicenseForm";
            this.Text = "ShowDrivingLicenseForm";
            this.Load += new System.EventHandler(this.ShowDrivingLicenseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DrivingLicenseControl drivingLicenseControl1;
    }
}