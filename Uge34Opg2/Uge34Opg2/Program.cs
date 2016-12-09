using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uge34Opg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil bil = new Bil();
            Motor motor = new Motor();
            Topstykke topstykke = new Topstykke();

            motor.HK = 433;
            topstykke.tryk = 1200;

            bil.motor = motor;
            motor.topstykke = topstykke;
            Console.WriteLine(bil.motor.topstykke.tryk);
        }
    }
}
