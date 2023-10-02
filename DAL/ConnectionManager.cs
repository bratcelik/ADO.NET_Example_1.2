using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public sealed class ConnectionManager
    {
        public static SqlConnection GetOpenConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["AWConnStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            return conn;
        }
    }
}
