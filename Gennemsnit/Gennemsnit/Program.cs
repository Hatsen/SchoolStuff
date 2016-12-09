using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gennemsnit
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                int sum =  i * (i + 1) / 2;
                int result = sum / 20;
                Console.WriteLine("Sum: {0}", sum);
                Console.WriteLine("Gennemsnit: {0}", result);
            }
            Console.ReadLine();
        }
    }
}
