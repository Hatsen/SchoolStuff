using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Spiller
    {
        private string navn;

        public Spiller(string navn)
        {
            this.navn = navn;
        }

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }
    }
}
