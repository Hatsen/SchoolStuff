using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBOpg
{
    class EEmployee
    {
        private string SSN;
        private string name;
        private int dno;

        public EEmployee(string SSN, string name, int dno)
        {
            this.SSN = SSN;
            this.name = name;
            this.dno = dno;
        }

        public string GetSSN
        {
            get { return SSN; }
            set { SSN = value; }
        }

        public string GetName
        {
            get { return name; }
            set { name = value; }
        }

        public int GetDno
        {
            get { return dno; }
            set { dno = value; }
        }

        public void Save()
        {
 
        }
    }
}
