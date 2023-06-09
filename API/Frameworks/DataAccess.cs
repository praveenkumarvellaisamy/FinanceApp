﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAPI_Montensseri.Frameworks
{
    public class DataAccess
    {
        ///<summary>Executes a stored proc and returns resultset in a DataSet object</summary>
        ///<param name="ProcedureName">Stored Procedure name.</param>
        ///<param name="Parameters">Collection of SqlParameter objects</param>
        ///<returns>DataSet: Resultset returned as a DataTable object</returns>
        public static DataSet ExecSPReturnDataSet(string ProcedureName, List<SqlParameter> Parameters)
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;

            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccess.GetConnectionString()))
                {
                    conn.Open();
                    cmd = new SqlCommand(ProcedureName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    CollectParameters(cmd, Parameters);
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    CollectOutputParameters(cmd, Parameters);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd = null;
            }
            return ds;
        }

        ///<summary>Executes a stored proc and returns int</summary>
        ///<param name="ProcedureName">Stored Procedure name.</param>
        ///<param name="Parameters">Collection of SqlParameter objects</param>
        ///<returns>int: int returned</returns>
        public static int ExecSPReturnInt(string ProcedureName, List<SqlParameter> Parameters)
        {
            SqlCommand cmd;
            int i = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccess.GetConnectionString()))
                {
                    conn.Open();
                    cmd = new SqlCommand(ProcedureName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    CollectParameters(cmd, Parameters);
                    i = cmd.ExecuteNonQuery();
                    CollectOutputParameters(cmd, Parameters);
                }
            }
            catch (SqlException sqlex)
            {
                if (!(sqlex.State == 127 && sqlex.Procedure.StartsWith("TR")))
                    throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd = null;
            }
            return i;
        }

        ///<summary>Executes a stored proc and returns a collection of parameters</summary>
        ///<param name="ProcedureName">Stored Procedure name.</param>
        ///<param name="Parameters">Collection of SqlParameter objects</param>
        ///<returns>SqlParameterCollection: Collection of Input/Output parameters returned</returns>
        public static List<SqlParameter> ExecSPReturnParameter(string ProcedureName, List<SqlParameter> Parameters)
        {
            SqlCommand cmd;
            int i;

            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccess.GetConnectionString()))
                {
                    conn.Open();
                    cmd = new SqlCommand(ProcedureName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    CollectParameters(cmd, Parameters);
                    i = cmd.ExecuteNonQuery();
                    CollectOutputParameters(cmd, Parameters);
                }
                return Parameters;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd = null;
            }
        }
        public static DataTable ExecSPReturnDataTable(string ProcedureName, List<SqlParameter> Parameters)
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;

            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccess.GetConnectionString()))
                {
                    conn.Open();
                    cmd = new SqlCommand(ProcedureName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (Parameters != null)
                    {
                        CollectParameters(cmd, Parameters);
                        da.SelectCommand = cmd;
                    }
                    else
                    {
                        da.SelectCommand = cmd;
                    }
                    da.Fill(ds);

                    if (Parameters != null)
                    {
                        CollectOutputParameters(cmd, Parameters);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd = null;
            }
            return ds.Tables[0];
        }


        ///<summary>Get the Connection String from the Web.Config</summary>
        ///<returns>string: Database connection string</returns>
        public static string GetConnectionString()
        {
            try
            {
                //if (ConfigurationManager.AppSettings.Get("databaseconfig").ToString().ToUpper().Equals("TRUE") && HttpContext.Current.Session["COMPANYCODE"] != null
                //    && HttpContext.Current.Session["COMPANYCODE"].ToString() != "")
                //{
                //    return ConfigurationManager.AppSettings.Get(HttpContext.Current.Session["COMPANYCODE"].ToString()).ToString();
                //}                    
                //else
                return ConfigurationManager.ConnectionStrings[1].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ParameterName"></param>
        /// <param name="dbType"></param>
        /// <param name="size"></param>
        /// <param name="direction"></param>
        /// <param name="precision"></param>
        /// <param name="scale"></param>
        /// <param name="value"></param>
        /// <returns></returns>        
        public static SqlParameter GetDBParameter(string ParameterName, SqlDbType dbType, int size, ParameterDirection direction, byte precision, byte scale, object value)
        {
            SqlParameter param;

            param = new SqlParameter(ParameterName, dbType, size);
            param.Precision = precision;
            param.Scale = scale;
            param.Direction = direction;
            param.Value = value;

            return param;
        }

        ///<summary>Create and Return a SqlParameter</summary>
        ///<param name="ParameterName">Name of the stored procedure parameter</param>
        ///<param name="dbType">SqlParameter data type</param>
        ///<param name="size">size of the parameter</param>
        ///<param name="direction">Parameter Direction Input/Output/InputOutput</param>
        ///<param name="value">value of the parameter</param>
        ///<returns>SqlParameter: SqlParameter created with the specified values</returns>
        public static SqlParameter GetDBParameter(string ParameterName, SqlDbType dbType, int size, ParameterDirection direction, object value)
        {
            SqlParameter param;

            param = new SqlParameter(ParameterName, dbType, size);
            param.Direction = direction;
            param.Value = value;

            return param;
        }
        ///<summary>Adds the Parameters from the collection to the Command Object</summary>
        ///<param name="cmd">Command Object</param>
        ///<param name="Parameters">Collection of SqlParameters passed to the Stored Procedure</param>
        ///<returns>void: no return value</returns>
        public static void CollectParameters(SqlCommand cmd, List<SqlParameter> Parameters)
        {
            foreach (SqlParameter p in Parameters)
                cmd.Parameters.Add(p);
        }

        ///<summary>Reads the output parameters returned by the stored procedure</summary>
        ///<param name="cmd">Command Object</param>
        ///<param name="Parameters">Collection of SqlParameters passed to the Stored Procedure will include the output parameters</param>
        ///<returns>void: no return value</returns>
        public static void CollectOutputParameters(SqlCommand cmd, List<SqlParameter> Parameters)
        {
            foreach (SqlParameter sp in Parameters)
            {
                if (sp.Direction == ParameterDirection.Output)
                {
                    sp.Value = cmd.Parameters[sp.ParameterName].Value;
                }
            }
        }

    }
}