using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
using System.IO;

namespace MessageEndClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Awaiting capitalized messages...");
            MessageQueue mq = new MessageQueue(@".\private$\Lasagne");

            mq.Formatter = new XmlMessageFormatter(new string[] { "System.String,mscorlib" });
            mq.ReceiveCompleted += messageQueue_RecieveCompleted;
            mq.BeginReceive();

            while (true)
            {
                string message = Console.ReadLine();
            }
        }

        static void messageQueue_RecieveCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            var messageQueue = (MessageQueue)sender;
            var message = messageQueue.EndReceive(e.AsyncResult);
            Console.WriteLine(new StreamReader(message.BodyStream).ReadToEnd());
            messageQueue.BeginReceive();
        }
    }
}
