using CoimbatoreFinanceAPI.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.Models
{
    public class CustomerInsert
    {
        public CustomerInsert(CustomerModel Params)
        {
            Customer.CustomerInsert(Params.CUSTOMERCODE
                                        , Params.FIRSTNAME
                                        , Params.LASTNAME
                                        , Params.DATEOFBIRTH
                                        , Params.GOVTIDTYPEID
                                        , Params.GOVTIDTYPE
                                        , Params.IDNUMBER
                                        , Params.IDATTACHMENTPATH
                                        , Params.PROFPICPATH
                                        , Params.QRCODE
                                        , Params.PHONENUMBER
                                        , Params.AREAID
                                        , Params.LOCATION
                                        , Params.ADDRESS
                                        , Params.USERCODE);
        }
    }
    public class CustomerUpdate
    {
        public CustomerUpdate(CustomerModel Params)
        {
            Customer.CustomerUpdate(Params.CUSTOMERCODE
                                        , Params.FIRSTNAME
                                        , Params.LASTNAME
                                        , Params.DATEOFBIRTH
                                        , Params.GOVTIDTYPEID
                                        , Params.GOVTIDTYPE
                                        , Params.IDNUMBER
                                        , Params.IDATTACHMENTPATH
                                        , Params.PROFPICPATH
                                        , Params.QRCODE
                                        , Params.PHONENUMBER
                                        , Params.AREAID
                                        , Params.LOCATION
                                        , Params.ADDRESS
                                        , Params.USERCODE
                                        , Params.CustomerID);
        }
    }
    public class CustomerList
    {
        public List<CustomerModel> GeneralList { get; set; }
        public CustomerList(CustomerModel Params)
        {
            DataTable dt = Customer.CustomerList(Params.CustomerID);
            GeneralList = dt.ToList<CustomerModel>();
        }
    }
    public class CustomerDelete
    {
        public CustomerDelete(CustomerModel Params)

        {
            Customer.CustomerDelete(Params.CustomerID);
        }
    }
    public class CustomerModel
    {
        public string CUSTOMERCODE { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public DateTime DATEOFBIRTH { get; set; }
        public int GOVTIDTYPEID { get; set; }
        public string GOVTIDTYPE { get; set; }
        public int IDNUMBER { get; set; }
        public string IDATTACHMENTPATH { get; set; }
        public string PROFPICPATH { get; set; }
        public string QRCODE { get; set; }
        public string PHONENUMBER { get; set; }
        public int AREAID { get; set; }
        public string LOCATION { get; set; }
        public string ADDRESS { get; set; }
        public int USERCODE { get; set; }
        public int CustomerID { get; set; }
    }
}