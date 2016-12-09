using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerOpgave
{   
    class TalContainer
    {
        private ArrayList Container;

        public TalContainer()
        {
            Container = new ArrayList();
        }

        public void Tilfoej(int tal)
        {
            Container.Add(tal);
        }

        public void Slet(int tal)
        {
            Container.Remove(tal);
        }

        public void Print()
        {
            foreach (int i in Container)
            {
                Console.WriteLine(i);
            }
        }

        public void Erstat(int x, int y)
        {
            for (int i = 0; i < Container.Count; i++)
            {
                if ((int)Container[i] == x)
                    Container[i] = y;
            }
        }

        public int BeregnSum()
        {
            int sum = 0;
            foreach (int item in Container)
            {
                sum += item;
            }
            return sum;
        }

        public int BeregnMax()
        {
            Container.Sort();
            int index = Container.Count - 1;
            int max = Convert.ToInt32(Container[index]);

            return max;
        }

        public bool Soeg(int tal)
        {
            if (Container.Contains(tal))
                return true;
            else
                return false;
        }
    }
}
