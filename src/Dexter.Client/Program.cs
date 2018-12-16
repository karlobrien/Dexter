using System;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dexter.Dto;
using NetMQ;
using NetMQ.Sockets;

namespace Dexter.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataRequest dr = new DataRequest();

            var md = new MarketData();
            md.Instrument = "VOD LN";

            var response = dr.SendReceiveRequest(md);
            Console.WriteLine($"Request/ Response: {response.Instrument}");

            MulticastSubscriber ms = new MulticastSubscriber();
            ms.JoinTopic("topic");

            Thread.Sleep(TimeSpan.FromSeconds(5));

            ms.JoinTopic("karl");
            bool stopRequested = false;
            Console.CancelKeyPress += (sender, e) => stopRequested = true;

            Console.ReadLine();
        }
    }

    public class SimpleClient
    {
        private DataRequest _dataRequest;
        private MulticastSubscriber _multicastSubscriber;

        public SimpleClient(string requestAddress, string multicastAddress)
        {
            _dataRequest = new DataRequest();
            _multicastSubscriber = new MulticastSubscriber();
        }
    }
}
