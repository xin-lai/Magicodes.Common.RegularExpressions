using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Common.RegularExpressions.Licenses
{
    /// <summary>
    /// 证照、牌照
    /// </summary>
    public class Licenses
    {
        /// <summary>
        /// 身份证
        /// </summary>
        public const string IdCard = "^[1-9]\\d{5}[1-9]\\d{3}((0\\d)|(1[0-2]))(([0|1|2]\\d)|3[0-1])\\d{3}([0-9Xx])$";

        /// <summary>
        /// 车牌
        /// </summary>
        public const string CarLicense =
            "^[京津沪渝冀豫云辽黑湘皖鲁新苏浙赣鄂桂甘晋蒙陕吉闽贵粤青藏川宁琼使领 A-Z]{1}[A-Z]{1}[A-Z0-9]{4}[A-Z0-9 挂学警港澳]{1}$";

    }


}
