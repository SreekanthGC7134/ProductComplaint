using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Honda.User
{
    public partial class Coplaintstatus : System.Web.UI.Page
    {
        BAL.ComplaintBal objcomtbl = new BAL.ComplaintBal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objcomtbl.Userid = Convert.ToInt32(Session["uid"]);
                GridView1.DataSource = objcomtbl.viewcomplaintstatus();
                GridView1.DataBind();
            }

        }
    }
}