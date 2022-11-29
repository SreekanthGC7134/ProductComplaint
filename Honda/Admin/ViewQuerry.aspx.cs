using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Honda.Admin
{
    public partial class ViewQuerry : System.Web.UI.Page
    {
        BAL.QuerryBal objqrybal = new BAL.QuerryBal();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = objqrybal.viewquery();
            GridView1.DataBind();
        }
    }
}