using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
   public class UserLoginBll
    {
        Usersdal dal = new Usersdal();
        public UserInfo UserInfoLgoin(string phone, string pass)
        {
            return dal.UserInfoLgoin(phone,pass);
        }
    }
}
