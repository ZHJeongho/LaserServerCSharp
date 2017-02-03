using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaserServer2017_2_3.Base
{
    internal class BTSession : AppSession<BTSession, BTRequestInfo>
    {
        protected override void HandleException(Exception e)
        {
            base.HandleException(e);
        }
    }
}