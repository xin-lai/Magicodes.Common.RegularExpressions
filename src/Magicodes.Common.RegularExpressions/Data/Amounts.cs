using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Common.RegularExpressions.Data
{
    public class Amounts
    {

        /// <summary>
        /// 金额（保留2位小数）
        /// </summary>
        public const string Amount = @"\d+(\.\d{1,2})?$";
    }
}
