using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DiningPhilosopher
{
    class Gaffel
    {
        private bool dirty = false;
        public int gaffelId;
        public bool side;

        public Gaffel(bool dirty, int gaffelId, Bord bord)
        {
            dirty = this.dirty;
            gaffelId = this.gaffelId;         
        }


        public void GetGaffel()
        {
            while (!dirty)
            {
                try
                {
                    Thread.Sleep(10000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public void GivGaffel()
        {
            dirty = true;
 
        }
    }
}
