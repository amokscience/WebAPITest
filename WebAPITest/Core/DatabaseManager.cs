using System.Configuration;
using System.Data.SqlClient;
using ServiceStack.OrmLite;
using WebAPITest.Core;

namespace WebAPITest.Core
{
    public static class DatabaseManager
    {
        public static SqlConnection GetOpenConnection()
        {
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql2013"].ConnectionString);
            //var connection2 = new OrmLiteConnection(new OrmLiteConnectionFactory(), 
            //var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sql2013"].ConnectionString);
            connection.Open();
            return connection;
        }
    }
}