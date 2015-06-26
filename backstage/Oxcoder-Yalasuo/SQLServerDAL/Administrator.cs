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
    public class Administrator : IDALAdministrator
    {

        //================================================================以下是ts的哟~=============================
        private const string SQL_UPDATESTATE_ADMIN = "Update admin set aState= 0 where aName = @Name;";//更新用户状态
        private const string SQL_GETINFOBYEMAIL_ADMIN = "select * from admin where aEmail = @Email";//按邮箱查询用户
        private const string SQL_GETINFOBYNAME_ADMIN = "select * from admin where aName = @Name";//按姓名查询用户
        private const string SQL_GETADMININFO_ADMIN = "select * from admin where aState = @State";//查询所有用户
        private const string SQL_DELETEADMIN_ADMIN = "delete from admin where aName = @Name";//删除用户
        private const string SQL_INSERT_ADMIN = "INSERT INTO admin (aName) VALUES (@Name) SELECT @@identity AS id;";
        private const string SQL_ADDADMIN_ADMIN = "insert into admin(aName,aPwd,aUserType,aState) values(@Name,@Psw,@Type,1);";


        private const string PARM_ID = "@Id";
        private const string PARM_NAME = "@Name";
        private const string PARM_PSW = "@Psw";
        private const string PARM_TYPE = "@Type";
        private const string PARM_EMAIL = "@Email";
        private const string PARM_STATE = "@State";

        private bool result = false;

        /*
         * 按邮箱查找用户
         * by ts
         */
        public AdminInfo GetAdminInfoByEmail(string email)
        {

            AdminInfo adminInfo = new AdminInfo();

            //Create a parameter
            SqlParameter parm = new SqlParameter(PARM_EMAIL, SqlDbType.VarChar);
            parm.Value = email;

            //Execute a query to read the order
            using (SqlDataReader rdr = SqlServerHelper.ExecuteReader(SqlServerHelper.ConnectionString, CommandType.Text, SQL_GETINFOBYEMAIL_ADMIN, parm))
            {
                if (rdr.Read())
                {
                    adminInfo.adminID = (int)rdr[0];
                    adminInfo.adminName = (string)rdr[1];
                    adminInfo.adminPassword = (string)rdr[2];
                    adminInfo.adminType = (int)rdr[3];
                    adminInfo.adminState = (int)rdr[4];                    
                }
            }

            return adminInfo;
        }


        /*
         * 按用户名查找用户
         * by ts
         */
        public AdminInfo GetAdminInfoByName(string name)
        {

            AdminInfo adminInfo = new AdminInfo();

            //Create a parameter
            SqlParameter parm = new SqlParameter(PARM_NAME, SqlDbType.VarChar);
            parm.Value = name;

            //Execute a query to read the order
            using (SqlDataReader rdr = SqlServerHelper.ExecuteReader(SqlServerHelper.ConnectionString, CommandType.Text, SQL_GETINFOBYNAME_ADMIN, parm))
            {

                if (rdr.Read())
                {
                    adminInfo.adminID = (int)rdr[0];
                    adminInfo.adminName = (string)rdr[1];
                    adminInfo.adminPassword = (string)rdr[2];
                    adminInfo.adminType = (int)rdr[3];
                    adminInfo.adminState = (int)rdr[4];
                    
                }
            }

            return adminInfo;
        }






        /*
         * 查询全部用户
         * by ts
         */
        public List<AdminInfo> GetAdminInfo()
        {

            AdminInfo adminInfo;
            List<AdminInfo> adminList = new List<AdminInfo>();

            //Create a parameter
            SqlParameter parm = new SqlParameter(PARM_STATE, SqlDbType.Int);
            parm.Value = 1;

            //Execute a query to read the order
            using (SqlDataReader rdr = SqlServerHelper.ExecuteReader(SqlServerHelper.ConnectionString, CommandType.Text, SQL_GETADMININFO_ADMIN, parm))
            {
                while (rdr.Read())
                {
                    adminInfo = new AdminInfo();

                    adminInfo.adminID = (int)rdr[0];
                    adminInfo.adminName = (string)rdr[1];
                    adminInfo.adminPassword = (string)rdr[2];
                    adminInfo.adminType = (int)rdr[3];
                    adminInfo.adminState = (int)rdr[4];

                    adminList.Add(adminInfo);
                }
            }

            return adminList;
        }

        /*
         * 删除用户
         * by ts
         */
        public bool DeleteAdmin(string name)
        {
            using (SqlConnection conn = new SqlConnection(SqlServerHelper.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(SQL_DELETEADMIN_ADMIN, conn);

                SqlParameter[] adminParms = GetClassParameters();

                adminParms[1].Value = name;

                cmd.Parameters.Add(adminParms[1]);

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

        public bool UpdateAdminState(string name)
        {
            using (SqlConnection conn = new SqlConnection(SqlServerHelper.ConnectionString))
            {

                SqlCommand cmd = new SqlCommand(SQL_UPDATESTATE_ADMIN, conn);

                SqlParameter parm = new SqlParameter(PARM_NAME, SqlDbType.VarChar);
                parm.Value = name;

                SqlParameter[] sqlParas = new SqlParameter[]{                      
                    new SqlParameter(PARM_ID, SqlDbType.Int),
					new SqlParameter(PARM_NAME, SqlDbType.VarChar),
                    new SqlParameter(PARM_EMAIL, SqlDbType.VarChar)
                };

                sqlParas[1].Value = name;
                cmd.Parameters.Add(sqlParas[1]);

                // foreach(SqlParameter sp in sqlParas)
                // {
                // cmd.Parameters.Add(sp);
                // }
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

        public bool AddAdmin(string name,string psw,int type)
        {
            using (SqlConnection conn = new SqlConnection(SqlServerHelper.ConnectionString))
            {

                //SqlCommand cmd = new SqlCommand(SQL_ADDADMIN_ADMIN, conn);
                string sql = "insert into admin(aName,aPwd,aUserType,aState) values('" + name + "','" + psw + "'," + type + ",1);";

                SqlCommand cmd = new SqlCommand(sql,conn);

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
            SqlParameter[] parms = SqlServerHelper.GetCachedParameters(SQL_INSERT_ADMIN);

            if (parms == null)
            {
                parms = new SqlParameter[] {
					new SqlParameter(PARM_ID, SqlDbType.Int),
					new SqlParameter(PARM_NAME, SqlDbType.VarChar, 50),
                    new SqlParameter(PARM_EMAIL, SqlDbType.VarChar, 50)
                };

                SqlServerHelper.CacheParameters(SQL_INSERT_ADMIN, parms);
            }

            return parms;
        }

    }

}
