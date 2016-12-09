using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorfi
{
    public abstract class Konto
    {
        protected double saldo;

        public Konto(double saldo)
        {
            this.saldo = saldo;
        }

        public virtual void Print()
        {
            Console.WriteLine(saldo);
        }

        public double GetSaldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
    }
}
