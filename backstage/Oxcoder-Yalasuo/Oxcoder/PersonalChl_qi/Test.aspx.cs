using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLServerDAL;
using Model;
using BLL;
using System.Web.UI.HtmlControls;


namespace Oxcoder.PersonalChl_qi
{
    public partial class Test : System.Web.UI.Page
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

            ChallengeBusiness cb = new ChallengeBusiness();
            ChallengeInfo challenge = cb.GetChl(1);


            TableRow Row = new TableRow();

            TableCell Cell0 = new TableCell();
            Cell0.Text = 1.ToString();

            TableCell Cell1 = new TableCell();
            Cell1.Text = challenge.cName;

            Row.Cells.Add(Cell0);
            Row.Cells.Add(Cell1);

            this.classTable.Rows.Add(Row);
        }
    }
}