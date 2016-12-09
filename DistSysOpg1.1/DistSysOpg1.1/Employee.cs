using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistSysOpg1._1
{
    class Employee
    {
        private int no;
        private string name;
        private static int numberOfEmployees = 0;

        public Employee()
        {
            no = numberOfEmployees;
            numberOfEmployees++;
        }

        public int GetNo()
        {
            return no;
        }

        public void SetNo()
        {
            throw new Exception("Dette system er automatisk. Du må ikke indtaste dit eget nummer.");
        }

        public string GetName()
        {
            return name.Substring(0, 10);
        }

        public void SetName(string s)
        {
            name = s;
        }
    }
}
