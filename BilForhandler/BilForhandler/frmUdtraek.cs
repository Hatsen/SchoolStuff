using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BilForhandler
{
    public partial class frmUdtraek : Form
    {
        public frmUdtraek()
        {
            InitializeComponent();
        }

        private void btnTilbage_Click(object sender, EventArgs e)
        {
            FrmMain frmMain_Show = new FrmMain();
            frmMain.Show();
        }
    }
}
