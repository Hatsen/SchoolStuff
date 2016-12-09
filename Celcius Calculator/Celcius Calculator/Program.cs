using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Celcius_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculating();
        }

        public static void Calculating()
        {
            double celcius;
            double fahrenheit;
            double kelvin;
            double reaumur;

            Console.WriteLine("Indtast graderne i celcius");
            celcius = Convert.ToDouble(Console.ReadLine());

            //Udregning
            fahrenheit = celcius * 1.80 + 32;
            kelvin = celcius + 273.15;
            reaumur = celcius * 0.8;

            //Resultat
            Console.WriteLine("I celcius er graderne: {0}, fahrenheit: {1}, kelvin: {2}, reaumur: {3}", celcius, fahrenheit, kelvin, reaumur);
            Console.ReadLine();               
        }
    }
}
