using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BilForhandlerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string regNr;
            string maerke;
            int vaegt;
            bool traek;

            Console.WriteLine("Indtast et registeringsnummer");
            regNr = Console.ReadLine();

            Console.WriteLine("Indtast et mærke");
            maerke = Console.ReadLine();

            Console.WriteLine("Indtast bilens vægt");
            vaegt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Har bilen afhængertræk? Ja/Nej?");
            string temp = Console.ReadLine();

            if (temp.ToLower() == "ja")
            {
                traek = true;
            }
            else
            {
                traek = false;
            }



            ArrayList bilList = new ArrayList();
            bilList.Add(new Bil(regNr, maerke, vaegt, traek));

            foreach (object o in bilList)
            {
                Console.WriteLine(o);
            }
            Console.ReadLine();
        }
    }
}
