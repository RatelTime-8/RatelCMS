using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using SDKClient;

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
        public UserGetProjectResponse BandProjectbinding(UserGetProjectRequest request)
        {
            return bll.BandProjectbinding(request);
        }

        [HttpPost]
        /// <summary>
        /// 新增项目
        /// </summary>
        public ProjectAddResponse AddProject(ProjectAddRequest request)
        {
            return bll.AddProject(request);
        }

        [HttpPost]
        /// <summary>
        /// 修改项目
        /// </summary>
        /// <returns></returns>
        public ProjectUpdateResponse UpdateProject(ProjectUpdateRequest request)
        {
            return bll.UpdateProject(request);
        }

        [HttpPost]
        /// <summary>
        /// 分页显示所有项目
        /// </summary>
        /// <returns></returns>
        public ProjectGetResponse ProjectShow(ProjectGetRequest request)
        {
            return bll.ProjectShow(request);
        }

        [HttpPost]
        /// <summary>
        /// 查询项目详情
        /// </summary>
        /// <returns></returns>
        public ProjectGetResponse ProjectDetail(ProjectGetRequest request)
        {
            return bll.ProjectDetail(request);
        }

        [HttpPost]
        /// <summary>
        /// 项目阶段详情
        /// </summary>
        /// <param name="ProjectStageId"></param>
        /// <returns></returns>
        public ProjectGetResponse StageDetail(ProjectGetRequest request)
        {
            return bll.StageDetail(request);
        }

        [HttpPost]
        /// <summary>
        /// 新增阶段
        /// </summary>
        /// <returns></returns>
        public ProjectAddResponse AddStage(ProjectAddRequest request)
        {
            return bll.AddStage(request);
        }

        [HttpPost]
        /// <summary>
        /// 逻辑删除修改阶段
        /// </summary>
        public ProjectUpdateResponse DeleteStage(ProjectUpdateRequest request)
        {
            return bll.DeleteStage(request);
        }

        [HttpPost]
        /// <summary>
        /// 修改阶段
        /// </summary>
        /// <returns></returns>
        public ProjectUpdateResponse UpdateStage(ProjectUpdateRequest request)
        {
            return bll.UpdateStage(request);
        }

        [HttpPost]
        /// <summary>
        /// 修改项目状态
        /// </summary>
        /// <returns></returns>
        public ProjectUpdateResponse UpdateProjectStaus(ProjectUpdateRequest request)
        {
            return bll.UpdateProjectStaus(request);
        }

        [HttpPost]
        /// <summary>
        /// 绑定项目状态
        /// </summary>
        /// <returns></returns>
        public ProjectUpdateResponse BandProjectStaus(ProjectUpdateRequest request)
        {
            return bll.BandProjectStaus(request);
        }

        [HttpPost]
        /// <summary>
        /// 逻辑删除项目
        /// </summary>
        /// <returns></returns>
        public ProjectUpdateResponse UpdateStausProject(ProjectUpdateRequest request)
        {
            return bll.UpdateStausProject(request);
        }
    }
}
