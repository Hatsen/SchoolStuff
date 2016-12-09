using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Person
    {
        private string navn;
        private string by;
        private int alder;

        public Person(string n, string b, int a)
        {
            navn = n;
            by = b;
            alder = a;
        }

        public string GetNavn
        {
            get { return navn; }
            set { navn = value; }
        }

        public string GetBy
        {
            get { return by; }
            set { by = value; }
        }

        public int GetAlder
        {
            get { return alder; }
            set { alder = value; }
        }
    }
}
