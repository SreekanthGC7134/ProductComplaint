using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Honda.Admin
{
    public partial class Reply : System.Web.UI.Page
    {
        BAL.QuerryBal objqrybal = new BAL.QuerryBal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int queid = Convert.ToInt32(Request.QueryString["qid"]);
            objqrybal.Reply = txtreply.Text;
            objqrybal.QuerryId = queid;
            int i = objqrybal.updateqry();
            if (i == 1)
            {
                Response.Write("<script>alert('Reply Registered Successfully');</script>");

            }
        }
    }
}
