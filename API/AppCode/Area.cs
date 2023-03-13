using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.AppCode
{
    public class Area
    {
        public static void AreaInsert(int? UserCode
                                            , string AreaName
                                            , string AreaCode
                                            , int? LineID
                                            )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@AREACODE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, AreaCode));
            ParameterList.Add(DataAccess.GetDBParameter("@AREANAME", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, AreaName));
            ParameterList.Add(DataAccess.GetDBParameter("@LINEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, LineID));

            int n = DataAccess.ExecSPReturnInt("PRAREAINSERT", ParameterList);
        }
        public static void AreaUpdate(int? UserCode
                                            , string AreaName
                                            , string AreaCode
                                            , int? LineID
                                            , int? AreaID
                                            )
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@AREAID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, AreaID));
            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@AREACODE", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, AreaCode));
            ParameterList.Add(DataAccess.GetDBParameter("@AREANAME", SqlDbType.VarChar, DbConstant.VARCHAR_50, ParameterDirection.Input, AreaName));
            ParameterList.Add(DataAccess.GetDBParameter("@LINEID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, LineID));

            int n = DataAccess.ExecSPReturnInt("PRAREAUPDATE", ParameterList);
        }
        public static DataTable AreaList(int? AreaID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@AREAID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, AreaID));
            DataTable dt = DataAccess.ExecSPReturnDataTable("PRAREALIST", ParameterList);
            return dt;
        }

        public static void AreaDelete(int? UserCode, int? AreaID)
        {
            List<SqlParameter> ParameterList = new List<SqlParameter>();

            ParameterList.Add(DataAccess.GetDBParameter("@USERCODE", SqlDbType.BigInt, DbConstant.BIGINT, ParameterDirection.Input, UserCode));
            ParameterList.Add(DataAccess.GetDBParameter("@AREAID", SqlDbType.Int, DbConstant.INT, ParameterDirection.Input, AreaID));

            int n = DataAccess.ExecSPReturnInt("PRAREADELETE", ParameterList);

        }
    }
}