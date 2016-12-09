using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VaerkstedOpg
{
    class Værksted
    {
        List<Motor> motorList = new List<Motor>();

        public void Add(Motor m)
        {
            motorList.Add(m);
        }

        public void SkiftMotor(Bil b, int hk)
        {
            foreach (var m in motorList)
            {
                if (m.HK == hk)
                {
                    Motor temp;
                    temp = m;

                    b.motor = temp;
                    motorList.Remove(m);
                }
            }
        }
    }
}
