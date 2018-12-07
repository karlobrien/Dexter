using System;
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
                //put this on the socket send
                Console.WriteLine($"Sending {sub}");
                _publisherSocket.SendMoreFrame("topic").SendFrame($"{sub}");
            });
        }

        public void Dispose()
        {
            _liveDataDis.Dispose();
            _publisherSocket.Dispose();
        }
    }
}