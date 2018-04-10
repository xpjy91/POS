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
    public partial class FrmPayCash : Form
    {

        Control ctrFocus = null;
        public FrmPayCash()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 포커스 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFocus_Enter(object sender, EventArgs e)
        {
            try
            {
                ctrFocus = (TextBox)sender;
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(1, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 고객구분 입력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    txtInfo.Focus();
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }


        /// <summary>
        /// 고객정보 엔터 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInfo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {

                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 등록버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
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
                if (ctrFocus == txtType)
                {
                    txtType.Text = "";
                    txtType.Focus();
                }
                else if (ctrFocus == txtInfo)
                {
                    txtInfo.Text = "";
                    txtInfo.Focus();
                }
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
                if (ctrFocus == txtType)
                {
                    if ((txtType.Text.Length + sKey.Length) <= 1)
                    {
                        txtType.Text += sKey;
                    }
                    txtType.Focus();
                    txtType.Select(txtType.TextLength, 0);
                }
                else if (ctrFocus == txtInfo)
                {
                    if ((txtInfo.Text.Length + sKey.Length) <= 2)
                    {
                        txtInfo.Text += sKey;
                    }
                    txtInfo.Focus();
                    txtInfo.Select(txtInfo.TextLength, 0);
                }//end if~ else if
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
                this.Close();
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 빈버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmpty_Click(object sender, EventArgs e)
        {
            try
            {
                SelectFocus();
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 선택 포커스
        /// </summary>
        private void SelectFocus()
        {
            try
            {
                if (ctrFocus == txtType)
                {
                    txtType.Focus();
                }
                else if (ctrFocus == txtInfo)
                {
                    txtInfo.Focus();
                }//end if~ else if
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }
    }

}
