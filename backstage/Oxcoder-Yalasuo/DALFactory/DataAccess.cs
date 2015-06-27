using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;

namespace DALFactory
{
    public sealed class DataAccess
    {
        // Look up the DAL implementation we should be using
        //private static readonly string path = ConfigurationManager.AppSettings["WebDAL"];
        private static readonly string path = "SQLServerDAL";
        private DataAccess() { }

        /*
         * 实例化用户数据操作
         * */
        public static IDAL.IChallenge CreateChallenge()
        {
            string className = "SQLServerDAL.Challenge";
            return (IDAL.IChallenge)Assembly.Load(path).CreateInstance(className);
        }
        //创建个人用户管理
        public static IDAL.IDALPersonalInfo CreatePersonal()
        {
            string className = "SQLServerDAL.Personal";
            return (IDAL.IDALPersonalInfo)Assembly.Load(path).CreateInstance(className);
        }
        //创建管理员管理
        public static IDAL.IDALAdministrator CreateAdmin()
        {
            string className = "SQLServerDAL.Administrator";
            return (IDAL.IDALAdministrator)Assembly.Load(path).CreateInstance(className);
        }
        //创建企业管理
        public static IDAL.IDALEnterpriseManagement CreateEnterpriseManagement()
        {
            string className = "SQLServerDAL.EnterpriseManagement";
            return (IDAL.IDALEnterpriseManagement)Assembly.Load(path).CreateInstance(className);
        }

    }
}
