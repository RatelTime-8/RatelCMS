﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class UserLoginResponse:BaseResponse
    {
        /// <summary>
        /// 是否登录成功
        /// </summary>
        public bool IsLoginSuccess { get; set; }
    }
}
