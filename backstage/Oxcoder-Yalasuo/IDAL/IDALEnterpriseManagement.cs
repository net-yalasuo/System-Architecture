using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IDALEnterpriseManagement
    {
        /*
         * 删除公司
         * 参数 用户名
         * 返回 bool
         * by ts
         */
        bool DeleteEnterprise(string name);

        /*
         * 更新公司审批状态
         * 参数 用户名
         * 返回 bool
         * by ts
         */
        bool UpdateEnterpriseState(string name, int state);

        /*
         *根据公司名查找待审批公司
         *参数 用户名
         *返回值 EnterpriseManagementInfo对象
         *by ts
         */
        EnterpriseManagementInfo GetEnterpriseInfoByName(string name);

        /*
         *根据用户名查找待审批公司
         *参数 
         *返回值 EnterpriseManagementInfo对象
         *by ts
         */

        List<EnterpriseManagementInfo> GetEnterpriseInfo();

    }
}
