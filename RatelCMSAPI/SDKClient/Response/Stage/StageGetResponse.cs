using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDKClient
{
    public class StageGetResponse:BaseResponse
    {
        public List<StagePlanInfo> Stage { get; set; }
    }
}
