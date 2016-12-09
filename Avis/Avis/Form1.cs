using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Avis
{
    public partial class Form1 : Form
    {
        const string Dato = "{0:dddd 'd.' d. MMMM yyyy}";
        int AntalBundter, AntalAviser, AntalLøse;
        double Vægt, BundtePris, LøsPris, TonsPris, Tons, TotalPris;
        public Form1()
        {
            InitializeComponent();
            labDato.Text = string.Format(Dato, DateTime.Today);
        }

        private void btnUdregn_Click(object sender, EventArgs e)
        {
            Calculation();
        }

        private void Clear()
        { 
            //Her nulstilles tekstboksene
            txtBundter.Clear();
            txtLøsAvis.Clear();
            txtPrisBundter.Clear();
            txtPrisLøsAvis.Clear();
            txtPrisTons.Clear();
            txtVægt.Clear();
        }

        public void Calculation()
        {
            Clear();
            AntalAviser = Convert.ToInt32(txtAntal.Text);

            if (txtNavn.Text.Equals(""))
            {
                MessageBox.Show("Skriv et navn");
            }
            else
            {
                try
                {
                    lstAntal.SelectedIndex = cmbNavne.SelectedIndex;

                    AntalLøse = AntalAviser;

                    bool OK;
                    OK = checkNavn(txtNavn.Text);
                    if (OK == false)
                    {
                        cmbNavne.Items.Add(txtNavn.Text);
                        txtNavn.Clear();
                        lstAntal.Items.Add(txtAntal.Text);
                    }

                    Clear();

                    //Her udregnes bundter og løse aviser
                    if (chkBundt.Checked)
                    {
                        AntalBundter = AntalAviser / 50;
                        AntalLøse = AntalAviser % 50;

                        txtBundter.Text = AntalBundter.ToString();
                        txtLøsAvis.Text = AntalLøse.ToString();
                    }
                    else
                        txtLøsAvis.Text = AntalLøse.ToString();

                    //Her udregnes vægten
                    Vægt = AntalAviser * 0.3;
                    txtVægt.Text = Vægt.ToString();

                    //Her udregnes priserne

                    //Prisen på bundter
                    BundtePris = AntalBundter * 7;
                    txtPrisBundter.Text = BundtePris.ToString();

                    //Prisen på de løse aviser
                    LøsPris = AntalLøse * 0.1;
                    txtPrisLøsAvis.Text = LøsPris.ToString();

                    //Tonsprisen
                    Vægt = AntalAviser * 300;
                    Tons = Convert.ToInt32(Math.Round(Vægt / 1000000.0));
                    TonsPris = Tons * 15;
                    txtPrisTons.Text = TonsPris.ToString();

                    //Totalprisen
                    TotalPris = BundtePris + LøsPris + TonsPris;
                    labPris.Text = "I alt kr. " + TotalPris.ToString();

                }
                catch
                {
                    MessageBox.Show("Skiv antal aviser");
                }
            }
        }

        private bool checkNavn(string P)
        {
            bool found = false;
            int i = 0;

            while (found == false && i < cmbNavne.Items.Count)
            {
                if (cmbNavne.Items[i].Equals(P))
                    found = true;
                else
                    i++;
            }
            return found;
        }

        private void cmbNavne_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNavn.Text = cmbNavne.SelectedItem.ToString();
            lstAntal.SelectedIndex = cmbNavne.SelectedIndex;
            txtAntal.Text = lstAntal.SelectedItem.ToString();
        }

        private void btnSlet_Click(object sender, EventArgs e)
        {
            cmbNavne.Items.Remove(cmbNavne.SelectedItem);
            cmbNavne.Text = "";
            lstAntal.Items.Remove(lstAntal.SelectedItem);
            lstAntal.Text = "";
            Clear();
        }
    }
}