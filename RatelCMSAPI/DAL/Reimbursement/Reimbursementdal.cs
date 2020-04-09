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
        /// 查询详情
        /// </summary>
        public List<ReimbursementInfo> ReimbursementInfos(string DepartId)
        {
            string sql = "select * from ApplyManager where Id=@departId";

            return DapperHelper<ReimbursementInfo>.Query(sql, new { departId = DepartId });
        }

        /// <summary>
        /// 新增详情
        /// </summary>
        public int AddReimburse(ReimbursementInfo info)
        {
            string sql = "insert into  ApplyManager (ApplyName,CostId,ApplyTime,Money,ApplyExplain) values(@ApplyName,@CostId,@ApplyTime,@Money,@ApplyExplain)";
            return DapperHelper<ReimbursementInfo>.Execute(sql, info);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        public int UpdateReimburse(ReimbursementInfo infos)
        {
            string sql = @"update ApplyManager set 
            ApplyName=@ApplyName,
            CostId=@CostId,
            ApplyTime=@ApplyTime,
            Money=@Money,
            ApplyExplain=@ApplyExplain
            where Id=@Id ";

            return DapperHelper<ReimbursementInfo>.Execute(sql, infos);
        }


        /// <summary>
        /// 查询详情
        /// </summary>
        /// <returns></returns>
        public List<ReimbursementInfo> Reimbursements(string ApplyName,string CostId,int ApplyState)
        {
            string sql = "select * from ApplyManager where ApplyName=@applyName and CostId=@costId and ApplyState=@applyState";
            return DapperHelper<ReimbursementInfo>.Query(sql,new { applyName= ApplyName, costId= CostId, applyState= ApplyState });
        }

        /// <summary>
        /// 显示详情
        /// </summary>
        /// <param name="ProjectStageId"></param>
        /// <returns></returns>
        public List<ReimbursementInfo> reimbursements()
        {
            string sql = "select * from ApplyManager";
            return DapperHelper<ReimbursementInfo>.Query(sql,null);
        }
        /// <summary>
        /// 修改状态
        /// </summary>
        /// <returns></returns>
        public int UpdateReimburseStage(int ReimId)
        {
            string sql = "update ApplyManager set ApplyState=2 where Id=@ProjectId";
            return DapperHelper<ReimbursementInfo>.Execute(sql, new { ProjectId = ReimId });
        }
    }
}
