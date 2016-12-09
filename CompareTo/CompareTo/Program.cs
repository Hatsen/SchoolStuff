using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareTo
{
    class Program
    {
        static void Main(string[] args)
        {
            string elefant = "elefant";
            string storElefant = "Elefant";
            int x = elefant.CompareTo(storElefant);
            Console.WriteLine(x);

            string tal1 = "2230";
            string tal2 = "8";
            int y = tal1.CompareTo(tal2);
            Console.WriteLine(y);

            string tom = "Tom";
            string tim = "Tim";
            int z = tom.CompareTo(tim);
            Console.WriteLine(z);

            string cSharp = "C#";
            string chip = "Chip";
            int x2 = cSharp.CompareTo(chip);
            Console.WriteLine(x2);

            string skaal = "skål";
            string skael = "Skæl";
            int y2 = skaal.CompareTo(skael);
            Console.WriteLine(y2);

            Console.ReadLine();
        }
    }
}
