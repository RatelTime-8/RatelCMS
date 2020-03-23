using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class ContraDeleteRequest : BaseRequest
    {
        public override string GetApiName()
        {
            return "/api/Contra/DeleteUser";
        }
    }
}
