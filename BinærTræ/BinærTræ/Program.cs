using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinærTræ
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            //Node node = new Node();

            Node n1 = new Node();
            Node n2 = new Node();
            Node n3 = new Node();
            Node n4 = new Node();
            Node n5 = new Node();
            Node n6 = new Node();
            Node n7 = new Node();
            Node n8 = new Node();

            n1.tal = 10;
            n2.tal = 3;
            n3.tal = 23;
            n4.tal = 42;
            n5.tal = 21;
            n6.tal = 16;
            n7.tal = 44;
            n8.tal = 17;

            tree.root = n1;

            //left
            n7.left = n4;
            n3.left = n5;
            n8.left = n6;

            //right
            n4.right = n7;
            n5.right = n3;
            n6.right = n8;

            tree.Print();
            tree.PrintAlt();

            /*
            tree.InsertNode(13);
            tree.InsertNode(43);
            tree.InsertNode(21);
            tree.InsertNode(8);
            tree.InsertNode(16);
            tree.InsertNode(4);
             */
        }
    }
}
