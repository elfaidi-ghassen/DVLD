namespace Winform_UI.Forms.DrivingLicense
{
    partial class IssueDrivingLicenseFirstTimeForm
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
            this.label = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // applicationInfo1
            // 
            this.applicationInfo1.BackColor = System.Drawing.Color.Transparent;
            this.applicationInfo1.Location = new System.Drawing.Point(19, 219);
            this.applicationInfo1.Name = "applicationInfo1";
            this.applicationInfo1.Size = new System.Drawing.Size(952, 370);
            this.applicationInfo1.TabIndex = 0;
            // 
            // drivingLicenseApplicationForm1
            // 
            this.drivingLicenseApplicationForm1.Location = new System.Drawing.Point(19, 12);
            this.drivingLicenseApplicationForm1.Name = "drivingLicenseApplicationForm1";
            this.drivingLicenseApplicationForm1.Size = new System.Drawing.Size(949, 201);
            this.drivingLicenseApplicationForm1.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label.Location = new System.Drawing.Point(13, 576);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 33);
            this.label.TabIndex = 22;
            this.label.Text = "Notes:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(124, 584);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(835, 112);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(640, 713);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(151, 40);
            this.guna2Button1.TabIndex = 26;
            this.guna2Button1.Text = "Close";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(808, 713);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(151, 40);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // IssueDrivingLicenseFirstTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 756);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.drivingLicenseApplicationForm1);
            this.Controls.Add(this.applicationInfo1);
            this.Name = "IssueDrivingLicenseFirstTimeForm";
            this.Text = "IssueDrivingLicenseFirstTimeForm";
            this.Load += new System.EventHandler(this.IssueDrivingLicenseFirstTimeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ApplicationInfo applicationInfo1;
        private Controls.DrivingLicenseApplicationForm drivingLicenseApplicationForm1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}