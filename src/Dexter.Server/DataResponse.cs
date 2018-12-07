using System;
using System.IO;
using Dexter.Dto;
using Google.Protobuf;
using NetMQ;
using NetMQ.Sockets;

namespace Dexter.Server
{
        public class DataResponse : IDisposable
        {
            private ResponseSocket _responseSocket;

            public DataResponse()
            {
                _responseSocket = new ResponseSocket();
                _responseSocket.Bind("tcp://*:5555");

                while(true)
                {
                    var mdMsg = _responseSocket.TryReceiveFrameBytes(out var items);
                    if (mdMsg)
                    {
                        MarketData mdRecd = MarketData.Parser.ParseFrom(items);

                        Console.WriteLine("Received {0}", mdRecd.Instrument);
                        mdRecd.Instrument = "CORP LN";

                        byte[] bytes;
                        using (MemoryStream stream = new MemoryStream())
                        {
                            mdRecd.WriteTo(stream);
                            bytes = stream.ToArray();
                        }

                       var sendSuccess = _responseSocket.TrySendFrame(bytes);
                    }
                }
            }

            public void Dispose()
            {
                _responseSocket.Dispose();
            }
        }
    }
