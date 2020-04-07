using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using SDKClient;

namespace API.Controllers.Reimbursement
{
    public class ReimController : ApiController
    {
        
        /// <summary>
        /// 项目参与人员绑定
        /// 根据所在职位部门
        /// </summary>
        public BurseBangResponse ReimbursementInfos(BurseBengRequest request)
        {
            return ReimBll.Instance.ReimbursementInfos(request);
        }

        /// <summary>
        /// 新增
        /// </summary>
        public BurseAddResponse AddReimburse(BurseAddRequest burse)
        {
            return ReimBll.Instance.AddReimburse(burse);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        public BurseUpdateResponse UpdateReimburse(BurseUpdateRequest request)
        {
            return ReimBll.Instance.UpdateReimburse(request);
        }

        /// <summary>
        /// 查询详情
        /// </summary>
        /// <returns></returns>
        public BurseChaResponse Reimbursements(BurseChaRequest request)
        {
            return ReimBll.Instance.Reimbursements(request);
        }

        /// <summary>
        /// 阶段详情
        /// </summary>
        /// <param name="ProjectStageId"></param>
        /// <returns></returns>
        public BurseXiangResponse reimbursements(BurseXiangRequest request)
        {
            return ReimBll.Instance.reimbursements(request);
        }

        /// <summary>
        /// 修改状态
        /// </summary>
        /// <returns></returns>
        public BurseZhuangResponse UpdateReimburse(BurseZhuangRequest request)
        {
            return ReimBll.Instance.UpdateReimburse(request);
        }
    }
}
