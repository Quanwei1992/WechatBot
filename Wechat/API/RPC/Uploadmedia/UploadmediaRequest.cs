using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Wechat.API.RPC
{
    public class UploadmediaRequest
    {
        public int UploadType;
        public BaseRequest BaseRequest;
        public long ClientMediaId;
        public int TotalLen;
        public int StartPos;
        public int DataLen;
        public int MediaType;
        public string FromUserName;
        public string ToUserName;
        public string FileMd5;
    }
}
