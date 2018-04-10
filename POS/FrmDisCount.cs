/**************************************************************************************************************************************************
 *  
 *  FileName    : FrmMain.cs
 *  Description : 메인 화면 이벤트 처리
 *  Date        : 2018. 04. 09
 *  Author      : UniBiz_ParkJIyun
 *  ---------------------------------------------------------------------------------------------------------------------------------------------------
 *  History
 *  
 *  
 * **************************************************************************************************************************************************/
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
    public partial class FrmDisCount : Form
    {
        FrmSale frmSale = new FrmSale();
        public FrmDisCount()
        {
            InitializeComponent();
        }

        public FrmDisCount(FrmSale frm)
        {
            InitializeComponent();
            frmSale = frm;
        }

        /// <summary>
        /// 등록버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            int iDisCount = 0;
            String sValue = "0";
            try
            {
                sValue = txtDisCount.Text;
                iDisCount = int.Parse(sValue);
                frmSale.grdSaleList.CurrentRow.Cells["colDisCount"].Value = iDisCount;
                frmSale.grdSaleList.CurrentRow.Cells["colRemarks"].Value = iDisCount + "원 할인";

                frmSale.txtInput.Clear();
                frmSale.UpdateDisplay();
                this.Close();

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
                txtDisCount.Clear();
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
                if ((txtDisCount.Text.Length + sKey.Length) <= 10)
                {
                    txtDisCount.Text += sKey;
                }
                txtDisCount.Focus();
                txtDisCount.Select(txtDisCount.TextLength, 0);
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
