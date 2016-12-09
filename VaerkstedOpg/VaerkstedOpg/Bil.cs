using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VaerkstedOpg
{
    class Bil
    {
        public Motor motor;
        string maerke;

        public Bil(string maerke)
        {
            this.maerke = maerke;
        }

        public string Maerke
        {
            get { return maerke; }
            set { maerke = value; }
        }
    }
}
