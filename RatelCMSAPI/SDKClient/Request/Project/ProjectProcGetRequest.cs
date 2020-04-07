using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace SDKClient
{
    public class ProjectProcGetRequest : BaseRequest
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int Projectstage { get; set; }
        public string ProjectNumber { get; set; }
        public override string GetApiName()
        {
            return "api/Project/ProjectShow";
        }
    }
}
