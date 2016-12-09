using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
using System.IO;

namespace MessageQueueExample
{
    class Program
    { //PRODUCER
        static void Main(string[] args)
        {
            Console.WriteLine("Type in your message...");
            MessageQueue listener = new MessageQueue(@".\private$\Lala");
            MessageQueue mq;

            if(MessageQueue.Exists(@".\private$\Test"))
            {
                mq = new MessageQueue(@".\private$\Test");
                mq.Label = "Lala";
                
            }
            else
            {
                 mq = MessageQueue.Create(@".\private$\Test");
                 mq.Label = "Lalala";
            }

            while (true)
            {
                string message = Console.ReadLine();
                mq.Send(message);
            }
        }

        static void messageQueue_RecieveCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            var messageQueue = (MessageQueue)sender;
            var message = messageQueue.EndReceive(e.AsyncResult);
            Console.WriteLine(new StreamReader(message.BodyStream).ReadToEnd().ToUpper());
            messageQueue.BeginReceive();
        }
    }
}
