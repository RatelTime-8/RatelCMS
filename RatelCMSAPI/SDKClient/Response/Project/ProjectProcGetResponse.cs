using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDKClient
{
    public class ProjectProcGetResponse:BaseResponse
    {
        public List<ProjectInfo> Project { get; set; }
    }
}
