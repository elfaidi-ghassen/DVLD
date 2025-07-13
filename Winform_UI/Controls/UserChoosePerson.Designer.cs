namespace Winform_UI.Controls
{
    partial class UserChoosePerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.personInfo1 = new Winform_UI.Controls.PersonInfo();
            this.filterGroup = new Guna.UI2.WinForms.Guna2GroupBox();
            this.filterGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find By";
            // 
            // comboFilter
            // 
            this.comboFilter.BackColor = System.Drawing.Color.Transparent;
            this.comboFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilter.FocusedColor = System.Drawing.Color.Empty;
            this.comboFilter.FocusedState.Parent = this.comboFilter;
            this.comboFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.HoverState.Parent = this.comboFilter;
            this.comboFilter.ItemHeight = 30;
            this.comboFilter.Items.AddRange(new object[] {
            "National Number",
            "Person ID"});
            this.comboFilter.ItemsAppearance.Parent = this.comboFilter;
            this.comboFilter.Location = new System.Drawing.Point(113, 21);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.ShadowDecoration.Parent = this.comboFilter;
            this.comboFilter.Size = new System.Drawing.Size(208, 36);
            this.comboFilter.TabIndex = 2;
            this.comboFilter.SelectedIndexChanged += new System.EventHandler(this.comboFilter_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox.DefaultText = "";
            this.textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox.DisabledState.Parent = this.textBox;
            this.textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox.FocusedState.Parent = this.textBox;
            this.textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox.HoverState.Parent = this.textBox;
            this.textBox.Location = new System.Drawing.Point(353, 21);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '\0';
            this.textBox.PlaceholderText = "";
            this.textBox.SelectedText = "";
            this.textBox.ShadowDecoration.Parent = this.textBox;
            this.textBox.Size = new System.Drawing.Size(305, 36);
            this.textBox.TabIndex = 3;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.DimGray;
            this.guna2Button1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(712, 21);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(72, 36);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Find";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(790, 21);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(72, 36);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "New";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // personInfo1
            // 
            this.personInfo1.BackColor = System.Drawing.Color.Transparent;
            this.personInfo1.Location = new System.Drawing.Point(19, 77);
            this.personInfo1.Name = "personInfo1";
            this.personInfo1.Size = new System.Drawing.Size(914, 386);
            this.personInfo1.TabIndex = 0;
            this.personInfo1.Load += new System.EventHandler(this.personInfo1_Load);
            // 
            // filterGroup
            // 
            this.filterGroup.Controls.Add(this.textBox);
            this.filterGroup.Controls.Add(this.guna2Button2);
            this.filterGroup.Controls.Add(this.label1);
            this.filterGroup.Controls.Add(this.guna2Button1);
            this.filterGroup.Controls.Add(this.comboFilter);
            this.filterGroup.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.filterGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.filterGroup.Location = new System.Drawing.Point(34, 3);
            this.filterGroup.Name = "filterGroup";
            this.filterGroup.ShadowDecoration.Parent = this.filterGroup;
            this.filterGroup.Size = new System.Drawing.Size(872, 75);
            this.filterGroup.TabIndex = 5;
            this.filterGroup.Click += new System.EventHandler(this.filterGroup_Click);
            // 
            // UserChoosePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.filterGroup);
            this.Controls.Add(this.personInfo1);
            this.Name = "UserChoosePerson";
            this.Size = new System.Drawing.Size(933, 443);
            this.filterGroup.ResumeLayout(false);
            this.filterGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonInfo personInfo1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox comboFilter;
        private Guna.UI2.WinForms.Guna2TextBox textBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2GroupBox filterGroup;
    }
}
