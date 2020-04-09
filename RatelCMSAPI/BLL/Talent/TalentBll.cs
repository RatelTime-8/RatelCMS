using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Talent;
using Model;
using Model.Talents;

namespace BLL
{
    public class TalentBll
    {
        Talentdal dal = new Talentdal();
        public int AddTalent(TalentsModel model)
        {
            return dal.AddTalent(model);
        }
        public List<TalentsModel> Show(string Name)
        {
            return dal.Show(Name);
        }
        /// <summary>
        /// 获取Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<TalentsModel> TalentId(int Id)
        {
            return dal.TalentId(Id);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateTalent(TalentsModel model)
        {
            return dal.UpdateTalent(model);
        }

        public int DeleteTalent(int Id)
        {
            return dal.DeleteTalent(Id);
        }
    }
}
