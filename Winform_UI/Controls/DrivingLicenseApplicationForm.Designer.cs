namespace Winform_UI.Controls
{
    partial class DrivingLicenseApplicationForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.labelPassedTests = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.labelPassedTests);
            this.guna2GroupBox1.Controls.Add(this.labelClass);
            this.guna2GroupBox1.Controls.Add(this.labelID);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(941, 196);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Driving License Applicaion info";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(480, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "Passed Tests:";
            // 
            // labelPassedTests
            // 
            this.labelPassedTests.AutoSize = true;
            this.labelPassedTests.BackColor = System.Drawing.Color.Transparent;
            this.labelPassedTests.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassedTests.Location = new System.Drawing.Point(647, 73);
            this.labelPassedTests.Name = "labelPassedTests";
            this.labelPassedTests.Size = new System.Drawing.Size(42, 30);
            this.labelPassedTests.TabIndex = 0;
            this.labelPassedTests.Text = "[...]";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.BackColor = System.Drawing.Color.Transparent;
            this.labelClass.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(196, 126);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(42, 30);
            this.labelClass.TabIndex = 0;
            this.labelClass.Text = "[...]";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(196, 73);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(42, 30);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "[...]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "DL.A. ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Class:";
            // 
            // DrivingLicenseApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "DrivingLicenseApplicationForm";
            this.Size = new System.Drawing.Size(949, 201);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPassedTests;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}
