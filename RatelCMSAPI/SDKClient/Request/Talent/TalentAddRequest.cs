
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class TalentAddRequest : BaseRequest
    {
       
        public string UserName { get; set; }
        public string Pwd { get; set; }
        public override string GetApiName()
        {
            return "/api/User/AddUser";
        }
    }
}
