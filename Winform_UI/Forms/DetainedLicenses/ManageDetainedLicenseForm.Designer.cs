namespace Winform_UI.Forms
{
    partial class ManageDetainedLicenseForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.labelRecordsCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ContextDetainedRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.filterBox1 = new Util.FilterBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.ContextDetainedRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Gray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(955, 540);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(119, 45);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.OnCloseButtonClick);
            // 
            // labelRecordsCount
            // 
            this.labelRecordsCount.BackColor = System.Drawing.Color.Transparent;
            this.labelRecordsCount.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecordsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(53)))));
            this.labelRecordsCount.Location = new System.Drawing.Point(59, 540);
            this.labelRecordsCount.Name = "labelRecordsCount";
            this.labelRecordsCount.Size = new System.Drawing.Size(133, 35);
            this.labelRecordsCount.TabIndex = 19;
            this.labelRecordsCount.Text = "# Records: ";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.ColumnHeadersHeight = 40;
            this.dgvData.ContextMenuStrip = this.ContextDetainedRow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvData.Location = new System.Drawing.Point(21, 166);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1065, 368);
            this.dgvData.TabIndex = 18;
            this.dgvData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvData.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvData.ThemeStyle.ReadOnly = false;
            this.dgvData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvData.ThemeStyle.RowsStyle.Height = 28;
            this.dgvData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ContextDetainedRow
            // 
            this.ContextDetainedRow.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextDetainedRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.ContextDetainedRow.Name = "ContextDetainedRow";
            this.ContextDetainedRow.Size = new System.Drawing.Size(147, 36);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(146, 32);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.OnRefreshToolStripMenuItemClick);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(53)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(291, 12);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(504, 52);
            this.guna2HtmlLabel2.TabIndex = 17;
            this.guna2HtmlLabel2.Text = "Manage Detained Licenses";
            // 
            // filterBox1
            // 
            this.filterBox1.Location = new System.Drawing.Point(12, 104);
            this.filterBox1.Name = "filterBox1";
            this.filterBox1.Size = new System.Drawing.Size(645, 56);
            this.filterBox1.TabIndex = 21;
            // 
            // ManageDetainedLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 625);
            this.Controls.Add(this.filterBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelRecordsCount);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Name = "ManageDetainedLicenseForm";
            this.Text = "ManageDetainedLicenseForm";
            this.Load += new System.EventHandler(this.ManageDetainedLicenseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ContextDetainedRow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelRecordsCount;
        private Guna.UI2.WinForms.Guna2DataGridView dgvData;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.ContextMenuStrip ContextDetainedRow;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private Util.FilterBox filterBox1;
    }
}