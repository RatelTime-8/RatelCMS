using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
   public class PositionInfoGetRequest : BaseRequest
    {
        public int DerId { get; set; }
        public override string GetApiName()
        {
            return "/api/User/GetPositionInfo";
        }
    }
}
