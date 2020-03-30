using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SDKClient;
using BLL;
namespace API.User
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


    }
}
