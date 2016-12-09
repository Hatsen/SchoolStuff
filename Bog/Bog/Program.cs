using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bog
{
    class Program
    {
        static void Main(string[] args)
        {
            Bog bog = new Bog("Eventyr");

            Kapitel kap1 = new Kapitel(1);
            Kapitel kap2 = new Kapitel(2);
            Kapitel kap3 = new Kapitel(3);

            Saetning s1 = new Saetning("Og en");
            Saetning s2 = new Saetning("Prinsesse");
            Saetning s3 = new Saetning("en Prins");
            Saetning s4 = new Saetning("Der var");
            Saetning s5 = new Saetning("engang");

            kap1.Add(s4);
            kap1.Add(s5);

            kap2.Add(s3);

            kap3.Add(s1);
            kap3.Add(s2);

            kap3.next = kap2;
            kap2.next = kap1;

            kap1.last = kap2;
            kap2.last = kap3;

        }
    }
}
