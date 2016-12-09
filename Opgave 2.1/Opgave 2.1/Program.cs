using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opgave_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double bredde;
            double laengde;
            double hoejde;
            double overflade;

            Console.WriteLine("Indtast bredde");
            bredde = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast laengde");
            laengde = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast hoejde");
            hoejde = Convert.ToDouble(Console.ReadLine());

            //Udregning
            overflade = 2 * (laengde * bredde) + 2 * (laengde * hoejde) + 2 * (hoejde * bredde);

            //Udprint
            Console.Clear();
            Console.WriteLine("Bredden      " + bredde);
            Console.WriteLine("Længden      " + laengde);
            Console.WriteLine("Højden       " + hoejde);
            Console.WriteLine("Overfladen   " + overflade);
            Console.ReadLine();
        }
    }
}
