using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxaOpg
{
    class TaxaStation
    {
        List<Ture> turListe = new List<Ture>();

        public void Add(Ture tur)
        {
            turListe.Add(tur);
        }
    }
}
