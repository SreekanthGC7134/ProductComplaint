using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Honda.Guest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BAL.HonBAL objbal=new BAL.HonBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objbal.Name = name.Text;
            objbal.Contact = phone.Text;
            objbal.Email = email.Text;
            objbal.District = district.Text;
            objbal.Place= place.Text;
            objbal.Password=pwd.Text;

           
            object a= objbal.loginInsert();
            objbal.LoginId=a.ToString();


            
            int i = objbal.Insert();
            if(i==1)
            {
                Response.Write("Successfully Inserted");
            }
            else
            {
                Response.Write("Failed To Insert");
            }
        }
    }
}