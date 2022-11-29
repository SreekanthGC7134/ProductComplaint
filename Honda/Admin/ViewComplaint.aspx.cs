using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Honda.Admin
{
    public partial class ViewComplaint : System.Web.UI.Page
    {
        BAL.ComplaintBal objcombal = new BAL.ComplaintBal();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = objcombal.viewcomplaint();
            GridView1.DataBind();
        }



        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objcombal.ComplaintId = id;
            int i = objcombal.changecmpltstatus();
            GridView1.DataSource = objcombal.viewcomplaint();
            GridView1.DataBind();
        }
    }
}