/**************************************************************************************************************************************************
 *  
 *  FileName    : ClsDB.cs
 *  Description : 데이터베이스 연결 Class
 *  Date        : 2018. 03. 16
 *  Author      : UniBiz_ParkJIyun
 *  ---------------------------------------------------------------------------------------------------------------------------------------------------
 *  History
 * 
 *  
 * ************************************************************************************************************************************************/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;

namespace POS
{
    class ClsDB
    {

        private static String sSource = "server=(local); Database=POSDB; PWD=UNIPOS; UID=UNIPOS;";
        private static SqlConnection sqlConn = null;

        /// <summary>
        /// 데이터베이스 열기
        /// </summary>
        public static void OpenDataBase()
        {
            try
            {
                sqlConn = new SqlConnection(sSource);
                sqlConn.Open();
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 데이터베이스 닫기
        /// </summary>
        public static void CloseDataBase()
        {
            try
            {
                if (sqlConn.State == System.Data.ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// SQL문 실행
        /// </summary>
        /// <param name="sSql"></param>
        /// <returns></returns>
        public int ExecuteSql(string sSql)
        {
            int iRet = -1;
            try
            {
                SqlCommand sqlCmd = new SqlCommand(sSql, sqlConn);
                iRet = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return iRet;
        }



        /// <summary>
        /// DB 조회
        /// </summary>
        /// <param name="sSql"></param>
        /// <returns></returns>
        public SqlDataReader GetData(string sSql)
        {
            SqlDataReader sqlReader = null;
            SqlCommand sqlCmd = null;
            try
            {
                sqlCmd = new SqlCommand(sSql, sqlConn);
                sqlReader = sqlCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return sqlReader;

        }

        /// <summary>
        /// DB 조회 DATASET return
        /// </summary>
        /// <param name="sSql"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string sSql)
        {
            SqlDataAdapter sqlAdapter = null;
            SqlCommandBuilder sqlBuilder = null;
            DataSet dsRet = null;

            try
            {
                sqlConn = new SqlConnection(sSource);
                sqlAdapter = new SqlDataAdapter(sSql, sqlConn);
                sqlBuilder = new SqlCommandBuilder(sqlAdapter);
                dsRet = new DataSet();
                sqlAdapter.Fill(dsRet);
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            return dsRet;
        }

    }


}
