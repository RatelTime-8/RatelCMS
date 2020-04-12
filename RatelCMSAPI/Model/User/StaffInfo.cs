using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 职位表
    /// </summary>
   public class StaffInfo
    {
        /// <summary>
        /// 职位Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 职位名称
        /// </summary>
        public string StaffName { get; set; }
        /// <summary>
        /// 入职时间
        /// </summary>
        public DateTime StaffEntryDate { get; set; }
    }
}
