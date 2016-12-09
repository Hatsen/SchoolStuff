using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enhedssalg
{
    class Program
    {
        static void Main(string[] args)
        {
            double enhedspris;
            int antal;
            double salgspris;

            Console.WriteLine("Indtast enhedspris");
            enhedspris = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast antal");
            antal = Convert.ToInt32(Console.ReadLine());

            salgspris = enhedspris * antal;

            if (salgspris >= 500)
            {
                
            }
        }
    }
}
