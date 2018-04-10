/**************************************************************************************************************************************************
 *  
 *  FileName    : FrmMain.cs
 *  Description : 메인 화면 이벤트 처리
 *  Date        : 2018. 03. 16
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
    public partial class FrmMain : Form
    {
        //로그인정보
        private ClsMain clsMain = new ClsMain();

        public FrmMain()
        {
            InitializeComponent();
        }
        
        private void btnMain_Click(object sender, EventArgs e)
        {
            int iIndex = 0;
            try
            {
                iIndex = ((Button)sender).TabIndex;
                switch (iIndex)
                {
                    case 1:
                        //영업시작
                        StartSale();
                        break;
                    case 2:
                        //판매등록
                        RegisterSale();
                        break;
                    case 3:
                        //마감입금
                        break;
                    case 4:
                        //정산출력
                        break;
                    case 5:
                        //관리설정
                        break;
                    case 6:
                        //영업관리
                        break;
                    case 7:
                        //영업종료
                        CloseSale();
                        break;
                    case 8:
                        //종    료
                        ClosePos();
                        break;

                    default:
                        break;


                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 판매등록
        /// </summary>
        private bool RegisterSale()
        {
            bool bRet = false;
            FrmLogin frmLogin = null;
            try
            {
                frmLogin = new FrmLogin();
                frmLogin.ShowDialog();

                if(ClsMain.sLoginState == "true")
                {
                    FrmSale frmSale = new FrmSale();
                    frmSale.txtCashierNo.Text = ClsMain.sCashierNo;
                    frmSale.txtCashierName.Text = ClsMain.sName;
                    frmSale.ShowDialog();
                }
                bRet = true;
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            return bRet;
        }

        /// <summary>
        /// 영업개시
        /// </summary>
        private bool StartSale()
        {
            bool bRet = false;
            try
            {
                btnStartSale.Enabled = false;
                btnSaveSale.Enabled = true;
                lblCashierNo.Text = "000001";
                lblSaleState.Text = "영업";
                txtState.Text = "ON";
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            return bRet;
        }

        /// <summary>
        /// 영업종료
        /// </summary>
        private bool CloseSale()
        {
            bool bRet = false;
            try
            {
                ClsMain.iSaleState = (int)ClsMain.EnumState.END_OF_SALE;
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            return bRet;
        }

        /// <summary>
        /// 종료
        /// </summary>
        private bool ClosePos()
        {
            bool bRet = false;
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
            return bRet;
        }


        /// <summary>
        /// 폼시작 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                ClsDB.OpenDataBase();
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 폼종료 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ClsDB.CloseDataBase();
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

    }
}
