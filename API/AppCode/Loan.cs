using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.AppCode
{
    public class Loan
    {
        public static void LoanInsert(int? UserCode
                                            , string LoanCode
                                            , int? CustomerID
                                            , string Status
                                            , DateTime DisbursementDate
                                            , Decimal? Amount
                                            , int? CompanyID
                                            )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@LOANCODE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, LoanCode));
            ParameterList.Add(DataAccess.GetDBParameter("@CUSTOMERID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, CustomerID));
            ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, Status));
            ParameterList.Add(DataAccess.GetDBParameter("@DISBURSEMENTDATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, DisbursementDate));
            ParameterList.Add(DataAccess.GetDBParameter("@AMOUNT", SqlDbType.Decimal, DbConstant.DECIMAL, ParameterDirection.Input, Amount));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, CompanyID));

            int n = DataAccess.ExecSPReturnInt("PRLOANINSERT", ParameterList);
        }
        public static void LoanUpdate(int? UserCode
                                            , string LoanCode
                                            , int? CustomerID
                                            , string Status
                                            , DateTime DisbursementDate
                                            , Decimal? Amount
                                            , int? CompanyID
                                            , int? LoanID
                                            )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@LOANCODE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, LoanCode));
            ParameterList.Add(DataAccess.GetDBParameter("@CUSTOMERID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, CustomerID));
            ParameterList.Add(DataAccess.GetDBParameter("@STATUS", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, Status));
            ParameterList.Add(DataAccess.GetDBParameter("@DISBURSEMENTDATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, DisbursementDate));
            ParameterList.Add(DataAccess.GetDBParameter("@AMOUNT", SqlDbType.Decimal, DbConstant.DECIMAL, ParameterDirection.Input, Amount));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, CompanyID));
            ParameterList.Add(DataAccess.GetDBParameter("@LOANID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, LoanID));

            int n = DataAccess.ExecSPReturnInt("PRLOANUPDATE", ParameterList);
        }
        public static DataTable LoanList(int? LoanID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@LOANID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, LoanID));
            DataTable dt = DataAccess.ExecSPReturnDataTable("PRLOANLIST", ParameterList);
            return dt;
        }

        public static void LoanDelete(int? UserCode, int? LoanID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.BigInt, DbConstant.BIGINT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@LOANID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, LoanID));

            int n = DataAccess.ExecSPReturnInt("PRLOANDELETE", ParameterList);

        }
    }
}