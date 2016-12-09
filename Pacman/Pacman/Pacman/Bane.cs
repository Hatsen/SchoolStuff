using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pacman
{
    public class Bane
    {
        public List<Node> baneList = new List<Node>();
        public Bane()
        {
            FletNodes();
        }

        public void FletNodes()
        {
            Node n1 = new Node();
            Node n2 = new Node();
            Node n3 = new Node();
            Node n4 = new Node();
            Node n5 = new Node();
            Node n6 = new Node();
            Node n7 = new Node();
            Node n8 = new Node();
            Node n9 = new Node();

            //Sammenfletning
            n1.right = n2;
            n2.right = n3;

            n4.right = n5;
            n5.right = n6;

            n7.right = n8;
            n8.right = n9;

            n9.left = n8;
            n8.left = n7;

            n6.left = n5;
            n5.left = n4;

            n3.left = n2;
            n2.left = n1;

            n1.bottom = n4;
            n2.bottom = n5;
            n3.bottom = n6;

            n4.bottom = n7;
            n5.bottom = n8;
            n6.bottom = n9;

            n7.top = n4;
            n8.top = n5;
            n9.top = n6;

            n4.top = n1;
            n5.top = n2;
            n6.top = n3;

            //Coords.
            n1.x = 10;
            n1.y = 10;

            n2.x = 60;
            n2.y = 10;

            n3.x = 110;
            n3.y = 10;

            n4.x = 10;
            n4.y = 60;

            n5.x = 60;
            n5.y = 60;

            n6.x = 110;
            n6.y = 60;

            n7.x = 10;
            n7.y = 110;

            n8.x = 60;
            n8.y = 110;

            n9.x = 110;
            n9.y = 110;

            baneList.Add(n1);
            baneList.Add(n2);
            baneList.Add(n3);
            baneList.Add(n4);
            baneList.Add(n5);
            baneList.Add(n6);
            baneList.Add(n7);
            baneList.Add(n8);
            baneList.Add(n9);
        }
    }
}
