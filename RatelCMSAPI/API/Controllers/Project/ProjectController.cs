﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using SDKClient;
using Model;

namespace API.Controllers
{
    public class ProjectController : ApiController
    {

        ProjectBll bll = new ProjectBll();

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

        [HttpPost]
        /// <summary>
        /// 分页显示所有项目
        /// </summary>
        /// <returns></returns>
        public ProjectProcGetResponse ProjectShow(ProjectProcGetRequest request)
        {
            return ProjectBll.Instance.ProjectShow(request);
        }

        [HttpPost]
        /// <summary>
        /// 查询项目详情
        /// </summary>
        /// <returns></returns>
        public ProjectGetResponse ProjectDetail(ProjectGetRequest request)
        {
            return ProjectBll.Instance.ProjectDetail(request);
        }

        [HttpPost]
        /// <summary>
        /// 数据反填
        /// </summary>
        /// <returns></returns>
        public StageBackFillGetResponse StageBackFill(StageBackFillGetRequest request)
        {
            return ProjectBll.Instance.StageBackFill(request);
        }

        [HttpPost]
        /// <summary>
        /// 项目阶段详情
        /// </summary>
        /// <param name="ProjectStageId"></param>
        /// <returns></returns>
        public StageGetResponse StageDetail(StageGetRequest request)
        {
            return ProjectBll.Instance.StageDetail(request);
        }

        [HttpPost]
        /// <summary>
        /// 新增阶段
        /// </summary>
        /// <returns></returns>
        public StageAddResponse AddStage(StageAddRequest request)
        {
            return ProjectBll.Instance.AddStage(request);
        }

        [HttpPost]
        /// <summary>
        /// 逻辑删除修改阶段
        /// </summary>
        public StageStausUpdateResponse DeleteStage(StageStausUpdaterequest request)
        {
            return ProjectBll.Instance.DeleteStage(request);
        }

        [HttpPost]
        /// <summary>
        /// 修改阶段
        /// </summary>
        /// <returns></returns>
        public StageUpdateResponse UpdateStage(StageUpdaterequest request)
        {
            return ProjectBll.Instance.UpdateStage(request);
        }

        [HttpPost]
        /// <summary>
        /// 修改项目状态
        /// </summary>
        /// <returns></returns>
        public ProjectStausUpdateReponse UpdateProjectStaus(ProjectStausUpdateRequest request)
        {
            return ProjectBll.Instance.UpdateProjectStaus(request);
        }

        [HttpPost]
        /// <summary>
        /// 绑定项目状态
        /// </summary>
        /// <returns></returns>
        public ProjectBandGetResponse BandProjectStaus(ProjectBandGetRequest request)
        {
            return ProjectBll.Instance.BandProjectStaus(request);
        }

        [HttpPost]
        /// <summary>
        /// 逻辑删除项目
        /// </summary>
        /// <returns></returns>
        public ProjectStausDeleteResponse UpdateStausProject(ProjectStausDeleteRequest request)
        {
            return ProjectBll.Instance.UpdateStausProject(request);
        }

        [HttpPost]
        /// <summary>
        /// 修改项目阶段
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <returns></returns>
        public ProjectStageUpdateResponse UpdateProjectStage(ProjectStageUpdateRequest request)
        {
            return ProjectBll.Instance.UpdateProjectStage(request);
        }
    }
}
