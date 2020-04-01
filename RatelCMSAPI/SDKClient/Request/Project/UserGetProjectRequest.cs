using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class UserGetProjectRequest:BaseRequest
    {
        //部门Id
        public int DepartId { get; set; }
        //职位名称
        public string PositName { get; set; }
        public override string GetApiName()
        {
            return "api/Project/BandProjectbinding";
        }
    }
}
