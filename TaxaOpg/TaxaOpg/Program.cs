using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxaOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxaStation station = new TaxaStation();

            Ture tur1 = new Ture();
            Ture tur2 = new Ture();
            Ture tur3 = new Ture();
            Ture tur4 = new Ture();

            Bil bil1 = new Bil();
            Bil bil2 = new Bil();

            bil1.Navn = "Jens";
            bil2.Navn = "Karl";

            station.Add(tur1);
            station.Add(tur2);
            station.Add(tur3);
            station.Add(tur4);

            tur1.Pris = 100;
            tur2.Pris = 90;
            tur3.Pris = 120;
            tur2.Pris = 40;

            tur1.bil = bil1;
            tur2.bil = bil2;
            tur3.bil = bil1;
            tur4.bil = bil2;
        }
    }
}
