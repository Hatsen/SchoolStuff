using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WindowsFormsApplication1
{
    class Metoder
    {
        public static ArrayList Personer = new ArrayList();
   
        public static void NyPerson(string navn, string by, int alder)
            {
                Person P = new Person(navn, by, alder);
                Personer.Add(P);
            }

        public static int FindPerson(string navn)
        {
            bool found = false;
            int i = 0;
            int result = 0;

            while (!found &&  i < Personer.Count)
            {
                Person P = (Person)Personer[i];

                if (P.GetNavn == navn)
                {
                    found = true;
                    result = P.GetAlder;
                }
                else
                    i++;
            }
            return result;
        }
    }
}
