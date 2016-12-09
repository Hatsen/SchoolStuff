using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string fil = @"C:\Tekst.txt";

            StreamWriter SW = new StreamWriter(fil);

            SW.WriteLine("Hej med dig!");
            SW.WriteLine("Du er grim!");

            SW.Close();
        }
    }
}
