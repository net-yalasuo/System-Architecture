using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EnterpriseManagementInfo
    {
        private int eID; //ID
        private String eName; //公司名
        private String eEmail;//Email
        private String eArea;//地点
        private DateTime eTime;//时间
        private String eTel;//联系电话
       
        private int eState;//状态  0-待审批 1-审批通过 2-拒绝


        // 构造函数
        public EnterpriseManagementInfo() { }

        // ID的获得与设置
        public int enterpriseID
        {
            set { this.eID = value; }
            get { return this.eID;  }
        }

        // 公司名的获得与设置
        public String enterpriseName
        {
            set { this.eName = value; }
            get { return this.eName; }
        }

        // 邮箱的获得与设置
        public String enterpriseEmail
        {
            set { this.eEmail = value; }
            get { return this.eEmail; }
        }

        // 地点的获得与设置
        public String enterpriseArea
        {
            set { this.eArea = value; }
            get { return this.eArea; }
        }

        // 时间的获得与设置
        public DateTime enterpriseTime
        {
            set { this.eTime = value; }
            get { return this.eTime; }
        }

        // 联系电话的获得与设置
        public String enterpriseTel
        {
            set { this.eTel = value; }
            get { return this.eTel; }
        }

        // 状态的获得与设置
        public int enterpriseState
        {
            set { this.eState = value; }
            get { return this.eState; }
        }
    }
}
