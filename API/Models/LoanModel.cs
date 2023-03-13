using CoimbatoreFinanceAPI.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.Models
{
    public class LoanInsert
    {
        public LoanInsert(LoanModel Params)
        {
            Loan.LoanInsert(Params.UserCode
                                            , Params.LoanCode
                                            , Params.CustomerID
                                            , Params.Status
                                            , Params.DisbursementDate
                                            , Params.Amount
                                            , Params.CompanyID);
        }
    }
    public class LoanUpdate
    {
        public LoanUpdate(LoanModel Params)
        {
            Loan.LoanUpdate(Params.UserCode
                                            , Params.LoanCode
                                            , Params.CustomerID
                                            , Params.Status
                                            , Params.DisbursementDate
                                            , Params.Amount
                                            , Params.CompanyID
                                            , Params.LoanID);
        }
    }
    public class LoanList
    {
        public List<LoanModel> GeneralList { get; set; }
        public LoanList(LoanModel Params)
        {
            DataTable dt = Loan.LoanList(Params.LoanID);
            GeneralList = dt.ToList<LoanModel>();
        }
    }
    public class LoanDelete
    {
        public LoanDelete(LoanModel Params)

        {
            Loan.LoanDelete(Params.UserCode, Params.LoanID);
        }
    }
    public class LoanModel
    {
        public int UserCode { get; set; }
        public string LoanCode { get; set; }
        public int CustomerID { get; set; }
        public string Status { get; set; }
        public DateTime DisbursementDate { get; set; }
        public Decimal Amount { get; set; }
        public int CompanyID { get; set; }
        public int LoanID { get; set; }
    }
}