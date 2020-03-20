using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //阶段计划表
    public class StagePlanInfo
    {
        //Id
        public int PlanId { get; set; }
        //阶段名称
        public int StageNameId { get; set; }
        //开始日期
        public DateTime StageStartTime { get; set; }
        //完成日期
        public DateTime StageFinishTime { get; set; }
        //阶段负责人
        public int StageStaffId { get; set; }
    }
}
