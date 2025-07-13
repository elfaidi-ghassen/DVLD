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
namespace Winform_UI.Forms
{
    public partial class UserDetails : Form
    {
        private int UserId { get; set; }
        public UserDetails()
        {
            InitializeComponent();
        }
        public void LoadUser(int id)
        {
            User user = UserManager.GetUserById(id);
            this.UserId = id;
            this.personInfo1.LoadPerson(user.PersonId);
            this.loginInfo1.LoadUser(UserId);
        }

        private void loginInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
