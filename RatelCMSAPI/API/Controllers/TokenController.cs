using Common;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using SDKClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Controllers
{
    public class TokenController
    {
        /// <summary>
        /// 获取权限验证token值
        /// </summary>
        /// <returns></returns>
        public string GetAuthToken(UserLoginResponse response)
        {
            var token = "";

            if (response.IsLoginSuccess == true)
            {


                IJwtAlgorithm algorithm = new HMACSHA256Algorithm();//HMACSHA256加密
                IJsonSerializer serializer = new JsonNetSerializer();//序列化和反序列
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();//Base64编解码
                IDateTimeProvider provider = new UtcDateTimeProvider();//UTC时间获取

                Dictionary<string, object> payload = new Dictionary<string, object>();

                payload.Add("iss", response.UserPhone);                     //iss：发行人
                payload.Add("exp", DateTime.Now.AddDays(7).ToUnixTime());   //exp：到期时间
                payload.Add("sub", "jwt");                                  //sub：主题
                payload.Add("aud", response.UserPhone);                     //aud：用户
                payload.Add("nbf", DateTime.Now.ToUnixTime());              //nbf：在此之前不可用
                payload.Add("iat", DateTime.Now.ToUnixTime());              //iat：发布时间
                payload.Add("jti", response.UserId);                        //jti：JWT ID用于标识该JWT

                const string secret = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC4aKpVo2OHXPwb1R7duLgg";//服务端

                IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
                token = encoder.Encode(payload, secret);
            }
            return token;
        }
    }
}