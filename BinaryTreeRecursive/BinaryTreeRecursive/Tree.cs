using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTreeRecursive
{
    class Tree
    {
        public Node root;

        public Tree()
        {
            Node n1 = new Node();
            Node n2 = new Node();
            Node n3 = new Node();
            Node n4 = new Node();
            Node n5 = new Node();
            Node n6 = new Node();
            Node n7 = new Node();

            n1.data = 50;
            n2.data = 25;
            n3.data = 70;
            n4.data = 10;
            n5.data = 30;
            n6.data = 90;
            n7.data = 15;

            root = n1;
            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            n2.right = n5;
            n3.right = n6;
            n4.right = n7;
        }

        public void InsertRecursive(int tal)
        {
            Node node = new Node();
            node.data = tal; 
        }

        public void PrintRecursive()
        {
            PrintHelper(root);
        }

        public void PrintHelper(Node n)
        {
            Console.WriteLine(n.data);

            if (n.left != null)
                PrintHelper(n.left);
            if (n.right != null)
                PrintHelper(n.right);
        }
    }
}
