using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanningPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 er det mindste tal i Planning Poker, 9999 skal ses som et spørgsmålstegn
            double[] pokerTal = { 0, 0.5, 1, 2, 3, 5, 8, 13, 20, 40, 100, 9999 };

            Random randomTal = new Random();

            for (int i = 0; i < 4; i++)
            {
                int tal = randomTal.Next(0, 12);
                Console.WriteLine(pokerTal[tal]);
            }
            Console.ReadLine();
        }
    }
}
