using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Wechat.API.RPC
{
    public class StatusnotifyRequest
    {
        public BaseRequest BaseRequest;
        public long ClientMsgId;
        public string FromUserName;
        public string ToUserName;
        public int Code;
    }
}
