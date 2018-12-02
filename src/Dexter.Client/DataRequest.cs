using System;
using NetMQ;
using NetMQ.Sockets;

namespace Dexter.Client
{
    public class DataRequest : IDisposable
    {
        private RequestSocket _requestSocket;
        public DataRequest()
        {
            _requestSocket = new RequestSocket();
            _requestSocket.Connect("tcp://localhost:5555");
        }

        public string SendReceiveRequst(string request)
        {
            _requestSocket.SendFrame(request);
            var message = _requestSocket.ReceiveFrameString();
            return message;
        }

        public void Dispose()
        {
            _requestSocket.Dispose();
        }
    }
}
