using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDKClient
{
    public class BaseResponse
    {
        /// <summary>
        /// 判断是否成功
        /// </summary>
        public bool IsRegistSuccess { get; set; }
        /// <summary>
        /// 状态为true 表示接口请示成功了
        /// </summary>
        public bool Status = true;
        /// <summary>
        /// 当状态失败时，提示消息
        /// </summary>
        public string Message { get; set; }

        public List<ProjectInfo> Project { get; set; }
        public List<StagePlanInfo> Stage { get; set; }
    }
}
