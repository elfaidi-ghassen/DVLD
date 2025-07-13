namespace Winform_UI.Forms
{
    partial class PersonInfoForm
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
            this.personInfo = new Winform_UI.Controls.PersonInfo();
            this.SuspendLayout();
            // 
            // personInfo
            // 
            this.personInfo.BackColor = System.Drawing.Color.Transparent;
            this.personInfo.Location = new System.Drawing.Point(2, 3);
            this.personInfo.Name = "personInfo";
            this.personInfo.Size = new System.Drawing.Size(914, 386);
            this.personInfo.TabIndex = 0;
            // 
            // PersonInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 384);
            this.Controls.Add(this.personInfo);
            this.Name = "PersonInfoForm";
            this.Text = "PersonInfoForm";
            this.Load += new System.EventHandler(this.PersonInfoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.PersonInfo personInfo;
    }
}