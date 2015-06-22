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

            PersonalBusiness pb = new PersonalBusiness();
            Model.PersonalInfo person = pb.GetPersonByName("ts");

            List<Model.PersonalInfo> personList = pb.GetAllPerson();

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
                //cell12.
                cell12.Text = "按钮啊啊啊";
                Row.Cells.Add(cell12);

                //cell12.

               // Response.Write("<a href=\"#\" class=\"btn btn-small btn-danger\" type=\"button\">屏蔽</a>      <a href=\"#\" class=\"btn btn-small btn-primary\" type=\"button\">详情（数据统计）</a>");
               
                //Response.Write("</center>");

                this.personalTable.Rows.Add(Row);
            }
            /*
            for (int i = 0; i < 3; i++)
            {
                TableRow Row = new TableRow();

                TableCell Cell0 = new TableCell();
                Cell0.Text = person.personalID.ToString();

                TableCell Cell1 = new TableCell();
                Cell1.Text = person.personalName;

                TableCell Cell2 = new TableCell();
                Cell2.Text = person.personalEmail;

                Row.Cells.Add(Cell0);
                Row.Cells.Add(Cell1);
                Row.Cells.Add(Cell2);

                this.personalTable.Rows.Add(Row);
            }*/
        }
    }
}