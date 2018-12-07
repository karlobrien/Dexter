using System;
using System.Collections.Concurrent;
using NetMQ;
using NetMQ.Sockets;

namespace Dexter.Client
{
    public class MulticastSubscriber
    {
        public ConcurrentQueue<string> ReceiveQueue { get; }
        private SubscriberSocket _subscriberSocket;
        public MulticastSubscriber()
        {
            ReceiveQueue = new ConcurrentQueue<string>();
            _subscriberSocket = new SubscriberSocket();
            _subscriberSocket.Options.ReceiveHighWatermark = 1000;
            _subscriberSocket.Connect("tcp://localhost:4090");
            _subscriberSocket.Subscribe("topic");

            Console.WriteLine("Subscriber socket connecting...");

            while (true)
            {
                string messageTopicReceived = _subscriberSocket.ReceiveFrameString();
                string messageReceived = _subscriberSocket.ReceiveFrameString();
                Console.WriteLine($"PubSub: topic: {messageTopicReceived}, msg: {messageReceived}");
            }
        }
    }
}
