using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;

namespace API.Controllers.Reimbursement
{
    public class ReimController : ApiController
    {
        
        /// <summary>
        /// 项目参与人员绑定
        /// 根据所在职位部门
        /// </summary>
        [HttpPost]
        public List<ReimbursementInfo> ReimbursementInfos(string DepartId)
        {
            return ReimBll.Instance.ReimbursementInfos(DepartId);
        }

        /// <summary>
        /// 新增
        /// </summary>
        [HttpPost]
        public int AddReimburse(ReimbursementInfo info)
        {
            return ReimBll.Instance.AddReimburse(info);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public int UpdateReimburse(List<ReimbursementInfo> infos)
        {
            return ReimBll.Instance.UpdateReimburse(infos);
        }

        /// <summary>
        /// 查询详情
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public List<ReimbursementInfo> Reimbursements(ReimbursementInfo info)
        {
            return ReimBll.Instance.Reimbursements(info);
        }

        /// <summary>
        /// 阶段详情
        /// </summary>
        /// <param name="ProjectStageId"></param>
        /// <returns></returns>
        [HttpPost]
        public List<ReimbursementInfo> reimbursements(int ProjectStageId)
        {
            return ReimBll.Instance.reimbursements(ProjectStageId);
        }

        /// <summary>
        /// 修改状态
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public int UpdateReimburse(int ReimId)
        {
            return ReimBll.Instance.UpdateReimburse(ReimId);
        }
    }
}
