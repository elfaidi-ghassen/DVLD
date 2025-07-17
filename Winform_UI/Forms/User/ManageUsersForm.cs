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
    enum ActiveOption
    {
        All, Active, Locked
    }
    enum UserFilterOption
    {
        None, UserID, PersonID, UserName, FullName, IsActive 
    }
    public partial class ManageUsersForm : Form
    {

        public ManageUsersForm()
        {
            InitializeComponent();
        }

        private string FilterOptionToString(UserFilterOption option)
        {
            switch (option)
            {
                case UserFilterOption.None:
                    return "None";
                case UserFilterOption.UserID:
                    return "User ID";
                case UserFilterOption.PersonID:
                    return "Person ID";
                case UserFilterOption.UserName:
                    return "User Name";
                case UserFilterOption.FullName:
                    return "Full Name";
                case UserFilterOption.IsActive:
                    return "Is Active";
                default:
                    return string.Empty;
            }
        }
        private UserFilterOption StringToFilterOption(string optionString)
        {
            switch (optionString.ToUpper())
            {
                case "NONE":
                    return UserFilterOption.None;
                case "USER ID":
                    return UserFilterOption.UserID;
                case "PERSON ID":
                    return UserFilterOption.PersonID;
                case "USER NAME":
                    return UserFilterOption.UserName;
                case "FULL NAME":
                    return UserFilterOption.FullName;
                case "IS ACTIVE":
                    return UserFilterOption.IsActive;
                default:
                    return UserFilterOption.None;
            }
        }
        private void UpdateCountLabel()
        {
            labelCountRecords.Text = $"# Records: {dgvUsers.RowCount}";
        }
        private void LoadUsers(List<User> users)
        {
            dgvUsers.Rows.Clear();
            
            foreach (User user in users)
            {
                dgvUsers.Rows.Add(user.UserId,
                                  user.PersonId,
                                  PersonManager.
                                      GetPersonById(user.PersonId).FullName,
                                  user.UserName,
                                  user.IsActive ? "ACTIVE" : "LOCKED");
            }
        }
        private void LoadUsers()
        {
            LoadUsers(UserManager.GetAllUsers());
        }

        private void InitColumns()
        {
            dgvUsers.Columns.Add("Column1", "User ID");
            dgvUsers.Columns.Add("Column2", "Person ID");
            dgvUsers.Columns.Add("Column3", "Full name");
            dgvUsers.Columns.Add("Column4", "User Name");
            dgvUsers.Columns.Add("Column4", "Is active");
        }
       
        private void InitFiltersComboBox()
        {
            foreach(UserFilterOption option in Enum.GetValues(typeof(UserFilterOption)))
            {
                string displayText = FilterOptionToString(option);
                filterCombo.Items.Add(displayText);
            }
            filterCombo.SelectedIndex = 0;

        }

        private string ActiveToString(ActiveOption option)
        {
            switch (option)
            {
                case ActiveOption.All:
                    return "All";
                case ActiveOption.Active:
                    return "Active";
                case ActiveOption.Locked:
                    return "Locked";
                default:
                    return string.Empty;
            }
        }
        private ActiveOption StringToActiveOption(string s)
        {
            switch (s.Trim().ToUpper())
            {
                case "ALL":
                    return ActiveOption.All;
                case "ACTIVE":
                    return ActiveOption.Active;
                case "LOCKED":
                    return ActiveOption.Locked;
                default:
                    throw new Exception("Invalid option string");
            }
        }
        private void InitFilterActiveCombo()
        {
            foreach (ActiveOption option in Enum.GetValues(typeof(ActiveOption)))
            {
                string displayText = ActiveToString(option);
                filterActiveCombo.Items.Add(displayText);
            }
            filterActiveCombo.SelectedIndex = 0;
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            InitColumns();
            InitFiltersComboBox();
            InitFilterActiveCombo();
            LoadUsers();
            UpdateCountLabel();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HideAllFilterInputs()
        {
            filterTextBox.Visible = false;
            filterNumber.Visible = false;
            filterActiveCombo.Visible = false;
        }
        private void filterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (StringToFilterOption(filterCombo.Text))
            {
                case UserFilterOption.UserID:
                case UserFilterOption.PersonID:
                    HideAllFilterInputs();
                    filterNumber.Visible = true;
                    break;

                case UserFilterOption.UserName:
                case UserFilterOption.FullName:
                    HideAllFilterInputs();
                    filterTextBox.Visible = true;
                    break;
                case UserFilterOption.IsActive:
                    HideAllFilterInputs();
                    filterActiveCombo.Visible = true;
                    break;
                case UserFilterOption.None:
                default:
                    HideAllFilterInputs();
                    LoadUsers();
                    break;

            }

        }

        private void filterActiveCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (StringToActiveOption(filterActiveCombo.Text))
            {
                case ActiveOption.Active:
                    LoadUsers(UserManager.GetUsersByActiveStatus(true));
                    break;
                case ActiveOption.Locked:
                    LoadUsers(UserManager.GetUsersByActiveStatus(false));
                    break;
                case ActiveOption.All:
                default:
                    LoadUsers();
                    break;
            }
            UpdateCountLabel();
        }

        private void filterNumber_ValueChanged(object sender, EventArgs e)
        {

            if (StringToFilterOption(filterCombo.Text) == UserFilterOption.UserID)
                LoadUsers(UserManager.GetAllUsers()
                    .Where(user => user.UserId == filterNumber.Value).ToList());

            if (StringToFilterOption(filterCombo.Text) == UserFilterOption.PersonID)
                LoadUsers(UserManager.GetAllUsers()
                    .Where(user => user.PersonId == filterNumber.Value).ToList());
            UpdateCountLabel();
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StringToFilterOption(filterCombo.Text) == UserFilterOption.UserName)
                LoadUsers(UserManager.GetAllUsers()
                    .Where(user => user.UserName.Contains(filterTextBox.Text)).ToList());

            if (StringToFilterOption(filterCombo.Text) == UserFilterOption.FullName)
                LoadUsers(UserManager.GetAllUsers()
                    .Where(user => PersonManager.GetPersonById(user.PersonId)
                                            .FullName.Contains(filterTextBox.Text))
                                             .ToList());
            UpdateCountLabel();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dgvUsers.CurrentRow.Cells[0].Value;

            UserDetails form = new UserDetails();
            form.LoadUser(selectedId);
            form.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new AddUpdateUser().ShowDialog();
            LoadUsers();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dgvUsers.CurrentRow.Cells[0].Value;
            AddUpdateUser form = new AddUpdateUser(selectedId);
            form.ShowDialog();
            LoadUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool cancelDeletion = MessageBox.Show("Are you sure you want to delete?", "reminder",
                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                                            == DialogResult.Cancel;
            if (cancelDeletion) { return; }

            int selectedUserId = (int)dgvUsers.CurrentRow.Cells[0].Value;
            if (!UserManager.DeleteUser(selectedUserId))
            {
                MessageBox.Show("There was an error while deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
