using System;
using System.Data;
using System.Windows.Forms;
using DVLVBusinessLayer;
using Winform_UI.Forms;

namespace Winform_UI
{
    public partial class ManagePeopleForm : Form
    {

        public ManagePeopleForm()
        {
            InitializeComponent();
            InitForm();
        }


        private void InitForm()
        {
            RefreshPeopleData();
            InitFilterCombobox();
        }


 
        private void InitFilterCombobox()
        {
            comboFilter.SelectedIndex = 0;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void RefreshPeopleData(DataTable dt = null)
        {
            if (dt == null)
            {
                dt = PersonManager.GetPeopleDataTable();
            }
            dgvPeople.DataSource = dt;
            UpdateRowCount();
        }
        private void RefreshPeopleData(DataView dv)
        {
            dgvPeople.DataSource = dv;
            UpdateRowCount();
        }

        private void UpdateRowCount()
        {
            labelRows.Text = $"# Records:   {dgvPeople.Rows.Count}";
        }



        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboFilter.Text)
            {
                case "Person ID":
                case "Gender":
                    tbNumberFilter.Visible = true;
                    tbTextFilter.Visible = false;
                    break;
                case "National No":
                case "First Name":
                case "Second Name":
                case "Third Name":
                case "Last Name":
                case "Email":
                    tbNumberFilter.Visible = false;
                    tbTextFilter.Visible = true;
                    break;
                case "None":
                default:
                    tbNumberFilter.Visible = false;
                    tbTextFilter.Visible = false;
                    RefreshPeopleData();
                    break;
            }
        }

        private void tbNumberFilter_ValueChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(PersonManager.GetPeopleDataTable());
            dv.RowFilter = $"{ComboToDBFields(comboFilter.Text)} = {tbNumberFilter.Value}";
            RefreshPeopleData(dv);
        }

        private string ComboToDBFields(string s)
        {
            switch (s)
            {
                case "Person ID":
                    return "PersonID";
                case "National No":
                    return "NationalNo";
                case "First Name":
                    return "FirstName";
                case "Second Name":
                    return "SecondName";
                case "Third Name":
                    return "ThirdName";
                case "Last Name":
                    return "LastName";
                case "Gender":
                    return "Gendor";
                case "Email":
                    return s;
                case "None":
                default:
                    return "";
            }
        }
    
        private void tbTextFilter_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(PersonManager.GetPeopleDataTable());
            dv.RowFilter = $"{ComboToDBFields(comboFilter.Text)} Like '%{tbTextFilter.Text}%'";
            RefreshPeopleData(dv);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Form form = new AddUpdatePerson();
            form.ShowDialog();
            RefreshPeopleData();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dgvPeople.CurrentRow.Cells[0].Value;
            Form form = new AddUpdatePerson(selectedId);
            form.ShowDialog();
            RefreshPeopleData();

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshPeopleData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dgvPeople.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete?", "caution",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            if (PersonManager.DeleteById(selectedId))
            {
                MessageBox.Show("Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshPeopleData();
            }

            else
            {
                MessageBox.Show("Error while deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dgvPeople.CurrentRow.Cells[0].Value;
            Form form = new PersonInfoForm(selectedId);
            form.ShowDialog();

        }


    }
}







