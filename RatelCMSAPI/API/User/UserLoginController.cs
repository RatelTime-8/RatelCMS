using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;
namespace API.User
{
     
    public class UserLoginController : ApiController
    {
        UserLoginBll LoginBll = new UserLoginBll();

        public UserInfo UserLogin(string phone,string pass)
        {
            return LoginBll.UserInfoLgoin(phone,pass);
        }

    }
}
