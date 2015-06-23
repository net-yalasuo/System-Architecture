using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace BLL
{
    public class PersonalBusiness
    {
         private static readonly IDALPersonalInfo dal = DALFactory.DataAccess.CreatePersonal();

        //通过用户名获取信息
         public PersonalInfo GetPersonByName(string name)
         {
             if (name == null)
                 return null;
             else
                 return dal.GetPersonalInfoByName(name);
         }
        //通过邮箱获取信息
         public PersonalInfo GetPersonByEmail(string email)
         {
             if (email == null)
                 return null;
             else
                 return dal.GetPersonalInfoByEmail(email);
         }
        //获取全部用户信息
         public List<PersonalInfo> GetAllPerson()
         {
             return dal.GetPersonalInfo();
         }

        //删除一条用户信息
        public bool Delete(string name)
        {
            if (name ==null )
                return false;
            else
                return dal.DeletePerson(name);
        }

        //更新用户状态
        public bool UpdateState(string name)
        {
            if (name == null)
                return false;
            else
                return dal.UpdatePersonState(name);
        }
    }
}
