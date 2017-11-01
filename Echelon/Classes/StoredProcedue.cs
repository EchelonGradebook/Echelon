using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Data.SqlClient;
using System.Data;

namespace Echelon.Classes
{
    public class StoredProcedue
    {
        protected string ConStr = "Server=tcp:echelongradebook.database.windows.net,1433;Initial Catalog=GradeBook;Persist Security Info=False;User ID=joshpadams123;Password=Jpa12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public void First(string user)
        {
            SqlConnection conn = null;
            SqlDataReader rdr = null;
            try
            {
                conn = new SqlConnection(ConStr);
                conn.Open();

                SqlCommand cmd = new SqlCommand("First", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                rdr = cmd.ExecuteReader();

                //output here
            }
            finally{closeDB(conn, rdr);}
        }

        public void closeDB(SqlConnection conn, SqlDataReader rdr)
        {
            if (conn != null)
            {
                conn.Close();
            }
            if (rdr != null)
            {
                rdr.Close();
            }
        }
    }
}
