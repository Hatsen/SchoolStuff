using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uge34Opg2
{
    class Liste
    {
        List<Node> nodeList = new List<Node>();

        public void IndsætNy(string s)
        {
            Node node = new Node();
            node.text = s;

            nodeList.Add(node);
        }

        public void PrintListe()
        { 
            foreach (Node n in nodeList)
            {
                Console.WriteLine(n.text);
            }
        }

        public void SletForan()
        { 
        }
    }
}
