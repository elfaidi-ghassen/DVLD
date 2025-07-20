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
            MessageBox.Show("All tests pass");
        }
    }
}
