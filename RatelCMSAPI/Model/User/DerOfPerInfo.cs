using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //权限关联表
    public class DerOfPerInfo
    {
        //Id
        public int Id { get; set; }
        //职位Id
        public int DerId { get; set; }
        //权限Id
        public int PerId { get; set; }
    }
}
