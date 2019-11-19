using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Common.RegularExpressions.Secrets
{
    public class Passwords
    {

        /// <summary>
        /// 普通密码（由6-16位数字或者字母组成）
        /// </summary>
        public const string Password = "^[0-9A-Za-z]{6,16}$";

        /// <summary>
        /// 强密码
        /// 最短6位，最长16位 {6,16}，必须包含1个数字，2个小写字母，2个大写字母，1个特殊字符
        /// </summary>
        public const string StrongPassword =
            "^.*(?=.{6,16})(?=.*\\d)(?=.*[A-Z]{2,})(?=.*[a-z]{2,})(?=.*[!@#$%^&*?\\(\\)]).*$";
    }
}
