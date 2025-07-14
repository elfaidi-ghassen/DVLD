using System;
using System.Windows.Forms;
using Winform_UI.Properties;
using Util;
using DVLVBusinessLayer;

namespace Winform_UI.Forms
{
    public enum enMode { Add, Update}
    public partial class AddUpdatePerson : Form
    {
        private int? Id;
        private enMode Mode;
        private string Heading;
        public delegate void OnPersonAdded(object self, int personId);
        public OnPersonAdded onPersonAdded;
        public AddUpdatePerson(int? id = null)
        {
            InitializeComponent();
            
            Id = id;
            this.Mode = (id == null) ? enMode.Add : enMode.Update;
            switch (Mode)
            {
                case enMode.Add:
                    labelHeading.Text = "Add a new person"; ;
                    btnAddUpdate.Text = "Add";
                    InitializeCountries();
                    pbImage.Image = Resources.male;
                    break;
                case enMode.Update:
                default:
                    labelHeading.Text = "Update a person";
                    groupBoxPerson.Text = $"ID: {id}";
                    btnAddUpdate.Text = "Update";
                    InitializePersonControls((int)id);

                    break;
            }
            dateOfBirthPicker.MaxDate = DateTime.Today.AddYears(-18);
        }

        private void InitializePersonControls(int id)
        {
            Person person = PersonManager.GetPersonById(id);
            if (person == null)
            {
                MessageBox.Show("NOT FOUND");
                return;
            }
            tbFirstName.Text = person.FirstName;
            tbSecondName.Text = person.SecondName;
            tbThirdName.Text = person.ThirdName;
            tbLastName.Text = person.LastName;
            tbEmail.Text = person.Email;
            tbPhone.Text = person.Phone;
            textAddress.Text = person.Address;
            dateOfBirthPicker.Value = person.DateOfBirth;
            tbNationalNo.Text = person.NationalNo;
            if (person.Gendor == enGender.Male)
                radMale.Checked = true;
            else
                radFemale.Checked = true;
            try
            {
                pbImage.Load(person.ImagePath);
            } 
            catch(Exception e) { }
            InitializeCountries();
            string countryName = CountryManager.FindCountryById(person.NationalityCountryID).CountryName;
            
            comboCountry.SelectedIndex = comboCountry.FindString(countryName);
            if (person.ImagePath == null)
                linkSetImage.Text = "Set image";
            else
                linkSetImage.Text = "Remove image";
        }
        private void InitializeCountries()
        {
            foreach(Country country in CountryManager.GetAllCountries())
            {
                comboCountry.Items.Add(country.CountryName);
            }
            comboCountry.SelectedIndex = 0;
        }

        private enGender GetSelectedGender()
        {
            return radMale.Checked ? enGender.Male : enGender.Female;
        }
        private Country GetSelectedCountry()
        {
            return CountryManager.FindCountryByName(comboCountry.Text);
        }


        private int? AddPersonFromFields()
        {
            if (tbNationalNo.Text == "" 
                || tbFirstName.Text == ""
                || tbSecondName.Text == ""
                || tbLastName.Text == ""
                || textAddress.Text == ""
                || tbPhone.Text == ""
                )
            {
                return null;
            }
            return PersonManager.AddPersonGetId(
                    tbNationalNo.Text,
                    tbFirstName.Text,
                    tbSecondName.Text,
                    tbThirdName.Text == "" ? null : tbThirdName.Text,
                    tbLastName.Text,
                    dateOfBirthPicker.Value,
                    GetSelectedGender(),
                    textAddress.Text,
                    tbPhone.Text,
                    tbEmail.Text == "" ? null : tbEmail.Text,
                    GetSelectedCountry().CountryID,
                    pbImage.ImageLocation == "" ? null : pbImage.ImageLocation
                );
        }
        private void HandleAddPerson()
        {
            
            if (PersonManager.NationalNoExists(tbNationalNo.Text))
            {
                MessageBox.Show("National Number already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int? personId = AddPersonFromFields();
            if (personId != null)
            {
                MessageBox.Show("Added!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                onPersonAdded.Invoke((object)this, (int)personId);
                return; 
            }
            else
            {
                MessageBox.Show("Error while adding!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void HandleUpdatePerson() 
        {
            Person person = PersonManager.GetPersonById((int)Id);


            if (person.NationalNo != tbNationalNo.Text  && PersonManager.NationalNoExists(tbNationalNo.Text))
            {
                MessageBox.Show("National Number already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            person.NationalNo = tbNationalNo.Text;
            person.FirstName = tbFirstName.Text;
            person.SecondName = tbSecondName.Text;
            person.ThirdName = tbThirdName.Text == "" ? null : tbSecondName.Text;
            person.LastName = tbLastName.Text;
            person.DateOfBirth = dateOfBirthPicker.Value;
            person.Gendor = GetSelectedGender();
            person.Phone = tbPhone.Text;
            person.Email = tbEmail.Text == "" ? null : tbEmail.Text;
            person.NationalityCountryID = GetSelectedCountry().CountryID;
            person.ImagePath = pbImage.ImageLocation == "" ? null : pbImage.ImageLocation;

            if (tbNationalNo.Text == ""
            || tbFirstName.Text == ""
            || tbSecondName.Text == ""
            || tbLastName.Text == ""
            || textAddress.Text == ""
            || tbPhone.Text == "")
            {
                MessageBox.Show("Error while updating!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PersonManager.UpdatePerson(person))
            {
                MessageBox.Show("Updated!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error while updating!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case enMode.Add:
                    HandleAddPerson();
                    
                    break;
                case enMode.Update:
                    HandleUpdatePerson();
                    break;
                default:
                    throw new ArgumentException("Invalid enum value");
            }

            
             


        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void radMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radMale.Checked)
            {
                if (pbImage.ImageLocation == null || pbImage.ImageLocation == "")
                {
                    pbImage.Image = Resources.male;
                } 

             }
        }

        private void radFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radFemale.Checked)
            {
                if (pbImage.ImageLocation == null || pbImage.ImageLocation == "")
                {
                    pbImage.Image = Resources.female;
                }

            }
        }

        private void linkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pbImage.ImageLocation == "" || pbImage.ImageLocation == null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "png (*.png)|*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string filePath = openFileDialog.FileName;
                    pbImage.Load(filePath);
                    linkSetImage.Text = "Remove image";
                }
            } else
            {
                linkSetImage.Text = "Set image";
                pbImage.ImageLocation = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbImage_Click_1(object sender, EventArgs e)
        {

        }
    }
}
