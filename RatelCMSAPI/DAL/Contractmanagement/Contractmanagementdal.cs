using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Model;
namespace DAL
{
    public class Contractmanagementdal
    {


        //public Contractmanagement GetContractmanagement(PageProperty page)
        //{
        //    Contractmanagement info = new Contractmanagement();

        //    var p = new DynamicParameters();
        //    p.Add("@Pageindex", page.PageIndex);
        //    p.Add("@PageSize", page.PageSize);
        //    p.Add("@ProjectNumber", page.ProjectNumber);
        //    p.Add("@Projectstage", page.Projectstage);
        //    p.Add("@TotalCount", page.Projectstage, DbType.Int32, ParameterDirection.Output);

        //    info.Project = DapperHelper<ProjectInfo>.ExecutePro("dbo.P_ProjectShow", p);

        //    info.TotalCount = p.Get<int>("@TotalCount");

        //    return info;
        //}

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
