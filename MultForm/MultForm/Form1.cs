using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MultForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            pictureBox1.Refresh();
            g.Clear(Color.White);

            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            g.DrawString("Hej", drawFont, drawBrush, 30, 30);

            Pen pen1 = new Pen(Color.Blue, 4F);
            g.DrawRectangle(pen1, 5, 5, 15, 15);
            pen1 = new Pen(Color.Green, 4F);
            g.DrawEllipse(pen1, 100, 30, 30, 30);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            Pen p = new Pen(Color.Gray, 2);
            p.CustomEndCap = new System.Drawing.Drawing2D.AdjustableArrowCap(4, 20, false);
            g.DrawLine(p, 10, 50, 120, 120);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.LightGoldenrodYellow);
            Pen pen1 = new Pen(Color.Blue, 4F);
            g.DrawEllipse(pen1, e.X, e.Y, 10, 10);
        }

        
    }
}
