using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorfi
{
    class BoerneOps : Konto
    {
        private int alder;

        public BoerneOps(int alder, double saldo) : base(saldo)
        {
            this.alder = alder;
        }

        public int GetAlder
        {
            get { return alder; }
            set { alder = value; }
        }

        public override void Print()
        {
            Console.WriteLine("Alder: {0}, Saldo: {1}", alder, saldo);
        }
    }
}
