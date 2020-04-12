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
        /// <summary>
        /// 登录数据访问层方法
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public UserInfo UserInfoLgoin(string phone, string pass)
        {
            string sql = $@"select u.UserId,u.UserName,u.UserPhone from UserInfo u where u.UserPhone=@Phone and u.UserPass=@Pass and Status=1;";
            UserInfo user = new UserInfo();
            user = DapperHelper<UserInfo>.QuerySingle(sql, new { Phone = phone, Pass = pass });
            return user;
        }
        /// <summary>
        /// 用户注册数据访问层方法
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int UserRegist(UserInfo user)
        {
            int res = 0;
            string sql = $@"INSERT INTO [dbo].[UserInfo]
                          (
                           [UserPhone]
                          ,[UserName]
                          ,[UserPass]
                          ,[UserSalt]
                          ,[Status]
                          ,[CreateTime]
                          ,[UpdateTime]
                          ,[CreaterId]
                          ,[UpdaterId])
                    VALUES
                          (
                           @UserPhone
                          ,@UserName
                          ,@UserPass
                          ,@UserSalt
                          ,1
                          ,GETDATE()
                          ,GETDATE()
                          ,1
                          ,1);";

            res = DapperHelper<UserInfo>.Execute(sql, user);
            return res;
        }

        /// <summary>
        /// 判断手机号是否已存在
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public bool IsExistPhone(string phone)
        {
            string sql = $" select count(1) from UserInfo where UserPhone=@UserPhone and status=1 ";
            return Convert.ToBoolean(DapperHelper<int>.ExecuteScalar(sql, new { UserPhone = phone }));
        }
        /// <summary>
        /// 获取盐
        /// </summary>
        /// <param name="UserPhone"></param>
        /// <returns></returns>
        public string GetUserInfoSalt(string UserPhone)
        {
            string sql = $" select UserSalt from UserInfo where UserPhone=@UserPhone and Status=1 ";
            return DapperHelper<string>.QuerySingle(sql, new { UserPhone = UserPhone });

        }
        /// <summary>
        /// 查询部门列表
        /// </summary>
        /// <returns></returns>
        public List<DepartmentInfo> GetDepartmentInfos()
        {
            string sql = @"select d.DepartmentId,d.DepartmentName from [dbo].[DepartmentInfo] d where Status=1";
            return DapperHelper<DepartmentInfo>.Query(sql, null);
        }
        /// <summary>
        /// 查询职位表
        /// </summary>
        /// <param name="DepartId"></param>
        /// <returns></returns>
        public List<PositionInfo> GetPositionInfos(int departId=0)
        {
            string sql = @"select p.Id,p.PositName from PositionInfo p
                           join  DepartOfPostion dp 
                           on dp.PositionId=p.Id
                           where dp.DepartmentId=@DeparId and p.Status=1";
            return DapperHelper<PositionInfo>.Query(sql, new { DepartId = departId });
        }
        /// <summary>
        /// 查询人员表
        /// </summary>
        /// <param name="DepartId"></param>
        /// <returns></returns>
        public List<StaffInfo> GetStaffInfos(int posiId=0)
        {
            string sql = @"select s.Id,s.StaffName from StaffInfo s
                           join [dbo].[PosiOfStaff] ps 
                           on ps.StaffId=s.Id
                           where ps.PositionId=@PosiId and s.Status=1";
            return DapperHelper<StaffInfo>.Query(sql, new { PosiId = posiId });
        }



    }
}
