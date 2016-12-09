using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArkitekturOpg1
{
    class Person
    {
        protected int pid = 0;
        protected string pfname;
        protected string paddress;

        protected List<Order> orders = new List<Order>();

        public Person(string pfname, string paddress)
        {
            this.pfname = pfname;
            this.paddress = paddress;
        }

        public string Pfname
        {
            get { return pfname; }
            set { pfname = (value + "....").Substring(0, 4); }
        }

        public string Paddress
        {
            get { return paddress; }
            set { paddress = value; }
        }

        public void AddOrder(Order o)
        {
            orders.Add(o);
        }
    }
}
