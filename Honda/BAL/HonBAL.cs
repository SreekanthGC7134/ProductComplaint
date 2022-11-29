using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Honda.BAL
{
    public class HonBAL
    {
        DAL.HonDAL obj = new DAL.HonDAL();
        private string _user_id;
        private string _user_name;
        private string _user_ph;
        
        private string _user_district;
        private string _user_place;
        private string _login_id;
        private string _user_email;
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
        public string Contact
        {
            get
            {
                return _user_ph;
            }
            set
            {
                _user_ph = value;
            }
        }
            public string Email
        {
            get
            {
                return _user_email;
            }
            set
            {
                _user_email = value;
            }
        }
        public string District
        {
            get 
            {
                return _user_district;
            }
            set
            {
                _user_district = value;
            }
        }
        public string Place
        {
            get
            {
                return _user_place;

            }
            set
            {
                _user_place = value;
            }
        }
        public string LoginId
        {
            get
            { return _login_id; }
            set
            { _login_id = value;} 
        }
        public string Password
        {
            get
            {
                return _login_password;
            }
            set
            {
                _login_password=value;
            }
        }
        
        public object loginInsert()
        {
            return obj.loginInsert(this);
        }
        public int Insert()
        {
            return obj.Insert(this);
        }
        public DataTable ViewUser()
        {
            return obj.Select(this);
        }
       
        }
    }
