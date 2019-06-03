using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LI4.DataAccess
{
    public static class DbAccess
    {
        public static string GetConnectionString(string connectName = "Database1")
        {
            return ConfigurationManager.ConnectionStrings[connectName].ConnectionString;
        }

        public static List<C> LoadData<C>(string sqlCode)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                return connection.Query<C>(sqlCode).ToList();
            }
        }
        //the Integer returned is the number of records affected (if returns 1, everything is ok)
        public static int SaveData<C>(string sqlCode, C data)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                return connection.Execute(sqlCode, data);
            }
        }
    }
}