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
        private NetMQPoller _poller;
        public MulticastSubscriber()
        {
            ReceiveQueue = new ConcurrentQueue<MarketData>();
            _subscriberSocket = new SubscriberSocket();
            _poller = new NetMQPoller();  //{ _subscriberSocket };

            _subscriberSocket.ReceiveReady += SubscriberMessage;
            _subscriberSocket.Options.ReceiveHighWatermark = 1000;
            _subscriberSocket.Connect("tcp://localhost:4090");
            _poller.RunAsync();
        }

        public void JoinTopic(string topic)
        {
            Console.WriteLine($"Subscriber socket connecting to {topic}");
            _subscriberSocket.Subscribe(topic);
            _poller.Add(_subscriberSocket);
        }

        private void SubscriberMessage(object sender, NetMQSocketEventArgs e)
        {
            NetMQMessage message = null;
            var msg = e.Socket.TryReceiveMultipartMessage(ref message, 2);
            if (msg)
            {
                Console.WriteLine(message.First.ConvertToString());
                var unwrap = MarketData.Parser.ParseFrom(message.Last.Buffer);
                Console.WriteLine(unwrap.Instrument);
            }
        }
    }
}
