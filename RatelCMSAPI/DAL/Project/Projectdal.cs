using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Model;

namespace DAL
{
    /// <summary>
    /// 项目相关
    /// </summary>
    public class Projectdal
    {
        /// <summary>
        /// 修改项目阶段
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <returns></returns>
        public int UpdateProjectStage(int ProjectId)
        {
            string sql = "update ProjectInfo set Projectstage=Projectstage+1 where ProjectId=@projectId";
            return DapperHelper<ProjectInfo>.Execute(sql,new {projectid=ProjectId });
        }

        ///// <summary>
        ///// 项目参与人员绑定
        ///// 根据所在职位部门
        ///// </summary>
        //public List<PositionInfo> BandProjectbinding(int DepartId)
        //{
        //    string sql = "select * from PositionInfo where DepartId=@Id";
        //    return DapperHelper<PositionInfo>.Query(sql, new {Id=DepartId});
        //}

        /// <summary>
        /// 新增项目
        /// </summary>
        public int AddProject(ProjectInfo info)
        {
            string sql = @"insert into ProjectInfo
           (ProjectNumber,ProjectName,ProjectDescribe,
           ProjectStaffId,TechStaffId,ProductStaffId,
           TestStaffId,MarketStaffId,Projectstage,ProjectStartTime,
           ProjectOutTime,ProjectStaus) 
           values(@ProjectNumber,@ProjectName,
           @ProjectDescribe,@ProjectStaffId,
           @TechStaffId,@ProductStaffId,@TestStaffId,
           @MarketStaffId,@ProjectStage,@ProjectStartTime,
           @ProjectOutTime,@ProjectStaus)";
          return DapperHelper<ProjectInfo>.Execute(sql, info);
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <returns></returns>
        public int UpdateProject(ProjectInfo info)
        {
            string sql = @"update ProjectInfo set 
            ProjectNumber=@ProjectNumber,
            ProjectName=@ProjectName,
            ProjectDescribe=@ProjectDescribe,
            ProjectStaffId=@ProjectStaffId,
            TechStaffId=@TechStaffId,
            ProductStaffId=@ProductStaffId,
            TestStaffId=@TestStaffId,
            MarketStaffId=@MarketStaffId,
            ProjectStage=@ProjectStage,
            ProjectStartTime=@ProjectStartTime,
            ProjectOutTime=@ProjectOutTime
            where ProjectId=@ProjectId ";

            return DapperHelper<ProjectInfo>.Execute(sql, info);
        }

        /// <summary>
        /// 分页显示所有项目
        /// </summary>
        /// <returns></returns>
        //public List<ProjectInfo> ProjectShow(int PageIndex, int PageSize, string ProjectNumber, int Projectstage, out int TotalCount)
        //{
        //    var p = new DynamicParameters();
        //    p.Add("@Pageindex", PageIndex);
        //    p.Add("@PageSize", PageSize);
        //    p.Add("@ProjectNumber", ProjectNumber);
        //    p.Add("@Projectstage", Projectstage);
        //    p.Add("@TotalCount", 0, DbType.Int32, ParameterDirection.Output);

        //    var list = DapperHelper<ProjectInfo>.ExecutePro("dbo.P_ProjectShow", p);

        //    TotalCount = p.Get<int>("@TotalCount");

        //    return list;
        //}

        /// <summary>
        /// 分页显示所有项目
        /// </summary>
        /// <returns></returns>
        public PageProjectInfo ProjectShow(PageProperty page)
        {
            PageProjectInfo info = new PageProjectInfo();

            var p = new DynamicParameters();
            p.Add("@Pageindex", page.PageIndex);
            p.Add("@PageSize", page.PageSize);
            p.Add("@ProjectNumber", page.ProjectNumber);
            p.Add("@Projectstage", page.Projectstage);
            p.Add("@TotalCount", page.Projectstage, DbType.Int32, ParameterDirection.Output);

            info.Project = DapperHelper<ProjectInfo>.ExecutePro("dbo.P_ProjectShow", p);

            info.TotalCount = p.Get<int>("@TotalCount");

            return info;
        }

        /// <summary>
        /// 修改项目状态
        /// </summary>
        /// <returns></returns>
        public int UpdateProjectStaus(ProjectInfo project)
        {
            string sql = "update ProjectInfo set Projectstage=@Projectstage where ProjectId=@ProjectId";
            return DapperHelper<ProjectInfo>.Execute(sql,project);
        }

        /// <summary>
        /// 绑定项目状态
        /// </summary>
        /// <returns></returns>
        public List<ProjectInfo> BandProjectStaus(int ProjectId)
        {
            string sql = "select P.Projectstage,s.StageName from ProjectInfo p join StagePlanInfo s on p.Projectstage=s.ProjectStageId where s.ProjectStageId=projectId";
            return DapperHelper<ProjectInfo>.Query(sql,new { projectId= ProjectId });
        }

        /// <summary>
        /// 逻辑删除项目
        /// </summary>
        /// <returns></returns>
        public int UpdateStausProject(int ProjectId)
        {
            string sql = "update ProjectInfo set ProjectStaus=0 where ProjectId=@projectId ";
            return DapperHelper<ProjectInfo>.Execute(sql,new { projectId= ProjectId });
        }

        /// <summary>
        /// 查询项目详情
        /// </summary>
        /// <returns></returns>
        public List<ProjectInfo> ProjectDetail(int ProjectId)
        {
            string sql = "select * from ProjectInfo where ProjectId=@projectId and ProjectStaus=1";
            return DapperHelper<ProjectInfo>.Query(sql, new { projectId = ProjectId });
        }
      
        /// <summary>
        /// 项目阶段详情
        /// </summary>
        /// <param name="ProjectStageId"></param>
        /// <returns></returns>
        public List<StagePlanInfo> StageDetail(int ProjectStageId)
        {
            string sql = "select * from StagePlanInfo where ProjectStageId=@projectStageId and StageStaus=1";
            return DapperHelper<StagePlanInfo>.Query(sql, new { projectStageId = ProjectStageId });
        }

        /// <summary>
        /// 新增阶段
        /// </summary>
        /// <returns></returns>
        public int AddStage(StagePlanInfo info)
        {
            string sql = @"insert into StagePlanInfo 
                         (StageName,StageStartTime,StageFinishTime,
                          StageStaffName,ProjectStageId,StageStaus)
                          values(@StageName,@StageStartTime,
                          @StageFinishTime,@StageStaffName,
                          @ProjectStageId,@StageStaus)";
            return DapperHelper<StagePlanInfo>.Execute(sql, info);
        }

        /// <summary>
        /// 逻辑删除修改阶段
        /// </summary>
        public int DeleteStage(int PlanId)
        {
            string sql = "update StagePlanInfo set StageStaus =0 where PlanId=@planId";
            return DapperHelper<StagePlanInfo>.Execute(sql, new { planId = PlanId });
        }

        /// <summary>
        /// 修改阶段
        /// </summary>
        /// <returns></returns>
        public int UpdateStage(StagePlanInfo info)
        {
            string sql = "update StagePlanInfo set StageName=@StageName ,StageStartTime=@StageStartTime,StageFinishTime=@StageFinishTime,StageStaffName=@StageStaffName,StageStaus=@StageStaus where PlanId=@PlanId";
            return DapperHelper<StagePlanInfo>.Execute(sql, info);
        }

        /// <summary>
        /// 数据反填
        /// </summary>
        /// <returns></returns>
        public List<StagePlanInfo> StageBackFill(int PlanId)
        {
            string sql = "select * from StagePlanInfo where PlanId=@planId";
            return DapperHelper<StagePlanInfo>.Query(sql,new { planId = PlanId });
        }
    }
}
