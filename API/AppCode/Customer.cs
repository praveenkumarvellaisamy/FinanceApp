using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.AppCode
{
    public class Customer
    {
        public static void CustomerInsert(string CUSTOMERCODE
                                        , string FIRSTNAME
                                        , string LASTNAME
                                        , DateTime DATEOFBIRTH
                                        , int? GOVTIDTYPEID
                                        , string GOVTIDTYPE
                                        , int? IDNUMBER
                                        , string IDATTACHMENTPATH
                                        , string PROFPICPATH
                                        , string QRCODE
                                        , string PHONENUMBER
                                        , int? AREAID
                                        , string LOCATION
                                        , string ADDRESS
                                        , int? USERCODE
                                            )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@CUSTOMERCODE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, CUSTOMERCODE));
            ParameterList.Add(DataAccess.GetDBParameter("@FIRSTNAME", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, FIRSTNAME));
            ParameterList.Add(DataAccess.GetDBParameter("@LASTNAME", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, LASTNAME));
            ParameterList.Add(DataAccess.GetDBParameter("@DATEOFBIRTH", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, DATEOFBIRTH));
            ParameterList.Add(DataAccess.GetDBParameter("@GOVTIDTYPEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, GOVTIDTYPEID));
            ParameterList.Add(DataAccess.GetDBParameter("@GOVTIDTYPE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, GOVTIDTYPE));
            ParameterList.Add(DataAccess.GetDBParameter("@IDNUMBER", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, IDNUMBER));
            ParameterList.Add(DataAccess.GetDBParameter("@IDATTACHMENTPATH", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, IDATTACHMENTPATH));
            ParameterList.Add(DataAccess.GetDBParameter("@PROFPICPATH", SqlDbType.VarChar, DbConstant.VARCHAR_500, ParameterDirection.Input, PROFPICPATH));
            ParameterList.Add(DataAccess.GetDBParameter("@QRCODE", SqlDbType.NVarChar, DbConstant.NVARCHAR_500, ParameterDirection.Input, QRCODE));
            ParameterList.Add(DataAccess.GetDBParameter("@PHONENUMBER", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, PHONENUMBER));
            ParameterList.Add(DataAccess.GetDBParameter("@AREAID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, AREAID));
            ParameterList.Add(DataAccess.GetDBParameter("@LOCATION", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, LOCATION));
            ParameterList.Add(DataAccess.GetDBParameter("@ADDRESS", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, ADDRESS));
            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, USERCODE));

            int n = DataAccess.ExecSPReturnInt("PRCUSTOMERINSERT", ParameterList);
        }
        public static void CustomerUpdate(string CUSTOMERCODE
                                       , string FIRSTNAME
                                       , string LASTNAME
                                       , DateTime DATEOFBIRTH
                                       , int? GOVTIDTYPEID
                                       , string GOVTIDTYPE
                                       , int? IDNUMBER
                                       , string IDATTACHMENTPATH
                                       , string PROFPICPATH
                                       , string QRCODE
                                       , string PHONENUMBER
                                       , int? AREAID
                                       , string LOCATION
                                       , string ADDRESS
                                       , int? USERCODE
                                       , int? CustomerID
                                           )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@CUSTOMERCODE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, CUSTOMERCODE));
            ParameterList.Add(DataAccess.GetDBParameter("@FIRSTNAME", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, FIRSTNAME));
            ParameterList.Add(DataAccess.GetDBParameter("@LASTNAME", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, LASTNAME));
            ParameterList.Add(DataAccess.GetDBParameter("@DATEOFBIRTH", SqlDbType.DateTime, DbConstant.DATETIME, ParameterDirection.Input, DATEOFBIRTH));
            ParameterList.Add(DataAccess.GetDBParameter("@GOVTIDTYPEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, GOVTIDTYPEID));
            ParameterList.Add(DataAccess.GetDBParameter("@GOVTIDTYPE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, GOVTIDTYPE));
            ParameterList.Add(DataAccess.GetDBParameter("@IDNUMBER", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, IDNUMBER));
            ParameterList.Add(DataAccess.GetDBParameter("@IDATTACHMENTPATH", SqlDbType.VarChar, DbConstant.VARCHAR_200, ParameterDirection.Input, IDATTACHMENTPATH));
            ParameterList.Add(DataAccess.GetDBParameter("@PROFPICPATH", SqlDbType.VarChar, DbConstant.VARCHAR_500, ParameterDirection.Input, PROFPICPATH));
            ParameterList.Add(DataAccess.GetDBParameter("@QRCODE", SqlDbType.NVarChar, DbConstant.NVARCHAR_500, ParameterDirection.Input, QRCODE));
            ParameterList.Add(DataAccess.GetDBParameter("@PHONENUMBER", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, PHONENUMBER));
            ParameterList.Add(DataAccess.GetDBParameter("@AREAID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, AREAID));
            ParameterList.Add(DataAccess.GetDBParameter("@LOCATION", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, LOCATION));
            ParameterList.Add(DataAccess.GetDBParameter("@ADDRESS", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, ADDRESS));
            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, USERCODE));
            ParameterList.Add(DataAccess.GetDBParameter("@CUSTOMERID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, CustomerID));

            int n = DataAccess.ExecSPReturnInt("PRCUSTOMERUPDATE", ParameterList);
        }
        public static DataTable CustomerList(int? CustomerID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@CUSTOMERID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, CustomerID));
            DataTable dt = DataAccess.ExecSPReturnDataTable("PRCUSTOMERLIST", ParameterList);
            return dt;
        }

        public static void CustomerDelete(int? CustomerID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@CUSTOMERID", SqlDbType.BigInt, DbConstant.BIGINT, ParameterDirection.Input, CustomerID));

            int n = DataAccess.ExecSPReturnInt("PRCUSTOMERDELETE", ParameterList);

        }
    }
}