using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BufferTraad
{
    class Program
    {
        static void Main(string[] args)
        {
            Traad t1 = new Traad();
            Traad t2 = new Traad();
            Traad t3 = new Traad();

            t1.navn = "Producer";
            t2.navn = "Consumer";
            t3.navn = "Producer";

            Buffer buf = new Buffer();

            t1.buffer = buf;
            t2.buffer = buf;

            Thread thread1 = new Thread(t1.Loop);
            Thread thread2 = new Thread(t2.Loop);
            Thread thread3 = new Thread(t3.Loop);

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}
