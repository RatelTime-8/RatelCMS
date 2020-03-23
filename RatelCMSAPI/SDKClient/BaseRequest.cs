using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class BaseRequest
    {
        /// <summary>
        /// 返回接口的名称
        /// </summary>
        /// <returns></returns>
        public virtual string GetApiName()
        {
            return "";
        }
    }
}
