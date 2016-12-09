using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ugedage = { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag", "Lørdag" };

            Console.WriteLine("Indtast en ugedag imellem 1 til 6");
            int x = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine(ugedage[x]);

            Console.ReadLine();
        }
    }
}
