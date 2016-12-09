using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArkitekturOpg1
{
    class Item
    {
        private int ino;
        private string itext;
        private int iprice;

        public Item(int ino, string itext, int iprice)
        {
            this.ino = ino;
            this.itext = itext;
            this.iprice = iprice;
        }

        public int Ino
        {
            get { return ino; }
            set { ino = value; }
        }

        public string Itext
        {
            get { return itext; }
            set { itext = value; }
        }

        public int Iprice
        {
            get { return iprice; }
            set { iprice = value; }
        }
    }
}
