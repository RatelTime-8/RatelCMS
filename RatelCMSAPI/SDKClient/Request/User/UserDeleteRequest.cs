﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class UserDeleteRequest:BaseRequest
    {
        public override string GetApiName()
        {
            return "/api/User/DeleteUser";
        }
    }
}
