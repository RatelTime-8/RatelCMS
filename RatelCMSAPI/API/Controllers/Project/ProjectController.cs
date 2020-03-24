using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;
using SDKClient;

namespace API.Controllers
{
    public class ProjectController : ApiController
    {
        
        [HttpPost]
        /// <summary>
        /// 项目参与人员绑定
        /// 根据所在职位部门
        /// </summary>
        public UserGetProjectResponse BandProjectbinding(UserGetProjectRequest request)
        {
            return ProjectBll.Instance.BandProjectbinding(request);
        }

        [HttpPost]
        /// <summary>
        /// 新增项目
        /// </summary>
        public ProjectAddResponse AddProject(ProjectAddRequest request)
        {
            return ProjectBll.Instance.AddProject(request);
        }

        [HttpPost]
        /// <summary>
        /// 修改项目
        /// </summary>
        /// <returns></returns>
        public ProjectUpdateResponse UpdateProject(ProjectUpdateRequest request)
        {
            return ProjectBll.Instance.UpdateProject(request);
        }
    }
}
