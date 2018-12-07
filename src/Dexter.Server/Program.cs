using System;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dexter.Dto;
using NetMQ;

namespace Dexter.Server
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Request/ Response Thread");
            Task t = Task.Run(() => new DataResponse());

            /*
            var interval = Observable.Interval(TimeSpan.FromSeconds(1));
            MulticastPublisher mp = new MulticastPublisher(interval);
            mp.Start();
            */

            Console.ReadLine();
        }
    }


}
