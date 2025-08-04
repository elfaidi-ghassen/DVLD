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
using Winform_UI.Debug;

namespace Winform_UI
{
    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();
        }

        private void DebugForm_Load(object sender, EventArgs e)
        {
            CustomAssert.That(DriverManager.PersonIsDriver(1) == true, "#1");
            CustomAssert.That(DriverManager.PersonIsDriver(1024) == false, "#2");
            CustomAssert.That(DriverManager.PersonIsDriver(1025) == true, "#3");
            CustomAssert.That(DriverManager.GetDriverByPersonId(1025).DriverID == 9, "#4");
            string name = DrivingLicenseManager.GetLicenseCardInfoByAppId(36).FullName;
            CustomAssert.That(name == "Ghassen Houcine Faidi", "#5");
            MessageBox.Show("All tests pass");


            List<User> users = UserManager.GetAllUsers();
            foreach(User user in users)
            {
                (byte[], byte[]) passwordSaltPair = PasswordHasher.HashPassword(user.PasswordHash);
                string passwordHash = Convert.ToBase64String(passwordSaltPair.Item1);
                string salt = Convert.ToBase64String(passwordSaltPair.Item2);
                user.PasswordHash = passwordHash;
                user.Salt = salt;
                UserManager.UpdateUser(user);
            }
        }
    }
}
