﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KcpSharp;

namespace KcpEchoWithConnectionManagement.NetworkConnection
{
    public class KcpNetworkConnectionOptions
    {
        public IKcpBufferPool? BufferPool { get; set; }
        internal KcpNetworkConnectionNegotiationOperationPool? NegotiationOperationPool { get; set; }
        public int Mtu { get; set; } = 1400;
        public int SendQueueSize { get; set; } = 1024;
    }
}
