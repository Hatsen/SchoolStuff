using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPR_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeregn_Click(object sender, EventArgs e)
        {
            bool CheckCPR;
            int Alder;
            string Koen;

            CheckCPR = Metoder.CPRValidering(txtCPR.Text);
            Alder = Metoder.CheckDato(txtCPR.Text);
            Koen = Metoder.CheckKoen(txtCPR.Text);

            if (CheckCPR == true)
            {
                txtResultNavn.Text = txtFornavn.Text + " " + txtEfternavn.Text;
                txtResultKoen.Text = "er en " + Alder + " år " + "gammel " + Koen;
            }
            else
                MessageBox.Show("CPR nummeret er ikke i det rigtige format.");
        }
    }
}
