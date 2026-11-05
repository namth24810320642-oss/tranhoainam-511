#pragma warning disable CS0618
using System.Data.SqlClient;

namespace bai6._2.DAL
{
    public class HRMDatabaseConnection
    {
        private static readonly string connStr = @"Data Source=.;Initial Catalog=HRMDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }
    }
}