using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Pacman
{
    public partial class frmSpil : Form
    {
        Bane bane = new Bane();

        Bil b1 = new Bil();
        Bil b2 = new Bil();

        Spiller spiller1 = new Spiller("Patrick");
        Spiller spiller2 = new Spiller("Mark");

        int spiller1Point = 0;
        int spiller2Point = 0;

        public frmSpil()
        {
            InitializeComponent();
        }

        private void Start()
        {
            b1.aktuelleNode = bane.baneList[0];
            b2.aktuelleNode = bane.baneList[8];

            LoadBil();
            DrawHandler();
        }

        private void DrawHandler()
        {
            Graphics g = baneBox.CreateGraphics();

            g.Clear(Color.Black);

            Pen pen1 = new Pen(Color.LightGreen);
            SolidBrush brush = new SolidBrush(Color.LightGreen);

            foreach (var v in bane.baneList)
            {
                g.DrawRectangle(pen1, v.x, v.y, 50, 50);
                g.FillRectangle(brush, v.x, v.y, 50, 50);
            }

            DrawBil();
            DrawPoints();
        }

        private void DrawBil()
        {
            Graphics g = baneBox.CreateGraphics();

            Pen pen1 = new Pen(Color.Blue);
            Pen pen2 = new Pen(Color.Red);
            Pen pen3 = new Pen(Color.Yellow);

            SolidBrush brush1 = new SolidBrush(Color.Blue);
            SolidBrush brush2 = new SolidBrush(Color.Red);
            SolidBrush brush3 = new SolidBrush(Color.Yellow);

            g.DrawRectangle(pen1, b1.x + 20, b1.y + 20, 10, 10);
            g.FillRectangle(brush1, b1.x + 20, b1.y + 20, 10, 10);

            g.DrawRectangle(pen2, b2.x + 20, b2.y + 20, 10, 10);
            g.FillRectangle(brush2, b2.x + 20, b2.y + 20, 10, 10);

            if (b1.x == b2.x && b1.y == b2.y)
            {
                g.DrawRectangle(pen3, b1.x + 20, b1.y + 20, 10, 10);
                g.FillRectangle(brush3, b1.x + 20, b2.y + 20, 10, 10);
            }
        }

        private void LoadBil()
        {
            b1.x = 10;
            b1.y = 10;
            b2.x = 110;
            b2.y = 110;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Start();
                }

                if (e.KeyCode == Keys.Up)
                {
                    b1.x = b1.aktuelleNode.top.x;
                    b1.y = b1.aktuelleNode.top.y;

                    b1.aktuelleNode = b1.aktuelleNode.top;

                    Spiller1Point();
                }

                if (e.KeyCode == Keys.Left)
                {

                    b1.x = b1.aktuelleNode.left.x;
                    b1.y = b1.aktuelleNode.left.y;

                    b1.aktuelleNode = b1.aktuelleNode.left;

                    Spiller1Point();
                }

                if (e.KeyCode == Keys.Right)
                {

                    b1.x = b1.aktuelleNode.right.x;
                    b1.y = b1.aktuelleNode.right.y;

                    b1.aktuelleNode = b1.aktuelleNode.right;

                    Spiller1Point();
                }

                if (e.KeyCode == Keys.Down)
                {

                    b1.x = b1.aktuelleNode.bottom.x;
                    b1.y = b1.aktuelleNode.bottom.y;

                    b1.aktuelleNode = b1.aktuelleNode.bottom;

                    Spiller1Point();
                }

                if (e.KeyCode == Keys.W)
                {
                    b2.x = b2.aktuelleNode.top.x;
                    b2.y = b2.aktuelleNode.top.y;

                    b2.aktuelleNode = b2.aktuelleNode.top;

                    Spiller2Point();
                }

                if (e.KeyCode == Keys.A)
                {

                    b2.x = b2.aktuelleNode.left.x;
                    b2.y = b2.aktuelleNode.left.y;

                    b2.aktuelleNode = b2.aktuelleNode.left;

                    Spiller2Point();
                }

                if (e.KeyCode == Keys.D)
                {
                    b2.x = b2.aktuelleNode.right.x;
                    b2.y = b2.aktuelleNode.right.y;

                    b2.aktuelleNode = b2.aktuelleNode.right;

                    Spiller2Point();
                }

                if (e.KeyCode == Keys.S)
                {
                    b2.x = b2.aktuelleNode.bottom.x;
                    b2.y = b2.aktuelleNode.bottom.y;

                    b2.aktuelleNode = b2.aktuelleNode.bottom;

                    Spiller2Point();
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                DrawHandler();
            }
        }

        private void Spiller1Point()
        {
            if (b1.x == b2.x && b1.y == b2.y)
            {
                spiller1Point++;
            }
        }

        private void Spiller2Point()
        {
            if (b1.x == b2.x && b1.y == b2.y)
            {
                spiller2Point++;
            }
        }

        private void DrawPoints()
        {
            Graphics g = baneBox.CreateGraphics();

            SolidBrush brush = new SolidBrush(Color.White);

            Font font = new Font("Arial", 10);
            g.DrawString(spiller1.Navn + " point: " + spiller1Point, font, brush, 50, 175);
            g.DrawString(spiller2.Navn + " point: " + spiller2Point, font, brush, 50, 200);
        }
    }
}
