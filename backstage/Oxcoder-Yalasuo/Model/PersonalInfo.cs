using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PersonalInfo
    {
        private int pID; //ID
        private String pName; //用户名
        private String pEmail;
        private int pAge;
        private String pSex;
        private String pTel;
        private String pWorth;
        private int pState;
        private int pLevel;

         

        // 构造函数
        public PersonalInfo() { }

        // ID的获得与设置
        public int personalID
        {
            set { this.pID = value; }
            get { return this.pID;  }
        }

        // 姓名的获得与设置
        public String personalName
        {
            set { this.pName = value; }
            get { return this.pName; }
        }

        // 性别的获得与设置
        public String personalSex
        {
            set { this.pSex = value; }
            get { return this.pSex; }
        }

        // 性别的获得与设置
        public int personalAge
        {
            set { this.pAge = value; }
            get { return this.pAge; }
        }

        // 电话号的获得与设置
        public String personalTel
        {
            set { this.pTel = value; }
            get { return this.pTel; }
        }

        // 邮箱的获得与设置
        public String personalEmail
        {
            set { this.pEmail = value; }
            get { return this.pEmail; }
        }

        // 身价的获得与设置
        public String personalWorth
        {
            set { this.pWorth = value; }
            get { return this.pWorth; }
        }

        // 状态的获得与设置
        public int personalState
        {
            set { this.pState = value; }
            get { return this.pState; }
        }

        // 等级的获得与设置
        public int personalLevel
        {
            set { this.pLevel = value; }
            get { return this.pLevel; }
        }
    }
}
