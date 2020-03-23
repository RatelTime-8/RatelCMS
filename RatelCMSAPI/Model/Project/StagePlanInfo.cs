﻿using System;
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
        public string StageName { get; set; }
        //开始日期
        public DateTime StageStartTime { get; set; }
        //完成日期
        public DateTime StageFinishTime { get; set; }
        //阶段负责人
        public int StageStaffName { get; set; }
        /// <summary>
        /// 项目连接
        /// </summary>
        public int ProjectStageId { get; set; }
    }
}
