using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_Search_Tree
{
    class Tree
    {
        private Node root;

        public Tree()
        {
            root = null;
        }

        public void Insert(int n)
        {
            Node newNode = new Node();
            newNode.data = n;
            newNode.left = null;
            newNode.right = null;
            if (root == null)
                root = newNode;
            else
                root.InsertNode(newNode);
        }

        public void Print()
        {
            if (root != null)
                root.PrintNode();
        }
    }
}
