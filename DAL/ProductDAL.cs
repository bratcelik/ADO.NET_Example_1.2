using System.Data.SqlClient;

namespace DAL
{
    public sealed class ProductDAL
    {
        public static int GetProductCountProcess(string sql)
        {
            int sonuc = 0;
            using (SqlConnection conn = ConnectionManager.GetOpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    sonuc = (int)cmd.ExecuteScalar();
                }
            }
            return sonuc;
        }
    }
}
