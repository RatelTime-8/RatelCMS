﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
    public class StageBackFillGetRequest:BaseRequest
    {
        public int PlanId { get; set; }
        public override string GetApiName()
        {
            return "api/Project/StageBackFill";
        }
    }
}
