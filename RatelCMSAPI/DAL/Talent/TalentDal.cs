using Model.Talents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Talent
{
    public class Talentdal
    {
        /// <summary>
        /// 添加人才个人信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddTalent(TalentsModel model)
        {    
            string sql = string.Format("insert into Talents values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", model.TName,model.TelePhone, model.Graduate, model.Education, model.Station, model.Information,model.Email,model.FanKui,model.TState);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 显示个人人才信息
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<TalentsModel> Show(string Name)
        {
            string sql = $"select * from Talents where TName like '%{Name}%'";
            List<TalentsModel> list = DBHelper.GetToList<TalentsModel>(sql);
            return list;
        }
        /// <summary>
        /// 获取Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<TalentsModel> TalentId(int Id)
        {
            string sql = string.Format("select * from Talents where TId=" + Id);
            return DBHelper.GetToList<TalentsModel>(sql);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int PutTalent(TalentsModel model)
        {
            string sql = string.Format("Update Talents set TName='{0}',TelePhone='{1}',Graduate='{2}',Education='{3}',Station='{4}',Information='{5}',Email='{6}',FanKui='{7}',TState='{8}'", model.TName, model.TelePhone, model.Graduate, model.Education, model.Station, model.Information, model.Email,model.FanKui,model.TState);
            return DBHelper.ExecuteNonQuery(sql);
        }
        public int DeleteTalent(int Id)
        {
            string sql = string.Format("delete from Talents where TId=" + Id);
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
