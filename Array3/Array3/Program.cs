using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stjernetegn = { "Vandmand", "Fisk", "Vædder", "Tyr", "Tvilling", "Krebs", "Løve", "Jomfru", "Vægt", "Skorpion", "Skytte", "Stenbuk" };

            Console.WriteLine("Indtast en dato i formatet: 01012001");
            string dato = Console.ReadLine();

            string dag = dato.Substring(0, 2);
            string maaned = dato.Substring(2, 2);
            string aar = dato.Substring(4, 4);

            //Konvertering
            Convert.ToInt32(dag);
            Convert.ToInt32(maaned);
            Convert.ToInt32(aar);

            
        }
    }
}
