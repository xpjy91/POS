/**************************************************************************************************************************************************
 *  
 *  FileName    : FrmLogin.cs
 *  Description : 로그인창 화면 이벤트 처리
 *  Date        : 2018. 03. 16
 *  Author      : UniBiz_ParkJIyun
 *  ---------------------------------------------------------------------------------------------------------------------------------------------------
 *  History
 *  
 *  
 * ************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{

    public partial class FrmLogin : Form
    {
        private Control ctrFocus = null;
        private ClsLogin clsLogin = new ClsLogin();

        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼시작 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
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
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
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


        /// <summary>
        /// 아이디 텍스트박스창 엔터 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    CheckId();
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }


        /// <summary>
        /// 비밀번호 텍스트박스창 엔터 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    btnLogin_Click(sender, e);
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    CheckId();
                }
                else
                {
                    CheckPwd();
                }
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
                if (ctrFocus == txtId)
                {
                    txtId.Text = "";
                    txtName.Text = "";
                    txtId.Focus();
                }
                else if (ctrFocus == txtPwd)
                {
                    txtPwd.Text = "";
                    txtPwd.Focus();
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
                if (ctrFocus == txtId)
                {
                    if ((txtId.Text.Length + sKey.Length) <= 6)
                    {
                        txtId.Text += sKey;
                    }
                    txtId.Focus();
                    txtId.Select(txtId.TextLength, 0);
                }
                else if (ctrFocus == txtPwd)
                {
                    if ((txtPwd.Text.Length + sKey.Length) <= 2)
                    {
                        txtPwd.Text += sKey;
                    }
                    txtPwd.Focus();
                    txtPwd.Select(txtPwd.TextLength, 0);
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
                if (MessageBox.Show("종료하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    SelectFocus();
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
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
                if (ctrFocus == txtId)
                {
                    txtId.Focus();
                }
                else if (ctrFocus == txtPwd)
                {
                    txtPwd.Focus();
                }//end if~ else if
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 아이디체크
        /// </summary>
        /// <returns></returns>
        private bool CheckId()
        {
            bool bRet = false;
            string sId = txtId.Text;
            string sName = null;

            try
            {
                if (CheckInput("I", sId) != true) { return false; }

                sName = clsLogin.SearchName(sId);
                if (sName != null)
                {
                    txtName.Text = sName;
                    txtPwd.Focus();
                    bRet = true;
                }
                else
                {
                    MessageBox.Show("잘못된 캐셔번호 입니다.");
                    txtName.Text = "";
                    txtId.Focus();
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            return bRet;
        }

        /// <summary>
        /// 비밀번호체크
        /// </summary>
        private bool CheckPwd()
        {
            bool bRet = false;
            string sId = txtId.Text;
            string sPw = txtPwd.Text;
            string sName = txtName.Text;

            try
            {
                if (CheckInput("P", sPw) != true) { return false; }

                bRet = clsLogin.CheckLogin(sId, sPw);
                if (bRet == true)
                {
                    //로그인정보 저장
                    ClsMain.sLoginState = "true";
                    ClsMain.sCashierNo = sId;
                    ClsMain.sName = sName;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("비밀번호를 확인하세요");
                    txtPwd.Text = "";
                    txtPwd.Focus();
                }//end if~else
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bRet;
        }

        /// <summary>
        /// 입력키 유효성체크
        /// </summary>
        /// <param name="sType"></param>
        /// <param name="sText"></param>
        /// <returns></returns>
        public bool CheckInput(String sType, String sText)
        {
            bool bCheck = false;

            try
            {
                switch (sType)
                {
                    case "I":
                        if (sText == "")
                        {
                            /* 아이디 입력 x */
                            MessageBox.Show("캐셔 번호를 입력 해주세요");
                            bCheck = false;
                        }
                        else
                        {
                            if (Regex.IsMatch(sText, @"[0-9]{6}"))
                            {
                                bCheck = true;
                            }
                            else
                            {
                                MessageBox.Show("캐셔번호 : 숫자 6자리를 입력해주세요.");
                                txtId.Focus();
                                bCheck = false;
                            }
                        }

                        break;
                    case "P":
                        if (sText == "")
                        {
                            /* 비밀번호 입력 x */
                            MessageBox.Show("비밀 번호를 입력 해주세요");
                            bCheck = false;
                        }
                        else
                        {
                            if (Regex.IsMatch(sText, @"[0-9]{2}"))
                            {
                                bCheck = true;
                            }
                            else
                            {
                                MessageBox.Show("비밀번호를 확인하세요.");
                                txtPwd.Focus();
                                bCheck = false;
                            }
                        }
                        break;
                    default:
                        break;
                }//end switch
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            return bCheck;
        }

    }

}


