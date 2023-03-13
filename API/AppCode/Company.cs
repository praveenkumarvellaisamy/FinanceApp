using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.AppCode
{
    public class Company
    {
        public static void CompanyInsert(int? UserCode
                                            , string CompanyName
                                            , string ShortCode
                                            , string Address
                                            , string City
                                            , string State
                                            , string Country
                                            )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYNAME", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, CompanyName));
            ParameterList.Add(DataAccess.GetDBParameter("@SHORTCODE", SqlDbType.VarChar, DbConstant.VARCHAR_20, ParameterDirection.Input, ShortCode));
            ParameterList.Add(DataAccess.GetDBParameter("@ADDRESS", SqlDbType.NVarChar, DbConstant.NVARCHAR_500, ParameterDirection.Input, Address));
            ParameterList.Add(DataAccess.GetDBParameter("@CITY", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, City));
            ParameterList.Add(DataAccess.GetDBParameter("@STATE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, State));
            ParameterList.Add(DataAccess.GetDBParameter("@COUNTRY", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, Country));

            int n = DataAccess.ExecSPReturnInt("PRCOMPANYINSERT", ParameterList);
        }
        public static void CompanyUpdate(int? UserCode
                                            , string CompanyName
                                            , string ShortCode
                                            , string Address
                                            , string City
                                            , string State
                                            , string Country
                                            , int? CompanyID
                                            )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, CompanyID));
            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYNAME", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, CompanyName));
            ParameterList.Add(DataAccess.GetDBParameter("@SHORTCODE", SqlDbType.VarChar, DbConstant.VARCHAR_20, ParameterDirection.Input, ShortCode));
            ParameterList.Add(DataAccess.GetDBParameter("@ADDRESS", SqlDbType.NVarChar, DbConstant.NVARCHAR_500, ParameterDirection.Input, Address));
            ParameterList.Add(DataAccess.GetDBParameter("@CITY", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, City));
            ParameterList.Add(DataAccess.GetDBParameter("@STATE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, State));
            ParameterList.Add(DataAccess.GetDBParameter("@COUNTRY", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, Country));

            int n = DataAccess.ExecSPReturnInt("PRCOMPANYUPDATE", ParameterList);
        }
        public static DataTable CompanyList(int? CompanyID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, CompanyID));
            DataTable dt = DataAccess.ExecSPReturnDataTable("PRCOMPANYLIST", ParameterList);
            return dt;
        }

        public static void CompanyDelete(int? UserCode, int? CompanyID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.BigInt, DbConstant.BIGINT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@COMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, CompanyID));

            int n = DataAccess.ExecSPReturnInt("PRCOMPANYDELETE", ParameterList);

        }
    }
}