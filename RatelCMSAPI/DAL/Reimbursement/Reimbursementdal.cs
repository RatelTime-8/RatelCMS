using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class Reimbursementdal
    {
        /// <summary>
        /// 项目参与人员绑定
        /// 根据所在职位部门
        /// </summary>
        public List<ReimbursementInfo> ReimbursementInfos(string DepartId)
        {
            string sql = "select * from ApplyManager where Id=@departId";

            return DapperHelper<ReimbursementInfo>.Query(sql, new { departId = DepartId });
        }

        /// <summary>
        /// 新增
        /// </summary>
        public int AddReimburse(ReimbursementInfo info)
        {
            string sql = "insert into ApplyManager values(@ApplyName,@CostId,@ApplyTime,@Money,@ApplyExplain)";
            return DapperHelper<ReimbursementInfo>.Execute(sql, info);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        public int UpdateReimburse(List<ReimbursementInfo> infos)
        {
            string sql = @"update ProjectInfo set 
            ApplyName=@ApplyName,
            CostId=@CostId,
            ApplyTime=@ApplyTime,
            Money=@Money,
            ApplyExplain=@ApplyExplain,
            where Id=@Id ";

            return DapperHelper<ReimbursementInfo>.Execute(sql, infos);
        }

        /// <summary>
        /// 分页显示所有项目
        /// </summary>
        /// <returns></returns>
        //public List<ProjectInfo> ProjectShow()
        //{

        //}

        /// <summary>
        /// 查询详情
        /// </summary>
        /// <returns></returns>
        public List<ReimbursementInfo> Reimbursements(ReimbursementInfo info)
        {
            string sql = "select * from ApplyManager where ApplyName=@ApplyName and CostId=@CostId and ApplyState=@ApplyState";
            return DapperHelper<ReimbursementInfo>.Query(sql, info);
        }

        /// <summary>
        /// 阶段详情
        /// </summary>
        /// <param name="ProjectStageId"></param>
        /// <returns></returns>
        public List<ReimbursementInfo> reimbursements(int ProjectStageId)
        {
            string sql = "select * from ApplyManager where Id=@ProjectStageId";
            return DapperHelper<ReimbursementInfo>.Query(sql, new { ProjectStageId = ProjectStageId });
        }

        /// <summary>
        /// 修改状态
        /// </summary>
        /// <returns></returns>
        public int UpdateReimburse(int ReimId)
        {
            string sql = "update ApplyManager set ApplyState=1 where Id=@ProjectId";
            return DapperHelper<ReimbursementInfo>.Execute(sql, new { ProjectId = ReimId });
        }
    }
}
