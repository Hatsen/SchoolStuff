using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Brik
    {
        private string spillerBrik;
        private string tegn;

        public Brik(string spiller)
        {
            this.spillerBrik = spiller;

            if (spiller == "spiller1")
                tegn = "X";
            else
                tegn = "O";
        }

        public void placerBrik(int x, int y)
        {
            try
            {
                Spilleplade sp = Spilleplade.getPlade();
                sp.spillePlade[x, y] = tegn;
            }
            catch (Exception ex)
            {
                Console.WriteLine("En fejl opstod, gå venligst i panik.");
            }
        }
    }
}
