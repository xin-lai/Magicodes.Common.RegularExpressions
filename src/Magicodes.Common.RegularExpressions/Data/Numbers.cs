using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Common.RegularExpressions.Numbers
{
    /// <summary>
    /// 数字
    /// </summary>
    public class Numbers
    {
        /// <summary>
        /// 整数
        /// </summary>
        public const string Integer = "^-?[1-9]\\d*$";

        /// <summary>
        /// 正整数
        /// </summary>
        public const string PositiveInteger = "^[1-9]\\d*$";

        /// <summary>
        /// 负整数
        /// </summary>
        public const string NegtiveInteger = "^-[1-9]\\d*$";

        /// <summary>
        /// 非正整数
        /// </summary>
        public const string NonPositiveInteger = "^-[1-9]\\d*|0$";

        /// <summary>
        /// 非负整数
        /// </summary>
        public const string NonNegtiveInteger = "^[1-9]\\d*|0$";

    }
}
