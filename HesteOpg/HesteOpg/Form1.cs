using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HesteOpg
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        private Graphics minGraphics;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(BlåTrådMetode);
            t1.Start();
            Thread t2 = new Thread(RødTrådMetode);
            t2.Start();

        }

        public void BlåTrådMetode()
        {
            for (int i = 0; i < 200; i++)
            {
                Random r = new Random();
                Thread.Sleep(r.Next(10, 50));
                flytBlåHest();
            }
        }

        public void RødTrådMetode()
        {
            for (int i = 0; i < 200; i++)
            {
                Random r = new Random();
                Thread.Sleep(r.Next(10, 50));
                flytRødHest();
            }
        }

        public void flytBlåHest()
        {
            xB = xB + 1;
            paintAll();
        }
        public void flytRødHest()
        {
            xR = xR + 1;
            paintAll();
        }
        int xB = 0;
        int xR = 0;

        int posX = 0;
        int posY = 0;

        public void paintAll()
        {
            lock (this)
            {
                posX++;
                posY++;

                bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                minGraphics = Graphics.FromImage(bmp);
                minGraphics.Clear(Color.White);

                Graphics g = pictureBox1.CreateGraphics();
                pictureBox1.Refresh();
                g.Clear(Color.White);
                Pen pen1 = new Pen(Color.Blue, 4F);
                Pen pen2 = new Pen(Color.Red, 4F);
                g.DrawRectangle(pen1, xB, 5, 15, 15);
                g.DrawRectangle(pen2, xR, 50, 15, 15);

                pictureBox1.Image = bmp;
                pictureBox1.Update();

                /*
                if (posX > pictureBox1.Width || posX > pictureBox1.Height)
                {
                    posX = 0;
                    posY = 0;
                }
                 */
            }
        }
    }
}
