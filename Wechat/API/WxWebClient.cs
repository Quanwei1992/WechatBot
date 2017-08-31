using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace Wechat.API
{
    public class WxHttpClient : HttpClient
    {


        [System.Security.SecuritySafeCritical]//重要  

        public WxHttpClient()  
  
            : base()  
  
        {

        }
        [System.Security.SecuritySafeCritical]//重要  
        public WxHttpClient(HttpMessageHandler handler) : base(handler)
        {
        }
    }
}
