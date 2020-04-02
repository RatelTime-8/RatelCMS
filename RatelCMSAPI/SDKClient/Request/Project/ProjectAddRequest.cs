
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class ProjectAddRequest : BaseRequest
    {

        //Id
        public int ProjectId { get; set; }
        //项目编号
        public string ProjectNumber { get; set; }
        //项目名称
        public string ProjectName { get; set; }
        //项目描述
        public string ProjectDescribe { get; set; }
        //项目负责人
        public string ProjectStaffId { get; set; }
        //技术负责人
        public string TechStaffId { get; set; }
        //产品负责人
        public string ProductStaffId { get; set; }
        //测试负责人
        public string TestStaffId { get; set; }
        //市场负责人
        public string MarketStaffId { get; set; }
        //当前阶段
        public int ProjectStage { get; set; }
        //项目开始日期
        public DateTime ProjectStartTime { get; set; }
        //项目截止时间
        public DateTime ProjectOutTime { get; set; }
        //项目状态
        public int ProjectStaus { get; set; }
        public override string GetApiName()
        {
            return "api/Project/AddProject";
        }
    }
}
