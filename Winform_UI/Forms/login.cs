using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;
using DVLVBusinessLayer;
using System.Diagnostics;
using Winform_UI.Debug;

namespace Winform_UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Cache cache = new Cache(Settings.CACHE_PATH);
            cache.Load();
            tbUsername.Text = cache.Get("USERNAME");
            tbPassword.Text = cache.Get("PASSWORD");
            if (cache.Get("USERNAME") != null && cache.Get("PASSWORD") != null)
            {
                cbRememberMe.Checked = true;
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            cbRememberMe.Checked = cbRememberMe.Checked ? false : true;

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {



            string username = tbUsername.Text;
            string password = tbPassword.Text;
            bool rememberMe = cbRememberMe.Checked;
            if (!UserManager.VerifyUser(username, password))
            {
                MessageBox.Show("Wrong username/password",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            

            if (!UserManager.IsActive(username))
            {
                MessageBox.Show("This account is deactived", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cache cache = new Cache(Settings.CACHE_PATH);
            cache.Load();
            if (rememberMe)
            {
                cache.Add("USERNAME", username);
                cache.Add("PASSWORD", password);
                cache.Save();
            } else
            {
                cache.Clear();
                tbUsername.Text = string.Empty;
                tbPassword.Text = string.Empty;
            }
            int UserId = (int)UserManager.GetUserId(username);
            this.Hide();
            Form mainForm = new MainForm(UserId);
            mainForm.Closed += (s, args) => this.Show();
            mainForm.Show();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
