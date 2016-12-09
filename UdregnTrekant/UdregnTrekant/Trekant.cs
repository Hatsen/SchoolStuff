using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UdregnTrekant
{
    class Trekant
    {
        private double hoejde;
        private double grundlinje;

        public void setHoejde(double trekantHoejde)
        {
            hoejde = trekantHoejde;
        }

        public double getHoejde()
        {
            return hoejde;
        }

        public void setGrundlinje(double trekantGrundlije)
        {
            grundlinje = trekantGrundlije;
        }

        public double getGrundlinje()
        {
            return grundlinje;
        }

        public double getArea()
        {
            return 0.5 * hoejde * grundlinje;
        }
    }
}
