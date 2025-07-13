namespace Winform_UI.Forms
{
    partial class UserDetails
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
            this.personInfo1 = new Winform_UI.Controls.PersonInfo();
            this.loginInfo1 = new Winform_UI.Controls.LoginInfo();
            this.SuspendLayout();
            // 
            // personInfo1
            // 
            this.personInfo1.BackColor = System.Drawing.Color.Transparent;
            this.personInfo1.Location = new System.Drawing.Point(2, 12);
            this.personInfo1.Name = "personInfo1";
            this.personInfo1.Size = new System.Drawing.Size(914, 386);
            this.personInfo1.TabIndex = 0;
            // 
            // loginInfo1
            // 
            this.loginInfo1.BackColor = System.Drawing.Color.Transparent;
            this.loginInfo1.Location = new System.Drawing.Point(7, 367);
            this.loginInfo1.Name = "loginInfo1";
            this.loginInfo1.Size = new System.Drawing.Size(892, 158);
            this.loginInfo1.TabIndex = 1;
            this.loginInfo1.Load += new System.EventHandler(this.loginInfo1_Load);
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 525);
            this.Controls.Add(this.loginInfo1);
            this.Controls.Add(this.personInfo1);
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.PersonInfo personInfo1;
        private Controls.LoginInfo loginInfo1;
    }
}