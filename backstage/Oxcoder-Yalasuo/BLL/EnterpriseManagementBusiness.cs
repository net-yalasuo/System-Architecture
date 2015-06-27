using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace BLL
{
    public class EnterpriseManagementBusiness
    {
        private static readonly IDALEnterpriseManagement dal = DALFactory.DataAccess.CreateEnterpriseManagement();

        //通过公司名获取信息
        public EnterpriseManagementInfo GetEnterpriseByName(string name)
        {
            if (name == null)
                return null;
            else
                return dal.GetEnterpriseInfoByName(name);
        }

        //获取全部公司信息
        public List<EnterpriseManagementInfo> GetAllEnterprise()
        {
            return dal.GetEnterpriseInfo();
        }

        //删除一条用户信息
        public bool Delete(string name)
        {
            if (name == null)
                return false;
            else
                return dal.DeleteEnterprise(name);
        }

        //更新状态
        public bool UpdateState(string name, int state)
        {
            if (name == null)
                return false;
            else
                return dal.UpdateEnterpriseState(name,state);
        }

    }
}
