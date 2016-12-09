using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dage = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine("Indtast en dato i formatet: 01012001");
            string dato = Console.ReadLine();

            string dag = dato.Substring(0, 2);
            string maaned = dato.Substring(2, 2);
            string aar = dato.Substring(4, 4);

            //Konvertering
            int dd = Convert.ToInt32(dag);
            int mm = Convert.ToInt32(maaned);
            int aa = Convert.ToInt32(aar);

            Console.ReadLine();
        }
    }
}
