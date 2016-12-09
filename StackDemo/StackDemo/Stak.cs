using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackDemo
{
    class Stak
    {
        private L f;

        public Stak()
        {
            f = null;
        }

        public void Push(int n)
        {
            L node = new L();
            node.data = n;
            node.next = f;
            f = node;
        }

        public void PrintStak()
        {
            L tmp = f;
            while (tmp != null)
            {
                Console.WriteLine("tmp.data: " + tmp.data);
                tmp = tmp.next;
            }
        }

        public bool Empty()
        {
            L tmp = f;

            if (tmp != null)
                return false;

            return true;
        }

        public int Pop()
        {
            L tmp = f;
            while (tmp.next != null)
                tmp = tmp.next;
            
        }

        public int Count()
        {
            L tmp = f;
            int antalElementer = 0;

            while (tmp.next != null)
            {
                antalElementer++;
                tmp = tmp.next;
            }
            return antalElementer;
        }
    }
}
