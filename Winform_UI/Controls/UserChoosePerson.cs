using DVLVBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;
using Winform_UI.Forms;

namespace Winform_UI.Controls
{
    public partial class UserChoosePerson : UserControl
    {
        public int? ChosenId { get; set; }
        public UserChoosePerson()
        {
            InitializeComponent();
            this.ChosenId = null;
            comboFilter.SelectedIndex = 0;
        }

        private void personInfo1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            switch(comboFilter.Text)
            {
                case "National Number":
                    Person person = PersonManager.GetPersonByNationalNo(textBox.Text);
                    if (person == null)
                    {
                        MessageBox.Show("Person not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.ChosenId = person.PersonID;
                    this.personInfo1.LoadPerson((int)ChosenId);
                    break;
                case "Person ID":
                    try
                    {
                    person = PersonManager.GetPersonById(Convert.ToInt32(textBox.Text));
                    } catch(FormatException ex)
                    {
                        return;
                    }
                    if (person == null)
                    {
                        MessageBox.Show("Person not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    this.ChosenId = person.PersonID;
                    LoadPerson((int)ChosenId);
                    
                    break;


            }
        }
        public void LoadPerson(int id)
        {
            this.personInfo1.LoadPerson(id);
            this.ChosenId = id;
        }

        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddUpdatePerson form = new AddUpdatePerson();
            form.onPersonAdded += HandleReturnFromAddPerson;
            form.ShowDialog();

        }
        private void HandleReturnFromAddPerson(object self, int personId)
        {
            this.personInfo1.LoadPerson(personId);
            ((AddUpdatePerson)self).Close();
        }

        private void filterGroup_Click(object sender, EventArgs e)
        {

        }
        public void HideFilters()
        {
            filterGroup.Hide();
        }
    }
}
