using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto[] konti = new Konto[4];
            konti[0] = new BoerneOps(5, 5000.32);
            konti[1] = new Pension(1, 4322.31);
            konti[2] = new OpsparingBolig(7213, 3213.42);

            for (int i = 0; i > 4; i++)
            {
                konti[i].Print();
            }
        }
    }
}
