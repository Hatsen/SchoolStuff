using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArkitekturOpg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Jones", "Florida");
            PrintPerson(p);

            List<Person> plist = new List<Person>();
            plist.Add(p);

            Customer c = new Customer("Bobo", "Boboland", 1000);
            plist.Add(c);
        }

        static void PrintPerson(Person p)
        {
            Console.WriteLine("Person: " + p.Pfname + " " + p.Paddress);
        }
    }
}
