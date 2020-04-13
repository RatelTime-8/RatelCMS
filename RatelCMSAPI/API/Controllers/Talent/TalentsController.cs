using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model.Talents;

namespace API.Controllers.Talent
{
    public class TalentsController : ApiController
    {
        TalentBll bll = new TalentBll();
        [HttpPost]
        public int AddTalent(TalentsModel model)
        {
            return bll.AddTalent(model);
        }
        [HttpGet]
        public List<TalentsModel> Show(string CName)
        {
            return bll.Show(CName);
        }
        [HttpGet]
        public List<TalentsModel> TalentId(int Id)
        {
            return bll.TalentId(Id);
        }
        [HttpPost]
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateTalent(TalentsModel model)
        {
            return bll.UpdateTalent(model);
        }
        [HttpDelete]
        public int DeleteTalent(int Id)
        {
            return bll.DeleteTalent(Id);
        }
    }
}
