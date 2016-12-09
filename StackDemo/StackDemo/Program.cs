using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stak s = new Stak();
            s.Push(3);
            s.Push(4);
            s.Push(7);
            s.Push(9);

            s.PrintStak();

            int x = s.Pop();
            s.PrintStak();
            //s.AddUnderTop(19);
        }
    }
}
