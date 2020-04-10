using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
   public class DepartmentInfoGetRequest:BaseRequest
    {
        public override string GetApiName()
        {
            return "api/User/DepartmentInfoGet";
        }
    }
}
