using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UdregnTrekant
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant();
            t.setHoejde(5.5);
            t.setGrundlinje(8.8);
            Console.WriteLine(t.getArea());

            Console.ReadLine();
        }
    }
}
