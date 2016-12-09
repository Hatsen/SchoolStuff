using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElevOpgave
{
    class Klasse
    {
       public List<Elev> elevListe = new List<Elev>();

       public void Print()
       {
           foreach (var elev in elevListe)
           {
               Console.WriteLine("Elev: {0}, {1} år", elev.Navn, elev.Aar);
           }
       }
        
       
    }
}
