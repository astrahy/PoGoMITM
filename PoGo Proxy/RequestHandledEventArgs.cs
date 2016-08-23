﻿using System;
using PoGo_Proxy.Models;

namespace PoGo_Proxy
{
    public class RequestHandledEventArgs : EventArgs
    {
        public ulong RequestId { get; set; }
        public MessageBlock RequestBlock { get; set; }
        public MessageBlock ResponseBlock { get; set; }
    }
}
