using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.AppCode
{
    public class InvestorCapital
    {
        public static void InvestorCapitalInsert(int? UserCode
                                            , int? InvestorUserCode
                                            , decimal? Amount
                                            , DateTime date
                                            , int? TransactionTypeID
                                            , string TransactionType
                                            , int? CompanyID
                                            )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@INVESUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, InvestorUserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@AMOUND", SqlDbType.Decimal, DbConstant.DECIMAL, ParameterDirection.Input, Amount));
            ParameterList.Add(DataAccess.GetDBParameter("@DATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, date));
            ParameterList.Add(DataAccess.GetDBParameter("@TRANSACTIONTYPEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, TransactionTypeID));
            ParameterList.Add(DataAccess.GetDBParameter("@TRANSACTIONTYPE", SqlDbType.VarChar, DbConstant.VARCHAR_5, ParameterDirection.Input, TransactionType));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, CompanyID));

            int n = DataAccess.ExecSPReturnInt("PRINVESTORCAPITALINSERT", ParameterList);
        }
        public static void InvestorCapitalUpdate(int? UserCode
                                           , int? InvestorUserCode
                                           , decimal? Amount
                                           , DateTime date
                                           , int? TransactionTypeID
                                           , string TransactionType
                                           , int? CompanyID
                                           , int? InvestorCapitalID
                                           )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@INVESUSERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, InvestorUserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@AMOUND", SqlDbType.Decimal, DbConstant.DECIMAL, ParameterDirection.Input, Amount));
            ParameterList.Add(DataAccess.GetDBParameter("@DATE", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, date));
            ParameterList.Add(DataAccess.GetDBParameter("@TRANSACTIONTYPEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, TransactionTypeID));
            ParameterList.Add(DataAccess.GetDBParameter("@TRANSACTIONTYPE", SqlDbType.VarChar, DbConstant.VARCHAR_5, ParameterDirection.Input, TransactionType));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, CompanyID));
            ParameterList.Add(DataAccess.GetDBParameter("@INVESTORCAPITALID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, InvestorCapitalID));

            int n = DataAccess.ExecSPReturnInt("PRINVESTORCAPITALUPDATE", ParameterList);
        }
        public static DataTable InvestorCapitalList(int? InvestorCapitalID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@INVESTORCAPITALID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, InvestorCapitalID));
            DataTable dt = DataAccess.ExecSPReturnDataTable("PRINVESTORCAPITALLIST", ParameterList);
            return dt;
        }

        public static void InvestorCapitalDelete(int? UserCode, int? InvestorCapitalID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.BigInt, DbConstant.BIGINT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@INVESTORCAPITALID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, InvestorCapitalID));

            int n = DataAccess.ExecSPReturnInt("PRINVESTORCAPITALDELETE", ParameterList);

        }
    }
}