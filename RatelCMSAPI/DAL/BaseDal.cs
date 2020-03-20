using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public static class BaseDal
    {
        //string ConnStr = ConfigurationManager.AppSettings["ConnStr"].ToString();
       static string ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
    }
}
