using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using DAL.Talent;
using Model.Talents;

namespace API.Controllers.Talent
{
    public class TalentsController : ApiController
    {
        //TalentBLL bll = new TalentBll();
        //[HttpPost]
        //public int AddTalent(TalentsModel model)
        //{
        //    return bll.AddTalent(model);
        //}
        //[HttpGet]
        //public List<TalentsModel> Show(string Name)
        //{
        //    return bll.Show(Name);
        //}
        ///// <summary>
        ///// 修改
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //[HttpPut]
        //public int PutTalent(TalentsModel model)
        //{
        //    return bll.PutTalent(model);
        //}
    }
}
