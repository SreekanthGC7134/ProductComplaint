using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Honda.Admin
{
    public partial class ViewUser : System.Web.UI.Page
    {
        BAL.HonBAL objbal=new BAL.HonBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GridView1.DataSource = objbal.ViewUser();
                GridView1.DataBind();
            }
        }

       
    }
}