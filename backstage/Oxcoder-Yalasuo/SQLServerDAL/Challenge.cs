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
        private const string SQL_SELECT_CHALLENGE_BY_ID = "SELECT * FROM challenge WHERE cID = @Id;";
        private const string SQL_SELECT_CHALLENGE_BY_TYPE = "SELECT * FROM challenge WHERE cType = @Type;";
        private const string SQL_DELETE_CHALLENGE = "DELETE FROM challenge WHERE cID = @Id;";

        private const string PARM_ID = "@Id";
        private const string PARM_NAME = "@Name";
        private const string PARM_TYPE = "@Type";

        private bool result = false;

        public ChallengeInfo GetChlById(int id)
        {

            ChallengeInfo chlInfo = new ChallengeInfo();

            //Create a parameter
            SqlParameter parm = new SqlParameter(PARM_ID, SqlDbType.Int);
            parm.Value = id;

            //Execute a query to read the order
            using (SqlDataReader rdr = SqlServerHelper.ExecuteReader(SqlServerHelper.ConnectionString, CommandType.Text, SQL_SELECT_CHALLENGE_BY_ID, parm))
            {

                if (rdr.Read())
                {
                    chlInfo.cID = (int)rdr[0];
                    chlInfo.cName = (string)rdr[1];
                    chlInfo.cType = (int)rdr[2];
                    chlInfo.cPicture = (int)rdr[3];
                    chlInfo.cSalary = (int)rdr[4];
                    chlInfo.cLevel = (int)rdr[5];
                    chlInfo.cArea = (string)rdr[6];
                    chlInfo.cRight = (int)rdr[7];
                    chlInfo.cTimeFrom = (DateTime)rdr[8];
                    chlInfo.cTimeTo = (DateTime)rdr[9];
                    chlInfo.cProject1 = (string)rdr[10];
                    chlInfo.cProject2 = (string)rdr[11];
                    chlInfo.cProject3 = (string)rdr[12];
                    chlInfo.cState = (int)rdr[13];
                    chlInfo.cRecommend = (int)rdr[14];
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

        public IList<ChallengeInfo> getChallengesByType(int type)
        {
            IList<ChallengeInfo> challenges = new List<ChallengeInfo>();
            //Create a parameter
            SqlParameter parm = new SqlParameter(PARM_TYPE, SqlDbType.Int);
            parm.Value = type;

            //Execute a query to read the order
            using (SqlDataReader rdr = SqlServerHelper.ExecuteReader(SqlServerHelper.ConnectionString, CommandType.Text, SQL_SELECT_CHALLENGE_BY_TYPE, parm))
            {
                while (rdr.Read())
                {
                    ChallengeInfo challengeInfo = new ChallengeInfo();
                    challengeInfo.cID = (int)rdr[0];
                    challengeInfo.cName = (string)rdr[1];
                    challengeInfo.cType = (int)rdr[2];
                    challengeInfo.cPicture = (int)rdr[3];
                    challengeInfo.cSalary = (int)rdr[4];
                    challengeInfo.cLevel = (int)rdr[5];
                    challengeInfo.cArea = (string)rdr[6];
                    challengeInfo.cRight = (int)rdr[7];
                    challengeInfo.cTimeFrom = (DateTime)rdr[8];
                    challengeInfo.cTimeTo = (DateTime)rdr[9];
                    challengeInfo.cProject1 = (string)rdr[10];
                    challengeInfo.cProject2 = (string)rdr[11];
                    challengeInfo.cProject3 = (string)rdr[12];
                    challengeInfo.cState = (int)rdr[13];
                    challengeInfo.cRecommend = (int)rdr[14];
                    challenges.Add(challengeInfo);
                }
                return challenges;
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
