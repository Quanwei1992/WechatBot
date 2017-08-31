using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Wechat.API.RPC
{

    public class BatchGetContactRequest
    {
        public BaseRequest BaseRequest;
        public int Count;
        public BatchUser[] List;
    }
}
