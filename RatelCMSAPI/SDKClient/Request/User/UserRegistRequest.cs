using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class UserRegistRequest:BaseRequest
    {
        /// <summary>
        /// 手机号
        /// </summary>
        public string UserPhone { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string UserPass { get; set; }
        public override string GetApiName()
        {
            return "/api/User/UserRegist";
        }
    }
}
