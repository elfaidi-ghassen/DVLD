namespace Winform_UI.Forms.DrivingLicense
{
    partial class ShowDrivingLicenseHistoryForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personInfo1 = new Winform_UI.Controls.PersonInfo();
            this.licensesHistory1 = new Winform_UI.Controls.LicensesHistory();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Montserrat SemiBold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(290, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(439, 72);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "License History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Winform_UI.Properties.Resources.history1;
            this.pictureBox1.Location = new System.Drawing.Point(213, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // personInfo1
            // 
            this.personInfo1.BackColor = System.Drawing.Color.Transparent;
            this.personInfo1.Location = new System.Drawing.Point(85, 93);
            this.personInfo1.Name = "personInfo1";
            this.personInfo1.Size = new System.Drawing.Size(914, 386);
            this.personInfo1.TabIndex = 15;
            // 
            // licensesHistory1
            // 
            this.licensesHistory1.Location = new System.Drawing.Point(4, 456);
            this.licensesHistory1.Name = "licensesHistory1";
            this.licensesHistory1.Size = new System.Drawing.Size(1058, 405);
            this.licensesHistory1.TabIndex = 13;
            this.licensesHistory1.Load += new System.EventHandler(this.licensesHistory1_Load);
            // 
            // ShowDrivingLicenseHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 788);
            this.Controls.Add(this.licensesHistory1);
            this.Controls.Add(this.personInfo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitle);
            this.Name = "ShowDrivingLicenseHistoryForm";
            this.Text = "ShowDrivingLicenseHistoryForm";
            this.Load += new System.EventHandler(this.ShowDrivingLicenseHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private Controls.LicensesHistory licensesHistory1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.PersonInfo personInfo1;
    }
}