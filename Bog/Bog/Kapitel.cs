using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bog
{
    class Kapitel
    {
        private int nr;
        public Kapitel next;
        public Kapitel last;

        List<Saetning> sListe = new List<Saetning>();

        public Kapitel(int nr)
        {
            this.nr = nr;
        }

        public void PrintKapitel()
        { 
        }

        public void Add(Saetning s)
        {
            sListe.Add(s);
        }

        public int NR
        {
            get { return nr; }
        }
    }
}
