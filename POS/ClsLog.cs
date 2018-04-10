/**************************************************************************************************************************************************
 *  
 *  FileName    : ClsLog.cs
 *  Description : 로그파일 제어처리 Class
 *  Date        : 2018. 03. 16
 *  Author      : UniBiz_ParkJIyun
 *  ---------------------------------------------------------------------------------------------------------------------------------------------------
 *  History
 *  
 *  
 * ************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace POS
{
    public static class ClsLog
    {

        // 예외
        public const int LOG_EXCEPTION = 1;
        // 에러
        public const int LOG_ERROR = 2;
        // 상태
        public const int LOG_STATUS = 3;
        
        /// <summary>
        /// 현재시간호출
        /// </summary>
        /// <returns></returns>
        public static string GetDateTime()
        {
            string sRet = null;
            DateTime dtNow;
            try
            {
                dtNow = DateTime.Now;
                sRet = dtNow.ToString("yyyy-MM-dd HH:mm:ss") + ":" + dtNow.Millisecond.ToString("000");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return sRet;
        }


        /// <summary>
        /// 로그내용쓰기
        /// </summary>
        /// <param name="iStatus"></param>
        /// <param name="sName"></param>
        /// <param name="sMsg"></param>
        public static void WriteLog(int iStatus, string sName, string sMsg)
        {
            string sFilePath = Application.StartupPath + @"\logs\" + DateTime.Now.ToString("yyyy-MM-dd") + "_Status.log";
            string sDirPath = Application.StartupPath + @"\logs";

            string sTemp = "";
            string sStatus = "";

            StreamWriter swLog = null;
            DirectoryInfo diInfo = new DirectoryInfo(sDirPath);
            FileInfo fiInfo = new FileInfo(sFilePath);

            try
            {
                switch ( iStatus )
                {
                    case 1:
                        sStatus = "예외";
                        break;
                    case 2:
                        sStatus = "에러";
                        break;
                    case 3:
                        sStatus = "상태";
                        break;
                    default:
                        break;
                }

                if ( diInfo.Exists != true ) Directory.CreateDirectory(sDirPath);

                if ( fiInfo.Exists != true )
                {
                    using ( swLog = new StreamWriter(sFilePath) )
                    {

                        sTemp = string.Format("[{0}] : {1}", GetDateTime(), "[" + sStatus + "]" +  "\t\t" + "[MethodName]" + sName + "\t\t" + "[Message] > " + sMsg);
                        swLog.WriteLine(sTemp);
                        swLog.Close();
                    }
                }
                else
                {
                    using ( swLog = File.AppendText(sFilePath) )
                    {
                        sTemp = string.Format("[{0}] : {1}", GetDateTime(), "[" + sStatus + "]" + "\t\t" + "[MethodName]" + sName + "\t\t" + "[Message] > " + sMsg);
                        swLog.WriteLine(sTemp);
                        swLog.Close();
                    }
                }//end if~else
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


    }


}