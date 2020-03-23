using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class Projectdal
    {
        /// <summary>
        /// 项目参与人员绑定
        /// 根据所在职位部门
        /// </summary>
        public List<PositionInfo> BandProjectbinding(string DepartId)
        {
            string sql = "select * from PositionInfo where DepartId=@DepartId";

            return DapperHelper<PositionInfo>.Query(sql, DepartId);
        }

        /// <summary>
        /// 新增项目
        /// </summary>
        public int AddProject(ProjectInfo info)
        {
            string sql = "insert into ProjectInfo values(@ProjectNumber,@ProjectName,@ProjectDescribe,@ProjectStaffId,@TechStaffId,@ProductStaffId,@TestStaffId,@MarketStaffId,@Projectstage,@ProjectStartTime,@ProjectOutTime)";
            return DapperHelper<ProjectInfo>.Execute(sql, info);
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <returns></returns>
        public int UpdateProject(List<ProjectInfo> infos)
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
            ProjectStageId=@ProjectStageId,
            ProjectStartTime=@ProjectStartTime,
            ProjectOutTime=@ProjectOutTime
            where ProjectId=@ProjectId ";

            return DapperHelper<ProjectInfo>.Execute(sql, infos);
        }

        /// <summary>
        /// 分页显示所有项目
        /// </summary>
        /// <returns></returns>
        //public List<ProjectInfo> ProjectShow()
        //{

        //}

        /// <summary>
        /// 查询项目详情
        /// </summary>
        /// <returns></returns>
        public List<ProjectInfo> ProjectDetail(string ProjectNumber)
        {
            string sql = "select * from ProjectInfo where ProjectNumber=@ProjectNumber";
            return DapperHelper<ProjectInfo>.Query(sql,ProjectNumber);
        }

        /// <summary>
        /// 项目阶段详情
        /// </summary>
        /// <param name="ProjectStageId"></param>
        /// <returns></returns>
        public List<StagePlanInfo> StageDetail(int ProjectStageId)
        {
            string sql = "select * from StagePlanInfo where ProjectStageId=@ProjectStageId";
            return DapperHelper<StagePlanInfo>.Query(sql,ProjectStageId);
        }

        /// <summary>
        /// 新增阶段
        /// </summary>
        /// <returns></returns>
        public int AddStage(StagePlanInfo info)
        {
            string sql = "insert into StagePlanInfo values(@StageName,@StageStartTime,@StageFinishTime,@StageStaffName,@ProjectStageId)";
            return DapperHelper<StagePlanInfo>.Execute(sql,info);
        }

        /// <summary>
        /// 逻辑删除修改阶段
        /// </summary>
        public int DeleteStage(int StageStaus)
        {
            string sql = "update StagePlanInfo set StageStaus =@StageStaus";
            return DapperHelper<StagePlanInfo>.Execute(sql, StageStaus);
        }

        /// <summary>
        /// 修改阶段
        /// </summary>
        /// <returns></returns>
        public int UpdateStage(List<StagePlanInfo> infos)
        {
            string sql = "update StagePlanInfo set StageName=@StageName ,StageStartTime=@StageStartTime,StageFinishTime=@StageFinishTime,StageStaffName=@StageStaffName,ProjectStageId=@ProjectStageId where PlanId=@PlanId";
            return DapperHelper<StagePlanInfo>.Execute(sql,infos);
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
        public List<StagePlanInfo> BandProjectStaus(int ProjectId)
        {
            string sql = "select s.ProjectStageId,s.StageName from ProjectInfo p join StagePlanInfo s on p.Projectstage=s.ProjectStageId where s.ProjectStageId=@ProjectId";
            return DapperHelper<StagePlanInfo>.Query(sql,ProjectId);
        }

    }
}
