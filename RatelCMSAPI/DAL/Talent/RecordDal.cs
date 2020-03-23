using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Talents;

namespace DAL.Talent
{
    public class RecordDal
    {
        /// <summary>
        /// 添加雇员信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int AddRecoed(RecordModel model)
        {
            string sql = string.Format("insert into Record values('{0}','{1}','{2}','{3}','{4}','{5})", model.Organization, model.Position, model.Pay, model.GongNeiR, model.LiZhi, model.RTime);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 显示雇员信息
        /// </summary>
        /// <returns></returns>
        public List<RecordModel> ShowRecoed()
        {
            string sql = string.Format("select * from Record");
            return DBHelper.GetToList<RecordModel>(sql);
        }
        public int DeleteRecoed(int Id)
        {
            string sql = string.Format("delete from Recoed where RId=" + Id);
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
