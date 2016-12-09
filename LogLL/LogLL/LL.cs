using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogLL
{
    class LL
    {
        private L f;

        public LL()
        {
            f = null;
        }

        public void add(int n)
        {
            L node = new L();
            node.data = n;
            node.next = f;
            f = node;
        }

        public void printAll()
        {
            L tmp = f;
            while (tmp != null)
            {
                Console.WriteLine("tmp.data: " + tmp.data);
                tmp = tmp.next;
            }
        }

        public void printAllOver(int n)
        {
            L tmp = f;

            while (tmp.data > n)
            {
                Console.WriteLine("Tal over {0}: {1}", n, tmp.data);
                tmp = tmp.next;
            }
        }

        public int BeregnSum()
        {
            L tmp = f;
            int sum = 0;

            while (tmp != null)
            {
                sum += tmp.data;
                tmp = tmp.next;
            }
            return sum;
        }
        public bool Empty()
        {
            L tmp = f;

            if (tmp != null)
                return false;

            return true;
        }

        public void SletFoersteElement()
        {
            L tmp = f;
            while (tmp.next != null)
                tmp = tmp.next;
            tmp.data = 0;
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
