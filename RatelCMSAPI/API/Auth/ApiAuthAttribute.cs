using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace API
{
    /// <summary>
    /// 自定义一个api的权限过滤器
    /// </summary>
   
    public class ApiAuthAttribute: AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            //1.从网络请求中获取到token
            //2.用相同的解密方式，判断请求过来的token是不是符合要求
            //3.符合要求，则验证通过
            //4.不符合要求，则验证失败
            var authHeader = from t in actionContext.Request.Headers where t.Key == "token" select t.Value.FirstOrDefault();

            if (authHeader != null)
            {
                string token = authHeader.FirstOrDefault();
                if (!string.IsNullOrEmpty(token))
                {
                    try
                    {
                        const string secret = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC4aKpVo2OHXPwb1R7duLgg";
                        //secret需要加密
                        IJsonSerializer serializer = new JsonNetSerializer();
                        IDateTimeProvider provider = new UtcDateTimeProvider();
                        IJwtValidator validator = new JwtValidator(serializer, provider);
                        IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                        IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
                        IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);
                        var json = decoder.DecodeToObject<Object>(token, secret, verify: true);
                        if (json!=null)
                        {
                            actionContext.RequestContext.RouteData.Values.Add("auth", json);
                            return true;
                        }
                        return false;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}