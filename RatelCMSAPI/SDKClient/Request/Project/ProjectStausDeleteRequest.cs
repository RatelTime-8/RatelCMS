﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class ProjectStausDeleteRequest:BaseRequest
    {
        public int ProjectId { get; set; }
        public override string GetApiName()
        {
            return "api/Project/UpdateStausProject";
        }
    }
}
