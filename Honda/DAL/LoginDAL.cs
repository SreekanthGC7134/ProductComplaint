using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Honda.DAL
{
    public class LoginDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public LoginDAL()
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
      
        public DataTable Select(BAL.LoginBAL obj)
        {


            string qry = "SELECT * from tbl_login where user_name='"+obj.Name+"' and login_password='"+obj.Password+"'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int userconfirm(BAL.LoginBAL obj)
        {
            string s = "UPDATE tbl_login set status='1' where login_id='" + obj.Userid + "' ";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
    }
}   