using CoimbatoreFinanceAPI.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.Models
{

    public class CompanyInsert
    {
        public CompanyInsert(CompanyModel Params)
        {
            Company.CompanyInsert(Params.UserCode, Params.CompanyName, Params.ShortCode, Params.Address, Params.City, Params.State, Params.Country);
        }
    }
    public class CompanyUpdate
    {
        public CompanyUpdate(CompanyModel Params)
        {
            Company.CompanyUpdate(Params.UserCode, Params.CompanyName, Params.ShortCode, Params.Address, Params.City, Params.State, Params.Country, Params.CompanyID);
        }
    }
    public class CompanyList
    {
        public List<CompanyModel> GeneralList { get; set; }
        public CompanyList(CompanyModel Params)
        {
            DataTable dt = Company.CompanyList(Params.CompanyID);
            GeneralList = dt.ToList<CompanyModel>();
        }
    }
    public class CompanyDelete
    {
        public CompanyDelete(CompanyModel Params)

        {
            Company.CompanyDelete(Params.UserCode, Params.CompanyID);
        }
    }
    public class CompanyModel
    {
        public int UserCode { get; set; }
        public string CompanyName { get; set; }
        public string ShortCode { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int CompanyID { get; set; }
    }
}