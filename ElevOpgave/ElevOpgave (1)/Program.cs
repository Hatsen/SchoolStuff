using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElevOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Klasse klasse = new Klasse();
            Elev elev1 = new Elev("Ole", 15);
            Elev elev2 = new Elev("Jørgen", 16);
            Elev elev3 = new Elev("Heine", 15);
            Elev elev4 = new Elev("Boris", 35);

            klasse.elevListe.Add(elev1);
            klasse.elevListe.Add(elev2);
            klasse.elevListe.Add(elev3);
            klasse.elevListe.Add(elev4);

            klasse.Print();
        }
    }
}
