using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Honda.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BAL.ProdBAL objbal = new BAL.ProdBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objbal.ViewProd();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objbal.Name = product.Text;
            objbal.Amount = amount.Text;



            int i = objbal.Insert();
            if (i == 1)
            {
                Response.Write("Successfully Inserted");
            }
            else
            {
                Response.Write("Failed To Insert");
            }
        }



        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objbal.ViewProd();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
                int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
                TextBox txt = new TextBox();
                txt = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
                objbal.Productid = id;
                objbal.Name = txt.Text;
            TextBox txtamount = new TextBox();
            txtamount = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            objbal.Amount = txtamount.Text;
                int i = objbal.updateprod();
                GridView1.EditIndex = -1;
            }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int d=Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString()); 
            objbal.Productid = d;
            int i=objbal.deleteprod();
            GridView1.DataSource=objbal.ViewProd();
            GridView1.DataBind();
        }
    }
    }
