using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.AppCode
{
    public class User
    {
        public static void UserInsert(int? UserCode
                                        , string FirstName
                                        , string LastName
                                        , string UserName
                                        , string Password
                                        , int? UserTypeID
                                        , string UserType
                                        , int? ApplicableCompanyID
                                        , string ApplicableCompany
                                        , string Phonenumber
                                        , int? DefaultCompanyID
                                        , string ApplicableArea
                                        , string ProfilePicPath
                                            )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@FIRSTNAME", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, FirstName));
            ParameterList.Add(DataAccess.GetDBParameter("@LASTNAME", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, LastName));
            ParameterList.Add(DataAccess.GetDBParameter("@USERNAME", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, UserName));
            ParameterList.Add(DataAccess.GetDBParameter("@PASSWORD", SqlDbType.NVarChar, DbConstant.NVARCHAR_MAX, ParameterDirection.Input, Password));
            ParameterList.Add(DataAccess.GetDBParameter("@USERTYPEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserTypeID));
            ParameterList.Add(DataAccess.GetDBParameter("@USERTYPE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, UserType));
            ParameterList.Add(DataAccess.GetDBParameter("@APPLICABLECOMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, ApplicableCompanyID));
            ParameterList.Add(DataAccess.GetDBParameter("@APPLICABLECOMPANY", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, ApplicableCompany));
            ParameterList.Add(DataAccess.GetDBParameter("@PHONENUMBER", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, Phonenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@DEFAULTCOMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, DefaultCompanyID));
            ParameterList.Add(DataAccess.GetDBParameter("@APPLICABLEAREA", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, ApplicableArea));
            ParameterList.Add(DataAccess.GetDBParameter("@PROFILEPICPATH", SqlDbType.NVarChar, DbConstant.NVARCHAR_MAX, ParameterDirection.Input, ProfilePicPath));

            int n = DataAccess.ExecSPReturnInt("PRUSERINSERT", ParameterList);
        }
        public static void UserUpdate(int? UserCode
                                 , string FirstName
                                 , string LastName
                                 , string UserName
                                 , string Password
                                 , int? UserTypeID
                                 , string UserType
                                 , int? ApplicableCompanyID
                                 , string ApplicableCompany
                                 , string Phonenumber
                                 , int? DefaultCompanyID
                                 , string ApplicableArea
                                 , string ProfilePicPath
                                 , int? UserCodeID 
                                     )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@USERCODEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCodeID));
            ParameterList.Add(DataAccess.GetDBParameter("@FIRSTNAME", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, FirstName));
            ParameterList.Add(DataAccess.GetDBParameter("@LASTNAME", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, LastName));
            ParameterList.Add(DataAccess.GetDBParameter("@USERNAME", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, UserName));
            ParameterList.Add(DataAccess.GetDBParameter("@PASSWORD", SqlDbType.NVarChar, DbConstant.NVARCHAR_MAX, ParameterDirection.Input, Password));
            ParameterList.Add(DataAccess.GetDBParameter("@USERTYPEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserTypeID));
            ParameterList.Add(DataAccess.GetDBParameter("@USERTYPE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, UserType));
            ParameterList.Add(DataAccess.GetDBParameter("@APPLICABLECOMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, ApplicableCompanyID));
            ParameterList.Add(DataAccess.GetDBParameter("@APPLICABLECOMPANY", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, ApplicableCompany));
            ParameterList.Add(DataAccess.GetDBParameter("@PHONENUMBER", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, Phonenumber));
            ParameterList.Add(DataAccess.GetDBParameter("@DEFAULTCOMPANYID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, DefaultCompanyID));
            ParameterList.Add(DataAccess.GetDBParameter("@APPLICABLEAREA", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, ApplicableArea));
            ParameterList.Add(DataAccess.GetDBParameter("@PROFILEPICPATH", SqlDbType.NVarChar, DbConstant.NVARCHAR_MAX, ParameterDirection.Input, ProfilePicPath));

            int n = DataAccess.ExecSPReturnInt("PRUSERUPDATE", ParameterList);
        }
        public static DataTable UserList(int? UserCodeID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCodeID));
            DataTable dt = DataAccess.ExecSPReturnDataTable("PRUSERLIST", ParameterList);
            return dt;
        }

        public static void UserDelete(int? UserCodeID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODEID", SqlDbType.BigInt, DbConstant.BIGINT, ParameterDirection.Input, UserCodeID));

            int n = DataAccess.ExecSPReturnInt("PRUSERDELETE", ParameterList);

        }
    }
}