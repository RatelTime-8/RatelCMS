using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SDKClient;
using BLL;
namespace API
{    
    
    public class UserController : ApiController
    {
        /// <summary>
        /// 用户登录接口
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public UserLoginResponse UserLogin(UserLoginRequest request)
        {
            return Userbll.Instance.UserInfoLgoin(request);

        }

        /// <summary>
        /// 用户注册接口
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        ///   
        [HttpPost]
        public UserRegistReponse UserRegist(UserRegistRequest request)
        {
            return Userbll.Instance.UserInfoRegist(request);
        }
        /// <summary>
        /// 部门
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public DepartmentInfoGetResponse DepartmentInfoGet(DepartmentInfoGetRequest request)
        {
            return Userbll.Instance.GetDepartment(request);
        }
        /// <summary>
        /// 职位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public PositionInfoGetResponse PositionInfoGet(PositionInfoGetRequest request)
        {
            return Userbll.Instance.GetPositionInfo(request);
        }
        /// <summary>
        /// 员工
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public StaffInfoGetResponse StaffInfoGet (StaffInfoGetRequset request)
        {
            return Userbll.Instance.GetStaffInfo(request);
        }


    }
}
