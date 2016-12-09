using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matador
{
    class Program
    {
        static void Main(string[] args)
        {
            Gade g1 = new Gade();
            Gade g2 = new Gade();
            Gade g3 = new Gade();
            Gade g4 = new Gade();

            g1.navn = "Rådhuspladsen";
            g2.navn = "Vestergade";
            g3.navn = "Nygade";
            g4.navn = "Ågade";

            g1.Next = g2;
            g2.Next = g3;
            g3.Next = g4;
            g4.Next = g1;

            Bil b1 = new Bil();
            b1.stårPåGade = g1;

            b1.Flyt();
            b1.PrintGade();

            b1.Flyt();
            b1.PrintGade();

            b1.Flyt();
            b1.PrintGade();

            b1.Flyt();
            b1.PrintGade();
        }
    }
}
