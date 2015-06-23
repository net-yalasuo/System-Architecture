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
         *通过挑战ID获得挑战信息
         *参数 挑战ID
         *返回值 ChallengeInfo对象
         */
        ChallengeInfo GetChlById(int id);

        /*
        *通过挑战的类型选择获得相关的所有挑战
        *参数 挑战类型
        *返回值 ChallengeInfo对象列表
        */
        IList<ChallengeInfo> getChallengesByType(int type);

    }
}
