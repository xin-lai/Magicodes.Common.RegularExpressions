using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Magicodes.Common.RegularExpressions
{
    /// <summary>
    /// 
    /// </summary>
    public class Matchs
    {
        /// <summary>
        /// 是否匹配
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsMath(string pattern, string input)
        {
            return new Regex(pattern).IsMatch(input);
        }
    }
}
