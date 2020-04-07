using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PageProjectInfo
    {
        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// list项目表
        /// </summary>
        public List<ProjectInfo> Project { get; set; }
    }
}
