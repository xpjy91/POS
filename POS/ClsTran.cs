/**************************************************************************************************************************************************
 *  
 *  FileName    : ClsMain.cs
 *  Description : 거래기능 클래스
 *  Date        : 2018. 03. 20
 *  Author      : UniBiz_ParkJIyun
 *  ---------------------------------------------------------------------------------------------------------------------------------------------------
 *  History
 * 
 *  
 * ************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class ClsTran
    {
        private ClsDB clsDb = new ClsDB();

        /// <summary>
        /// 상품검색
        /// </summary>
        /// <param name="sCode"></param>
        /// <returns></returns>
        public Dictionary<string, string> SearchGoods(String sCode)
        {
            SqlDataReader sqlRead = null;
            Dictionary<string, string> dicGoods = null;
            string sQuery = null;

            try
            {
                sQuery = "SELECT PLU_CD as colCode," +
                                    "PLU_NM as colTitle, " +
                                    "SALE_PRICE as colUnitPrice, " +
                                    "CASE WHEN TAX_YN = '1' THEN '과세' " +
                                    "ELSE '비과세' " +
                                    "END as colRemarks " +
                            "FROM PLUMST " +
                            "WHERE PLU_CD = " + "'" + sCode + "'";

                sqlRead = clsDb.GetData(sQuery);

                while (sqlRead.Read() == true)
                {
                    dicGoods = new Dictionary<string, string>();
                    dicGoods["colCode"] = sqlRead["colCode"].ToString();
                    dicGoods["colTitle"] = sqlRead["colTitle"].ToString();
                    dicGoods["colUnitPrice"] = sqlRead["colUnitPrice"].ToString();
                    dicGoods["colRemarks"] = sqlRead["colRemarks"].ToString();
                    dicGoods["colQty"] = "1";
                    dicGoods["colDisCount"] = "0";
                    dicGoods["colTaxYn"] = "N";
                    dicGoods["colPrice"] = sqlRead["colUnitPrice"].ToString();
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
            return dicGoods;
        }

        /// <summary>
        /// 거래번호조회
        /// </summary>
        /// <returns></returns>
        public string SelectTranNo()
        {
            string sRet = null;
            string sQuery = "SELECT MAX(TRAN_NO) FROM SALHDR";
            SqlDataReader sqlRead = null;

            try
            {
                sqlRead = clsDb.GetData(sQuery);

                if (sqlRead.Read() == true)
                {
                    sRet = sqlRead[0].ToString();
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
            return sRet;
        }

        /// <summary>
        /// 거래저장
        /// </summary>
        /// <param name="iTotal"></param>
        /// <param name="iCash"></param>
        /// <returns></returns>
        public bool InsertTran(string sTranType, int iTotal, int iCash)
        {

            int iCheck = -1;
            bool bRet = false;
            string sQuery = "INSERT INTO SALHDR " +
                                        "(" +
                                        "SAL_DATE, " +
                                        "STORE_NO, " +
                                        "POS_NO, " +
                                        "TRAN_NO, " +
                                        "SYS_DATE, " +
                                        "TRAN_TYPE, " +
                                        "TRAN_KIND, " +
                                        "TOT_AMT, " +
                                        "TOT_VAT, " +
                                        "CASH_AMT, " +
                                        "CARD_AMT" +
                                        ")" +
                                "VALUES " +
                                        "(" +
                                        "CONVERT(CHAR, Getdate(), 112), " +
                                        "'0001', " +
                                        "'0001', " +
                                        "next value FOR seq_tranno, " +
                                        "CONVERT(CHAR, Getdate(), 112), " +
                                        "'" + sTranType + "', " +
                                        "'01', " +
                                        "'" + iTotal + "', " +
                                        "'0', " +
                                        "'" + iCash + "'," +
                                        "'0' " +
                                        ")";

            try
            {
                iCheck = clsDb.ExecuteSql(sQuery);
                if (iCheck > 0)
                {
                    bRet = true;
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bRet;
        }

        /// <summary>
        /// 거래상세저장
        /// </summary>
        /// <param name="dicCommand"></param>
        /// <returns></returns>
        public Boolean InsertTranDetail(Dictionary<String,String> dicCommand)
        {
            int iCheck = -1;
            bool bRet = false;
            
            try
            {
                string sQuery = "INSERT INTO SALDTL " +
                                        "(" +
                                        "SAL_DATE, " +
                                        "STORE_NO, " +
                                        "POS_NO, " +
                                        "TRAN_NO, " +
                                        "SEQ_NO, " +
                                        "PLU_CD, " +
                                        "SAL_QTY, " +
                                        "SAL_PRICE, " +
                                        "DC_AMT, " +
                                        "SAL_AMT, " +
                                        "TAX_YN" +
                                        ")" +
                                "VALUES " +
                                        "(" +
                                        "CONVERT(CHAR, Getdate(), 112), " +
                                        "'0001', " +
                                        "'0001', " +
                                        "'" + dicCommand["sTranNo"] + "', " +
                                        "'" + dicCommand["sSeq"] + "', " +
                                        "'" + dicCommand["sCode"] + "', " +
                                        "'" + dicCommand["sCount"] + "', " +
                                        "'" + dicCommand["sPrice"] + "', " +
                                        "'" + dicCommand["sDisCount"] + "', " +
                                        "'" + dicCommand["sSum"] + "', " +
                                        "'" + dicCommand["sTaxYn"] + "'" +
                                        ")";

                iCheck = clsDb.ExecuteSql(sQuery);
                if (iCheck > 0)
                {
                    bRet = true;
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bRet;
        }

        /// <summary>
        /// 거래보류 카운트
        /// </summary>
        /// <returns></returns>
        public int SelectHoldCount()
        {
            int iRet = 0;
            SqlDataReader sqlRead = null;
            string sQuery = null;

            try
            {
                sQuery = "SELECT count(*) " +
                         "FROM SALHDR " +
                         "WHERE tran_type = '02'";

                sqlRead = clsDb.GetData(sQuery);
                if (sqlRead.Read() == true)
                {
                    iRet = (int)sqlRead[0];
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
            return iRet;
        }

        /// <summary>
        /// 보류리스트 검색
        /// </summary>
        /// <param name="sTranNo"></param>
        /// <returns></returns>
        public List<Dictionary<string, string>> SearchHold()
        {
            SqlDataReader sqlRead = null;
            List<Dictionary<string, string>> liRet = null;
            Dictionary<string, string> dicGoods = null;
            string sQuery = null;

            try
            {
                liRet = new List<Dictionary<string, string>>();
                sQuery = "SELECT hdr.sal_date, " +
                                 "hdr.tot_amt AS sal_HoldPrice, " +
                                 "hdr.POS_NO, " +
                                 "hdr.STORE_NO, " +
                                 "hdr.TRAN_NO " +
                          "FROM  salhdr hdr " +
                                 "INNER JOIN saldtl dtl " +
                                         "ON(hdr.sal_date = dtl.sal_date " +
                                              "AND hdr.store_no = dtl.store_no " +
                                              "AND hdr.pos_no = dtl.pos_no " +
                                              "AND hdr.tran_no = dtl.tran_no) " +
                          "WHERE hdr.tran_type = '02' " +
                          "GROUP BY hdr.TRAN_TYPE, hdr.SAL_DATE, hdr.TOT_AMT, hdr.POS_NO, hdr.STORE_NO, hdr.TRAN_NO";

                sqlRead = clsDb.GetData(sQuery);

                while (sqlRead.Read() == true)
                {
                    dicGoods = new Dictionary<string, string>();
                    dicGoods["sal_date"] = sqlRead["sal_date"].ToString();
                    dicGoods["sal_price"] = sqlRead["sal_HoldPrice"].ToString();
                    dicGoods["STORE_NO"] = sqlRead["STORE_NO"].ToString();
                    dicGoods["POS_NO"] = sqlRead["POS_NO"].ToString();
                    dicGoods["TRAN_NO"] = sqlRead["TRAN_NO"].ToString();

                    liRet.Add(dicGoods);
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
            return liRet;
        }

        /// <summary>
        /// 거래상세 조회
        /// </summary>
        /// <param name="sSaleDate"></param>
        /// <param name="sStroeNo"></param>
        /// <param name="sPosNo"></param>
        /// <param name="sTranNo"></param>
        /// <returns></returns>
        public List<Dictionary<string, string>> SelectTranDetail(String sSaleDate, String sStroeNo, String sPosNo, String sTranNo)
        {
            SqlDataReader sqlRead = null;
            List<Dictionary<string, string>> liRet = null;
            Dictionary<string, string> dicGoods = null;
            string sQuery = null;

            try
            {
                liRet = new List<Dictionary<string, string>>();
                sQuery = "SELECT dtl.SAL_DATE, " +
                                "dtl.STORE_NO, " +
	                            "dtl.POS_NO, " +
	                            "dtl.TRAN_NO, " +
	                            "dtl.SEQ_NO, " +
	                            "dtl.PLU_CD, " +
	                            "dtl.SAL_QTY, " +
                                "dtl.SAL_PRICE, " +
	                            "dtl.DC_AMT, " +
                                "dtl.SAL_AMT, " +
	                            "dtl.TAX_YN, " +
                                "plu.PLU_NM " +
                        "FROM   SALDTL dtl " +
                        "INNER JOIN PLUMST plu " +
                                "ON(dtl.PLU_CD = plu.PLU_CD) " +
                        "WHERE  sal_date = '" + sSaleDate + "' " +
                               "AND store_no = '" + sStroeNo + "' " +
                               "AND pos_no = '" + sPosNo + "' " +
                               "AND tran_no = '" + sTranNo + "'";

                sqlRead = clsDb.GetData(sQuery);

                while (sqlRead.Read() == true)
                {
                    dicGoods = new Dictionary<string, string>();
                    dicGoods["colSaleDate"] = sqlRead["sal_date"].ToString();
                    dicGoods["colStoreNo"] = sqlRead["store_no"].ToString();
                    dicGoods["colPosNo"] = sqlRead["pos_no"].ToString();
                    dicGoods["colTranNo"] = sqlRead["tran_no"].ToString();
                    dicGoods["colSeq"] = sqlRead["seq_no"].ToString();
                    dicGoods["colCode"] = sqlRead["plu_cd"].ToString();
                    dicGoods["colQty"] = sqlRead["sal_qty"].ToString();
                    dicGoods["colUnitPrice"] = sqlRead["sal_price"].ToString();
                    dicGoods["colDisCount"] = sqlRead["dc_amt"].ToString();
                    dicGoods["colPrice"] = sqlRead["sal_amt"].ToString();
                    dicGoods["colTaxYn"] = sqlRead["tax_yn"].ToString();
                    dicGoods["colTitle"] = sqlRead["PLU_NM"].ToString();
                    dicGoods["colRemarks"] = "";

                    liRet.Add(dicGoods);
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
            return liRet;
        }

        /// <summary>
        /// 영수증조회
        /// </summary>
        /// <returns></returns>
        public List<Dictionary<string, string>> SelectReceipt(String sTranNo)
        {
            List<Dictionary<string, string>> liRet = null;
            Dictionary<string, string> dicGoods = null;
            SqlDataReader sqlRead = null;
            string sQuery = null;

            try
            {
                liRet = new List<Dictionary<string, string>>();
                     sQuery = "SELECT  hdr.sal_date AS sal_date, " +
                                        "hdr.tran_type AS tran_type, " +
                                        "hdr.tran_no AS tran_no, " +
                                        "hdr.pos_no AS pos_no, " +
                                        "hdr.tot_vat AS tot_vat, " +
                                        "hdr.tot_amt AS tot_amt, " +
                                        "dtl.plu_cd AS plu_cd, " +
                                        "dtl.seq_no AS seq_no, " +
                                        "dtl.sal_price AS sal_price, " +
                                        "dtl.sal_qty AS sal_qty, " +
                                        "dtl.sal_amt AS sal_amt, " +
                                        "dtl.dc_amt AS dc_amt, " +
                                        "dtl.tax_yn AS tax_yn " +
                                "FROM salhdr hdr " +
                                "INNER JOIN saldtl dtl " +
                                "ON(" +
                                    "hdr.sal_date = dtl.sal_date " +
                                    "AND hdr.store_no = dtl.store_no " +
                                    "AND hdr.pos_no = dtl.pos_no " +
                                    "AND hdr.tran_no = dtl.tran_no)" +
                                "WHERE hdr.SAL_DATE = CONVERT(CHAR, Getdate(), 112)" +
                                  "AND hdr.STORE_NO = '0001'" +
                                  "AND hdr.POS_NO = '0001'" +
                                  "AND hdr.TRAN_NO = '" + sTranNo + "'";
                sqlRead = clsDb.GetData(sQuery);

                while (sqlRead.Read() == true)
                {
                    dicGoods = new Dictionary<string, string>();
                    dicGoods["sal_date"] = sqlRead["sal_date"].ToString();
                    dicGoods["tran_type"] = sqlRead["tran_type"].ToString();
                    dicGoods["pos_no"] = sqlRead["pos_no"].ToString();
                    dicGoods["plu_cd"] = sqlRead["plu_cd"].ToString();
                    dicGoods["seq_no"] = sqlRead["seq_no"].ToString();
                    dicGoods["sal_price"] = sqlRead["sal_price"].ToString();
                    dicGoods["sal_qty"] = sqlRead["sal_qty"].ToString();
                    dicGoods["sal_amt"] = sqlRead["sal_amt"].ToString();
                    dicGoods["dc_amt"] = sqlRead["dc_amt"].ToString();
                    dicGoods["tax_yn"] = sqlRead["tax_yn"].ToString();
                    liRet.Add(dicGoods);
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
            return liRet;
        }

    }
}
