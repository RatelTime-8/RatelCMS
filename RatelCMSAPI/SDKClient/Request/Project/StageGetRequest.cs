using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class StageGetRequest:BaseRequest
    {
        public int ProjectStageId { get; set; }
        public override string GetApiName()
        {
            return "api/Project/StageDetail";
        }
    }
}
