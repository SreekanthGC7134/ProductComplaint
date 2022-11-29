using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Honda.Admin
{
    public partial class UserConfirm : System.Web.UI.Page
    { 
    BAL.HonBAL obj=new BAL.HonBAL();
        BAL.LoginBAL objlogin = new BAL.LoginBAL();
    
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                GridView1.DataSource = obj.ViewUser();
                GridView1.DataBind();
            }
        }
        protected void GridView1_RowDeleting(object sender,GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objlogin.Userid = id.ToString();
            int i = objlogin.ConfirmUser();
            GridView1.DataSource = obj.ViewUser();



            GridView1.DataBind();
        }
    }
}