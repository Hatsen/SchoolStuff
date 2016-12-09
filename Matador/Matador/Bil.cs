using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matador
{
    class Bil
    {
        public Gade stårPåGade;

        public Bil()
        { 
        }

        public void Flyt()
        {
            stårPåGade = stårPåGade.Next;
        }

        public void PrintGade()
        {
            Console.WriteLine(stårPåGade.navn);
        }
    }
}
