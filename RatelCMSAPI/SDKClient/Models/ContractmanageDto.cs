using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKClient
{
   public class ContractmanageDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 合同编号
        /// </summary>
        public string Contractnumber { get; set; }
        /// <summary>
        /// 合同名称
        /// </summary>
        public string Contractname { get; set; }
        /// <summary>
        /// 合同类型
        /// </summary>
        public string Contracttype { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        public string Personincharge { get; set; }
        /// <summary>
        /// 生效日期
        /// </summary>
        public DateTime Effectivedate { get; set; }
        /// <summary>
        /// 失效日期
        /// </summary>
        public DateTime Expirationdate { get; set; }
        
    }
}
