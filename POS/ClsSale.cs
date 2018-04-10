/**************************************************************************************************************************************************
 *  
 *  FileName    : ClsMain.cs
 *  Description : 판매화면 로직 Class
 *  Date        : 2018. 03. 21
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
using System.Windows.Forms;

namespace POS
{
    class ClsSale
    {
        private ClsDB clsDb = new ClsDB();
        private ClsTran clsTran = new ClsTran();

        /// <summary>
        /// 거래정보 저장
        /// </summary>
        /// <param name="rowCollection"></param>
        /// <param name="iTotal"></param>
        /// <param name="iCash"></param>
        /// <returns></returns>
        public bool SaveTran(DataGridViewRowCollection rowCollection,string sTranType, int iTotal, int iCash)
        {
            //상품
            Dictionary<string, string> dicGoods = null;
            string sTranNo = null;
            bool bRet = false;

            try
            {
                if (rowCollection.Count < 1) { return false; }

                if (clsTran.InsertTran(sTranType, iTotal, iTotal) == true)
                {
                    sTranNo = clsTran.SelectTranNo();
                    foreach (DataGridViewRow grdRow in rowCollection)
                    {
                        dicGoods = new Dictionary<string, string>();
                        dicGoods.Add("sTranNo", sTranNo);
                        dicGoods.Add("sSeq", grdRow.Cells["colSeq"].Value.ToString());
                        dicGoods.Add("sCode", grdRow.Cells["colCode"].Value.ToString());
                        dicGoods.Add("sCount", grdRow.Cells["colQty"].Value.ToString());
                        dicGoods.Add("sPrice", grdRow.Cells["colUnitPrice"].Value.ToString());
                        dicGoods.Add("sDisCount", grdRow.Cells["colDisCount"].Value.ToString());
                        dicGoods.Add("sSum", grdRow.Cells["colPrice"].Value.ToString());
                        dicGoods.Add("sTaxYn", grdRow.Cells["colTaxYn"].Value.ToString());

                        clsTran.InsertTranDetail(dicGoods);
                    }

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
        /// 프린트 출력
        /// </summary>
        /// <returns></returns>
        public bool OutputPrint()
        {
            bool bRet = false;
            try
            {
                ClsPrint clsPrint = new ClsPrint();
                clsPrint.OpenPort();
                clsPrint.ExecutePrint();
                clsPrint.ClosePort();
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            return bRet;
        }

    }
}
