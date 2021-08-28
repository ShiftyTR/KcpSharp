﻿using KcpSharp;

namespace KcpEchoWithConnectionManagement.NetworkConnection
{
    public class NetworkConnectionListenerOptions
    {
        public IKcpBufferPool? BufferPool { get; set; }
        public int Mtu { get; set; } = 1400;
        public int BackLog { get; set; } = 100;
        public int SendQueueSize { get; set; } = 1024;
    }
}
