namespace Winform_UI.Forms.DrivingLicense
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonSelect = new System.Windows.Forms.TabPage();
            this.tabApplication = new System.Windows.Forms.TabPage();
            this.userChoosePerson1 = new Winform_UI.Controls.UserChoosePerson();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelApplicationDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCreatedBy = new System.Windows.Forms.Label();
            this.comboLicenseClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPersonSelect.SuspendLayout();
            this.tabApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Montserrat SemiBold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(271, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(478, 72);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "[PLACEHOLDER]";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPersonSelect);
            this.tabControl1.Controls.Add(this.tabApplication);
            this.tabControl1.Location = new System.Drawing.Point(12, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 531);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPersonSelect
            // 
            this.tabPersonSelect.Controls.Add(this.btnNext);
            this.tabPersonSelect.Controls.Add(this.userChoosePerson1);
            this.tabPersonSelect.Location = new System.Drawing.Point(4, 29);
            this.tabPersonSelect.Name = "tabPersonSelect";
            this.tabPersonSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonSelect.Size = new System.Drawing.Size(932, 498);
            this.tabPersonSelect.TabIndex = 0;
            this.tabPersonSelect.Text = "Person information";
            this.tabPersonSelect.UseVisualStyleBackColor = true;
            // 
            // tabApplication
            // 
            this.tabApplication.Controls.Add(this.comboLicenseClass);
            this.tabApplication.Controls.Add(this.label5);
            this.tabApplication.Controls.Add(this.label4);
            this.tabApplication.Controls.Add(this.label3);
            this.tabApplication.Controls.Add(this.label2);
            this.tabApplication.Controls.Add(this.label9);
            this.tabApplication.Controls.Add(this.labelCreatedBy);
            this.tabApplication.Controls.Add(this.label7);
            this.tabApplication.Controls.Add(this.labelApplicationDate);
            this.tabApplication.Controls.Add(this.label1);
            this.tabApplication.Controls.Add(this.guna2Button3);
            this.tabApplication.Controls.Add(this.guna2Button2);
            this.tabApplication.Location = new System.Drawing.Point(4, 29);
            this.tabApplication.Name = "tabApplication";
            this.tabApplication.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplication.Size = new System.Drawing.Size(932, 498);
            this.tabApplication.TabIndex = 1;
            this.tabApplication.Text = "Application";
            this.tabApplication.UseVisualStyleBackColor = true;
            // 
            // userChoosePerson1
            // 
            this.userChoosePerson1.BackColor = System.Drawing.Color.White;
            this.userChoosePerson1.ChosenId = null;
            this.userChoosePerson1.Location = new System.Drawing.Point(18, 6);
            this.userChoosePerson1.Name = "userChoosePerson1";
            this.userChoosePerson1.Size = new System.Drawing.Size(933, 443);
            this.userChoosePerson1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(792, 448);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(123, 35);
            this.btnNext.TabIndex = 32;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.Gray;
            this.guna2Button3.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(621, 437);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(131, 39);
            this.guna2Button3.TabIndex = 10;
            this.guna2Button3.Text = "Cancel";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(777, 437);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(131, 39);
            this.guna2Button2.TabIndex = 9;
            this.guna2Button2.Text = "Save";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "D.L. Application ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Application Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "License Class: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Application Fees: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Created By:";
            // 
            // labelApplicationDate
            // 
            this.labelApplicationDate.AutoSize = true;
            this.labelApplicationDate.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationDate.Location = new System.Drawing.Point(326, 89);
            this.labelApplicationDate.Name = "labelApplicationDate";
            this.labelApplicationDate.Size = new System.Drawing.Size(46, 33);
            this.labelApplicationDate.TabIndex = 11;
            this.labelApplicationDate.Text = "[...]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 33);
            this.label7.TabIndex = 11;
            this.label7.Text = "[...]";
            // 
            // labelCreatedBy
            // 
            this.labelCreatedBy.AutoSize = true;
            this.labelCreatedBy.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedBy.Location = new System.Drawing.Point(326, 208);
            this.labelCreatedBy.Name = "labelCreatedBy";
            this.labelCreatedBy.Size = new System.Drawing.Size(46, 33);
            this.labelCreatedBy.TabIndex = 11;
            this.labelCreatedBy.Text = "[...]";
            // 
            // comboLicenseClass
            // 
            this.comboLicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.comboLicenseClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLicenseClass.FocusedColor = System.Drawing.Color.Empty;
            this.comboLicenseClass.FocusedState.Parent = this.comboLicenseClass;
            this.comboLicenseClass.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLicenseClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboLicenseClass.FormattingEnabled = true;
            this.comboLicenseClass.HoverState.Parent = this.comboLicenseClass;
            this.comboLicenseClass.ItemHeight = 30;
            this.comboLicenseClass.ItemsAppearance.Parent = this.comboLicenseClass;
            this.comboLicenseClass.Location = new System.Drawing.Point(330, 169);
            this.comboLicenseClass.Name = "comboLicenseClass";
            this.comboLicenseClass.ShadowDecoration.Parent = this.comboLicenseClass;
            this.comboLicenseClass.Size = new System.Drawing.Size(292, 36);
            this.comboLicenseClass.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 33);
            this.label9.TabIndex = 11;
            this.label9.Text = "[...]";
            // 
            // DrivingLicenseApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 670);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelTitle);
            this.Name = "DrivingLicenseApplicationForm";
            this.Text = "DrivingLicenseApplicationForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPersonSelect.ResumeLayout(false);
            this.tabApplication.ResumeLayout(false);
            this.tabApplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPersonSelect;
        private System.Windows.Forms.TabPage tabApplication;
        private Controls.UserChoosePerson userChoosePerson1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox comboLicenseClass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelCreatedBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelApplicationDate;
    }
}