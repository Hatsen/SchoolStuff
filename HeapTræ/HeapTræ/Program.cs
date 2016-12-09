using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeapTræ
{
    class Program
    {
        static void Main(string[] args)
        {
            HeapTree træ = new HeapTree();
            træ.insertNewNode(4);
            træ.insertNewNode(8);
            træ.insertNewNode(3);
            træ.insertNewNode(9);
            træ.insertNewNode(2);
            træ.insertNewNode(66);
            træ.insertNewNode(1);
            træ.insertNewNode(21);
            træ.printTræ();
            træ.Delete();
            træ.printTræ();
            Console.WriteLine(træ.AntalBørn());
            Console.WriteLine(træ.AntalNodes());
        }
    }
    class HeapTree
    {
        Node root;
        Node lastNode;
        List<Node> insertListe = new List<Node>();
        int taeller = 0;
        int nodeTaeller = 0;

        public void insertNewNode(int data)
        {
            Console.WriteLine("--Ny node: " + data + " indsat");
            Node ny = new Node();
            ny.number = data;
            insertListe.Add(ny);
            if (lastNode == null)
            {
                root = ny;
                lastNode = ny;
            }
            else
            {
                Node aktuel = GetInsertParantNode();
                if (aktuel.left == null)
                {
                    aktuel.left = ny;
                    ny.parent = aktuel;
                    lastNode = ny;
                }
                else
                {
                    aktuel.right = ny;
                    ny.parent = aktuel;
                    lastNode = ny;
                }
            }
            HeapifyUp();
        }

        public Node GetInsertParantNode()
        {
            Node result = lastNode;
            while ((result != root) && (result.parent.left != result))
            {
                result = result.parent;
            }
            if (result != root)
            {
                if (result.parent.right == null)
                {
                    result = result.parent;
                }
                else
                {
                    result = result.parent.right;
                    while (result.left != null)
                    {
                        result = result.left;
                    }
                }
            }
            else
            {
                while (result.left != null)
                {
                    result = result.left;
                }
            }
            return result;
        }

        public void HeapifyUp()
        {
            int temp;
            Node next = lastNode;
            while ((next != root) && (next.number < next.parent.number))
            {
                temp = next.number;
                next.number = next.parent.number;
                next.parent.number = temp;
                next = next.parent;
            }
        }

        public int Delete()
        {
            int svar = root.number;
            Console.WriteLine("--Slettet node: " + svar + " ");
            root.number = lastNode.number;
            if (lastNode == lastNode.parent.left)
            {
                lastNode.parent.left = null;
            }
            else
            {
                lastNode.parent.right = null;
            }
            Node n = insertListe[insertListe.Count - 2];
            insertListe.RemoveAt(insertListe.Count - 1);
            lastNode = n;
            HeapifyDown();
            return svar;
        }
        public void HeapifyDown()
        {
            int temp;
            Node node = root;
            Node left = node.left;
            Node right = node.right;
            Node next;
            if ((left == null) && (right == null))
            {
                next = null;
            }
            else if (left == null)
            {
                next = right;
            }
            else if (right == null)
            {
                next = left;
            }
            else if ((left.number < right.number))
            {
                next = left;
            }
            else
            {
                next = right;
            }
            while ((next != null) && (next.number < node.number))
            {
                temp = node.number;
                node.number = next.number;
                next.number = temp;
                node = next;
                left = node.left;
                right = node.right;
                if (left == null && right == null)
                {
                    next = null;
                }
                else if (left == null)
                {
                    next = right;
                }
                else if (right == null)
                {
                    next = left;
                }
                else if (left.number < right.number)
                {
                    next = left;
                }
                else
                {
                    next = right;
                }
            }
        }
        public void printTræ()
        {
            Console.WriteLine("-----------Print Start ----------------");
            root.printMig(0);
            Console.WriteLine("---------------------------------------");
        }

        public int AntalBørn()
        {
            taeller = 0;
            AntalBørnHelper(root);
            return taeller;
        }

        public void AntalBørnHelper(Node n)
        {
            if (n.left != null)
            {
                AntalBørnHelper(n.left);
            }
            else if (n.right != null)
            {
                AntalBørnHelper(n.right);
            }
            if (n.left == null && n.right == null)
            {
                taeller++;
            }
        }

        public int AntalNodes()
        {
            nodeTaeller = 0;
            AntalNodesHelper(root);
            return nodeTaeller;
        }

        public void AntalNodesHelper(Node n)
        {
            nodeTaeller++;
            if (n.left != null)
            {
                AntalNodesHelper(n.left);
            }

            if (n.right != null)
            {
                AntalNodesHelper(n.right);
            }
        }

        public void WeirdDelete()
        {
            if (root.left.number < root.right.number)
            {
                Node temp;
                temp = root.right;
                root = root.left;
                root.right = temp;
            }
            else if (root.left.number > root.right.number)
            {
                Node temp;
                temp = root.left;
                root = root.right;
                root.left = temp;
            }
        }

        public bool Insert(int data)
        {
            int antal = 0;
            int taeller = 1;

            while (taeller >= antal)
            {
                antal = (antal * 2) + 1;

                if (taeller == antal)
                {
                    while (root.left != null)
                    { }
                }
            }
        }
    }
    class Node
    {
        public Node parent;
        public Node left;
        public Node right;
        public int number;

        public void printMig(int tal)
        {
            tal++;
            String s = "-";
            String samlet = "";
            for (int i = 0; i < tal; i++)
            {
                samlet = samlet + s;
            }
            if (left != null)
            {
                left.printMig(tal);
            }
            Console.WriteLine(samlet + number);
            if (right != null)
            {
                right.printMig(tal);
            }
        }
    }
}