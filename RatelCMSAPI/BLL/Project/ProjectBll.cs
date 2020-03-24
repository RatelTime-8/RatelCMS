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
    public class ProjectBll
    {
        Projectdal dal = new Projectdal();

        /// <summary>
        /// 项目参与人员绑定
        /// 根据所在职位部门
        /// </summary>
        public UserGetResponse BandProjectbinding(UserAddRequest request)
        {
            UserGetResponse response = new UserGetResponse();

            return response;
        }

        /// <summary>
        /// 新增项目
        /// </summary>
        public ProjectAddResponse AddProject(ProjectAddRequest request)
        {
            ProjectAddResponse response = new ProjectAddResponse();

            return response;
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <returns></returns>
        public ProjectUpdateResponse UpdateProject(ProjectUpdateRequest request)
        {
            ProjectUpdateResponse response = new ProjectUpdateResponse();

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
        public ProjectDeleteResponse DeleteStage(ProjectDeleteRequest request)
        {
            ProjectDeleteResponse response = new ProjectDeleteResponse();

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
        public ProjectDeleteResponse UpdateStausProject(ProjectDeleteRequest request)
        {
            ProjectDeleteResponse response = new ProjectDeleteResponse();

            return response;
        }
    }
}
