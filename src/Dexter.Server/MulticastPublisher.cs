using System;
using System.IO;
using Dexter.Dto;
using Google.Protobuf;
using NetMQ;
using NetMQ.Sockets;

namespace Dexter.Server
{
    public class MulticastPublisher : IDisposable
    {
        private IDisposable _liveDataDis;
        private PublisherSocket _publisherSocket;
        private IObservable<long> _liveData;
        public MulticastPublisher(IObservable<long> liveData)
        {
            _liveData = liveData;
            _publisherSocket = new PublisherSocket();
            _publisherSocket.Options.SendHighWatermark = 1000;
            _publisherSocket.Bind("tcp://localhost:4090");
        }

        public void Start()
        {
            _liveDataDis = _liveData.Subscribe(sub => {

                MarketData msg = new MarketData();
                msg.Instrument = "VOD LN";
                msg.AskPrice = 2;
                msg.BidPrice = 4;

                byte[] bytes;
                using(MemoryStream stream = new MemoryStream())
                {
                    msg.WriteTo(stream);
                    bytes = stream.ToArray();
                }
                //put this on the socket send
                Console.WriteLine($"Sending {msg.Instrument}");
                _publisherSocket.SendMoreFrame("topic").SendFrame(bytes);
            });
        }

        public void Dispose()
        {
            _liveDataDis.Dispose();
            _publisherSocket.Dispose();
        }
    }
}