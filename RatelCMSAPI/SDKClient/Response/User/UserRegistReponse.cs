using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class UserRegistReponse:BaseResponse
    {
        /// <summary>
        /// 是否注册成功
        /// </summary>
        public bool IsLoginSuccess { get; set; }
    }
}
