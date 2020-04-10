using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace SDKClient
{
    public class StaffInfoGetResponse : BaseResponse
    {
        public List<StaffInfo>  staffs { get; set; }

    }
}
