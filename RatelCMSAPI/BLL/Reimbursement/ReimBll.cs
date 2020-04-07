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
    public sealed class ReimBll:BaseBll<ReimBll>
    {
        Reimbursementdal dal = new Reimbursementdal();
        /// <summary>
        /// 项目参与人员绑定
        /// 根据所在职位部门
        /// </summary>
        public List<ReimbursementInfo> ReimbursementInfos(string DepartId)
        {
            return dal.ReimbursementInfos(DepartId);
        }

        /// <summary>
        /// 新增
        /// </summary>
        public int AddReimburse(ReimbursementInfo info)
        {
            return dal.AddReimburse(info);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        public int UpdateReimburse(List<ReimbursementInfo> infos)
        {
            return dal.UpdateReimburse(infos);
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
            return dal.Reimbursements(info);
        }

        /// <summary>
        /// 阶段详情
        /// </summary>
        /// <param name="ProjectStageId"></param>
        /// <returns></returns>
        public List<ReimbursementInfo> reimbursements(int ProjectStageId)
        {
            return dal.reimbursements(ProjectStageId);
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
