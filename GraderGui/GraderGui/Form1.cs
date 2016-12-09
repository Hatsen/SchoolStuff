using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraderGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUdregn_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        public void Calculate()
        {
            double celcius;
            double fahrenheit;
            double kelvin;
            double reaumur;

            celcius = Convert.ToDouble(txtCelcius.Text);

            //Udregning
            fahrenheit = celcius * 1.80 + 32;
            kelvin = celcius + 273.15;
            reaumur = celcius * 0.8;

            //Resultat
            txtFahrenheit.Text = fahrenheit.ToString();
            txtKelvin.Text = kelvin.ToString();
            txtReaumur.Text = reaumur.ToString();
        }
    }
}
