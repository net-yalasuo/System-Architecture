using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IDALAdministrator
    {
        /*
         * 删除管理员
         * 参数 用户名
         * 返回 bool
         * by ts
         */
        bool DeleteAdmin(string name);

        /*
         * 更新管理员状态
         * 参数 用户名
         * 返回 bool
         * by ts
         */
        bool UpdateAdminState(string name);

        /*
         *根据用户名查找用户
         *参数 用户名
         *返回值 AdminInfo对象
         *by ts
         */
        AdminInfo GetAdminInfoByName(string name);

        /*
         *根据用户名查找管理员
         *参数 邮箱
         *返回值 AdminInfo对象
         *by ts
         */
        AdminInfo GetAdminInfoByEmail(string email);

        /*
         *查找全部管理员
         *参数 
         *返回值 List<AdminInfo>对象
         *by ts
         */
        List<AdminInfo> GetAdminInfo();

        /*
         *添加管理员
         *参数 用户名，密码，类型
         *返回值 bool
         *by ts
         */
        bool AddAdmin(string name, string psw, int type);
    }
}
