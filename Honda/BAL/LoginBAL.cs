using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Honda.BAL
{
    public class LoginBAL
    {
        DAL.LoginDAL obj = new DAL.LoginDAL();
        private string _user_id;
        private string _user_name;
 
        private string _login_password;


        public string Userid
        {
            get
            {
                return _user_id;
            }
            set
            { _user_id = value; }
        }
        public string Name
        {
            get
            {
                return _user_name;
            }
            set
            {
                _user_name = value;
            }
        }
        
        public string Password
        {
            get
            {
                return _login_password;
            }
            set
            {
                _login_password = value;
            }
        }

        public DataTable Logincheck()
        {
            return obj.Select(this);
        }
        public int ConfirmUser()
        {
            return obj.userconfirm(this);
        }

    }
}
