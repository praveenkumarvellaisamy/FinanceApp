using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.AppCode
{
    public class Line
    {
        public static void LineInsert(int? UserCode
                                            , string LineCode
                                            , string LineName
                                            )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@LINECODE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, LineCode));
            ParameterList.Add(DataAccess.GetDBParameter("@LINENAME", SqlDbType.NVarChar, DbConstant.NVARCHAR_20, ParameterDirection.Input, LineName));

            int n = DataAccess.ExecSPReturnInt("PRLINEINSERT", ParameterList);
        }
        public static void LineUpdate(int? UserCode
                                            , string LineCode
                                            , string LineName
                                            , int? LineID
                                            )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@LINEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, LineID));
            ParameterList.Add(DataAccess.GetDBParameter("@LINECODE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, LineCode));
            ParameterList.Add(DataAccess.GetDBParameter("@LINENAME", SqlDbType.NVarChar, DbConstant.NVARCHAR_20, ParameterDirection.Input, LineName));

            int n = DataAccess.ExecSPReturnInt("PRLINEUPDATE", ParameterList);
        }
        public static DataTable LineList(int? LineID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@LINEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, LineID));
            DataTable dt = DataAccess.ExecSPReturnDataTable("PRLINELIST", ParameterList);
            return dt;
        }

        public static void LineDelete(int? UserCode, int? LineID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.BigInt, DbConstant.BIGINT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@LINEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, LineID));

            int n = DataAccess.ExecSPReturnInt("PRLINEDELETE", ParameterList);

        }
    }
}