using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Wechat.API.RPC
{
    public class BatchGetContactResponse
    {
        public BaseResponse BaseResponse;
        public int Count;
        public User[] ContactList;
    }
}
