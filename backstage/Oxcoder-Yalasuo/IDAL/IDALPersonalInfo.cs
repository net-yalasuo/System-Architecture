using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IDALPersonalInfo
    {
        /*
         * 删除用户
         * 参数 用户名
         * 返回 bool
         * by ts
         */
        bool DeletePerson(string name);

        /*
         * 更新用户状态
         * 参数 用户名
         * 返回 bool
         * by ts
         */
        bool UpdatePersonState(string name);

        /*
         *根据用户名查找用户
         *参数 用户名
         *返回值 PersonalInfo对象
         *by ts
         */
        PersonalInfo GetPersonalInfoByName(string name);

        /*
         *根据用户名查找用户
         *参数 邮箱
         *返回值 PersonalInfo对象
         *by ts
         */
        PersonalInfo GetPersonalInfoByEmail(string email);

        /*
         *查找全部用户
         *参数 用户名
         *返回值 List<PersonalInfo>对象
         *by ts
         */
        List<PersonalInfo> GetPersonalInfo();
    }
}
