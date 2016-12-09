using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kø
{
    class Program
    {
        static void Main(string[] args)
        {
            Koe k = new Koe();
            k.Enqueue(4);
            k.Enqueue(7);
            k.Moever(1, 200);
            k.PrintQueue();
        }
    }
}
