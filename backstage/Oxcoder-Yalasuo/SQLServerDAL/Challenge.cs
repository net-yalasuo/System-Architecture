using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtility;
using Model;
using IDAL;

namespace SQLServerDAL
{
    public class Challenge : IChallenge
    {
        private const string SQL_INSERT_CHALLENGE = "INSERT INTO challenge (cName) VALUES (@Name) SELECT @@identity AS id;";
        private const string SQL_SELECT_CHALLENGE = "SELECT * FROM challenge WHERE cID = @Id;";
        private const string SQL_DELETE_CHALLENGE = "DELETE FROM challenge WHERE cID = @Id;";

        private const string PARM_ID = "@Id";
        private const string PARM_NAME = "@Name";
        private bool result = false;

        public ChallengeInfo GetChlById(int id)
        {

            ChallengeInfo chlInfo = new ChallengeInfo();

            //Create a parameter
            SqlParameter parm = new SqlParameter(PARM_ID, SqlDbType.Int);
            parm.Value = id;

            //Execute a query to read the order
            using (SqlDataReader rdr = SqlServerHelper.ExecuteReader(SqlServerHelper.ConnectionString, CommandType.Text, SQL_SELECT_CHALLENGE, parm))
            {

                if (rdr.Read())
                {
                    chlInfo.cID = (int)rdr[0];
                    chlInfo.cName = (string)rdr[1];
                }
            }

            return chlInfo;
        }

        public bool Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(SqlServerHelper.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(SQL_DELETE_CHALLENGE, conn);

                SqlParameter[] challengeParms = GetClassParameters();

                challengeParms[0].Value = id;

                cmd.Parameters.Add(challengeParms[0]);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    result = true;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    ex.StackTrace.ToString();
                    return false;
                }
                return result;
            }
        }

        /// <summary>
        /// Internal function to get cached parameters
        /// </summary>
        /// <returns></returns>
        private static SqlParameter[] GetClassParameters()
        {
            SqlParameter[] parms = SqlServerHelper.GetCachedParameters(SQL_INSERT_CHALLENGE);

            if (parms == null)
            {
                parms = new SqlParameter[] {
					new SqlParameter(PARM_ID, SqlDbType.Int),
					new SqlParameter(PARM_NAME, SqlDbType.VarChar, 50)
                };

                SqlServerHelper.CacheParameters(SQL_INSERT_CHALLENGE, parms);
            }

            return parms;
        }


    }
}
