using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            A a1 = new A();
            A a2 = new A();
            A a3 = new A();

            a1.tal = 3;
            a2.tal = 4;
            a3.tal = 5;

            a1.Next = a2;
            a2.Next = a3;

            Console.WriteLine(a1.tal);
            Console.WriteLine(a1.Next.tal);
            Console.WriteLine(a1.Next.Next.tal);
            */
            A start = new A();
            start.tal = 100;
            int tæller = 100;

            for (int i = 0; i < 100; i++)
            {
                A a = new A();
                a.tal = tæller;
                tæller--;
                a.Next = start;
                start = a;
            }
            A index = start;
            while (index.Next != null)
            {
                Console.WriteLine(index.tal);
                index = index.Next;
            }
        }
    }
}
