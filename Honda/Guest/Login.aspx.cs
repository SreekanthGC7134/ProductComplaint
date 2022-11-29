using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Honda.Guest
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        BAL.LoginBAL objbal=new BAL.LoginBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objbal.Name = Name.Text;
            objbal.Password = pwd.Text;
            DataTable dt = objbal.Logincheck();

            if(dt.Rows.Count ==1)
            {
                Session["uid"]=dt.Rows[0]["login_id"];
                Session["uname"] = dt.Rows[0]["user_name"].ToString();

                string a = dt.Rows[0]["role"].ToString().Trim();

                if (a=="Admin")
                {
                    Response.Write("<script>alert('Successfully Logged in')</script>");
                    Response.Redirect("../Admin/AdminHome.aspx");
                }
                else
                {
                    string c = dt.Rows[0]["status"].ToString().Trim();
                   if (c=="1")
                    {
                        Response.Write("<script>alert('Successfully logged in')</script>");
                        Response.Redirect("../User/userhome1.aspx");
                    }
                   
                    else
                    {
                        Response.Write("<script>alert('Failed to login')</script>");
                        Response.Redirect("../Guest/GuestHome.aspx");
                    }
                }
            }
        }
    }
}