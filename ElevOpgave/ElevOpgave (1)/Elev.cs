using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElevOpgave
{
    class Elev
    {
        private string navn;
        private int aar;

        public Elev(string navn, int aar)
        {
            this.navn = navn;
            this.aar = aar;
        }

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        public int Aar
        {
            get { return aar; }
            set { aar = value; }
        }
    }
}
