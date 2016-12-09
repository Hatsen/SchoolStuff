using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kø
{
    class Koe
    {
        private Node front;
        private Node rear;

        public Koe()
        {
            front = null;
            rear = null;
        }

        public void Enqueue(int tal)
        {
            Node tmp = new Node();

            if (tmp != null)
            {
                tmp.data = tal;
                tmp.next = rear;
                rear = tmp;
            }
        }

        public int Dequeue()
        {
            int tal = 1;
            return tal;
        }

        public void PrintQueue()
        {
            Node tmp = rear;
            while (tmp != null)
            {
                Console.WriteLine(tmp.data);
                tmp = tmp.next;
            }
        }

        public void Moever(int x, int y)
        {
            Node tmp = new Node();
            tmp = front;
            x = 0;

            while (x < y)
            {
                tmp = tmp.next;
                x++;
            }
        }
    }
}
