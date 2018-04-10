/**************************************************************************************************************************************************
 *  
 *  FileName    : ClsMain.cs
 *  Description : 메인기능 로직 Class
 *  Date        : 2018. 03. 20
 *  Author      : UniBiz_ParkJIyun
 *  ---------------------------------------------------------------------------------------------------------------------------------------------------
 *  History
 * 
 *  
 * ************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class ClsMain
    {

        private ClsDB clsDb = new ClsDB();

        public enum EnumState {
            //영업종료
            END_OF_SALE = 0,
            //판매초기
            INIT_SALE = 1,
            //판매중
            FOR_SALE = 2

        };
        /// <summary>
        /// 상태
        /// 0 -> 영업종료
        /// 1 -> 판매초기
        /// 2 -> 판매중
        /// </summary>
        public static int iSaleState = 0;
        public static string sLoginState = "false";
        public static string sName = null;
        public static string sCashierNo = null;

        /// <summary>
        /// 공지사항 리스트
        /// </summary>
        /// <returns></returns>
        public List<string[]> SearchNoticeList()
        {

            List<string[]> liNotice = new List<string[]>();
            String sQuery = "SELECT * " +
                             "FROM NoticeList " +
                             "ORDER BY creDate desc " +
                             "OFFSET 0 ROWS " +
                             "FETCH NEXT 10 ROWS ONLY";
            SqlDataReader sqlRead = null;
            string[] arrNotice = null;

            try
            {
                sqlRead = clsDb.GetData(sQuery);
                while (sqlRead.Read() == true)
                {
                    arrNotice = new string[2];
                    arrNotice[0] = sqlRead["nNoticeSeq"].ToString();
                    arrNotice[1] = sqlRead["sNoticeTitle"].ToString();
                    liNotice.Add(arrNotice);
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

            return liNotice;
        }

    }
}
