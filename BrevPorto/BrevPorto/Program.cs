using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrevPorto
{
    class Program
    {
        static void Main(string[] args)
        {
            double vaegt;

            Console.WriteLine("Indtast vægt");
            vaegt = Convert.ToDouble(Console.ReadLine());

            if (vaegt > 0 && vaegt <= 50)
            {
                Console.WriteLine("Prisen på dit brev er kr. 8");
            }
            else if (vaegt > 50 && vaegt <= 100)
            {
                Console.WriteLine("Prisen på dit brev er kr. 16");
            }
            else if (vaegt > 100 && vaegt <= 250)
            {
                Console.WriteLine("Prisen på dit brev er kr. 25");
            }
            else if (vaegt > 250 && vaegt <= 500)
            {
                Console.WriteLine("Prisen på dit brev er kr. 35");
            }
            else if (vaegt > 750 && vaegt <= 1000)
            {
                Console.WriteLine("Prisen på dit brev er kr. 46");
            }
            else if (vaegt > 1000 && vaegt <= 2000)
            {
                Console.WriteLine("Prisen på dit brev er kr. 58");
            }
            else
            {
                Console.WriteLine("Her kan du ikke få sendt et brev");
            }

            Console.ReadLine();
        }
    }
}
