using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorfi
{
    class OpsparingBolig : Konto
    {
        private double opsparing;

        public OpsparingBolig(double opsparing, double saldo) : base(saldo)
        {
            this.opsparing = opsparing;
        }

        public double GetOpsparing
        {
            get { return opsparing; }
            set { opsparing = value; }
        }

        public override void Print()
        {
            Console.WriteLine("Opsparing: {0}, Saldo: {1}", opsparing, saldo);
        }
    }
}
