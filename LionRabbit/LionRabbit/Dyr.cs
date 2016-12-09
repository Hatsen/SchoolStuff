using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LionRabbit
{
    public abstract class Dyr
    {
        private double vaegt;
        private int koen;
        private int x;
        private int y;

        public Dyr(int x, int y, int koen, double vaegt)
        {
            
        }

        public abstract void Spis(double kg);

        public abstract void bevaeg();
    }
}
