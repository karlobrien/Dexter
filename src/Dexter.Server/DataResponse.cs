using System;
using NetMQ;
using NetMQ.Sockets;

namespace Dexter.Server
{
    public partial class Program
    {
        public class DataResponse : IDisposable
        {
            private ResponseSocket _responseSocket;

            public DataResponse()
            {
                _responseSocket = new ResponseSocket();
                _responseSocket.Bind("tcp://*:5555");

                while(true)
                {
                    var message = _responseSocket.ReceiveFrameString();
                    Console.WriteLine("Received {0}", message);
                    Console.WriteLine("Sending World");
                    _responseSocket.SendFrame("World");
                }
            }

            public void Dispose()
            {
                _responseSocket.Dispose();
            }
        }
    }


}
