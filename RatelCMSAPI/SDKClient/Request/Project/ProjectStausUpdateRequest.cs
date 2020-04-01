
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class ProjectStausUpdateRequest : BaseRequest
    {

        //Id
        public int ProjectId { get; set; }
        //当前阶段
        public int ProjectStage { get; set; }

        public override string GetApiName()
        {
            return "api/Project/UpdateProjectStaus";
        }
    }
}
