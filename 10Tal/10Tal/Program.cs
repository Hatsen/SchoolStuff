using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Indtast tal nummer: " + i);
                int tal = Convert.ToInt32(Console.ReadLine());
                sum += tal;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
