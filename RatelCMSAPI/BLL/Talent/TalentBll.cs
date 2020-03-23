﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Talent;
using Model;
using Model.Talents;

namespace BLL.Talent
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
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int PutTalent(TalentsModel model)
        {
            return dal.PutTalent(model);
        }
    }
}