using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opgave_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            string dag;
            string maanede;
            string aar;
            Console.WriteLine("Indtast en dato i formen: ddmmåååå");
            dato = Console.ReadLine();

            dag = dato.Substring(0, 2);
            maanede = dato.Substring(2, 2);
            aar = dato.Substring(4, 4);

            Console.WriteLine("Dag:     " + dag);
            Console.WriteLine("Månede:  " + maanede);
            Console.WriteLine("År:      " + aar);
            Console.ReadLine();
        }
    }
}
