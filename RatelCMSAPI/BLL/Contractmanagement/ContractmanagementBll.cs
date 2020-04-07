using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using SDKClient;
using DAL;
namespace BLL
{
   public class ContractmanagementBll:BaseBll<ContractmanagementBll>
    {
        Contractmanagementdal dal = new Contractmanagementdal();
        public ContraGetResponse GetContra(ContraGetRequest request)
        {
            ContraGetResponse response = new ContraGetResponse();
            var pageSIndex = request.pageSIndex;
            var pageSize = request.pageSize;
            var TotalPage = request.TotalPage;
            var RecordCount = request.RecordCount;
            //response.ContractmanageDtos =/* dal.GetContractmanagement(pageSIndex, pageSize,out TotalPage, out RecordCount);*/
            return response;
        }

        public ContraDeleteResponse DeleteContra(ContraGetRequest request)
        {
            ContraDeleteResponse response = new ContraDeleteResponse();
            

            return response;
        }



    }
}
