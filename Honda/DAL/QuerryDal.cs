using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Honda.DAL
{
    public class QuerryDal

    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public QuerryDal()
        {
            //call conncetionstring;conncetion string should be set in the web.conf file
            string conn = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection GetCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public DataTable Getproduct(BAL.QuerryBal obj)
        {
            string s = "SELECT * FROM tbl_product";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int QuerryInsert(BAL.QuerryBal obj)
        {
            string qry = "insert into tbl_query values('" + obj.CustomerId + "','" + obj.ProductId + "','" + obj.Querry + "','Querry-Received',GETDATE())";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable queryview(BAL.QuerryBal obj)
        {
            string s = "select * from tbl_user tb inner join tbl_query qrt on tb.user_id=qrt.user_id inner join tbl_product pt on pt.product_id=qrt.product_id";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}