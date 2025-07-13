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
    public partial class AddUpdateUser : Form
    {
        private enMode mode;
        private int? currentUserId = null;
        public AddUpdateUser(int? id = null)
        {
            InitializeComponent();
            this.mode = id == null ? enMode.Add : enMode.Update;
            this.currentUserId = id;
            UpdateForm();
        }


        private void UpdateForm()
        {
            if (this.mode == enMode.Add)
            {
                heading.Text = "Add new user";
                this.Text = "Add";
            } else
            {
                heading.Text = "Update user";
                this.Text = "Update";
                User user = UserManager.GetUserById((int)currentUserId);
                userChoosePerson1.LoadPerson(user.PersonId);
                userChoosePerson1.HideFilters();
                this.labelUserId.Text = this.currentUserId.ToString();
                cbIsActive.Checked = user.IsActive;
                tbUsername.Text = user.UserName;
            }
        }


        private void AddUpdateUser_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (userChoosePerson1.ChosenId == null)
            {
                MessageBox.Show("Please choose a person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsValidPasswordString(string password)
        {
            // I didn't include all the needed verifications
            return tbPassword.Text != "";
        }

        private void HandleAddUser()
        {

            if (PersonManager.PersonIsUser((int)userChoosePerson1.ChosenId))
            {
                MessageBox.Show("This person is already a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedIndex = 0;
                return;
            }


            if (!IsValidPasswordString(tbPassword.Text))
            {
                MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbConfirm.Text != tbPassword.Text)
            {
                MessageBox.Show("The passwords don't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? userId = UserManager.AddUserGetId((int)userChoosePerson1.ChosenId,
                                tbUsername.Text,
                                tbPassword.Text,
                                cbIsActive.Checked);
            if (userId == null)
            {
                MessageBox.Show("There was an error while adding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                labelUserId.Text = userId.ToString();
                this.currentUserId = userId;
                MessageBox.Show("Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.mode = enMode.Update;
                this.UpdateForm();
                this.labelUserId.Text = this.currentUserId.ToString();
            }
        }
        
        private void HandleUpdateUser()
        {
      
            bool excludePassword = (tbPassword.Text == string.Empty);

            if (!excludePassword && tbConfirm.Text != tbPassword.Text)
            {
                MessageBox.Show("The passwords don't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User user = UserManager.GetUserById((int)this.currentUserId);
            user.UserName = tbUsername.Text;
            if (!excludePassword)
                user.Password = tbPassword.Text;
            user.IsActive = cbIsActive.Checked;


            if (!UserManager.UpdateUser(user))
            {
                MessageBox.Show("There was an error while updating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }
        private void AddUpdateButton_Click(object sender, EventArgs e)
        {

            if (userChoosePerson1.ChosenId == null)
            {
                MessageBox.Show("Please choose a person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedIndex = 0;
                return;
            }


   
            

            switch (this.mode)
            {
                case enMode.Add:

                    HandleAddUser();
                    break;
                case enMode.Update:
                    HandleUpdateUser();
                    break;
                default:
                    break;
            }
        }

        private void userChoosePerson1_Load(object sender, EventArgs e)
        {

        }
    }

}
