using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
   public  class BurseUpdateRequest: BaseRequest
    {
        public override string GetApiName()
        {
            return "/api/User/UpdateUser";
        }
    }
}
