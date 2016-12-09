using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistSysOpg1._1
{
    class EmployeeList
    {
        private static EmployeeList instance = null;
        List<Employee> empList = new List<Employee>();

        public void Add(Employee e)
        {
            empList.Add(e);
        }

        public Employee Get(int no)
        { 
                return empList[0];
        }

        public static EmployeeList GetInstance()
        {
            if (instance == null)
            {
                instance = new EmployeeList();
            }
            return instance;
        }

    }
}
    