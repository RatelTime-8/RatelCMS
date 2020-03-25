using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SDKClient;
using Model;

namespace BLL
{
    public sealed class ProjectBll:BaseBll<ProjectBll>
    {
        Projectdal dal = new Projectdal();

        /// <summary>
        /// 项目参与人员绑定
        /// 根据所在职位部门
        /// </summary>
        public UserGetProjectResponse BandProjectbinding(UserGetProjectRequest request)
        {
            UserGetProjectResponse response = new UserGetProjectResponse();

            int departId = request.DepartId;

            var list = dal.BandProjectbinding(departId);

            if (list.Count>0)
            {
                response.Message = "部门人员查询成功";
                response.IsRegistSuccess = true;
            }

            else
            {
                response.Message = "部门人员查询失败";
                response.IsRegistSuccess = false;
            }

            return response;
        }

        /// <summary>
        /// 新增项目
        /// </summary>
        public ProjectAddResponse AddProject(ProjectAddRequest request)
        {
            ProjectAddResponse response = new ProjectAddResponse();

            ProjectInfo info = new ProjectInfo()
            {
                ProjectNumber=request.ProjectNumber,
                ProjectName=request.ProjectName,
                ProjectDescribe = request.ProjectDescribe,
                ProjectStaffId = request.ProjectStaffId,
                TechStaffId = request.TechStaffId,
                ProductStaffId = request.ProductStaffId,
                TestStaffId = request.TestStaffId,
                MarketStaffId = request.MarketStaffId,
                ProjectStage = request.ProjectStage,
                ProjectStartTime = request.ProjectStartTime,
                ProjectOutTime=request.ProjectOutTime,
                ProjectStaus=1
            };

            var result = dal.AddProject(info);

            if (result>0)
            {
                response.Message = "新增项目成功";
                response.IsRegistSuccess = true;
            }

            else
            {
                response.Message = "新增项目失败";
                response.IsRegistSuccess = false;
            }

            return response;
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <returns></returns>
        public ProjectUpdateResponse UpdateProject(ProjectUpdateRequest request)
        {
            ProjectUpdateResponse response = new ProjectUpdateResponse();

            ProjectInfo info = new ProjectInfo()
            {
                ProjectId = request.ProjectId,
                ProjectNumber = request.ProjectNumber,
                ProjectName = request.ProjectName,
                ProjectDescribe = request.ProjectDescribe,
                ProjectStaffId = request.ProjectStaffId,
                TechStaffId = request.TechStaffId,
                ProductStaffId = request.ProductStaffId,
                TestStaffId = request.TestStaffId,
                MarketStaffId = request.MarketStaffId,
                ProjectStage = request.ProjectStage,
                ProjectStartTime = request.ProjectStartTime,
                ProjectOutTime = request.ProjectOutTime,
                ProjectStaus = 1
            };

            var result = dal.UpdateProject(info);

            if (result>0)
            {
                response.Message = "项目修改成功";
                response.IsRegistSuccess = true;
            }
            else
            {
                response.Message = "修改项目失败";
                response.IsRegistSuccess = false;
            }

            return response;
        }

        /// <summary>
        /// 分页显示所有项目
        /// </summary>
        /// <returns></returns>
        public ProjectGetResponse ProjectShow(ProjectGetRequest request)
        {
            ProjectGetResponse response = new ProjectGetResponse();

            return response;
        }

        /// <summary>
        /// 查询项目详情
        /// </summary>
        /// <returns></returns>
        public ProjectGetResponse ProjectDetail(ProjectGetRequest request)
        {
            ProjectGetResponse response = new ProjectGetResponse();

            return response;
        }

        /// <summary>
        /// 项目阶段详情
        /// </summary>
        /// <param name="ProjectStageId"></param>
        /// <returns></returns>
        public ProjectGetResponse StageDetail(ProjectGetRequest request)
        {
            ProjectGetResponse response = new ProjectGetResponse();

            return response;
        }

        /// <summary>
        /// 新增阶段
        /// </summary>
        /// <returns></returns>
        public ProjectAddResponse AddStage(ProjectAddRequest request)
        {
            ProjectAddResponse response = new ProjectAddResponse();

            return response;
        }

        /// <summary>
        /// 逻辑删除修改阶段
        /// </summary>
        public ProjectUpdateResponse DeleteStage(ProjectUpdateRequest request)
        {
            ProjectUpdateResponse response = new ProjectUpdateResponse();

            return response;
        }

        /// <summary>
        /// 修改阶段
        /// </summary>
        /// <returns></returns>
        public ProjectUpdateResponse UpdateStage(ProjectUpdateRequest request)
        {
            ProjectUpdateResponse response = new ProjectUpdateResponse();

            return response; 
        }

        /// <summary>
        /// 修改项目状态
        /// </summary>
        /// <returns></returns>
        public ProjectUpdateResponse UpdateProjectStaus(ProjectUpdateRequest request)
        {
            ProjectUpdateResponse response = new ProjectUpdateResponse();

            return response;
        }

        /// <summary>
        /// 绑定项目状态
        /// </summary>
        /// <returns></returns>
        public ProjectUpdateResponse BandProjectStaus(ProjectUpdateRequest request)
        {
            ProjectUpdateResponse response = new ProjectUpdateResponse();

            return response;
        }

        /// <summary>
        /// 逻辑删除项目
        /// </summary>
        /// <returns></returns>
        public ProjectUpdateResponse UpdateStausProject(ProjectUpdateRequest request)
        {
            ProjectUpdateResponse response = new ProjectUpdateResponse();

            return response;
        }
    }
}
