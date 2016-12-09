using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistSysOpg1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee patrick = new Employee();
            Employee kurt = new Employee();
            patrick.SetName("012345678910");
            Console.WriteLine(patrick.GetName());
            Console.WriteLine(patrick.GetNo());
            Console.WriteLine(kurt.GetNo());
        }
    }
}
