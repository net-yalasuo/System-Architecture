using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace BLL
{
    public class AdministratorBusiness
    {
        private static readonly IDALAdministrator dal = DALFactory.DataAccess.CreateAdmin();

        //通过用户名获取信息
         public AdminInfo GetAdminByName(string name)
         {
             if (name == null)
                 return null;
             else
                 return dal.GetAdminInfoByName(name);
         }
        //通过邮箱获取信息
         public AdminInfo GetAdminByEmail(string email)
         {
             if (email == null)
                 return null;
             else
                 return dal.GetAdminInfoByEmail(email);
         }
        //获取全部管理员信息
         public List<AdminInfo> GetAllAdmin()
         {
             return dal.GetAdminInfo();
         }

        //删除一条用户信息
        public bool Delete(string name)
        {
            if (name ==null )
                return false;
            else
                return dal.DeleteAdmin(name);
        }

        //更新用户状态
        public bool UpdateState(string name)
        {
            if (name == null)
                return false;
            else
                return dal.UpdateAdminState(name);
        }

        //添加管理员
        public bool AddAdmin(string name,string psw, int type)
        {
            if (name == null || psw==null)
                return false;
            else
                return dal.AddAdmin(name,psw,type);
        }
    }
    }

