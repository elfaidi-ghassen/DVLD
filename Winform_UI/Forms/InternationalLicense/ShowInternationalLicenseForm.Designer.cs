namespace Winform_UI.Forms.InternationalLicense
{
    partial class ShowInternationalLicenseForm
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
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.internationalLicenseControl1 = new Winform_UI.Forms.InternationalLicense.InternationalLicenseControl();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(53)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(280, 12);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(505, 68);
            this.guna2HtmlLabel2.TabIndex = 8;
            this.guna2HtmlLabel2.Text = "International License";
            // 
            // internationalLicenseControl1
            // 
            this.internationalLicenseControl1.BackColor = System.Drawing.Color.Transparent;
            this.internationalLicenseControl1.Location = new System.Drawing.Point(12, 74);
            this.internationalLicenseControl1.Name = "internationalLicenseControl1";
            this.internationalLicenseControl1.Size = new System.Drawing.Size(1046, 381);
            this.internationalLicenseControl1.TabIndex = 0;
            this.internationalLicenseControl1.Load += new System.EventHandler(this.internationalLicenseControl1_Load);
            // 
            // ShowInternationalLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 461);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.internationalLicenseControl1);
            this.Name = "ShowInternationalLicenseForm";
            this.Text = "ShowInternationalLicenseForm";
            this.Load += new System.EventHandler(this.ShowInternationalLicenseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InternationalLicenseControl internationalLicenseControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}