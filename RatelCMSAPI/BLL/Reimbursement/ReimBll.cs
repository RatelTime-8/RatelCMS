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
        public BurseBangResponse ReimbursementInfos(BurseBengRequest request )
        {
            BurseBangResponse response = new BurseBangResponse();

            return response;
        }

        /// <summary>
        /// 新增
        /// </summary>
        public BurseAddResponse AddReimburse(BurseAddRequest burse)
        {
            BurseAddResponse burseAdd = new BurseAddResponse();
            return burseAdd;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        public BurseUpdateResponse UpdateReimburse(BurseUpdateRequest request )
        {
            BurseUpdateResponse response = new BurseUpdateResponse();
            return response;
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
        public BurseChaResponse Reimbursements(BurseChaRequest request )
        {
            BurseChaResponse response = new BurseChaResponse();
            return response;
        }

        /// <summary>
        /// 阶段详情
        /// </summary>
        /// <param name="ProjectStageId"></param>
        /// <returns></returns>
        public BurseXiangResponse reimbursements(BurseXiangRequest request )
        {
            BurseXiangResponse response = new BurseXiangResponse();
            return response;
        }

        /// <summary>
        /// 修改状态
        /// </summary>
        /// <returns></returns>
        public BurseZhuangResponse  UpdateReimburse(BurseZhuangRequest request)
        {
            BurseZhuangResponse response = new BurseZhuangResponse();
            return response;
        }
    }
}
