using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArkitekturOpg1
{
    class Cat
    {
        private Person p;
        private int catno;

        public Cat(int catno)
        {
            this.catno = catno;
        }

        public int Catno
        {
            get { return catno; }
            set { catno = value; }
        }
    }
}
