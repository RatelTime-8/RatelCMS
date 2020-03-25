using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class Usersdal
    {
        public UserInfo UserInfoLgoin(string phone, string pass)
        {
            string sql = $@"select u.UserId,u.UserName,u.UserPhone from UserInfo u where u.UserPhone=@Phone and u.UserPass=@Pass;";
            UserInfo user = new UserInfo();
            user = DapperHelper<UserInfo>.QuerySingle(sql, new {Phone=phone,Pass=pass });
            return user;
        }


    }
}
