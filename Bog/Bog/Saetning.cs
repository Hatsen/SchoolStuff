using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bog
{
    class Saetning
    {
        private string tekst;

        public Saetning(string tekst)
        {
            this.tekst = tekst;
        }

        public void PrintS()
        { 
        }

        public string Tekst
        {
            get { return tekst; }
        }
    }
}
