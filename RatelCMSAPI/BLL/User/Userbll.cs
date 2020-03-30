using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDKClient;
using Common;
namespace BLL
{
    public sealed class Userbll : BaseBll<Userbll>
    {
        Usersdal dal = new Usersdal();
        /// <summary>
        /// 用户登录方法
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public UserLoginResponse UserInfoLgoin(UserLoginRequest request)
        {
            UserLoginResponse response = new UserLoginResponse();
            if (string.IsNullOrEmpty(request.UserPhone))
            {
                response.Status = false;
                response.Message = "手机号不能为空";
                return response;
            }
            if (string.IsNullOrEmpty(request.UserPass))
            {
                response.Status = false;
                response.Message = "密码不能为空";
                return response;
            }
            var salt = dal.GetUserInfoSalt(request.UserPhone);
            var password = MD5Encrypt.MD5Encrypt32(request.UserPass + salt);
            var res = dal.UserInfoLgoin(request.UserPhone, password);
            if (!string.IsNullOrEmpty(res.UserPhone))
            {
                response.IsLoginSuccess = true;
                response.UName = res.UserName;
                response.UserPhone = res.UserPhone;
                response.UserId = res.Id;    
            }
            else
            {
                response.IsLoginSuccess = false;
                response.Message = "登录失败";
            }
            return response;
        }
        /// <summary>
        /// 用户注册方法
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UserRegistReponse UserInfoRegist(UserRegistRequest request)
        {
            UserRegistReponse response = new UserRegistReponse();
            if (string.IsNullOrEmpty(request.UserPhone))
            {
                response.Status = false;
                response.Message = "手机号不能为空";
                return response;
            }
            if (string.IsNullOrEmpty(request.UserPass))
            {
                response.Status = false;
                response.Message = "密码不能为空";
                return response;
            }
            //判断手机号是否已注册
            var isExist = dal.IsExistPhone(request.UserPhone);
            if (isExist)
            {
                response.Status = false;
                response.Message = "手机号已存在";
                return response;
            }
            //对密码进行加密
            //1 生成一个盐  
            var salt = Generate.GenerateSalt();
            //2 加密
            var password = MD5Encrypt.MD5Encrypt32(request.UserPass + salt);
            UserInfo user = new UserInfo()
            {
                UserSalt = salt,
                UserPhone = request.UserPhone,//13621807335
                UserName = request.UserName,
                UserPass = password

            };
            var res = dal.UserRegist(user);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
            }
            else
            {
                response.Status = false;
                response.Message = "注册失败";
            }
            return response;
        }
    }
}

