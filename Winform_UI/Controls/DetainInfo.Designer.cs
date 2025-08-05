namespace Winform_UI.Controls
{
    partial class DetainInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.labelDetainID = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelCreatedBy = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDetainDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLicenseID = new System.Windows.Forms.Label();
            this.tbFineAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.tbFineAmount);
            this.guna2GroupBox1.Controls.Add(this.labelDetainID);
            this.guna2GroupBox1.Controls.Add(this.label);
            this.guna2GroupBox1.Controls.Add(this.labelLicenseID);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.labelCreatedBy);
            this.guna2GroupBox1.Controls.Add(this.label13);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.labelDetainDate);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1033, 181);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Detain info";
            // 
            // labelDetainID
            // 
            this.labelDetainID.AutoSize = true;
            this.labelDetainID.BackColor = System.Drawing.Color.Transparent;
            this.labelDetainID.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetainID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDetainID.Location = new System.Drawing.Point(199, 62);
            this.labelDetainID.Name = "labelDetainID";
            this.labelDetainID.Size = new System.Drawing.Size(42, 30);
            this.labelDetainID.TabIndex = 21;
            this.labelDetainID.Text = "[...]";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label.Location = new System.Drawing.Point(33, 62);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(124, 30);
            this.label.TabIndex = 24;
            this.label.Text = "Detain ID:";
            // 
            // labelCreatedBy
            // 
            this.labelCreatedBy.AutoSize = true;
            this.labelCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.labelCreatedBy.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCreatedBy.Location = new System.Drawing.Point(827, 92);
            this.labelCreatedBy.Name = "labelCreatedBy";
            this.labelCreatedBy.Size = new System.Drawing.Size(42, 30);
            this.labelCreatedBy.TabIndex = 19;
            this.labelCreatedBy.Text = "[...]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(582, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 30);
            this.label13.TabIndex = 23;
            this.label13.Text = "Created By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(34, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Detain Date:";
            // 
            // labelDetainDate
            // 
            this.labelDetainDate.AutoSize = true;
            this.labelDetainDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDetainDate.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetainDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDetainDate.Location = new System.Drawing.Point(208, 92);
            this.labelDetainDate.Name = "labelDetainDate";
            this.labelDetainDate.Size = new System.Drawing.Size(42, 30);
            this.labelDetainDate.TabIndex = 20;
            this.labelDetainDate.Text = "[...]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(33, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fine amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(582, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "License ID:";
            // 
            // labelLicenseID
            // 
            this.labelLicenseID.AutoSize = true;
            this.labelLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.labelLicenseID.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLicenseID.Location = new System.Drawing.Point(827, 62);
            this.labelLicenseID.Name = "labelLicenseID";
            this.labelLicenseID.Size = new System.Drawing.Size(42, 30);
            this.labelLicenseID.TabIndex = 19;
            this.labelLicenseID.Text = "[...]";
            // 
            // tbFineAmount
            // 
            this.tbFineAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFineAmount.DefaultText = "";
            this.tbFineAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFineAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFineAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFineAmount.DisabledState.Parent = this.tbFineAmount;
            this.tbFineAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFineAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFineAmount.FocusedState.Parent = this.tbFineAmount;
            this.tbFineAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFineAmount.HoverState.Parent = this.tbFineAmount;
            this.tbFineAmount.Location = new System.Drawing.Point(213, 133);
            this.tbFineAmount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbFineAmount.Name = "tbFineAmount";
            this.tbFineAmount.PasswordChar = '\0';
            this.tbFineAmount.PlaceholderText = "";
            this.tbFineAmount.SelectedText = "";
            this.tbFineAmount.ShadowDecoration.Parent = this.tbFineAmount;
            this.tbFineAmount.Size = new System.Drawing.Size(247, 29);
            this.tbFineAmount.TabIndex = 25;
            // 
            // DetainInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "DetainInfo";
            this.Size = new System.Drawing.Size(1042, 249);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label labelDetainID;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelCreatedBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDetainDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLicenseID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbFineAmount;
    }
}
