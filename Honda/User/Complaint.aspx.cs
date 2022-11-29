using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Honda.User
{
    public partial class Complaint : System.Web.UI.Page
    {
        BAL.ComplaintBal objbal = new BAL.ComplaintBal();    
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DropDownList2.DataSource = objbal.getproduct();
                
                DropDownList2.DataValueField = "product_amount";
                DropDownList2.DataValueField = "product_name";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("--Select--", "0"));
            }
        }
        protected void Button1(object sender, EventArgs e)
        {
            objbal.ProductId = int.Parse(DropDownList2.SelectedItem.Value);
            objbal.Userid = Convert.ToInt32(Session["uid"]);
            objbal.Complaint = complaint.Text;
            
            //objbal.complaint = Request.Form["complaint"];
           

            int i = objbal.insertComplaint();
            
            if(i==1)
            {
                Response.Write("<script>alert('complaint Registered Successfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('Failed to register the complaint');</script>");
            }

        }
    }
}