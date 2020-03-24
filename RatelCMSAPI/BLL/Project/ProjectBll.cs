using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class ProjectBll
    {
        Projectdal dal = new Projectdal();
        /// <summary>
        /// 项目参与人员绑定
        /// 根据所在职位部门
        /// </summary>
        public List<PositionInfo> BandProjectbinding(string DepartId)
        {
            return dal.BandProjectbinding(DepartId);
        }
    }
}
