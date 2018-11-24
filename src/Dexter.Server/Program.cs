using System;
using System.Threading;
using System.Threading.Tasks;
using NetMQ;
using NetMQ.Sockets;

namespace Dexter.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Task serverTask = Task.Run(() => Server());
            Console.WriteLine("Server");
            Console.ReadLine();
        }

        public static void Server()
        {
            using (var server = new ResponseSocket())
            {
                server.Bind("tcp://*:5555");

                while (true)
                {
                    var message = server.ReceiveFrameString();
                    Console.WriteLine("Received {0}", message);
                    Console.WriteLine("Sending World");
                    server.SendFrame("World");

                    if (message == "exit")
                        break;
                }
            }
        }
    }


}
