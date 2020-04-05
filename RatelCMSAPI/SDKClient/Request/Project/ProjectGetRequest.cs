﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDKClient
{
    public class ProjectGetRequest : BaseRequest
    {
        public int ProjectId { get; set; }
        public override string GetApiName()
        {
            return "api/Project/ProjectDetail";
        }

    }
}
