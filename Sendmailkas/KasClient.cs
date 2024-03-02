using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;
using Protowire;

namespace Sendmailkas
{
    /// <summary>
    /// demo:A .NET usage implementation of the kaspad
    /// 
    /// Made by kaspa:qpje7d7x4w0hme7yzxtvas0qmj5h946p3vpxhag56wqwrkamfshxq4ev0kczz
    /// 
    /// </summary>
    public class KasClient:RPC.RPCClient, IDisposable
    {
        public RPC.RPCClient Client { get; private set; }

        private GrpcChannel channel;

        public KasClient(string url = "http://localhost:16110")
        {
            channel = GrpcChannel.ForAddress(url);
            Client = new RPC.RPCClient(channel);            
        }

        public void Dispose()
        {
            channel.Dispose();
        }
    }
}
