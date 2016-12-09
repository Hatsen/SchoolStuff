using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaerSoegning
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] t = new String[10000];

            Random random = new Random();
            
            for (int i = 0; i < 10000; i++)
            {
                t[i] = " " + random.Next(1, 10000);
            }

            string tempTime = DateTime.Now.ToString("HH:mm:ss tt");

            Console.WriteLine("Tiden før sorteringen: " + tempTime);
            BubbleSort(t);

            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }
            Console.WriteLine("Tid inden sorteringen: " + tempTime);
            Console.WriteLine("Tid efter sorteringen: " + DateTime.Now.ToString("HH:mm:ss tt"));

            Console.WriteLine("Indtast et søgetal");
            string soegeTal = Console.ReadLine();

            Soeg(t, soegeTal);
        }

        public static int Soeg(String[] t, string soegeTal)
        {
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == soegeTal)
                {
                    return i;
                }
            }
                return -1;
        }

        public static void BubbleSort(string[] t)
        {
            for (int i = t.Length - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                    if (t[j].CompareTo(t[j + 1]) > 0)
                    {
                        string b = t[j];
                        t[j] = t[j + 1];
                        t[j + 1] = b;
                    }
        }
    }
}
