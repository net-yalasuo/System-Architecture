using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AdminInfo
    {
        private int aID; //ID
        private String aName; //用户名
        private String aPwd;//密码
        private int aUserType;//类型。0-普通管理员。1-高级管理员
        private int aState;//状态


        // 构造函数
        public AdminInfo() { }

        // ID的获得与设置
        public int adminID
        {
            set { this.aID = value; }
            get { return this.aID;  }
        }

        // 姓名的获得与设置
        public String adminName
        {
            set { this.aName = value; }
            get { return this.aName; }
        }

        // 密码的获得与设置
        public String adminPassword
        {
            set { this.aPwd = value; }
            get { return this.aPwd; }
        }

        // 类型的获得与设置
        public int adminType
        {
            set { this.aUserType = value; }
            get { return this.aUserType; }
        }

        // 状态的获得与设置
        public int adminState
        {
            set { this.aState = value; }
            get { return this.aState; }
        }

    }
}
