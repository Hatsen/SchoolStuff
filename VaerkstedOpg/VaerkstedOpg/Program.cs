using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VaerkstedOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Værksted værksted = new Værksted();

            Bil bil = new Bil("Ford");
            
            Motor motor1 = new Motor(132);
            Motor motor2 = new Motor(90);
            Motor motor3 = new Motor(50);
            Motor motor4 = new Motor(67);

            værksted.Add(motor1);
            værksted.Add(motor2);
            værksted.Add(motor3);

            bil.motor = motor4;
            Console.WriteLine("Inden skift:");
            Console.WriteLine(bil.motor.HK);

            værksted.SkiftMotor(bil, 132);
            Console.WriteLine("Efter skift:");
            Console.WriteLine(bil.motor.HK);
        }
    }
}
