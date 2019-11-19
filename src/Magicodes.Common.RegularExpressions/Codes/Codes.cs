using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Common.RegularExpressions.Codes
{
    /// <summary>
    /// 各种编码
    /// </summary>
    public class Codes
    {
        /// <summary>
        /// 邮政编码
        /// </summary>
        public const string PostalCode = "[1-9]\\d{5}(?!\\d)";
    }
}
