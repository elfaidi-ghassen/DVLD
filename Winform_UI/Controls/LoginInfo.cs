using DVLVBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace Winform_UI.Controls
{
    public partial class LoginInfo : UserControl
    {
        private int UserId { get; set; }
        public LoginInfo()
        {
            InitializeComponent();
        }
        public void LoadUser(int userId)
        {
            UserId = userId;
            User user = UserManager.GetUserById(userId);
            UpdateFormData(user);
        }

        private void UpdateFormData(User user)
        {
            labelUserId.Text = user.UserId.ToString();
            labelUsername.Text = user.UserName;
            labelIsActive.Text = user.IsActive.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelUserId_Click(object sender, EventArgs e)
        {

        }
    }
}
