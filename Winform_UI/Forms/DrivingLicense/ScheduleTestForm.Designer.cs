namespace Winform_UI.Forms.DrivingLicense
{
    partial class ScheduleTestForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.testGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // testGroupBox
            // 
            this.testGroupBox.Controls.Add(this.dateTimePicker1);
            this.testGroupBox.Controls.Add(this.btnSave);
            this.testGroupBox.Controls.Add(this.labelFees);
            this.testGroupBox.Controls.Add(this.labelTrial);
            this.testGroupBox.Controls.Add(this.labelFullName);
            this.testGroupBox.Controls.Add(this.labelDriverClass);
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
            this.testGroupBox.Location = new System.Drawing.Point(13, 13);
            this.testGroupBox.Name = "testGroupBox";
            this.testGroupBox.ShadowDecoration.Parent = this.testGroupBox;
            this.testGroupBox.Size = new System.Drawing.Size(627, 544);
            this.testGroupBox.TabIndex = 0;
            this.testGroupBox.Text = "Test";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 358);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 31);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(464, 471);
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
            this.labelFees.Location = new System.Drawing.Point(226, 401);
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
            this.labelFullName.Location = new System.Drawing.Point(226, 254);
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
            this.labelDriverClass.Location = new System.Drawing.Point(226, 208);
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
            this.labelDLAppId.Location = new System.Drawing.Point(226, 163);
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
            this.label1.Location = new System.Drawing.Point(83, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 72);
            this.label1.TabIndex = 17;
            this.label1.Text = "Schedule Test";
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Gray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(234, 568);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(151, 40);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ScheduleTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 620);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.testGroupBox);
            this.Name = "ScheduleTestForm";
            this.Text = "ScheduleTestForm";
            this.testGroupBox.ResumeLayout(false);
            this.testGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox testGroupBox;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDLAppId;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelFees;
        private System.Windows.Forms.Label labelTrial;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelDriverClass;
    }
}