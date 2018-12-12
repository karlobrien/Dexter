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
                var mdTopicReceived = _subscriberSocket.TryReceiveFrameString(out var messageTopicReceived);
                if (mdTopicReceived)
                {
                    var mdMsgRecd = _subscriberSocket.TryReceiveFrameBytes(out var msg);
                    var messageReceived = MarketData.Parser.ParseFrom(msg);
                    Console.WriteLine($"PubSub: topic: {messageTopicReceived}, msg: {messageReceived}");
                }
            }
        }
    }
}
