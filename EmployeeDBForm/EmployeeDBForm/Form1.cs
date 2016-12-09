using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeDBForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpret_Click(object sender, EventArgs e)
        {
            EEmployee eemp = new EEmployee(txtSSN.Text, txtName.Text, Convert.ToInt32(txtDno.Text));
            FEmployee femp = new FEmployee();

            femp.Put(eemp);

        }

        private void btnHent_Click(object sender, EventArgs e)
        {
            FEmployee femp = new FEmployee();

            femp.Get(txtHentSSN.Text);
        }
    }
}
