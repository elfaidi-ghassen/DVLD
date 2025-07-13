using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_UI.Forms;
using DVLVBusinessLayer;
using Util;

namespace Winform_UI.Controls
{
    public partial class PersonInfo : UserControl
    {
        private int? ID { get; set; }
        public PersonInfo()
        {
            InitializeComponent();
            ID = null;
           
        }
        public void LoadPerson(int id)
        {            
            this.ID = id;
            UpdateFormDate();
        }

        /// <summary>
        /// Updates the person's details in the form
        /// using the data from database.
        /// </summary>
        private void UpdateFormDate()
        {
            Person person = PersonManager.GetPersonById((int)ID);
            labelPersonId.Text = person.PersonID.ToString();
            labelFullName.Text = person.FullName;
            labelNationalNo.Text = person.NationalNo;
            labelGender.Text = person.Gendor.ToString();
            labelEmail.Text = person.Email ?? "???";
            LabelAddress.Text = person.Address;
            LabelDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
            labelPhone.Text = person.Phone;
            labelCountry.Text = CountryManager.FindCountryById(person.NationalityCountryID).CountryName;
            pbImage.ImageLocation = person.ImagePath ?? "";

        }

        private void LinkUpdate_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ID == null)
            {
                return;
            }
            new AddUpdatePerson((int)ID).ShowDialog();
            UpdateFormDate();
        }
    }
}
