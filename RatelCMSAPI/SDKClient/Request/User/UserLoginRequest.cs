using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
   public class UserLoginRequest:BaseRequest
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string UserPhone { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string UserPass { get; set; }
        public override string GetApiName()
        {
            return "/api/User/UserLogin";
        }
    }
}
