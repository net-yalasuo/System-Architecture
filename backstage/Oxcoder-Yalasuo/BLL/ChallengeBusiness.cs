using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace BLL
{
    public class ChallengeBusiness
    {
        private static readonly IChallenge dal = DALFactory.DataAccess.CreateChallenge();

        //通过ID获取一个挑战的信息
        public ChallengeInfo GetChl(int cId)
        {
            if (cId <= 0)
                return null;
            else
                return dal.GetChlById(cId);
        }

        //删除一条挑战
        public bool Delete(int cId)
        {
            if (cId < 0)
                return false;
            else
                return dal.Delete(cId);
        }

        //通过挑战类型获得所有相关的挑战
        public IList<ChallengeInfo> GetChallengesByType(int type)
        {
            //还不确定是否需要附加条件
            return dal.getChallengesByType(type);
        }
    }
}
