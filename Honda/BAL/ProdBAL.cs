using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Honda.BAL
{
    public class ProdBAL
    {

        DAL.ProdDAL obj = new DAL.ProdDAL();
        private int _product_id;
        private string _product_name;
        private string _product_amount;


        public int Productid
        {
            get
            {
                return _product_id;
            }
            set
            { _product_id = value; }
        }
        public string Name
        {
            get
            {
                return _product_name;
            }
            set
            {
                _product_name = value;
            }
        }
        public string Amount
        {
            get
            {
                return _product_amount;
            }
            set
            {
                _product_amount = value;
            }
        }
        

        public int Insert()
        {
            return obj.Insert(this);
        }

        public DataTable ViewProd()
        {
            return obj.select(this);    
        }
        public int updateprod()
        {
            return obj.updateprod(this);
        }
        public int deleteprod()
        {
            return obj.deleteprod(this);
        }

    }
}
