using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class PageInfo
    {
       
        /// <summary>
        /// 分页的大小
        /// </summary>
        public int pageSize { get; set; }
        /// <summary>
        /// 要显示的页的索引
        /// </summary>
        public int pageSIndex { get; set; }
        /// <summary>
        /// 页的总数
        /// </summary>
        public int TotalPage { get; set; }
        /// <summary>
        /// 总记录数
        /// </summary>
        public int RecordCount { get; set; }

   
    }
}
