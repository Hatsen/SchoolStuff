using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Spilleplade
    {
        private static Spilleplade instance = new Spilleplade();

        public Spilleplade()
        {
        }

        public string[,] spillePlade =
        {
            {"+", "+", "+"}, 
            {"+", "+", "+"}, 
            {"+", "+", "+"}
        };

        public void tjekSejr(Spiller spiller)
        {
            string[,] winningCombos =
            {
                {instance.spillePlade[0,0], instance.spillePlade[0,1], instance.spillePlade[0,2]},
                {instance.spillePlade[1,0], instance.spillePlade[1,1], instance.spillePlade[1,2]},
                {instance.spillePlade[2,0], instance.spillePlade[2,1], instance.spillePlade[2,2]},
                {instance.spillePlade[0,0], instance.spillePlade[1,0], instance.spillePlade[2,0]},
                {instance.spillePlade[0,1], instance.spillePlade[1,1], instance.spillePlade[2,1]},
                {instance.spillePlade[0,2], instance.spillePlade[1,2], instance.spillePlade[2,2]},
                {instance.spillePlade[0,0], instance.spillePlade[1,1], instance.spillePlade[2,2]},
                {instance.spillePlade[0,2], instance.spillePlade[1,1], instance.spillePlade[2,0]} 
            };

            for (int i = 0; i < 8; i++)
            {

                //Her tjekker vi om spiller1 har vundet.
                if ((winningCombos[i, 0] == "X") & (winningCombos[i, 1] == "X") & (winningCombos[i, 2] == "X"))
                {
                    spiller.printVinder(spiller);
                }

                //Her tjekker vi om spiller2 har vundet.
                if ((winningCombos[i, 0] == "O") & (winningCombos[i, 1] == "O") & (winningCombos[i, 2] == "O"))
                {
                    spiller.printVinder(spiller);
                }

            }
        }

        public bool tjekPlade(string spiller, int x, int y)
        {
            if (spillePlade[x, y] == "X" || spillePlade[x, y] == "O")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void printPlade()
        {
            int rowLength = instance.spillePlade.GetLength(0);
            int colLength = instance.spillePlade.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", instance.spillePlade[i, j]));
                }
                Console.Write("\n");
            }
        }

        public static Spilleplade getPlade()
        {
            return instance;
        }
    }
}
