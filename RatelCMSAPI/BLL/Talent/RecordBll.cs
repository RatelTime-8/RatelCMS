using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Talent;
using Model.Talents;

namespace BLL.Talent
{
    public class RecordBll
    {
        RecordDal dal = new RecordDal();
        public int AddRecoed(RecordModel model)
        {
            return dal.AddRecoed(model);
        }
        /// <summary>
        /// 显示雇员信息
        /// </summary>
        /// <returns></returns>
        public List<RecordModel> ShowRecoed()
        {
            return dal.ShowRecoed();
        }
        public int DeleteRecoed(int Id)
        {
            return dal.DeleteRecoed(Id);
        }
    }
}
