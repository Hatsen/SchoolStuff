using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        public static int spiller1Ture = 0;
        public static int spiller2Ture = 0;

        public static Spilleplade sp = new Spilleplade();
        public static Spiller Spiller1 = new Spiller("");
        public static Spiller Spiller2 = new Spiller("");

        static void Main(string[] args)
        {
            StartSpil();
        }

        public static void StartSpil()
        {
            Console.WriteLine("Spiller1, indtast venligst dit navn.");
            Spiller1.Navn = Console.ReadLine();

            Console.WriteLine("Spiller2, indtast venligst dit navn.");
            Spiller2.Navn = Console.ReadLine();

            Console.WriteLine("Spiller1 placere den første brik");
            Spiller1Tur();
            Spiller2Tur();
            Spiller1Tur();
            Spiller2Tur();
            Spiller1Tur();
            TjekSejr();
            Spiller2Tur();
            TjekSejr();

            //Hvis ingen har vundet spillet - uafgjort.
            Console.WriteLine("Spillet er nu slut, og en vinder blev ikke fundet. Bedre held næste gang.");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public static void Spiller1Tur()
        {
            Spilleplade sp = Spilleplade.getPlade();
            Brik spiller1 = new Brik("spiller1");
            int x = 0;
            int y = 0;

            sp.printPlade();
            Console.WriteLine("Spiller1, indtast venligst dine ønskede kordinater");
            x = Convert.ToInt32(Console.ReadLine()) - 1;
            y = Convert.ToInt32(Console.ReadLine()) - 1;

            while (sp.tjekPlade("spiller1", x, y) == false)
            {
                Console.WriteLine("Der er der allerede placeret en brik. Prøv igen!");
                x = Convert.ToInt32(Console.ReadLine()) - 1;
                y = Convert.ToInt32(Console.ReadLine()) - 1;
            }
            spiller1Ture++;
            spiller1.placerBrik(x, y);
            Console.Clear();
        }

        public static void Spiller2Tur()
        {
            Spilleplade sp = Spilleplade.getPlade();
            Brik spiller2 = new Brik("spiller2");
            int x = 0;
            int y = 0;

            sp.printPlade();
            Console.WriteLine("Spiller 2, indtast venligst dine ønskede kordinater");
            x = Convert.ToInt32(Console.ReadLine()) - 1;
            y = Convert.ToInt32(Console.ReadLine()) - 1;

            while (sp.tjekPlade("spiller2", x, y) == false)
            {
                Console.WriteLine("Der er der allerede placeret en brik. Prøv igen!");
                x = Convert.ToInt32(Console.ReadLine()) - 1;
                y = Convert.ToInt32(Console.ReadLine()) - 1;
            }
            spiller2Ture++;
            spiller2.placerBrik(x, y);

            Console.Clear();
        }

        public static void TjekSejr()
        {
            if (spiller2Ture == 3)
            {
                sp.tjekSejr(Spiller2);
            }
            else
                sp.tjekSejr(Spiller1);
        }
    }
}
