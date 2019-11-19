using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Common.RegularExpressions.Social
{
    /// <summary>
    /// 腾讯相关
    /// </summary>
    public class Tencent
    {
        /// <summary>
        /// QQ
        /// </summary>
        public const string QQ = "[1-9][0-9]{4,}";

        /// <summary>
        /// 微信
        /// </summary>
        public const string WeChat = "^[a-zA-Z]{1}[-_a-zA-Z0-9]{5,19}$";


    }
}
