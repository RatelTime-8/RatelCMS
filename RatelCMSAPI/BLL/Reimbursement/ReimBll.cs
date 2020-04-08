using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using SDKClient;


namespace BLL
{
    public sealed class ReimBll : BaseBll<ReimBll>
    {
        Reimbursementdal dal = new Reimbursementdal();
        /// <summary>
        /// 查询显示项目
        /// </summary>
        public List<ReimbursementInfo> ReimbursementInfos(string DepartId)
        {

            return dal.ReimbursementInfos(DepartId);
        }

        /// <summary>
        /// 新增项目
        /// </summary>
        public int AddReimburse(ReimbursementInfo info)
        {
            return dal.AddReimburse(info);
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <returns></returns>
        public int UpdateReimburse(List<ReimbursementInfo> infos)
        {
            return dal.UpdateReimburse(infos);
        }

        /// <summary>
        /// 查询详情
        /// </summary>
        /// <returns></returns>
        public List<ReimbursementInfo> Reimbursements(ReimbursementInfo info)
        {
            return dal.Reimbursements(info);
        }

        /// <summary>
        /// 显示项目
        /// </summary>
        /// <param name = "ProjectStageId" ></ param >
        /// < returns ></ returns >
        public List<ReimbursementInfo> reimbursements()
        {
            return dal.reimbursements();
        }

        /// <summary>
        /// 修改状态
        /// </summary>
        /// <returns></returns>
        public int UpdateReimburse(int ReimId)
        {
            return dal.UpdateReimburse(ReimId);
        }
    }
}
