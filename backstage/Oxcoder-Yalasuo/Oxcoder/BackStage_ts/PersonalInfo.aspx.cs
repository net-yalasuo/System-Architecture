using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using IDAL;
using Model;


namespace Oxcoder.BackStage_ts
{
    public partial class PersonalInfo : System.Web.UI.Page
    {
        PersonalBusiness pb = null;
        Model.PersonalInfo person = null;
        List<Model.PersonalInfo> personList = null;
        static int flag=0;
        static string keyword = null;



        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["result"] != null)
            {
                int result = int.Parse(Request.QueryString["result"]);
                if (result == 1)
                {
                    this.resultMsg.InnerText = "操作成功";
                }
                else
                {
                    this.resultMsg.InnerText = "操作失败";
                }

            }
  

            pb = new PersonalBusiness();

            if(flag==0)
                personList = pb.GetAllPerson();
            else if (flag == 1)
            {
                 personList = new List<Model.PersonalInfo>();
                 person = pb.GetPersonByName(keyword);//先按姓名查询
                 if (person.personalID == 0 && person.personalLevel == 0 && person.personalAge == 0)
                 {
                     person = pb.GetPersonByEmail(keyword);//再按邮箱查询
                     if (person.personalID == 0 && person.personalLevel == 0 && person.personalAge == 0)
                     {
                         Alert("查无此人", this);
                         return;
                     }
                         
                     else
                         personList.Add(person);
                 } 
                 else
                     personList.Add(person);
            }


            Button btn;

            for (int i = 0; i < personList.Count; i++)
            {
                TableRow Row = new TableRow();
                //ID
                TableCell cell0 = new TableCell();
                cell0.Text = personList[i].personalID.ToString();
                Row.Cells.Add(cell0);
                //Name
                TableCell cell1 = new TableCell();
                cell1.Text = personList[i].personalName;
                Row.Cells.Add(cell1);
                //Age
                TableCell cell2 = new TableCell();
                cell2.Text = personList[i].personalAge.ToString();
                Row.Cells.Add(cell2);
                //Sex
                TableCell cell3 = new TableCell();
                cell3.Text = personList[i].personalSex;
                Row.Cells.Add(cell3);
                //Tel
                TableCell cell4 = new TableCell();
                cell4.Text = personList[i].personalTel;
                Row.Cells.Add(cell4);
                //Email
                TableCell cell5 = new TableCell();
                cell5.Text = personList[i].personalEmail;
                Row.Cells.Add(cell5);
                //Worth身价
                TableCell cell6 = new TableCell();
                cell6.Text = personList[i].personalWorth;
                Row.Cells.Add(cell6);
                //级别
                TableCell cell7 = new TableCell();
                cell7.Text = personList[i].personalLevel.ToString();
                Row.Cells.Add(cell7);
                //技术类型
                TableCell cell8 = new TableCell();
                cell8.Text = "Android";
                Row.Cells.Add(cell8);
                //挑战次数
                TableCell cell9 = new TableCell();
                cell9.Text = 7.ToString();
                Row.Cells.Add(cell9);
                //绑定社交帐号
                TableCell cell10 = new TableCell();
                cell10.Text = "Github";
                Row.Cells.Add(cell10);
                //更新时间
                TableCell cell11 = new TableCell();
                cell11.Text = "2015-6-20 11:11";
                Row.Cells.Add(cell11);
                //操作按钮
                TableCell cell12 = new TableCell();
                btn = new Button();
                btn.ID = i.ToString();
                btn.Text = "屏蔽";
                btn.Click += new System.EventHandler(this.buttonClick);
                cell12.Controls.Add(btn);                
                Row.Cells.Add(cell12);


                this.personalTable.Rows.Add(Row);
            }

        }

        protected void buttonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int id = int.Parse(button.ID);
            //Alert("屏蔽" + button.ID + "name"+personList[id].personalName, this);
            PersonalBusiness personBusiness = new PersonalBusiness();
           // personBusiness.Delete(personList[id].personalName);
            personBusiness.UpdateState(personList[id].personalName);

            flag = 0;
            Response.AddHeader("Refresh", "0"); 
        }


        protected void Button1_Click(object sender, EventArgs e)//搜索按钮
        {
            keyword = TextName.Text;
            if (keyword.Equals("请输入关键词，姓名、邮箱"))
                flag = 0;
            else
                flag = 1;
            Response.AddHeader("Refresh", "0"); 
        }

        public static void Alert(string info, Page p)//弹窗
        {
            string script = "<script>alert('" + info + "')</script>";
            p.ClientScript.RegisterStartupScript(p.GetType(), "", script);
        }

    }

    
}