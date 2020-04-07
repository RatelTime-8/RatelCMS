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
    public sealed class ProjectBll : BaseBll<ProjectBll>
    {
        /// <summary>
        /// 修改项目阶段
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <returns></returns>
        public ProjectStageUpdateResponse UpdateProjectStage(ProjectStageUpdateRequest request)
        {
            ProjectStageUpdateResponse response = new ProjectStageUpdateResponse();

            var ProjectId=request.ProjectId;

            var result = dal.UpdateProjectStage(ProjectId);

            if (result>0)
            {
                response.Message = "状态修改成功";
                response.IsRegistSuccess = true;
            }

            else
            {
                response.Message = "状态修改失败";
                response.IsRegistSuccess = false;
            }

            return response;
        }

        Projectdal dal = new Projectdal();
        /// <summary>
        /// 项目参与人员绑定
        /// 根据所在职位部门
        /// </summary>
        public UserGetProjectResponse BandProjectbinding(UserGetProjectRequest request)
        {
            UserGetProjectResponse response = new UserGetProjectResponse();

            int departId = request.DepartId;

            response.info = dal.BandProjectbinding(departId);

            if (response.info.Count>0)
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

            Model.ProjectInfo info = new Model.ProjectInfo()
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
        public ProjectProcGetResponse ProjectShow(ProjectProcGetRequest request)
        {
            ProjectProcGetResponse response = new ProjectProcGetResponse();

            var PageIndex = request.PageIndex;
            var PageSize = request.PageSize;
            var ProjectNumber = request.ProjectNumber;
            var Count = request.TotalCount;
            var Projectstage = request.Projectstage;

            response.Project = dal.ProjectShow(PageIndex,PageSize,ProjectNumber,Projectstage,out Count);
            if (response.Project.Count > 0)
            {
                response.Message = "项目执行成功";
                response.IsRegistSuccess = true;
            }  
            else
            {
                response.Message = "项目执行失败";
                response.IsRegistSuccess = false;
            }

            return response;
        }

        /// <summary>
        /// 查询项目详情
        /// </summary>
        /// <returns></returns>
        public ProjectGetResponse ProjectDetail(ProjectGetRequest request)
        {
            ProjectGetResponse response = new ProjectGetResponse();

            var ProjectId = request.ProjectId;

            response.Project= dal.ProjectDetail(ProjectId);

            if (response.Project.Count>0)
            {
                response.Message = "项目详情调用成功";
                response.IsRegistSuccess = true;
            }

            else
            {
                response.Message = "项目详情调用失败";
                response.IsRegistSuccess = false;
            }

            return response;
        }

        /// <summary>
        /// 数据反填
        /// </summary>
        /// <returns></returns>
        public StageBackFillGetResponse  StageBackFill(StageBackFillGetRequest request)
        {
            StageBackFillGetResponse response = new StageBackFillGetResponse();

            var PlanId = request.PlanId;

            response.Stage = dal.StageBackFill(PlanId);

            if (response.Stage.Count>0)
            {
                response.Message = "反填数据查询成功";
                response.IsRegistSuccess = true;
            }

            else
            {
                response.Message = "反填数据查询失败";
                response.IsRegistSuccess = false;
            }

            return response;
        }

        /// <summary>
        /// 项目阶段详情
        /// </summary>
        /// <param name="ProjectStageId"></param>
        /// <returns></returns>
        public StageGetResponse StageDetail(StageGetRequest request)
        {
            StageGetResponse response = new StageGetResponse();

            var projectstageId = request.ProjectStageId;

            response.Stage = dal.StageDetail(projectstageId);

            if (response.Stage.Count>0)
            {
                response.Message = "项目阶段详情调用成功";
                response.IsRegistSuccess = true;
            }

            else
            {
                response.Message = "项目阶段详情调用失败";
                response.IsRegistSuccess = false;
            }

            return response;
        }

        /// <summary>
        /// 新增阶段
        /// </summary>
        /// <returns></returns>
        public StageAddResponse AddStage(StageAddRequest request)
        {
            StageAddResponse response = new StageAddResponse();

            StagePlanInfo info = new StagePlanInfo()
            {
                ProjectStageId =request.ProjectStageId,
                StageName = request.StageName,
                StageFinishTime = request.StageFinishTime.ToUniversalTime(),
                StageStaffName = request.StageStaffName,
                StageStartTime = request.StageStartTime,
                StageStaus = 1
            };

            var result = dal.AddStage(info);

            if (result > 0)
            {
                response.Message = "阶段添加成功";
                response.IsRegistSuccess = true;
            }

            else
            {
                response.Message = "阶段添加失败";
                response.IsRegistSuccess = false;
            }

            return response;
        }

        /// <summary>
        /// 逻辑删除修改阶段
        /// </summary>
        public StageStausUpdateResponse DeleteStage(StageStausUpdaterequest request)
        {
            StageStausUpdateResponse response = new StageStausUpdateResponse();

            var PlanId = request.PlanId;

            var result = dal.DeleteStage(PlanId);

            if (result > 0)
            {
                response.Message = "逻辑删除该阶段成功";
                response.IsRegistSuccess = true;
            }

            else
            {
                response.Message = "逻辑删除该阶段失败";
                response.IsRegistSuccess = false;
            }

            return response;
        }

        /// <summary>
        /// 修改阶段
        /// </summary>
        /// <returns></returns>
        public StageUpdateResponse UpdateStage(StageUpdaterequest request)
        {
            StageUpdateResponse response = new StageUpdateResponse();

            StagePlanInfo info = new StagePlanInfo()
            {
                PlanId = request.PlanId,
                StageName = request.StageName,
                StageStaus = 1,
                StageStartTime = request.StageStartTime.ToUniversalTime(),
                StageFinishTime = request.StageFinishTime.ToUniversalTime(),
                StageStaffName = request.StageStaffName
        };

            var result = dal.UpdateStage(info);

            if (result > 0)
            {
                response.Message = "阶段修改成功";
                response.IsRegistSuccess = true;
            }
            else
            {
                response.Message = "阶段修改失败";
                response.IsRegistSuccess = false;
            }

            return response; 
        }

        /// <summary>
        /// 修改项目状态
        /// </summary>
        /// <returns></returns>
        public ProjectStausUpdateReponse UpdateProjectStaus(ProjectStausUpdateRequest request)
        {
            ProjectStausUpdateReponse response = new ProjectStausUpdateReponse();

            ProjectInfo info = new ProjectInfo()
            {
                ProjectId = request.ProjectId,
                ProjectStage = request.ProjectStage
            };

            var result = dal.UpdateProjectStaus(info);

            if (result > 0)
            {
                response.Message = "项目状态修改成功";
                response.IsRegistSuccess = true;
            }
            else
            {
                response.Message = "项目状态修改失败";
                response.IsRegistSuccess = false;
            }

            return response;
        }

        /// <summary>
        /// 绑定项目状态
        /// </summary>
        /// <returns></returns>
        public ProjectBandGetResponse BandProjectStaus(ProjectBandGetRequest request)
        {
            ProjectBandGetResponse response = new ProjectBandGetResponse();

            var ProjectId = request.ProjectId;

            var result = dal.BandProjectStaus(ProjectId);

            if (result.Count > 0)
            {
                response.Message = "阶段绑定成功";
                response.IsRegistSuccess = true;
            }

            else
            {
                response.Message = "阶段绑定失败";
                response.IsRegistSuccess = false;
            }

            return response;
        }

        /// <summary>
        /// 逻辑删除项目
        /// </summary>
        /// <returns></returns>
        public ProjectStausDeleteResponse UpdateStausProject(ProjectStausDeleteRequest request)
        {
            ProjectStausDeleteResponse response = new ProjectStausDeleteResponse();

            var ProjectId = request.ProjectId;

            var result = dal.UpdateStausProject(ProjectId);


            if (result > 0)
            {
                response.Message = "逻辑删除项目成功";
                response.IsRegistSuccess = true;
            }
            else
            {
                response.Message = "逻辑删除项目失败";
                response.IsRegistSuccess = false;
            }

            return response;
        }
    }
}
