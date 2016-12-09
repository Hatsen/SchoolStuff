using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndenGrad
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double d; //Discriminanten
            double x1, x2;

            Console.WriteLine("Indtast a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast c");
            c = Convert.ToInt32(Console.ReadLine());

            d = (b * b) - 4 * a * c;

            if (d == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                Console.WriteLine("Begge løsninger er: {0}", x1);
            }

            else if (d < 0)
            {
                Console.WriteLine("Der er ingen løsninger");
            }

            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("X1 = {0} \n X2 = {1}", x1, x2);
            }
            Console.ReadLine();
        }
    }
}
