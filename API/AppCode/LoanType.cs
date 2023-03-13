using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.AppCode
{
    public class LoanType
    {
        public static void LoanTypeInsert(int? UserCode
                                            , string TypeCode
                                            , string LoanName
                                            , int? LoanID
                                            )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@TYPECODE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, TypeCode));
            ParameterList.Add(DataAccess.GetDBParameter("@LOANNAME", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, LoanName));
            ParameterList.Add(DataAccess.GetDBParameter("@LOANID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, LoanID));

            int n = DataAccess.ExecSPReturnInt("PRLOANTYPEINSERT", ParameterList);
        }
        public static void LoanTypeUpdate(int? UserCode
                                           , string TypeCode
                                           , string LoanName
                                           , int? LoanID
                                           , int? LoanTypeID 
                                           )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@TYPECODE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, TypeCode));
            ParameterList.Add(DataAccess.GetDBParameter("@LOANNAME", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, LoanName));
            ParameterList.Add(DataAccess.GetDBParameter("@LOANID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, LoanID));
            ParameterList.Add(DataAccess.GetDBParameter("@LOANTYPEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, LoanTypeID));
            int n = DataAccess.ExecSPReturnInt("PRLOANTYPEUPDATE", ParameterList);
        }
        public static DataTable LoanTypeList(int? LoanTypeID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@LOANTYPEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, LoanTypeID));
            DataTable dt = DataAccess.ExecSPReturnDataTable("PRLOANTYPELIST", ParameterList);
            return dt;
        }

        public static void LoanTypeDelete(int? UserCode, int? LoanTypeID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.BigInt, DbConstant.BIGINT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@LOANTYPEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, LoanTypeID));

            int n = DataAccess.ExecSPReturnInt("PRLOANTYPEDELETE", ParameterList);

        }
    }
}