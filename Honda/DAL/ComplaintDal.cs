using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Honda.DAL
{
    public class ComplaintDal
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public ComplaintDal()
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

        public DataTable Getproduct(BAL.ComplaintBal obj)
        {
            string s = "SELECT * FROM tbl_product";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int complaintInsert(BAL.ComplaintBal obj)
        {
            string qry = "insert into tbl_complaint values('" + obj.Userid + "','" + obj.ProductId + "','" + obj.Complaint + "',GETDATE(),'Complaint Received')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable Viewcomplaintstatus(BAL.ComplaintBal obj)
        {
            string s = "select * from tbl_user tb inner join tbl_complaint cmt on tb.user_id=cmt.user_id inner join tbl_product pt on pt.product_id=cmt.product_id where cmt.user_id='" + obj.Userid + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable complaintview(BAL.ComplaintBal obj)
        {
            string s = "select * from tbl_user tb inner join tbl_complaint cmt on tb.user_id=cmt.user_id inner join tbl_product pt on pt.product_id=cmt.product_id";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int Changecmpltstatus(BAL.ComplaintBal obj)
        {
            string s = "update tbl_complaint set status='Complaint Confirmed' where complaint_id='" + obj.ComplaintId + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }
    }
}
