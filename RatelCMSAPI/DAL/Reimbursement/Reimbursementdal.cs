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
        /// 查询详情
        /// </summary>
        /// <returns></returns>
        public List<ReimbursementInfo> Reimbursements(ReimbursementInfo info)
        {
            string sql = "select * from ApplyManager where ApplyName=@ApplyName and CostId=@CostId and ApplyState=@ApplyState";
            return DapperHelper<ReimbursementInfo>.Query(sql, info);
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
        public int UpdateReimburse(int ReimId)
        {
            string sql = "update ApplyManager set ApplyState=2 where Id=@ProjectId";
            return DapperHelper<ReimbursementInfo>.Execute(sql, new { ProjectId = ReimId });
        }
    }
}
