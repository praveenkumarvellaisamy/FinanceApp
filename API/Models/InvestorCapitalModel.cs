using CoimbatoreFinanceAPI.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.Models
{
    public class InvestorCapitalInsert
    {
        public InvestorCapitalInsert(InvestorCapitalModel Params)
        {
            InvestorCapital.InvestorCapitalInsert(Params.UserCode
                                           , Params.InvestorUserCode
                                           , Params.Amount
                                           , Params.date
                                           , Params.TransactionTypeID
                                           , Params.TransactionType
                                           , Params.CompanyID);
        }
    }
    public class InvestorCapitalUpdate
    {
        public InvestorCapitalUpdate(InvestorCapitalModel Params)
        {
            InvestorCapital.InvestorCapitalUpdate(Params.UserCode
                                           , Params.InvestorUserCode
                                           , Params.Amount
                                           , Params.date
                                           , Params.TransactionTypeID
                                           , Params.TransactionType
                                           , Params.CompanyID
                                           , Params.InvestorCapitalID);
        }
    }
    public class InvestorCapitalList
    {
        public List<InvestorCapitalModel> GeneralList { get; set; }
        public InvestorCapitalList(InvestorCapitalModel Params)
        {
            DataTable dt = InvestorCapital.InvestorCapitalList(Params.InvestorCapitalID);
            GeneralList = dt.ToList<InvestorCapitalModel>();
        }
    }
    public class InvestorCapitalDelete
    {
        public InvestorCapitalDelete(InvestorCapitalModel Params)

        {
            InvestorCapital.InvestorCapitalDelete(Params.UserCode, Params.InvestorCapitalID);
        }
    }
    public class InvestorCapitalModel
    {
        public int UserCode { get; set; }
        public int InvestorUserCode { get; set; }
        public decimal Amount { get; set; }
        public DateTime date { get; set; }
        public int TransactionTypeID { get; set; }
        public string TransactionType { get; set; }
        public int CompanyID { get; set; }
        public int InvestorCapitalID { get; set; }
    }
}