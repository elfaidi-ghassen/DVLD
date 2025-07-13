using System;
using System.Windows.Forms;

namespace Winform_UI.Forms
{
    public partial class PersonInfoForm : Form
    {
        private int ID { get;  }
        public PersonInfoForm(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void PersonInfoForm_Load(object sender, EventArgs e)
        {
            personInfo.LoadPerson(ID);
        }


    }
}
