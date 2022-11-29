using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Honda.BAL
{
    public class ComplaintBal
    {
        DAL.ComplaintDal objcompltdl = new DAL.ComplaintDal();

        private int _complaintid;
        private int _userid;
        private int _productid;
        private string _complaint;




        public int ComplaintId
        {
            get
            {
                return _complaintid;
            }
            set
            {
                _complaintid = value;
            }
        }
        public int Userid
        {
            get
            {
                return _userid;
            }
            set
            {
                _userid = value;
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
        public string Complaint
        {
            get
            {
                return _complaint;
            }
            set
            {
                _complaint = value;
            }
        }

        public DataTable getproduct()
        {
            return objcompltdl.Getproduct(this);
        }

        public int insertComplaint()
        {
            return objcompltdl.complaintInsert(this);
        }

        public DataTable viewcomplaintstatus()
        {
            return objcompltdl.Viewcomplaintstatus(this);
        }
        public DataTable viewcomplaint()
        {
            return objcompltdl.complaintview(this);
        }
        public int changecmpltstatus()
        {
            return objcompltdl.Changecmpltstatus(this);
        }






    }
}