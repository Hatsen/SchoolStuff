using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VaerkstedOpg
{
    class Motor
    {
        int hk = 0;

        public Motor(int hk)
        {
            this.hk = hk;
        }

        public int HK
        {
            get { return hk; }
            set { hk = value; }
        }
    }
}
