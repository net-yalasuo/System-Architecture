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
         * 实例化挑战数据操作
         * */
        public static IDAL.IChallenge CreateChallenge()
        {
            string className = "SQLServerDAL.Challenge";
            return (IDAL.IChallenge)Assembly.Load(path).CreateInstance(className);
        }

        public static IDAL.IDALPersonalInfo CreatePersonal()
        {
            string className = "SQLServerDAL.Personal";
            return (IDAL.IDALPersonalInfo)Assembly.Load(path).CreateInstance(className);
        }

        /*
         * 实例化挑战具体项目数据操作
         * 
        public static IDAL.IChallengeProject CreateChallengeProject()
        {
            string className = "SQLServerDAL.ChallengeProject";
            return (IDAL.IChallengeProject)Assembly.Load(path).CreateInstance(className);
        }*/

        /*
         * 实例化个人挑战数据操作
         * 
        public static IDAL.IPersonalChallenge CreatePersonalChallenge()
        {
            string className = "SQLServerDAL.PersonalChallenge";
            return (IDAL.IPersonalChallenge)Assembly.Load(path).CreateInstance(className);
        }*/

    }
}
