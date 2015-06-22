using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IChallenge
    {

        /*
         * 删除挑战信息
         * 参数 挑战ID
         * 返回 影响:成功与否
         */
        bool Delete(int cId);

        /*
         *通过挑战ID获得课程信息
         *参数 挑战ID
         *返回值 ChallengeInfo对象
         */
        ChallengeInfo GetChlById(int id);

    }
}
