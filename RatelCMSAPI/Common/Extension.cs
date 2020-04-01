using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 时间戳
    /// </summary>
    public static class Extension
    {
        public static long ToUnixTime(this DateTime dateTime)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            long t = 0;
            //秒
            t = (long)(dateTime - startTime).TotalSeconds;

            return t;
        }
    }
}
