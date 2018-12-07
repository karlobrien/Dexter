using System;
using System.IO;
using Dexter.Dto;
using NetMQ;
using Google.Protobuf;
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

        public MarketData SendReceiveRequest(MarketData request)
        {
            byte[] bytes;
            using(MemoryStream stream = new MemoryStream())
            {
                request.WriteTo(stream);
                bytes = stream.ToArray();
            }
            var sendSuccess = _requestSocket.TrySendFrame(bytes);

            if (sendSuccess)
            {
                //blocking
                var result = _requestSocket.ReceiveFrameBytes();
                return MarketData.Parser.ParseFrom(result);
            }

            return new MarketData {Instrument = "EMPTY"};
        }

        public void Dispose()
        {
            _requestSocket.Dispose();
        }
    }
}
