using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmSpil frmSpil_Show = new frmSpil();
            frmSpil_Show.Show();
        }

        private void btnTilslut_Click(object sender, EventArgs e)
        {
            frmTilslut frmTilslut_Show = new frmTilslut();
            frmTilslut_Show.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            frmServer frmServer_Show = new frmServer();
            frmServer_Show.Show();
        }

        private void btnAfslut_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
