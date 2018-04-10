/**************************************************************************************************************************************************
 *  
 *  FileName    : ClsLogin.cs
 *  Description : 로그인기능 로직 class
 *  Date        : 2018. 03. 16
 *  Author      : UniBiz_ParkJIyun
 *  ---------------------------------------------------------------------------------------------------------------------------------------------------
 *  History
 *  
 *  
 * ************************************************************************************************************************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;

namespace POS
{
    public class ClsLogin
    {
        private ClsDB clsDb = new ClsDB();

        /// <summary>
        /// 로그인체크
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="sPwd"></param>
        /// <returns></returns>
        public bool CheckLogin(string sId, string sPwd)
        {
            bool bRet = false;
            int iCount = -1;
            string sQuery = "SELECT count(*) FROM EMPMST " +
                                            "WHERE EMP_ID =" + "'" + sId + "'" +
                                            "AND EMP_PASS =" + "'" + sPwd + "'";
            SqlDataReader sqlRead = null;

            try
            {
                sqlRead = clsDb.GetData(sQuery);
                if (sqlRead.Read() == true)
                {

                    iCount = (int)sqlRead[0];
                    if (iCount > 0) { bRet = true; }

                }

            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            finally
            {
                if (sqlRead.IsClosed != true)
                {
                    sqlRead.Close();
                }
            }

            return bRet;
        }

        /// <summary>
        /// 이름검색
        /// </summary>
        /// <param name="sId"></param>
        /// <returns></returns>
        public string SearchName(string sId)
        {
            string sName = null;
            string sQuery = "SELECT EMP_NAME FROM EMPMST " +
                                            "WHERE EMP_ID =" + "'" + sId + "'";
            SqlDataReader sqlRead = null;

            try
            {
                sqlRead = clsDb.GetData(sQuery);

                if (sqlRead.Read() == true)
                {
                    sName = sqlRead[0].ToString();
                }

            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            finally
            {
                if (sqlRead.IsClosed != true)
                {
                    sqlRead.Close();
                }
            }
            return sName;
        }

    }

}
