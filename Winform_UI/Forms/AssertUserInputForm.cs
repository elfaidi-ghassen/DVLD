using DVLVBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace Winform_UI
{

    public partial class AssertUserInputForm : Form
    {

        private Exception Exception { get; set; }
        private int UserId { get; set; }
        public AssertUserInputForm(Exception e, int userId)
        {
            InitializeComponent();
            this.Exception = e;
            this.UserId = userId;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UserAssertInfoManager.Add(UserId, Exception.ToString(), richTextBox1.Text);
            MessageBox.Show("Thank you for your feedback!", "🖤ty!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();


        }

        private void AssertUserInputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
