using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_Search_Tree
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public void InsertNode(Node newNode)
        {
            if ()
        }

        public void PrintNode()
        {
            if (left != null)
                left.PrintNode();
            Console.WriteLine(data);
            if (right != null)
                right.PrintNode();
        }

        public void PrintNode2()
        {
            if (left != null)
                left.PrintNode();
            if (right != null)
                right.PrintNode();
            Console.WriteLine(data);
        }

        public void PrintNode3()
        { 

        }
    }
}
