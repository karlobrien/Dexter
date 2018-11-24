using System;
using NetMQ;
using NetMQ.Sockets;

namespace Dexter.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var client = new RequestSocket())
            {
                client.Connect("tcp://localhost:5555");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Sending Hello");
                    client.SendFrame("Hello");

                    var message = client.ReceiveFrameString();
                    Console.WriteLine("Received {0}", message);
                }
            }
        }
    }
}
