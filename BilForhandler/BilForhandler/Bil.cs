using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilForhandler
{
    class Bil
    {
        private String regNr;
        private String maerke;
        private int vaegt;
        private bool traek;

        public Bil(string regNr, string maerke, int vaegt, bool traek)
        {
            this.regNr = regNr;
            this.maerke = maerke;
            this.vaegt = vaegt;
            this.traek = traek;
        }

        public double udregnAfgift(int vaegt, bool traek)
        {
            double pris = 0;
            int overvaegt = 0;

            if (vaegt <= 800)
            {
                pris = vaegt * 50;
            }
            else if (vaegt > 800)
            {
                overvaegt = vaegt - 800;
                pris = vaegt * 50 + (overvaegt * 75);
            }

            if (traek == true)
            {
                pris += 200;
            }

            return pris;
        }
    }
}
