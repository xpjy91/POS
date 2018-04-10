using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmRestore : Form
    {

        FrmSale frmSale = null;
        ClsTran clsTran = new ClsTran();

        public FrmRestore()
        {
            InitializeComponent();
            SearchHoldList();
        }

        public FrmRestore(FrmSale frm)
        {
            InitializeComponent();
            SearchHoldList();
            frmSale = frm;
        }

        /// <summary>
        /// 보류리스트
        /// </summary>
        public bool SearchHoldList()
        {
            bool bRet = false;
            int iIndex = 0;
            List<Dictionary<string, string>> liHold = null;
            try
            {
               liHold = clsTran.SearchHold();
                if (liHold.Count > 0)
                {
                    foreach(Dictionary<string,string> dicHold in liHold)
                    {
                        iIndex = grdHoldList.Rows.Add();
                        grdHoldList.Rows[iIndex].Cells["colNo"].Value = iIndex;
                        grdHoldList.Rows[iIndex].Cells["colSaleDate"].Value = dicHold["sal_date"];
                        grdHoldList.Rows[iIndex].Cells["colPrice"].Value = dicHold["sal_price"];
                        grdHoldList.Rows[iIndex].Cells["colStoreNo"].Value = dicHold["STORE_NO"];
                        grdHoldList.Rows[iIndex].Cells["colPosNo"].Value = dicHold["POS_NO"];
                        grdHoldList.Rows[iIndex].Cells["colTranNo"].Value = dicHold["TRAN_NO"];

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
        /// 등록버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> liTran = new List<Dictionary<string, string>>();
            string sSaleDate = null;
            string sStoreNo = null;
            string sPosNo = null;
            string sTranNo = null;
            try
            {
                sSaleDate = grdHoldList.CurrentRow.Cells["colSaleDate"].Value.ToString();
                sStoreNo = grdHoldList.CurrentRow.Cells["colStoreNo"].Value.ToString();
                sPosNo = grdHoldList.CurrentRow.Cells["colPosNo"].Value.ToString();
                sTranNo = grdHoldList.CurrentRow.Cells["colTranNo"].Value.ToString();
                liTran = clsTran.SelectTranDetail(sSaleDate, sStoreNo, sPosNo, sTranNo);
                frmSale.AddRow(liTran);

            }//end try
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }//end catch
        }

        /// <summary>
        /// Clear버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtInput.Clear();
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 숫자키 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum_Click(object sender, EventArgs e)
        {
            string sKey = null;

            try
            {
                sKey = ((Button)sender).Text;
                if ((txtInput.Text.Length + sKey.Length) <= 3)
                {
                    txtInput.Text += sKey;
                }
                txtInput.Focus();
                txtInput.Select(txtInput.TextLength, 0);
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 종료버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("종료하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

    }
}
