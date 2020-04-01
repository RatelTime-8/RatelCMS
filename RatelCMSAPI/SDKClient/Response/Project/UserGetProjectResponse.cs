using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDKClient
{
    public class UserGetProjectResponse : BaseResponse
    {
        public List<PositionInfo> info { get; set; }
    }
}
