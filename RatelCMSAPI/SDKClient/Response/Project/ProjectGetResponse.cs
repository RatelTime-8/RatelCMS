using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDKClient
{
    public class ProjectGetResponse : BaseResponse
    {
        public List<ProjectInfo> Project { get; set; }
    }
}
