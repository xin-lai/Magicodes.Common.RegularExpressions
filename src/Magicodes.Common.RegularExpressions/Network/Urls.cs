using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Common.RegularExpressions.Network
{
    public class Urls
    {
        /// <summary>
        /// 统一资源标识符
        /// </summary>
        public const string URI = "[a-zA-z]+:\\/\\/[^\\s]*";

        /// <summary>
        /// Url
        /// </summary>
        public const string URL = "[a-zA-z]+://[^\\s]*";
    }
}
