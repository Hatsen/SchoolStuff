using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KvadratTal
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            { 
                double res = Math.Pow(i, 2);
                Console.WriteLine("Kvadratet af {0} er {1}", i, res);
            }
            Console.ReadLine();
        }
    }
}
