using Honda.BAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Honda.DAL
{
    public class ProdDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public ProdDAL()
        {
            //call connectionstring: connection string should be set in the web.config file. 
            string conn = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public int Insert(BAL.ProdBAL obj)
        {

           
            string p = "insert into tbl_product values('" + obj.Name + "','" + obj.Amount + "')";
            SqlCommand cmd= new SqlCommand(p,Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable select(BAL.ProdBAL pb1)
        {
            string s = "SELECT * from tbl_product";
            SqlCommand cm1=new SqlCommand(s,Getcon());
            SqlDataAdapter da=new SqlDataAdapter(cm1);
            DataTable dt=new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int updateprod(BAL.ProdBAL obj)
        {
            string s = "update tbl_product set product_name='" + obj.Name + "' where product_id='" + obj.Productid + "' ";
            SqlCommand cmd=new SqlCommand(s,Getcon());
            return cmd.ExecuteNonQuery();
        }

        public int deleteprod(BAL.ProdBAL obj)
        {
            string s = "delete from tbl_product where product_id='" + obj.Productid + "'";
            SqlCommand cmd= new SqlCommand(s,Getcon());
            return cmd.ExecuteNonQuery();
        }
    }
}