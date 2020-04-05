
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class ProjectStageUpdateRequest : BaseRequest
    {

        //Id
        public int ProjectId { get; set; }
       
        public override string GetApiName()
        {
            return "api/Project/UpdateProjectStage";
        }
    }
}
