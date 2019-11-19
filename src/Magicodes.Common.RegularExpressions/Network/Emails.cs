using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Common.RegularExpressions.Network
{
    public class Emails
    {
        /// <summary>
        /// 邮箱
        /// </summary>
        public const string Email =
            "^\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
    }
}
