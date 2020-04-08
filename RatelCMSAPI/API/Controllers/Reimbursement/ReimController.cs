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

        [HttpGet]
        /// <summary>
        /// 查询显示项目
        /// </summary>
        public List<ReimbursementInfo> ReimbursementInfos(string DepartId)
        {

            return ReimBll.Instance.ReimbursementInfos(DepartId);
        }
        [HttpPost]
        /// <summary>
        /// 新增项目
        /// </summary>
        public int AddReimburse(ReimbursementInfo info)
        {
            return ReimBll.Instance.AddReimburse(info);
        }

        [HttpPost]
        /// <summary>
        /// 修改项目
        /// </summary>
        /// <returns></returns>
        public int UpdateReimburse(List<ReimbursementInfo> infos)
        {
            return ReimBll.Instance.UpdateReimburse(infos);
        }

        [HttpGet]
        /// <summary>
        /// 查询详情
        /// </summary>
        /// <returns></returns>
        public List<ReimbursementInfo> Reimbursements(ReimbursementInfo info)
        {
            return ReimBll.Instance.Reimbursements(info);
        }

        [HttpGet]
        /// <summary>
        /// 显示项目
        /// </summary>
        /// <param name = "ProjectStageId" ></ param >
        /// < returns ></ returns >
        public List<ReimbursementInfo> ReimbursementsShow()
        {
            return ReimBll.Instance.reimbursements();
        }

        [HttpDelete]
        /// <summary>
        /// 修改状态
        /// </summary>
        /// <returns></returns>
        public int UpdateReimburseStage(int ReimId)
        {
            return ReimBll.Instance.UpdateReimburse(ReimId);
        }
    }
}
