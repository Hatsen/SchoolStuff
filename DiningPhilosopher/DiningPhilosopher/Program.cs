using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DiningPhilosopher
{
    class Program
    {
        static void Main(string[] args)
        {
            Bord bord = new Bord();

            /*
            Thread traad1 = new Thread();
            Thread traad2 = new Thread();
            Thread traad3 = new Thread();
            Thread traad4 = new Thread();
            Thread traad5 = new Thread();
             */

            Filosof filosof1 = new Filosof();
            Filosof filosof2 = new Filosof();
            Filosof filosof3 = new Filosof();
            Filosof filosof4 = new Filosof();
            Filosof filosof5 = new Filosof();

            Gaffel gaffel1 = new Gaffel(true, 1, bord);
            Gaffel gaffel2 = new Gaffel(true, 2, bord);
            Gaffel gaffel3 = new Gaffel(true, 3, bord);
            Gaffel gaffel4 = new Gaffel(true, 4, bord);
            Gaffel gaffel5 = new Gaffel(true, 5, bord);

            Random rand = new Random();


            for (int i = 0; i < 100; i++)
            {
                int kage = rand.Next(0, 3);
                Console.WriteLine(kage);
            }
        }
    }
}
