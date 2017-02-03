using SuperSocket.Facility.Protocol;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaserServer2017_2_3.Base
{
    internal class BTReceiveFilter : FixedHeaderReceiveFilter<BTRequestInfo>
    {
        public BTReceiveFilter()
            : base(6)
        {
        }

        protected override int GetBodyLengthFromHeader(byte[] header, int offset, int length)
        {
            Console.WriteLine("" + (int)header[offset + 3]);
            Console.WriteLine("" + (int)header[offset + 4]);
            Console.WriteLine("" + (int)header[offset + 3] * 256 + (int)header[offset + 4]);
            return (int)header[offset + 3] * 256 + (int)header[offset + 4];
        }

        protected override BTRequestInfo ResolveRequestInfo(ArraySegment<byte> header, byte[] bodyBuffer, int offset, int length)
        {
            BTRequestInfo requestInfo = new BTRequestInfo();

            string entireFrame = BytesToHexStr(header.Array);

            switch (bodyBuffer[offset + 1])
            {
                case 0xb0:
                    requestInfo.command = "supplyWater";
                    break;
            }

            byte[] contents = new byte[length - 2];
            for (int i = 0; i < length - 2; i++)
            {
                contents[i] = bodyBuffer[offset + 2 + i];
            }

            requestInfo.content = contents;

            return requestInfo;
        }

        private string BytesToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }
    }
}