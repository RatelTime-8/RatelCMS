using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;

namespace API.Controllers
{
    public class ProjectController : ApiController
    {
        ProjectBll bll = new ProjectBll();
        [HttpPost]
        /// <summary>
        /// 项目参与人员绑定
        /// 根据所在职位部门
        /// </summary>
        
        public List<PositionInfo> BandProjectbinding(string DepartId)
        {
            return bll.BandProjectbinding(DepartId);
        }
    }
}
