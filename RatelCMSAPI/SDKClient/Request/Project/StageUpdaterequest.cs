
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class StageUpdaterequest : BaseRequest
    {
        //Id
        public int PlanId { get; set; }
        //阶段名称
        public string StageName { get; set; }
        //开始日期
        public DateTime StageStartTime { get; set; }
        //完成日期
        public DateTime StageFinishTime { get; set; }
        //阶段负责人
        public string StageStaffName { get; set; }
        //项目连接
        public int ProjectStageId { get; set; }
        //状态
        public int StageStaus { get; set; }

        public override string GetApiName()
        {
            return "api/Project/UpdateStage";
        }
    }
}
