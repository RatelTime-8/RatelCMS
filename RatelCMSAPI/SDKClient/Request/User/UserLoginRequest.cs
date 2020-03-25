using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
   public class UserLoginRequest:BaseRequest
    {
        public string Phone { get; set; }
        public string Pass { get; set; }
        public override string GetApiName()
        {
            return "/api/User/UserLoginUser";
        }
    }
}
