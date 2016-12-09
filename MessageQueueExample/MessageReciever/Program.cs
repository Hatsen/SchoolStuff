using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MessageReciever
{
    class Program
    { //CONSUMER
        static void Main(string[] args)
        {
            Console.WriteLine("Awaiting messages to consume and capitalize...");
            MessageQueue mq = new MessageQueue(@".\private$\Test");

            mq.Formatter = new XmlMessageFormatter(new string[] { "System.String,mscorlib" });
            mq.ReceiveCompleted += messageQueue_RecieveCompleted;
            mq.BeginReceive();

            string newMessage = Console.ReadLine();
        }

        static void messageQueue_RecieveCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            MessageQueue sendingQueue = new MessageQueue(@".\private$\Lasagne");

            var messageQueue = (MessageQueue)sender;
            var message = messageQueue.EndReceive(e.AsyncResult);
            var cleanMessage = new StreamReader(message.BodyStream).ReadToEnd();
            sendingQueue.Send(cleanMessage.ToUpper());
            messageQueue.BeginReceive();
        }
    }
}
