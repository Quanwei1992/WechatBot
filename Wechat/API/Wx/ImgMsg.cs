﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Wechat.API
{
    public class ImgMsg
    {
        public long ClientMsgId;
        public long LocalID;
        public string FromUserName;
        public string ToUserName;
        public int Type;//3
        public string MediaId;
    }
}
