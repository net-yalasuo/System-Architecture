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
    public partial class Enterprise : System.Web.UI.Page
    {
        EnterpriseManagementBusiness emb = null;
        Model.EnterpriseManagementInfo enterprise = null;
        List<Model.EnterpriseManagementInfo> enterpriseList = null;
        static int flag = 0;
        static int ID = -1;
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


            emb = new EnterpriseManagementBusiness();

            if (flag == 0)
                enterpriseList = emb.GetAllEnterprise();
            else if (flag == 1)
            {
                enterpriseList = new List<Model.EnterpriseManagementInfo>();
                enterprise = emb.GetEnterpriseByName(keyword);//按公司名查询
                if (enterprise.enterpriseName == null)
                {
                        Alert("查无此公司", this);
                        return;
                }
                else
                    enterpriseList.Add(enterprise);
            }


            Button btn;

            for (int i = 0; i < enterpriseList.Count; i++)
            {
                TableRow Row = new TableRow();
                //ID
                TableCell cell0 = new TableCell();
                cell0.Text = enterpriseList[i].enterpriseID.ToString();
                Row.Cells.Add(cell0);
                //Name
                TableCell cell1 = new TableCell();
                cell1.Text = enterpriseList[i].enterpriseName;
                Row.Cells.Add(cell1);
                //email
                TableCell cell2 = new TableCell();
                cell2.Text = enterpriseList[i].enterpriseEmail;
                Row.Cells.Add(cell2);
                //area
                TableCell cell3 = new TableCell();
                cell3.Text = enterpriseList[i].enterpriseArea;
                Row.Cells.Add(cell3);
                //time
                TableCell cell4 = new TableCell();
                cell4.Text = enterpriseList[i].enterpriseTime.ToString();
                Row.Cells.Add(cell4);

                //操作按钮
                TableCell cell6 = new TableCell();
                btn = new Button();
                btn.ID = i.ToString();
                btn.Text = "详情";
                btn.Click += new System.EventHandler(this.buttonClick);
                cell6.Controls.Add(btn);
                Row.Cells.Add(cell6);


                this.adminTable.Rows.Add(Row);
            }

        }

        protected void buttonClick(object sender, EventArgs e)//详情按钮
        {
            Button button = sender as Button;
            int id = int.Parse(button.ID);
            ID = id;

            EnterpriseManagementBusiness enterpriseBusiness = new EnterpriseManagementBusiness();

            nameLabel.Text = enterpriseList[id].enterpriseName;
            emailLabel.Text = enterpriseList[id].enterpriseEmail;
            phoneLabel.Text = enterpriseList[id].enterpriseTel;

            //enterpriseBusiness.UpdateState(enterpriseList[id].enterpriseName,1);

            //Response.AddHeader("Refresh", "0");


            string script = "<script language='javascript'>$(document).ready(function(){$(\"#myModal\").modal('show');});</script>";
            //string ss = "<script language='javascript'>$(\"#myModal\").modal('show');</script>";
            this.ClientScript.RegisterStartupScript(this.GetType(), "", script);            
        }


        protected void Button1_Click(object sender, EventArgs e)//搜索按钮
        {
            keyword = TextName.Text;
            if (keyword.Equals("请输入关键词，公司名"))
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

        protected void Button2_Click(object sender, EventArgs e)//拒绝按钮
        {
            EnterpriseManagementBusiness enterpriseBusiness = new EnterpriseManagementBusiness();
            enterpriseBusiness.UpdateState(enterpriseList[ID].enterpriseName, 2);
  
            Response.AddHeader("Refresh", "0");
        }

        protected void Button3_Click(object sender, EventArgs e)//通过按钮
        {
            EnterpriseManagementBusiness enterpriseBusiness = new EnterpriseManagementBusiness();

            enterpriseBusiness.UpdateState(enterpriseList[ID].enterpriseName, 1);
            Response.AddHeader("Refresh", "0");
        }

    }
}