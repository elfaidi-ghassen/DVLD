namespace Winform_UI.Forms.InternationalLicense
{
    partial class AddInternationalDrivingLicenseForm
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
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.drivingLicenseControl1 = new Winform_UI.Controls.DrivingLicenseControl();
            this.internationalApplicationInfo1 = new Winform_UI.Controls.InternationalApplicationInfo();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnShow = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(53)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(142, 12);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(793, 68);
            this.guna2HtmlLabel2.TabIndex = 7;
            this.guna2HtmlLabel2.Text = "International License Application";
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2NumericUpDown1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2NumericUpDown1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2NumericUpDown1.DisabledState.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.guna2NumericUpDown1.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.guna2NumericUpDown1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2NumericUpDown1.FocusedState.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2NumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(190, 123);
            this.guna2NumericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.ShadowDecoration.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(382, 45);
            this.guna2NumericUpDown1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "LicenseID";
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(923, 123);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(148, 45);
            this.guna2Button2.TabIndex = 13;
            this.guna2Button2.Text = "Find";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(1490, 650);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(148, 45);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.DarkGray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(29, 650);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(148, 45);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // drivingLicenseControl1
            // 
            this.drivingLicenseControl1.Location = new System.Drawing.Point(12, 153);
            this.drivingLicenseControl1.Name = "drivingLicenseControl1";
            this.drivingLicenseControl1.Size = new System.Drawing.Size(1080, 504);
            this.drivingLicenseControl1.TabIndex = 8;
            // 
            // internationalApplicationInfo1
            // 
            this.internationalApplicationInfo1.BackColor = System.Drawing.Color.Transparent;
            this.internationalApplicationInfo1.Location = new System.Drawing.Point(1075, 171);
            this.internationalApplicationInfo1.Name = "internationalApplicationInfo1";
            this.internationalApplicationInfo1.Size = new System.Drawing.Size(563, 464);
            this.internationalApplicationInfo1.TabIndex = 14;
            // 
            // btnHistory
            // 
            this.btnHistory.CheckedState.Parent = this.btnHistory;
            this.btnHistory.CustomImages.Parent = this.btnHistory;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.HoverState.Parent = this.btnHistory;
            this.btnHistory.Location = new System.Drawing.Point(1053, 650);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.ShadowDecoration.Parent = this.btnHistory;
            this.btnHistory.Size = new System.Drawing.Size(148, 45);
            this.btnHistory.TabIndex = 16;
            this.btnHistory.Text = "History";
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnShow
            // 
            this.btnShow.CheckedState.Parent = this.btnShow;
            this.btnShow.CustomImages.Parent = this.btnShow;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.HoverState.Parent = this.btnShow;
            this.btnShow.Location = new System.Drawing.Point(1218, 650);
            this.btnShow.Name = "btnShow";
            this.btnShow.ShadowDecoration.Parent = this.btnShow;
            this.btnShow.Size = new System.Drawing.Size(254, 45);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Show International License";
            this.btnShow.Click += new System.EventHandler(this.showLicense_Click);
            // 
            // AddInternationalDrivingLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 708);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2NumericUpDown1);
            this.Controls.Add(this.drivingLicenseControl1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.internationalApplicationInfo1);
            this.Name = "AddInternationalDrivingLicenseForm";
            this.Text = "AddInternationalDrivingLicenseForm";
            this.Load += new System.EventHandler(this.AddInternationalDrivingLicenseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Controls.DrivingLicenseControl drivingLicenseControl1;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Controls.InternationalApplicationInfo internationalApplicationInfo1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnHistory;
        private Guna.UI2.WinForms.Guna2Button btnShow;
    }
}