using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Oxcoder.BackStage_ts
{
    public partial class Administrator : System.Web.UI.Page
    {
        
        AdministratorBusiness ab = null;
        Model.AdminInfo admin = null;
        List<Model.AdminInfo> adminList = null;
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
  

            ab = new AdministratorBusiness();

            if(flag==0)
                adminList = ab.GetAllAdmin();
            else if (flag == 1)
            {
                 adminList = new List<Model.AdminInfo>();
                 admin = ab.GetAdminByName(keyword);//先按姓名查询
                 if (admin.adminName == null)
                 {
                     admin = ab.GetAdminByEmail(keyword);//再按邮箱查询
                     if (admin.adminName == null)
                     {
                         Alert("查无此人", this);
                         return;
                     }
                         
                     else
                         adminList.Add(admin);
                 } 
                 else
                     adminList.Add(admin);
            }


            Button btn;

            for (int i = 0; i < adminList.Count; i++)
            {
                TableRow Row = new TableRow();
                //ID
                TableCell cell0 = new TableCell();
                cell0.Text = adminList[i].adminID.ToString();
                Row.Cells.Add(cell0);
                //Name
                TableCell cell1 = new TableCell();
                cell1.Text = adminList[i].adminName;
                Row.Cells.Add(cell1);
                //type
                TableCell cell2 = new TableCell();
                int type = adminList[i].adminType;
                if (type == 0)
                    cell2.Text = "普通管理员";
                else
                    cell2.Text = "高级管理员";               
                Row.Cells.Add(cell2);
               
                //操作按钮
                TableCell cell3 = new TableCell();
                btn = new Button();
                btn.ID = i.ToString();
                btn.Text = "屏蔽";
                btn.Click += new System.EventHandler(this.buttonClick);
                cell3.Controls.Add(btn);                
                Row.Cells.Add(cell3);


                this.adminTable.Rows.Add(Row);
            }

        }

        protected void buttonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int id = int.Parse(button.ID);
            //Alert("屏蔽" + button.ID + "name"+personList[id].personalName, this);
            AdministratorBusiness adminBusiness = new AdministratorBusiness();
           // personBusiness.Delete(personList[id].personalName);
            adminBusiness.UpdateState(adminList[id].adminName);

            flag = 0;
            Response.AddHeader("Refresh", "0"); 
        }


        protected void Button1_Click(object sender, EventArgs e)//搜索按钮
        {
            keyword = TextName.Text;
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/BackStage_ts/NewAdmin.aspx");
        }

    }

    
}