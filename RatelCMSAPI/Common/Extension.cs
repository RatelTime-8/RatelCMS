using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 1.静态类 扩展方法相关的
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// 将时间转换成时间戳
        /// 静态方法
        /// this关键字
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>

        public static long ToUnixTime(this DateTime dateTime)
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            long t = 0;
            //秒
            t = (long)(dateTime - startTime).TotalSeconds;

            return t;
            
        }

        /// <summary>
        /// 将手机号码转为
        /// 保密状态
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToNickName(this string str)
        {
            var res= "";
            if (string.IsNullOrEmpty(str)||str.Length<11)
            {
                return str;
            }
            var preStr = str.Substring(0, 4);
            var lastStr = str.Substring(str.Length - 4, 4);
            res = preStr + "****" + lastStr;

            return res;
        }
    }
}
