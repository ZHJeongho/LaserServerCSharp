using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaserServer2017_2_3.Base
{
    internal class BTRequestInfo : IRequestInfo
    {
        public string Key { get; set; }

        public string command { get; set; }

        public byte[] content { get; set; }
    }
}