using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ChallengeInfo
    {

        private int cid; //挑战ID
        private String cname; //挑战名称

        // 构造函数
        public ChallengeInfo() { }

        // 挑战ID的获得与设置
        public int cID
        {
            set { this.cid = value; }
            get { return this.cid;  }
        }

        // 挑战名称的获得与设置
        public String cName
        {
            set { this.cname = value; }
            get { return this.cname; }
        }


    }
}
