namespace Util
{
    partial class FilterBox
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
            this.filterSubCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.filterNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.filterTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filterCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.filterNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // filterSubCombo
            // 
            this.filterSubCombo.BackColor = System.Drawing.Color.Transparent;
            this.filterSubCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterSubCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterSubCombo.FocusedColor = System.Drawing.Color.Empty;
            this.filterSubCombo.FocusedState.Parent = this.filterSubCombo;
            this.filterSubCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterSubCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filterSubCombo.FormattingEnabled = true;
            this.filterSubCombo.HoverState.Parent = this.filterSubCombo;
            this.filterSubCombo.ItemHeight = 30;
            this.filterSubCombo.ItemsAppearance.Parent = this.filterSubCombo;
            this.filterSubCombo.Location = new System.Drawing.Point(337, 13);
            this.filterSubCombo.Name = "filterSubCombo";
            this.filterSubCombo.ShadowDecoration.Parent = this.filterSubCombo;
            this.filterSubCombo.Size = new System.Drawing.Size(163, 36);
            this.filterSubCombo.TabIndex = 29;
            // 
            // filterNumber
            // 
            this.filterNumber.BackColor = System.Drawing.Color.Transparent;
            this.filterNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filterNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.filterNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.filterNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filterNumber.DisabledState.Parent = this.filterNumber;
            this.filterNumber.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.filterNumber.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.filterNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterNumber.FocusedState.Parent = this.filterNumber;
            this.filterNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.filterNumber.Location = new System.Drawing.Point(337, 15);
            this.filterNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.filterNumber.Name = "filterNumber";
            this.filterNumber.ShadowDecoration.Parent = this.filterNumber;
            this.filterNumber.Size = new System.Drawing.Size(300, 36);
            this.filterNumber.TabIndex = 28;
            this.filterNumber.ValueChanged += new System.EventHandler(this.OnFilterNumberValueChange);
            this.filterNumber.Validated += new System.EventHandler(this.OnValidatedFilterNumber);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filterTextBox.DefaultText = "";
            this.filterTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.filterTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.filterTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filterTextBox.DisabledState.Parent = this.filterTextBox;
            this.filterTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filterTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterTextBox.FocusedState.Parent = this.filterTextBox;
            this.filterTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterTextBox.HoverState.Parent = this.filterTextBox;
            this.filterTextBox.Location = new System.Drawing.Point(338, 13);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.PasswordChar = '\0';
            this.filterTextBox.PlaceholderText = "";
            this.filterTextBox.SelectedText = "";
            this.filterTextBox.ShadowDecoration.Parent = this.filterTextBox;
            this.filterTextBox.Size = new System.Drawing.Size(300, 36);
            this.filterTextBox.TabIndex = 27;
            this.filterTextBox.TextChanged += new System.EventHandler(this.OnTextChangedFilterTextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 26;
            this.label2.Text = "Filter by";
            // 
            // filterCombo
            // 
            this.filterCombo.BackColor = System.Drawing.Color.Transparent;
            this.filterCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterCombo.FocusedColor = System.Drawing.Color.Empty;
            this.filterCombo.FocusedState.Parent = this.filterCombo;
            this.filterCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filterCombo.FormattingEnabled = true;
            this.filterCombo.HoverState.Parent = this.filterCombo;
            this.filterCombo.ItemHeight = 30;
            this.filterCombo.ItemsAppearance.Parent = this.filterCombo;
            this.filterCombo.Location = new System.Drawing.Point(121, 14);
            this.filterCombo.Name = "filterCombo";
            this.filterCombo.ShadowDecoration.Parent = this.filterCombo;
            this.filterCombo.Size = new System.Drawing.Size(203, 36);
            this.filterCombo.TabIndex = 25;
            this.filterCombo.SelectedIndexChanged += new System.EventHandler(this.OnFilterComboSelectedIndexChanged);
            // 
            // FilterBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterSubCombo);
            this.Controls.Add(this.filterNumber);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterCombo);
            this.Name = "FilterBox";
            this.Size = new System.Drawing.Size(645, 56);
            this.Load += new System.EventHandler(this.OnFilterBoxLoad);
            ((System.ComponentModel.ISupportInitialize)(this.filterNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox filterSubCombo;
        private Guna.UI2.WinForms.Guna2NumericUpDown filterNumber;
        private Guna.UI2.WinForms.Guna2TextBox filterTextBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox filterCombo;
    }
}
