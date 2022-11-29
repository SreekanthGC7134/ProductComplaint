using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Honda.DAL
{
    class HonDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public HonDAL()
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
        public object loginInsert(BAL.HonBAL obj)
        {
            Getcon();
            cmd.CommandType=CommandType.Text;
            cmd.CommandText = "insert into tbl_login values('"+obj.Name+"','"+obj.Password+"','Customer',0);select @@IDENTITY";
            object id = cmd.ExecuteScalar();
            return id;
        }
        public int Insert(BAL.HonBAL obj)
        {

           
            string qry = "insert into tbl_user values('"+obj.Name+ "','" + obj.Contact+"','"+obj.District+"','"+obj.Place+"','"+obj.LoginId+ "','"+obj.Email+"')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable Select(BAL.HonBAL obj)
        {
            string s = "SELECT * from tbl_user u INNER JOIN tbl_login l ON u.login_id=l.login_id";
            SqlCommand cm1=new SqlCommand(s, Getcon());
            SqlDataAdapter da=new SqlDataAdapter(cm1);
            DataTable dt=new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable userview()
        {
            string s = "SELECT * from tbl_user u INNER JOIN tbl_login l ON u.login_id=l.login_id where status='0' ";
               SqlCommand cmd=new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            da.Fill(dt);
            return dt;
        }

       
    }
    }