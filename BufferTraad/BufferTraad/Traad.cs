using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BufferTraad
{
    class Traad
    {
        public Buffer buffer;
        public string navn;

        public void Loop()
        {
                for (int i = 0; i < 100; i++)
                {
                    buffer.TaellerOp(navn);
                }
        }
    }
}
