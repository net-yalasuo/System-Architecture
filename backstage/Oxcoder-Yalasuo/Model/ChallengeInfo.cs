using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ChallengeInfo
    {
        private int cid;            //挑战ID
        private String cname;       //挑战名称
        private int ctype;       //挑战类型
        private int cpicture;       //是否使用随机拍照功能  0-不使用，1-使用
        private int csalary;        //挑战的薪资等级
        private int clevel;         //挑战的等级，会按照薪资自动划分
        private String carea;       //挑战的地区，和公司的地区一样
        private int cright;         //挑战是否有公开的权利（企业中好像用到）
        private DateTime ctimefrom; //挑战开始的时间
        private DateTime ctimeto;   //挑战截止日期
        private string cproject1;      //挑战中的第一个项目
        private string cproject2;      //挑战中的第二个项目
        private string cproject3;      //挑战中的第三个项目
        private int cstate;         //挑战的状态
        private int crecommend;     //挑战推荐的状态，是否为推荐的挑战

        // 构造函数
        public ChallengeInfo() { }

        // 挑战ID的获得与设置
        public int cID
        {
            set { this.cid = value; }
            get { return this.cid; }
        }

        // 挑战名称的获得与设置
        public String cName
        {
            set { this.cname = value; }
            get { return this.cname; }
        }

        // 挑战类型的获得与设置
        public int cType
        {
            set { this.ctype = value; }
            get { return this.ctype; }
        }

        // 挑战是否使用随机拍照功能的获得与设置
        public int cPicture
        {
            set { this.cpicture = value; }
            get { return this.cpicture; }
        }

        // 挑战设定的薪资的获得与设置
        public int cSalary
        {
            set { this.csalary = value; }
            get { return this.csalary; }
        }

        // 挑战等级的获得与设置
        public int cLevel
        {
            set { this.clevel = value; }
            get { return this.clevel; }
        }

        // 挑战的地区（对应企业的地区）的获得与设置
        public String cArea
        {
            set { this.carea = value; }
            get { return this.carea; }
        }

        // 挑战是否有公开的权利的获得与设置
        public int cRight
        {
            set { this.cright = value; }
            get { return this.cright; }
        }

        // 挑战开始时间的获得与设置
        public DateTime cTimeFrom
        {
            set { this.ctimefrom = value; }
            get { return this.ctimefrom; }
        }

        // 挑战截止时间的获得与设置
        public DateTime cTimeTo
        {
            set { this.ctimeto = value; }
            get { return this.ctimeto; }
        }

        // 挑战状态的获得与设置
        public int cState
        {
            set { this.cstate = value; }
            get { return this.cstate; }
        }

        // 挑战推荐状态，是否为推荐的获得与设置
        public int cRecommend
        {
            set { this.crecommend = value; }
            get { return this.crecommend; }
        }

        // 挑战具体项目1的获得与设置
        public String cProject1
        {
            set { this.cproject1 = value; }
            get { return this.cproject1; }
        }

        // 挑战具体项目2的获得与设置
        public String cProject2
        {
            set { this.cproject2 = value; }
            get { return this.cproject2; }
        }

        // 挑战具体项目3的获得与设置
        public String cProject3
        {
            set { this.cproject3 = value; }
            get { return this.cproject3; }
        }

    }
}
