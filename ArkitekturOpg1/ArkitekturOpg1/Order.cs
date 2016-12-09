using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArkitekturOpg1
{
    class Order
    {
        private int ono;
        private string odato;

        public Order(int ono, string odato)
        {
            this.ono = ono;
            this.odato = odato;
        }

        public int Ono
        {
            get { return ono; }
            set { ono = value; }
        }

        public string Odato
        {
            get { return odato; }
            set { odato = value; }
        }
    }
}
