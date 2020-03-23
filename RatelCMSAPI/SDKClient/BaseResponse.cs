﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class BaseResponse
    {
        /// <summary>
        /// 状态为true 表示接口请示成功了
        /// </summary>
        public bool Status = true;
        /// <summary>
        /// 当状态失败时，提示消息
        /// </summary>
        public string Message { get; set; }
    }
}
