using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using NetMQ;
using NetMQ.Sockets;
namespace SubscriberA
{
    class Program
    {
        public static IList<string> allowableCommandLineArgs
            = new[] { "TopicA", "TopicB", "All" };
        static void Main(string[] args)
        {
            //using (var server = new ResponseSocket("@tcp://127.0.0.1:5556"))
            //using (var client = new RequestSocket(">tcp://127.0.0.1:5556"))
            //{
            //    // client sends message consisting of two frames
            //    Console.WriteLine("Client sending");
            //    client.SendMoreFrame("A").SendFrame("Hello");
            //    // server receives frames
            //    bool more = true;
            //    while (more)
            //    {
            //        string frame = server.ReceiveFrameString(out more);
            //        Console.WriteLine("Server received frame={0} more={1}",
            //            frame, more);
            //    }
            //    Console.WriteLine("================================");
            //    // server sends message, this time using NetMqMessage
            //    var msg = new NetMQMessage();
            //    msg.Append("From");
            //    msg.Append("Server");
            //    Console.WriteLine("Server sending");
            //    server.SendMultipartMessage(msg);
            //    // client receives the message
            //    msg = client.ReceiveMultipartMessage();
            //    Console.WriteLine("Client received {0} frames", msg.FrameCount);
            //    foreach (var frame in msg)
            //        Console.WriteLine("Frame={0}", frame.ConvertToString());
            //    Console.ReadLine();



            //    Console.Read();
           // }
        }
    }
}