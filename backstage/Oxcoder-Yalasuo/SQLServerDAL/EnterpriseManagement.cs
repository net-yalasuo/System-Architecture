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
    public class EnterpriseManagement : IDALEnterpriseManagement
    {
        private const string SQL_UPDATESTATE_ENTERPRISE = "Update enterpriseinfor set eState= @State where eName = @Name;";//更新公司审批状态
        //private const string SQL_GETINFOBYNAME_ENTERPRISE = "select * from enterpriseinfor where eCmpName = @Name";//按公司名查询
        private const string SQL_GETINFOBYNAME_ENTERPRISE = "select * from enterpriseinfor where eCmpName like '%@Name%';";//按公司名查询
        private const string SQL_GETENTERPRISEINFO_ENTERPRISE = "select * from enterpriseinfor where eState = @State";//查询所有待审批公司
        private const string SQL_DELETEENTERPRISE_ENTERPRISE = "delete from enterpriseinfor where eName = @Name";//删除公司


        private const string PARM_ID = "@Id";
        private const string PARM_NAME = "@Name";
        private const string PARM_STATE = "@State";

        private bool result = false;

        //按公司名删除
        public bool DeleteEnterprise(string name)
        {
            using (SqlConnection conn = new SqlConnection(SqlServerHelper.ConnectionString))
            {

                SqlCommand cmd = new SqlCommand(SQL_DELETEENTERPRISE_ENTERPRISE, conn);

                SqlParameter parm = new SqlParameter(PARM_NAME, SqlDbType.VarChar);
                parm.Value = name;

                SqlParameter[] sqlParas = new SqlParameter[]{                      
                    new SqlParameter(PARM_ID, SqlDbType.Int),
					new SqlParameter(PARM_NAME, SqlDbType.VarChar),
                    new SqlParameter(PARM_STATE, SqlDbType.Int)
                };

                sqlParas[1].Value = name;
                cmd.Parameters.Add(sqlParas[1]);
 

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

        public bool UpdateEnterpriseState(string name,int state)
        {
            using (SqlConnection conn = new SqlConnection(SqlServerHelper.ConnectionString))
            {

                SqlCommand cmd = new SqlCommand(SQL_UPDATESTATE_ENTERPRISE, conn);

                SqlParameter parm = new SqlParameter(PARM_NAME, SqlDbType.VarChar);
                parm.Value = name;

                SqlParameter[] sqlParas = new SqlParameter[]{                      
                    new SqlParameter(PARM_ID, SqlDbType.Int),
					new SqlParameter(PARM_NAME, SqlDbType.VarChar),
                    new SqlParameter(PARM_STATE, SqlDbType.Int)
                };

                sqlParas[1].Value = name;
                cmd.Parameters.Add(sqlParas[1]);
                sqlParas[2].Value = state;
                cmd.Parameters.Add(sqlParas[2]);

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

        //按公司名获取企业信息
        public EnterpriseManagementInfo GetEnterpriseInfoByName(string name)
        {
            EnterpriseManagementInfo enterpriseInfo = new EnterpriseManagementInfo();

            //Create a parameter
            SqlParameter parm = new SqlParameter(PARM_NAME, SqlDbType.VarChar);
            parm.Value = name;

            //模糊查询
            String sql = "select * from enterpriseinfor where eCmpName like '%"+name+"%';";

            using (SqlDataReader rdr = SqlServerHelper.ExecuteReader(SqlServerHelper.ConnectionString, CommandType.Text, sql))
            {
                if (rdr.Read())
                {
                    enterpriseInfo.enterpriseID = (int)rdr[0];
                    enterpriseInfo.enterpriseEmail = (string)rdr[3];
                    enterpriseInfo.enterpriseName = (string)rdr[4];
                    enterpriseInfo.enterpriseState = (int)rdr[16];
                    enterpriseInfo.enterpriseArea = (string)rdr[8];
                    enterpriseInfo.enterpriseTime = (DateTime)rdr[17];
                }
            }
               

            //精准查询
            //Execute a query to read the order
        /*    using (SqlDataReader rdr = SqlServerHelper.ExecuteReader(SqlServerHelper.ConnectionString, CommandType.Text, SQL_GETINFOBYNAME_ENTERPRISE, parm))
            {

                if (rdr.Read())
                {
                    enterpriseInfo.enterpriseID = (int)rdr[0];
                    enterpriseInfo.enterpriseEmail = (string)rdr[3];
                    enterpriseInfo.enterpriseName = (string)rdr[4];
                    enterpriseInfo.enterpriseState = (int)rdr[16];
                    enterpriseInfo.enterpriseArea = (string)rdr[8];
                    enterpriseInfo.enterpriseTime = (DateTime)rdr[17];  
                }
            }*/

            return enterpriseInfo;
        }

        //获取所有待审批的企业信息
        public List<EnterpriseManagementInfo> GetEnterpriseInfo()
        {
            EnterpriseManagementInfo enterpriseInfo;
            
            List<EnterpriseManagementInfo> enterpriseList = new List<EnterpriseManagementInfo>();

            //Create a parameter
            SqlParameter parm = new SqlParameter(PARM_STATE, SqlDbType.Int);
            parm.Value = 0;

            //Execute a query to read the order
            using (SqlDataReader rdr = SqlServerHelper.ExecuteReader(SqlServerHelper.ConnectionString, CommandType.Text, SQL_GETENTERPRISEINFO_ENTERPRISE, parm))
            {
                while (rdr.Read())
                {
                    enterpriseInfo = new EnterpriseManagementInfo();

                    enterpriseInfo.enterpriseID = (int)rdr[0];
                    enterpriseInfo.enterpriseEmail = (string)rdr[3];
                    enterpriseInfo.enterpriseName = (string)rdr[4];
                    enterpriseInfo.enterpriseState = (int)rdr[16];
                    enterpriseInfo.enterpriseArea = (string)rdr[8];
                    enterpriseInfo.enterpriseTime = (DateTime)rdr[17];                    

                    enterpriseList.Add(enterpriseInfo);
                }
            }

            return enterpriseList;
        }


        
    }
}
