using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
   public class StaffInfoGetRequset : BaseRequest
    {
        public int PosId { get; set; }
        public override string GetApiName()
        {
            return "api/User/StaffInfoGet";
        }
    }
}
