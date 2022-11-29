using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Honda.BAL
{
    public class QuerryBal
    {
        DAL.QuerryDal objquerytdl = new DAL.QuerryDal();

        private int _querryid;
        private int _customerid;
        private int _productid;
        private string _querry;




        public int QuerryId
        {
            get
            {
                return _querryid;
            }
            set
            {
                _querryid = value;
            }
        }
        public int CustomerId
        {
            get
            {
                return _customerid;
            }
            set
            {
                _customerid = value;
            }
        }
        public int ProductId
        {
            get
            {
                return _productid;
            }
            set
            {
                _productid = value;
            }
        }
        public string Querry
        {
            get
            {
                return _querry;
            }
            set
            {
                _querry = value;
            }
        }

        public DataTable getproduct()
        {
            return objquerytdl.Getproduct(this);
        }

        public int insertQuerry()
        {
            return objquerytdl.QuerryInsert(this);
        }
        public DataTable viewquery()
        {
            return objquerytdl.queryview(this);
        }
    }
}