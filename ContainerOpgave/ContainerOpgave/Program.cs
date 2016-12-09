using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContainerOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            TalContainer tc = new TalContainer();
            tc.Tilfoej(5);
            tc.Tilfoej(9);
            tc.Tilfoej(7);
            tc.Tilfoej(4);
            tc.Print();
            tc.Slet(9);
            tc.Erstat(7, 108);
            tc.Print();

            int sum = tc.BeregnSum();
            int max = tc.BeregnMax();


            bool fundet = tc.Soeg(4);
            if (fundet == true)
                Console.WriteLine("4 er i containeren");

            Console.WriteLine(sum);
            Console.WriteLine(max);
        }
    }
}
