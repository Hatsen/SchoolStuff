using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BufferTraad
{
    class Buffer
    {
        int taeller = 0;

        public void TaellerOp(string navn)
        {
                if (navn.Equals("Producer"))
                {
                    lock (this)
                    {
                        while (taeller > 4)
                        {
                            Console.WriteLine(navn + " " + taeller + " venter");
                            Monitor.Wait(this);
                        }
                        taeller++;
                        Console.WriteLine(navn + " " + taeller + " har produceret");
                        Monitor.Pulse(this);
                    }
                }

                if (navn.Equals("Consumer"))
                {
                    lock (this)
                    {
                        while (taeller < 1)
                        {
                            Monitor.Wait(this);
                            Console.WriteLine(navn + " " + taeller);
                        }
                        taeller--;
                        Console.WriteLine(navn + " " + taeller + " har consumet");
                        Monitor.Pulse(this);
                    }
                }
        }
    }
}
