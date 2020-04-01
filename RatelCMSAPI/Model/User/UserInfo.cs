using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //用户表
    public class UserInfo
    {
       //用户Id
        public int UserId { get; set; }
        //用户电话
        public string UserPhone { get; set; }
        //用户名称
        public string UserName { get; set; }
        //用户密码
        public string UserPass { get; set; }
        //盐
        public string  UserSalt { get; set; }
    }
}
