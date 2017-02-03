using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaserServer2017_2_3.Base
{
    internal class BTServer : AppServer<BTSession, BTRequestInfo>
    {
        public BTServer()
            : base(new DefaultReceiveFilterFactory<BTReceiveFilter, BTRequestInfo>())
        {
        }
    }
}