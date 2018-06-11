using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESSENGER
{
    class DAL
    {
        public static DataTable ExecSP(string spName, List<SqlParameter> sqlParams = null)
        {
            string strConnect = "Server=DESKTOP-Q6S0OSM\\SQLEXPRESS; Database=MyLoginApp; Trusted_Connection=True;";

            SqlConnection conn = new SqlConnection();
            DataTable dt = new DataTable();

            try
            {
                conn = new SqlConnection(strConnect);
                conn.Open();

                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(sqlParams.ToArray());

                SqlCommand command = conn.CreateCommand();
                SqlDataReader dr = cmd.ExecuteReader();

                dt.Load(dr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
    }
}
