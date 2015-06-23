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
    public class Personal : IDALPersonalInfo
    {

        //================================================================以下是ts的哟~=============================
        private const string SQL_UPDATESTATE_PERSONAL = "Update personalinfor set pState= state where pName = @Name;";//更新用户状态
        private const string SQL_GETINFOBYEMAIL_PERSONAL = "select * from personalinfor where pEmail = @Email";//按邮箱查询用户
        private const string SQL_GETINFOBYNAME_PERSONAL = "select * from personalinfor where pName = @Name";//按姓名查询用户
        private const string SQL_GETPERSONALINFO_PERSONAL = "select * from personalinfor where pState = @State";//查询所有用户
        private const string SQL_DELETEPERSON_PERSONAL = "delete from personalinfor where pID = @Id";//删除用户
        private const string SQL_INSERT_PERSONAL = "INSERT INTO personalinfor (pName) VALUES (@Name) SELECT @@identity AS id;";
        private const string SQL_GETONELEVEL_PERSONAL = "select wLevel from personalworth where @Worth>=wRangeFrom AND @Worth<wRangeTo;";


        private const string PARM_ID = "@Id";
        private const string PARM_NAME = "@Name";
        private const string PARM_EMAIL = "@Email";
        private const string PARM_STATE = "@State";
        private const string PARM_WORTH = "@Worth";
        private bool result = false;

       // private int personalLevel;

        /*
         * 按邮箱查找用户
         * by ts
         */
        public PersonalInfo GetPersonalInfoByEmail(string email)
        {

            PersonalInfo personInfo = new PersonalInfo();

            //Create a parameter
            SqlParameter parm = new SqlParameter(PARM_EMAIL, SqlDbType.VarChar);
            parm.Value = email;

            //Execute a query to read the order
            using (SqlDataReader rdr = SqlServerHelper.ExecuteReader(SqlServerHelper.ConnectionString, CommandType.Text, SQL_GETINFOBYEMAIL_PERSONAL, parm))
            {
                if (rdr.Read())
                {
                    personInfo.personalID = (int)rdr[0];
                    personInfo.personalName = (string)rdr[1];
                    personInfo.personalEmail = (string)rdr[3];
                    personInfo.personalAge = (int)rdr[4];
                    personInfo.personalSex = (string)rdr[5];
                    personInfo.personalTel = (string)rdr[6];
                    personInfo.personalWorth = (string)rdr[8];
                    personInfo.personalLevel = GetOnePersonLevel(int.Parse((string)rdr[8]));
                }
            }

            return personInfo;
        }


        /*
         * 按用户名查找用户
         * by ts
         */
        public PersonalInfo GetPersonalInfoByName(string name)
        {

            PersonalInfo personInfo = new PersonalInfo();

            //Create a parameter
            SqlParameter parm = new SqlParameter(PARM_NAME, SqlDbType.VarChar);
            parm.Value = name;

            //Execute a query to read the order
            using (SqlDataReader rdr = SqlServerHelper.ExecuteReader(SqlServerHelper.ConnectionString, CommandType.Text, SQL_GETINFOBYNAME_PERSONAL, parm))
            {

                if (rdr.Read())
                {
                    personInfo.personalID = (int)rdr[0];
                    personInfo.personalName = (string)rdr[1];
                    personInfo.personalEmail = (string)rdr[3];
                    personInfo.personalAge = (int)rdr[4];
                    personInfo.personalSex = (string)rdr[5];
                    personInfo.personalTel = (string)rdr[6];
                    personInfo.personalWorth = (string)rdr[8];
                    personInfo.personalLevel = GetOnePersonLevel(int.Parse((string)rdr[8]));
                }
            }

            return personInfo;
        }




  

        /*
         * 查询全部用户
         * by ts
         */
        public List<PersonalInfo> GetPersonalInfo()
        {

            PersonalInfo personInfo;
            //= new PersonalInfo();
            List<PersonalInfo> personalList = new List<PersonalInfo>();

            //Create a parameter
            SqlParameter parm = new SqlParameter(PARM_STATE, SqlDbType.Int);
            parm.Value = 1;

            //Execute a query to read the order
            using (SqlDataReader rdr = SqlServerHelper.ExecuteReader(SqlServerHelper.ConnectionString, CommandType.Text, SQL_GETPERSONALINFO_PERSONAL,parm))
            {
                while (rdr.Read())
                {
                    personInfo = new PersonalInfo();

                    personInfo.personalID = (int)rdr[0];
                    personInfo.personalName = (string)rdr[1];
                    personInfo.personalEmail = (string)rdr[3];
                    personInfo.personalAge = (int)rdr[4];
                    personInfo.personalSex = (string)rdr[5];
                    personInfo.personalTel = (string)rdr[6];
                    personInfo.personalWorth = (string)rdr[8];
                    personInfo.personalLevel = GetOnePersonLevel(int.Parse((string)rdr[8]));

                    personalList.Add(personInfo);
                }                
            }

            return personalList;
        }

        /*
         * 删除用户
         * by ts
         */
        public bool DeletePerson(int id)
        {
            using (SqlConnection conn = new SqlConnection(SqlServerHelper.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(SQL_DELETEPERSON_PERSONAL, conn);

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
            SqlParameter[] parms = SqlServerHelper.GetCachedParameters(SQL_INSERT_PERSONAL);

            if (parms == null)
            {
                parms = new SqlParameter[] {
					new SqlParameter(PARM_ID, SqlDbType.Int),
					new SqlParameter(PARM_NAME, SqlDbType.VarChar, 50),
                    new SqlParameter(PARM_EMAIL, SqlDbType.VarChar, 50)
                };

                SqlServerHelper.CacheParameters(SQL_INSERT_PERSONAL, parms);
            }

            return parms;
        }

        /*
         * 查询用户等级
         * by ts
         */
        public int GetOnePersonLevel(int worth)
        {

            //PersonalInfo personInfo = new PersonalInfo();
            int level = 0;

            //Create a parameter
            SqlParameter parm = new SqlParameter(PARM_WORTH, SqlDbType.Int);
            parm.Value = worth;

            //Execute a query to read the order
            using (SqlDataReader rdr = SqlServerHelper.ExecuteReader(SqlServerHelper.ConnectionString, CommandType.Text, SQL_GETONELEVEL_PERSONAL, parm))
            {

                if (rdr.Read())
                {
                    //personInfo.personalLevel = (int)rdr[0];  
                    level = (int)rdr[0];

                }
            }

            return level;
        }


    }

}
