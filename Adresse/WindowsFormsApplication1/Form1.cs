using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGem_Click(object sender, EventArgs e)
        {
            int alder;
            alder = Convert.ToInt32(txtAlder.Text);
            Metoder.NyPerson(txtNavn.Text, txtBy.Text, alder);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            txtFindAlder.Text = Metoder.FindPerson(txtFindPerson.Text).ToString();
        }
    }
}
