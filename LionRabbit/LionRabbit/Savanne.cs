using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LionRabbit
{
    class Savanne
    {
        private Dyr[,] d = new Dyr[8, 8];

        public Savanne()
        {
            d[2, 3] = new Kanin(2,3,0,0.3);
            d[6, 5] = new Loeve(6,5,1,50);
        }

        public void GoGo()
        {
 
        }
    }
}
