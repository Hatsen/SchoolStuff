using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinærTræ
{
    class Tree
    {
        public Node root;

        public void Print()
        {
            Console.WriteLine(root.tal);
            Node temp = root;

            while (temp != null)
            {
                Console.WriteLine(temp.tal);
                temp = temp.left;
            }
        }

        public void PrintAlt()
        {
            List<Node> minListe = new List<Node>();
            minListe.Add(root);

            while (minListe.Count > 0)
            {
                Node temp = minListe[0];
                Console.WriteLine(minListe[0].tal);
                minListe.RemoveAt(0);

                if (temp.left != null)
                {
                    minListe.Add(temp.right);
                }
            }
        }
    }
}
