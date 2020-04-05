using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class Contractmanagementdal
    {


        public List<Contractmanagement> GetContractmanagement(int pageSIndex,int pageSize,out int TotalPage,out int RecordCount)
        {
            TotalPage = 0;
            RecordCount = 0;
            string sql = @"EXEC    @return_value = [dbo].[SP_Procedure_PageGX]
                         @TableName = N'Contractmanagement',
                         @Fields = N'*',
                         @OrderField = N'Contractnumber DESC',
                         @sqlWhere = N'1=1',
                         @pageSize = @pageSize,
                         @pageIndex = @pageIndex,
                         @TotalPage = @TotalPage OUTPUT,
                         @RecordCount = @RecordCount OUTPUT";
            return DapperHelper<Contractmanagement>.ExecutePro(sql,new {pageIndex=pageSIndex,pageSize,TotalPage, RecordCount });
        }

        /// <summary>
        /// 删除合同
        /// </summary>
        /// <param name="cInfo"></param>
        /// <returns></returns>
        public int AddContractmanagement(int Id)
        {
            string sql = @"DELETE FROM [dbo].[Contractmanagement]
                           WHERE Id=@Id";
            return DapperHelper<Contractmanagement>.Execute(sql, new { Id = Id });
        }


        /// <summary>
        /// 添加合同
        /// </summary>
        /// <param name="cInfo"></param>
        /// <returns></returns>
        public int AddContractmanagement(Contractmanagement cInfo)
        {
            string sql = @"INSERT INTO [dbo].[Contractmanagement]
                           ([Contractnumber]
                           ,[Contractname]
                           ,[Contracttype]
                           ,[Personincharge]
                           ,[Effectivedate]
                           ,[Expirationdate]
                           ,[Status]
                           ,[CreateTime]
                           ,[UpdateTime]
                           ,[CreaterId]
                           ,[UpdaterId])
                     VALUES
                           @Contractnumber
                           ,@Contractname
                           ,@Contracttype
                           ,@Personincharge
                           ,@Effectivedate
                           ,@Expirationdate
                           ,1
                           ,GETDATE()
                           ,GETDATE()
                           ,1
                           ,1";
            return DapperHelper<Contractmanagement>.Execute(sql, cInfo);
        }



        /// <summary>
        /// 修改合同
        /// </summary>
        /// <returns></returns>
        public int UpdateContractmanagement(Contractmanagement cInfo)
        {
            string sql = @"UPDATE [dbo].[Contractmanagement]
                          SET [Contractnumber] = @Contractnumber
                          ,[Contractname] =@Contractname
                          ,[Contracttype] = @Contracttype
                          ,[Personincharge] =@Personincharge
                          ,[Effectivedate] = @Effectivedate
                          ,[Expirationdate] =@Expirationdate
                          ,[Status] =1
                          ,[CreateTime] =GetDate()
                          ,[UpdateTime] =GetDate()
                          ,[CreaterId] =1
                          ,[UpdaterId] =1
                          WHERE Id=@Id ";
            return DapperHelper<Contractmanagement>.Execute(sql, cInfo);
        }

    }
}
