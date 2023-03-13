using CoimbatoreFinanceAPI.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.Models
{
    public class LoanTypeInsert
    {
        public LoanTypeInsert(LoanTypeModel Params)
        {
            LoanType.LoanTypeInsert(Params.UserCode
                                            , Params.TypeCode
                                            , Params.LoanName
                                            , Params.LoanID);
        }
    }
    public class LoanTypeUpdate
    {
        public LoanTypeUpdate(LoanTypeModel Params)
        {
            LoanType.LoanTypeUpdate(Params.UserCode
                                            , Params.TypeCode
                                            , Params.LoanName
                                            , Params.LoanID
                                            , Params.LoanTypeID);
        }
    }
    public class LoanTypeList
    {
        public List<LoanTypeModel> GeneralList { get; set; }
        public LoanTypeList(LoanTypeModel Params)
        {
            DataTable dt = LoanType.LoanTypeList(Params.LoanTypeID);
            GeneralList = dt.ToList<LoanTypeModel>();
        }
    }
    public class LoanTypeDelete
    {
        public LoanTypeDelete(LoanTypeModel Params)

        {
            LoanType.LoanTypeDelete(Params.UserCode, Params.LoanTypeID);
        }
    }
    public class LoanTypeModel
    {
        public int UserCode { get; set; }
        public string TypeCode { get; set; }
        public string LoanName { get; set; }
        public int LoanID { get; set; }
        public int LoanTypeID { get; set; }
    }
}