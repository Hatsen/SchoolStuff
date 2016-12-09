using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Spiller
    {
        string navn;

        public Spiller(string navn)
        {
            this.navn = navn;
        }

        public void printVinder(Spiller spiller)
        {
            Console.WriteLine(spiller.Navn + " vinder spillet! \n Tillykke!");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public string Navn
        {
            get { return navn; }
            set { this.navn = value; }
        }
    }
}
