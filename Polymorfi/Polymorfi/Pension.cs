using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorfi
{
    class Pension : Konto
    {
        private int type;

        public Pension(int type, double saldo) : base(saldo)
        {
            this.type = type;
        }

        public int getType
        {
            get { return type; }
            set { type = value; }
        }

        public override void Print()
        {
            Console.WriteLine("Type: {0}, Saldo: {1}", type, saldo);
        }
    }
}
