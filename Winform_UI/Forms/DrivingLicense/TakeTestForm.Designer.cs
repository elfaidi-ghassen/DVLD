namespace Winform_UI.Forms.DrivingLicense
{
    partial class TakeTestForm
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
            this.testGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.labelFees = new System.Windows.Forms.Label();
            this.labelTrial = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelDriverClass = new System.Windows.Forms.Label();
            this.labelDLAppId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTestId = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.radioPass = new System.Windows.Forms.RadioButton();
            this.radioFail = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.testGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // testGroupBox
            // 
            this.testGroupBox.Controls.Add(this.labelDate);
            this.testGroupBox.Controls.Add(this.labelTestId);
            this.testGroupBox.Controls.Add(this.labelFees);
            this.testGroupBox.Controls.Add(this.labelTrial);
            this.testGroupBox.Controls.Add(this.labelFullName);
            this.testGroupBox.Controls.Add(this.labelDriverClass);
            this.testGroupBox.Controls.Add(this.label2);
            this.testGroupBox.Controls.Add(this.labelDLAppId);
            this.testGroupBox.Controls.Add(this.label7);
            this.testGroupBox.Controls.Add(this.label6);
            this.testGroupBox.Controls.Add(this.label5);
            this.testGroupBox.Controls.Add(this.label4);
            this.testGroupBox.Controls.Add(this.label3);
            this.testGroupBox.Controls.Add(this.label);
            this.testGroupBox.Controls.Add(this.label1);
            this.testGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.testGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.testGroupBox.Location = new System.Drawing.Point(14, 12);
            this.testGroupBox.Name = "testGroupBox";
            this.testGroupBox.ShadowDecoration.Parent = this.testGroupBox;
            this.testGroupBox.Size = new System.Drawing.Size(627, 508);
            this.testGroupBox.TabIndex = 1;
            this.testGroupBox.Text = "Take Test";
            // 
            // btnSave
            // 
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(490, 704);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(151, 40);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelFees
            // 
            this.labelFees.AutoSize = true;
            this.labelFees.BackColor = System.Drawing.Color.Transparent;
            this.labelFees.CausesValidation = false;
            this.labelFees.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFees.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelFees.Location = new System.Drawing.Point(226, 406);
            this.labelFees.Name = "labelFees";
            this.labelFees.Size = new System.Drawing.Size(46, 27);
            this.labelFees.TabIndex = 21;
            this.labelFees.Text = "[...]";
            // 
            // labelTrial
            // 
            this.labelTrial.AutoSize = true;
            this.labelTrial.BackColor = System.Drawing.Color.Transparent;
            this.labelTrial.CausesValidation = false;
            this.labelTrial.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrial.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelTrial.Location = new System.Drawing.Point(226, 308);
            this.labelTrial.Name = "labelTrial";
            this.labelTrial.Size = new System.Drawing.Size(46, 27);
            this.labelTrial.TabIndex = 21;
            this.labelTrial.Text = "[...]";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.BackColor = System.Drawing.Color.Transparent;
            this.labelFullName.CausesValidation = false;
            this.labelFullName.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelFullName.Location = new System.Drawing.Point(226, 260);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(46, 27);
            this.labelFullName.TabIndex = 21;
            this.labelFullName.Text = "[...]";
            // 
            // labelDriverClass
            // 
            this.labelDriverClass.AutoSize = true;
            this.labelDriverClass.BackColor = System.Drawing.Color.Transparent;
            this.labelDriverClass.CausesValidation = false;
            this.labelDriverClass.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDriverClass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDriverClass.Location = new System.Drawing.Point(226, 214);
            this.labelDriverClass.Name = "labelDriverClass";
            this.labelDriverClass.Size = new System.Drawing.Size(46, 27);
            this.labelDriverClass.TabIndex = 21;
            this.labelDriverClass.Text = "[...]";
            // 
            // labelDLAppId
            // 
            this.labelDLAppId.AutoSize = true;
            this.labelDLAppId.BackColor = System.Drawing.Color.Transparent;
            this.labelDLAppId.CausesValidation = false;
            this.labelDLAppId.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDLAppId.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDLAppId.Location = new System.Drawing.Point(226, 169);
            this.labelDLAppId.Name = "labelDLAppId";
            this.labelDLAppId.Size = new System.Drawing.Size(46, 27);
            this.labelDLAppId.TabIndex = 21;
            this.labelDLAppId.Text = "[...]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(124, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 33);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fees:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(124, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 33);
            this.label6.TabIndex = 21;
            this.label6.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(10, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 33);
            this.label5.TabIndex = 21;
            this.label5.Text = "Previous trials:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(110, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 33);
            this.label4.TabIndex = 21;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(88, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "D. Class:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label.Location = new System.Drawing.Point(45, 163);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(160, 33);
            this.label.TabIndex = 21;
            this.label.Text = "DL. App. ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 72);
            this.label1.TabIndex = 17;
            this.label1.Text = "Scheduled Test";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.CausesValidation = false;
            this.labelDate.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDate.Location = new System.Drawing.Point(226, 358);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 27);
            this.labelDate.TabIndex = 22;
            this.labelDate.Text = "[...]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(99, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "Test ID:";
            // 
            // labelTestId
            // 
            this.labelTestId.AutoSize = true;
            this.labelTestId.BackColor = System.Drawing.Color.Transparent;
            this.labelTestId.CausesValidation = false;
            this.labelTestId.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestId.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelTestId.Location = new System.Drawing.Point(226, 447);
            this.labelTestId.Name = "labelTestId";
            this.labelTestId.Size = new System.Drawing.Size(46, 27);
            this.labelTestId.TabIndex = 21;
            this.labelTestId.Text = "[...]";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(322, 704);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(151, 40);
            this.guna2Button1.TabIndex = 24;
            this.guna2Button1.Text = "Close";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(59, 538);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 33);
            this.label8.TabIndex = 23;
            this.label8.Text = "Result:";
            // 
            // radioPass
            // 
            this.radioPass.AutoSize = true;
            this.radioPass.Checked = true;
            this.radioPass.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPass.Location = new System.Drawing.Point(274, 541);
            this.radioPass.Name = "radioPass";
            this.radioPass.Size = new System.Drawing.Size(83, 31);
            this.radioPass.TabIndex = 25;
            this.radioPass.TabStop = true;
            this.radioPass.Text = "Pass";
            this.radioPass.UseVisualStyleBackColor = true;
            // 
            // radioFail
            // 
            this.radioFail.AutoSize = true;
            this.radioFail.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFail.Location = new System.Drawing.Point(184, 541);
            this.radioFail.Name = "radioFail";
            this.radioFail.Size = new System.Drawing.Size(72, 31);
            this.radioFail.TabIndex = 25;
            this.radioFail.TabStop = true;
            this.radioFail.Text = "Fail";
            this.radioFail.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(59, 585);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 33);
            this.label9.TabIndex = 23;
            this.label9.Text = "Notes:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(161, 593);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(480, 96);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // TakeTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 756);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.radioFail);
            this.Controls.Add(this.radioPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.testGroupBox);
            this.Controls.Add(this.btnSave);
            this.Name = "TakeTestForm";
            this.Text = "TakeTestForm";
            this.testGroupBox.ResumeLayout(false);
            this.testGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox testGroupBox;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label labelFees;
        private System.Windows.Forms.Label labelTrial;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelDriverClass;
        private System.Windows.Forms.Label labelDLAppId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTestId;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioPass;
        private System.Windows.Forms.RadioButton radioFail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}