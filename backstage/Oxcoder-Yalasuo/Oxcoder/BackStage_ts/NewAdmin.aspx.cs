using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Oxcoder.BackStage_ts
{
    public partial class NewAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = AdminUserName.Text;
            string password = AdminPassword.Text;

            AdministratorBusiness ab = null;

            if (RadioButtonList1.SelectedValue == "normal")
            {
               // Response.Redirect("~/Teacher.aspx?name=" + TextName.Text);
                ab = new AdministratorBusiness();
                bool result = ab.AddAdmin(name, password, 0);
                if(result)
                    Alert("添加成功" + name, this);
                else
                    Alert("添加失败" + name , this);

            }
            else
            {
                //Response.Redirect("~/Student.aspx?name=" + TextName.Text);
                ab = new AdministratorBusiness();
                bool result = ab.AddAdmin(name, password, 1);
                if (result)
                    Alert("添加成功" + name, this);
                else
                    Alert("添加失败" + name, this);
                
            }
            Response.Redirect("~/BackStage_ts/Administrator.aspx");
        }

        public static void Alert(string info, Page p)//弹窗
        {
            string script = "<script>alert('" + info + "')</script>";
            p.ClientScript.RegisterStartupScript(p.GetType(), "", script);
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}