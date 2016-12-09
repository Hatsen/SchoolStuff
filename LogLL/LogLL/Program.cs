using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogLL
{
    class Program
    {
        static void Main(string[] args)
        {
            LL s = new LL();
            s.add(3);
            s.add(7);
            s.add(5);
            s.add(6);
            s.printAll();
            s.printAllOver(6);
            
            int sum = s.BeregnSum();
            bool ok = s.Empty();
            s.SletFoersteElement();
            s.Count();
        }
    }
}
