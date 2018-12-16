using System;
using System.Collections.Concurrent;
using Dexter.Dto;
using NetMQ;
using NetMQ.Sockets;

namespace Dexter.Client
{
    public class MulticastSubscriber
    {
        public ConcurrentQueue<MarketData> ReceiveQueue { get; }
        private SubscriberSocket _subscriberSocket;
        public MulticastSubscriber()
        {
            ReceiveQueue = new ConcurrentQueue<MarketData>();
            _subscriberSocket = new SubscriberSocket();
            _subscriberSocket.Options.ReceiveHighWatermark = 1000;
            _subscriberSocket.Connect("tcp://localhost:4090");
            _subscriberSocket.Subscribe("topic");

            Console.WriteLine("Subscriber socket connecting...");

            while (true)
            {
                NetMQMessage message = null;
                var msg = _subscriberSocket.TryReceiveMultipartMessage(ref message, 2);
                if (msg)
                {
                    Console.WriteLine(message.First.ConvertToString());
                    var unwrap = MarketData.Parser.ParseFrom(message.Last.Buffer);
                    Console.WriteLine(unwrap.Instrument);
                }
            }
        }
    }
}
