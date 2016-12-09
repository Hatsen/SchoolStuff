using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArkitekturOpg1
{
    class Customer : Person
    {
        private int ccreditmax = 1000;

        public Customer(string pfname, string paddress, int ccreditmax) : base(pfname, paddress)
        {
            this.pfname = pfname;
            this.paddress = paddress;
            this.ccreditmax = ccreditmax;
        }

        public int Ccreditmax
        {
            get { return ccreditmax; }
            set { ccreditmax = value; }
        }
    }
}
