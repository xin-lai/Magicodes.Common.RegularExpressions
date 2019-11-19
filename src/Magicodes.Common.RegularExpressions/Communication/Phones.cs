using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Common.RegularExpressions.Communication
{
    /// <summary>
    /// 手机固话等
    /// </summary>
    public class Phones
    {
        /// <summary>
        /// 中国大陆手机号 (移动/联通/电信)
        /// </summary>
        public const string Phone = "^1(3[0-9]|4[5-9]|5[0-35-9]|66|7[013-8]|8[0-9]|9[89])\\d{8}$";

        /// <summary>
        /// 固话
        /// </summary>
        public const string Telephone = "^(\\(\\d{3,4}\\)|\\d{3,4}-|\\s)?\\d{7,14}$";
    }
}
