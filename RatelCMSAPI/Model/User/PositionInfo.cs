using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //职位表
    public class PositionInfo
    {
        //职位表主键
        public int Id { get; set; }
        //部门Id
        public int DepartId { get; set; }
        //职位名称
        public string PositName { get; set; }
        
    }
}
