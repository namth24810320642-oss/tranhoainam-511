#pragma warning disable CS0618
using System.Data.SqlClient;

namespace bai6._1.DAL
{
    public class DatabaseConnection
    {
        private static readonly string connStr = @"Data Source=.;Initial Catalog=SalesDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }
    }
}