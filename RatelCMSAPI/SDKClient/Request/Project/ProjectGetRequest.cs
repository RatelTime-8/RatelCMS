using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class ProjectGetRequest : BaseRequest
    {
        public string ProjectNumber { get; set; }
        public override string GetApiName()
        {
            return "/api/User/GetUser";
        }

    }
}
