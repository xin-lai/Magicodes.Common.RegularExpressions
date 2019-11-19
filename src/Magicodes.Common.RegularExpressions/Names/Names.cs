using System;
using System.Collections.Generic;
using System.Text;

namespace Magicodes.Common.RegularExpressions.Names
{
    /// <summary>
    /// 命名、昵称等
    /// </summary>
    public class Names
    {
        /// <summary>
        /// 昵称（支持中英文）
        /// </summary>
        public const string NickName = "^([\\u4e00-\\u9fa5_a-zA-Z0-9]){2,20}$";

        /// <summary>
        /// 中文姓名
        /// </summary>
        public const string ChineseName = "^((?![\\u3000-\\u303F])[\\u2E80-\\uFE4F]|\\·)*(?![\\u3000-\\u303F])[\\u2E80-\\uFE4F](\\·)*$";

        //TODO:
        //public const string UserName
    }
}
