using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpret_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(txtNavn.Text);
            EmployeeList liste = EmployeeList.GetInstance();

            liste.Add(employee);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EmployeeList liste = EmployeeList.GetInstance();
            liste.Get(Convert.ToInt32(txtNo.Text));
        }
    }
}
