using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcGlobalError.Controllers
{
    public class UpdateController : ApiController
    {
        /// <summary>
        /// 获取最新版本号
        /// </summary>
        /// <returns></returns>
        public string GetLasterVersion()
        {
            using (SqlConnection con = new SqlConnection("Data Source=mssql9.zzidc.ha.cn;Initial Catalog=TaskManager;User ID=TaskManager_f;Password=959380"))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT TOP 1 version FROM Application_Version";
                var result=cmd.ExecuteScalar();
                if(result is DBNull)
                {
                    return "";
                }
                else
                {
                    return result.ToString();
                }
            }
        }
    }
}
