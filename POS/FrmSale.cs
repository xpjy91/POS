/**************************************************************************************************************************************************
 *  
 *  FileName    : ClsMain.cs
 *  Description : 판매등록폼
 *  Date        : 2018. 03. 20
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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmSale : Form
    {

        private Control ctrFocus = null;
        private ClsSale clsSale = new ClsSale();
        private ClsTran clsTran = new ClsTran();
        //private ClsUndoRedo<Button> clsUndoRedo = new ClsUndoRedo<Button>(10);

        public FrmSale()
        {
            InitializeComponent();
            DateTimer();
        }

        /// <summary>
        /// 폼시작 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSale_Load(object sender, EventArgs e)
        {
            try
            {
                ClsDB.OpenDataBase();
                InitTestData();
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
        private void FrmSale_FormClosed(object sender, FormClosedEventArgs e)
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
        /// 기능버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFunction_Click(object sender, EventArgs e)
        {
            int iIndex = 0;
            FrmHold frmHold = new FrmHold();
            try
            {
                iIndex = ((Button)sender).TabIndex;

                switch (iIndex)
                {
                    case 1:
                        //공통 -> 영업관리
                        break;
                    case 2:
                        //판매초기 -> 반품
                        //판매중 -> Empty
                        break;
                    case 3:
                        //판매초기 -> Empty
                        //판매중 -> 수량
                        if (ClsMain.iSaleState == (int)ClsMain.EnumState.INIT_SALE)
                        {

                        }
                        else if (ClsMain.iSaleState == (int)ClsMain.EnumState.FOR_SALE)
                        {
                            if (ChangeQty() == true) UpdateDisplay();
                        }
                        break;
                    case 4:
                        //판매초기 -> Empty
                        //판매중 -> 수량
                        break;
                    case 5:
                        //판매초기 -> Empty or 복원
                        //판매중 -> 보류
                        if (ClsMain.iSaleState == (int)ClsMain.EnumState.INIT_SALE)
                        {
                            RestoreGoods();
                        }
                        else if (ClsMain.iSaleState == (int)ClsMain.EnumState.FOR_SALE)
                        {
                            frmHold.ShowDialog();
                            HoldSale();
                        }
                        break;
                    case 6:
                        //판매초기 -> Empty
                        //판매중 -> 할인
                        if (ClsMain.iSaleState == (int)ClsMain.EnumState.INIT_SALE)
                        {

                        }
                        else if (ClsMain.iSaleState == (int)ClsMain.EnumState.FOR_SALE)
                        {
                            if (ChangeDisCount() == true) UpdateDisplay();
                        }
                        break;
                    case 7:
                        //판매초기 -> Empty
                        //판매중 -> 상품권
                        break;
                    case 8:
                        //판매초기 -> Empty
                        //판매중 -> 가격변경
                        if (ClsMain.iSaleState == (int)ClsMain.EnumState.INIT_SALE)
                        {

                        }
                        else if (ClsMain.iSaleState == (int)ClsMain.EnumState.FOR_SALE)
                        {
                            if (ChangePrice() == true) UpdateDisplay();
                        }
                        break;
                    case 9:
                        //판매초기 -> Empty
                        //판매중 -> 취소
                        if (ClsMain.iSaleState == (int)ClsMain.EnumState.INIT_SALE)
                        {

                        }
                        else if (ClsMain.iSaleState == (int)ClsMain.EnumState.FOR_SALE)
                        {
                            if (DeleteRow() == true) UpdateDisplay();
                        }
                        break;
                    case 10:
                        //판매초기 -> Empty
                        //판매중 -> 상품관리
                        break;
                    case 11:
                        //판매초기 -> Empty
                        //판매중 -> 거래중지
                        if (ClsMain.iSaleState == (int)ClsMain.EnumState.INIT_SALE)
                        {

                        }
                        else if (ClsMain.iSaleState == (int)ClsMain.EnumState.FOR_SALE)
                        {
                            clsSale.OutputPrint();
                        }
                        break;
                    case 12:
                        //판매초기 -> Empty
                        //판매중 -> 조회
                        break;
                    case 13:
                        UpRow();
                        break;
                    case 14:
                        DownRow();
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
        /// 숫자버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNum_Click(object sender, EventArgs e)
        {
            string sKey = null;

            try
            {
                sKey = ((Button)sender).Text;

                if ((txtInput.Text.Length + sKey.Length) <= 13)
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
        /// 화면 업데이트
        /// </summary>
        public void UpdateDisplay()
        {
            try
            {
                if (UpdateRow() == true)
                {
                    UpdateTotal();
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// ESC 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEsc_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Clear버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtInput.Clear();
                txtInput.Focus();
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 등록버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (ctrFocus == txtInput)
                {
                    InputGoods(txtInput.Text);
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }

        }

        /// <summary>
        /// 현금버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCash_Click(object sender, EventArgs e)
        {

            try
            {
                if (PayCash() == true)
                {
                    ChangeButton("sale");
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 판매보류
        /// </summary>
        /// <returns></returns>
        private bool HoldSale()
        {
            bool bRet = false;
            int iTotal = 0;

            try
            {
                iTotal = int.Parse(txtTotal.Text.Replace(",", ""));
                bRet = clsSale.SaveTran(grdSaleList.Rows, "02", iTotal, 0);
                if(bRet == true)
                {
                    grdSaleList.Rows.Clear();
                    txtHoldCount.Text = clsTran.SelectHoldCount().ToString();
                    ChangeButton("sale");
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            return bRet;
        }

        /// <summary>
        /// 현금계산
        /// </summary>
        /// <returns></returns>
        private bool PayCash()
        {
            bool bRet = false;

            //합계
            int iTotal = 0;
            //거스름
            int iChange = 0;
            //받은돈
            int iCash = 0;

            try
            {
                iTotal = int.Parse(txtTotal.Text.Replace(",",""));

                if (txtInput.Text == "")
                {
                    iCash = iTotal;
                }
                else
                {
                    iCash = int.Parse(txtInput.Text);
                }

                iChange = iCash - iTotal;

                txtPay.Text = iCash.ToString();
                txtChange.Text = iChange.ToString();

                if (iChange < 0)
                {
                    MessageBox.Show("받은 금액을 확인해주세요.");
                    return false;
                }

                bRet = clsSale.SaveTran(grdSaleList.Rows, "01", iTotal, iCash);

                if( bRet == true)
                {
                    FrmPayCash frmPayCash = new FrmPayCash();
                    frmPayCash.Show();
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bRet;
        }

        /// <summary>
        /// input창 키입력 이벤트 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar) != true && e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 텍스트 유효성 체크
        /// </summary>
        /// <param name="sType"></param>
        /// <param name="sText"></param>
        /// <returns></returns>
        private bool CheckInput(String sType, String sText)
        {
            bool bRet = false;
            int iValue = 0;
            try
            {
                switch (sType)
                {
                    case "count":
                        if (sText == "")
                        {
                            MessageBox.Show("수량을 입력해주세요");
                            break;
                        }
                        iValue = int.Parse(sText);
                        if (iValue >= 100 || iValue < 1)
                        {
                            MessageBox.Show("수량을 1~100개 사이로 입력해주세요");
                            txtInput.Clear();
                            break;
                        }

                        bRet = true;
                        break;
                    case "disCount":
                        if (sText == "")
                        {
                            MessageBox.Show("할인금액을 입력해주세요");
                            break;
                        }
                        iValue = int.Parse(sText);
                        if (iValue >= 100)
                        {
                            MessageBox.Show("할인율은 100% 미만으로만 가능합니다.");
                            txtInput.Clear();
                            break;
                        }

                        bRet = true;
                        break;
                    case "price":
                        if (sText == "")
                        {
                            MessageBox.Show("변경할 금액을 입력해주세요");
                            break;
                        }

                        bRet = true;
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bRet;
        }


        /// <summary>
        //  행업데이트
        /// </summary>
        private bool UpdateRow()
        {
            bool bRet = false;

            int iUnitPrice = 0;
            int iPrice = 0;
            int iQty = 0;
            int iDisCount = 0;
            int iRowIndex = 0;

            try
            {
                if (checkRow(grdSaleList.CurrentRow) != true) { return false; }

                iRowIndex = grdSaleList.CurrentRow.Index;
                iUnitPrice = int.Parse(grdSaleList.Rows[iRowIndex].Cells["colUnitPrice"].Value.ToString());
                iQty = int.Parse(grdSaleList.Rows[iRowIndex].Cells["colQty"].Value.ToString());
                iDisCount = int.Parse(grdSaleList.Rows[iRowIndex].Cells["colDisCount"].Value.ToString());
                //iPrice = (iUnitPrice * iQty) - ((iUnitPrice * iQty) * iDisCount / 100 );
                iPrice = (iUnitPrice * iQty) - (iDisCount * iQty);
                grdSaleList.Rows[iRowIndex].Cells["colPrice"].Value = iPrice;

                bRet = true;

            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }


            return bRet;
        }

        /// <summary>
        /// 합계업데이트
        /// </summary>
        /// <returns></returns>
        private bool UpdateTotal()
        {
            bool bRet = false;

            int iSubTotal = 0;
            int iDisCount = 0;
            int iTotal = 0;
            try
            {
                foreach (DataGridViewRow grdRow in grdSaleList.Rows)
                {
                    iSubTotal += int.Parse(grdRow.Cells["colUnitPrice"].Value.ToString()) * int.Parse(grdRow.Cells["colQty"].Value.ToString());
                    iTotal += int.Parse(grdRow.Cells["colPrice"].Value.ToString());
                }

                iDisCount = iSubTotal - iTotal;
                txtSubTotal.Text = String.Format("{0:#,###}",iSubTotal);
                txtDisCount.Text = String.Format("{0:#,###}",iDisCount);
                txtTotal.Text = String.Format("{0:#,###}",iTotal);

            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bRet;
        }

        /// <summary>
        /// 행 삭제
        /// </summary>
        /// <returns></returns>
        private bool DeleteRow()
        {
            bool bRet = false;
            DataGridViewRow grdRow = null;
            int iCurrentRow = 0;

            try
            {
                if (grdSaleList.CurrentRow == null) { return false; }
                iCurrentRow = grdSaleList.CurrentRow.Index;
                grdRow = grdSaleList.Rows[iCurrentRow];
                grdSaleList.Rows.RemoveAt(iCurrentRow);
                if(grdSaleList.Rows.Count <= 0)
                {
                    ChangeButton("sale");
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
        /// 행 UP 
        /// </summary>
        /// <returns></returns>
        private bool UpRow()
        {
            bool bRet = false;
            int iCurrentRow = 0;
            try
            {
                if (grdSaleList.CurrentRow.Index <= 0) { return false; }
                iCurrentRow = grdSaleList.CurrentRow.Index;
                grdSaleList.Rows[iCurrentRow - 1].Selected = true;
                grdSaleList.CurrentCell = grdSaleList[grdSaleList.CurrentCell.ColumnIndex, iCurrentRow - 1];

                bRet = true;
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            return bRet;
        }

        /// <summary>
        /// 행 Down
        /// </summary>
        /// <returns></returns>
        private bool DownRow()
        {
            bool bRet = false;
            int iCurrentRow = 0;
            try
            {
                if (grdSaleList.CurrentRow.Index < 0 || grdSaleList.CurrentRow.Index + 1 == grdSaleList.Rows.Count) return false;
                iCurrentRow = grdSaleList.CurrentRow.Index;
                grdSaleList.Rows[iCurrentRow + 1].Selected = true;
                grdSaleList.CurrentCell = grdSaleList[grdSaleList.CurrentCell.ColumnIndex, iCurrentRow + 1];

                bRet = true;
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            return bRet;
        }

        /// <summary>
        /// 상품정보등록
        /// </summary>
        /// <param name="sCode"></param>
        private void InputGoods(String sCode)
        {
            List<Dictionary<string, string> > liRowData = null;
            Dictionary<string, string> dicRow = null;
            string sPluCd = null;
            string sCount = null;
            int iValue = 0;
            bool bCheck = false;

            try
            {
                foreach (DataGridViewRow rowTemp in grdSaleList.Rows)
                {

                    sPluCd = rowTemp.Cells["colCode"].Value.ToString();
                    if (sPluCd == sCode)
                    {
                        sCount = rowTemp.Cells["colQty"].Value.ToString();
                        iValue = int.Parse(sCount) + 1;
                        rowTemp.Cells["colQty"].Value = iValue;
                        grdSaleList.CurrentCell = grdSaleList["colQty", rowTemp.Index];

                        UpdateRow();
                        return;
                    }
                }

                dicRow = clsTran.SearchGoods(sCode);
                liRowData = new List<Dictionary<string, string>>();
                liRowData.Add(dicRow);
                bCheck = AddRow(liRowData);

                if (bCheck != true)
                {
                    MessageBox.Show("상품코드를 확인해주세요");
                }

                txtInput.Clear();
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 가격변경
        /// </summary>
        /// <param name="sPrice"></param>
        /// <returns></returns>
        private bool ChangePrice()
        {
            bool bRet = false;
            string sValue = null;
            int iPrice = 0;
            try
            {

                sValue = txtInput.Text;
                if (CheckInput("price", sValue) != true) { return false; }
                iPrice = int.Parse(sValue);
                grdSaleList.CurrentRow.Cells["colUnitPrice"].Value = iPrice;
                txtInput.Clear();
                bRet = true;
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bRet;
        }

        /// <summary>
        /// 수량 변경
        /// </summary>
        /// <returns></returns>
        private bool ChangeQty()
        {
            bool bRet = false;
            string sValue = null;
            int iQty = 0;
            try
            {
                sValue = txtInput.Text;
                if (sValue == "") { sValue = (int.Parse(grdSaleList.CurrentRow.Cells["colQty"].Value.ToString()) + 1).ToString(); }
                if (CheckInput("count", sValue) != true) { return false; }
                iQty = int.Parse(sValue);
                grdSaleList.CurrentRow.Cells["colQty"].Value = iQty;
                txtInput.Clear();
                bRet = true;
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            return bRet;
        }

        /// <summary>
        /// 할인변경
        /// </summary>
        /// <param name="Discount"></param>
        /// <returns></returns>
        private bool ChangeDisCount()
        {
            bool bRet = false;
            int iDisCount = 0;
            string sValue = null;
            string sType = "persent";

            int iUnitPrice = 0;
            int iTemp = 0;
            try
            {
                sValue = txtInput.Text;
                if (CheckInput("disCount", sValue) != true) { return false; }
                if (sValue == "99") { sType = "value"; }

                switch (sType)
                {
                    case "persent":

                        iDisCount = int.Parse(sValue);
                        iUnitPrice = int.Parse(grdSaleList.CurrentRow.Cells["colUnitPrice"].Value.ToString());

                        iTemp = (iUnitPrice * iDisCount / 100);
                        grdSaleList.CurrentRow.Cells["colDisCount"].Value = iTemp;
                        grdSaleList.CurrentRow.Cells["colRemarks"].Value = iDisCount + "% 할인";

                        txtInput.Clear();
                        bRet = true;

                        break;

                    case "value":

                        FrmDisCount frmDisCount = new FrmDisCount(this);
                        frmDisCount.Show();

                        bRet = true;
                        break;

                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bRet;
        }

        /// <summary>
        /// 로우 검사
        /// </summary>
        /// <param name="rowInput"></param>
        /// <returns></returns>
        private bool checkRow(DataGridViewRow rowInput)
        {
            bool bRet = false;
            try
            {
                if(rowInput == null) { return false; }
                else if (Regex.IsMatch(rowInput.Cells["colUnitPrice"].Value.ToString(), @"\D")) { return false; }
                else if (Regex.IsMatch(rowInput.Cells["colQty"].Value.ToString(), @"\D")) { return false; }
                else if (Regex.IsMatch(rowInput.Cells["colDisCount"].Value.ToString(), @"\D")) { return false; }

                bRet = true;
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bRet;
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
                ctrFocus = (Control)sender;
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(1, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 날짜 타이머
        /// </summary>
        private void DateTimer()
        {
            try
            {
                Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; // 1초
                timer.Tick += new EventHandler(GetCurrentDate);
                timer.Start();
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 현재날짜시간 구하기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetCurrentDate(object sender, EventArgs e)
        {
            string sDate = null;
            string sHour = null;
            try
            {
                DateTime dtNow = DateTime.Now;
                sDate = string.Format("{0:yyyy/MM/dd}", dtNow);
                sHour = string.Format("{0:HH:mm:ss}", dtNow);

                this.txtCurrentDate.Text = sDate;
                this.txtCurrentHour.Text = sHour;
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 버튼 변경
        /// </summary>
        /// <param name="sType"></param>
        private bool ChangeButton(String sType)
        {
            bool bRet = false;
            int iHoldCount = 0;
            try
            {
                switch (sType)
                {
                    case "sale":
                        //판매초기

                        //보류 카운트
                        iHoldCount = int.Parse(txtHoldCount.Text);
                        ClsMain.iSaleState = (int) ClsMain.EnumState.INIT_SALE;
                        btnFunction02.Text = "반품";
                        btnFunction03.Text = "";
                        btnFunction04.Text = "캐셔메뉴";
                        if(iHoldCount > 0)
                        {
                            btnFunction05.Text = "복원";
                        }
                        else
                        {
                            btnFunction05.Text = "";
                        }
                        btnFunction06.Text = "";
                        btnFunction07.Text = "입출금";
                        btnFunction08.Text = "";
                        btnFunction09.Text = "";
                        btnFunction10.Text = "판매종료";
                        btnFunction11.Text = "영수증";


                        bRet = true;
                        break;
                    case "tran":
                        ClsMain.iSaleState = (int)ClsMain.EnumState.FOR_SALE;
                        btnFunction02.Text = "";
                        btnFunction03.Text = "수량";
                        btnFunction04.Text = "";
                        btnFunction05.Text = "보류";
                        btnFunction06.Text = "할인";
                        btnFunction07.Text = "상품권";
                        btnFunction08.Text = "가격변경";
                        btnFunction09.Text = "취소";
                        btnFunction10.Text = "상품관리";
                        btnFunction11.Text = "거래중지";

                        bRet = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }

            return bRet;
        }

        /// <summary>
        /// 로우추가
        /// </summary>
        /// <param name="rowData"></param>
        /// <returns></returns>
        public bool AddRow(List<Dictionary<string,string>> liRowData)
        {
            bool bRet = false;
            int iIndex = 0;
            try
            {
                if (liRowData.Count > 0)
                {
                    foreach(Dictionary<string, string> rowData in liRowData)
                    {
                        iIndex = grdSaleList.Rows.Add();
                        grdSaleList.Rows[iIndex].Cells["colSeq"].Value = iIndex;
                        grdSaleList.Rows[iIndex].Cells["colCode"].Value = rowData["colCode"];
                        grdSaleList.Rows[iIndex].Cells["colTitle"].Value = rowData["colTitle"];
                        grdSaleList.Rows[iIndex].Cells["colUnitPrice"].Value = rowData["colUnitPrice"];
                        grdSaleList.Rows[iIndex].Cells["colQty"].Value = rowData["colQty"];
                        grdSaleList.Rows[iIndex].Cells["colDisCount"].Value = rowData["colDisCount"];
                        grdSaleList.Rows[iIndex].Cells["colTaxYn"].Value = rowData["colTaxYn"];
                        grdSaleList.Rows[iIndex].Cells["colPrice"].Value = rowData["colPrice"];
                        grdSaleList.Rows[iIndex].Cells["colRemarks"].Value = rowData["colRemarks"];
                    }

                    ChangeButton("tran");
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
        /// 상품복원
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestoreGoods()
        {
            FrmRestore frmRestor = new FrmRestore(this);
            try
            {
                frmRestor.Show();
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 테스트 데이터 셋팅
        /// </summary>
        private void InitTestData()
        {
            Random ranData = new Random();
            int iCnt = 0;
            List<Dictionary<string, string>> liRowData = new List<Dictionary<string, string>>();
            Dictionary<string, string> dicRow = new Dictionary<string, string>();
            string[] lColCode = { "0010101010111", "0011010101110", "0011101010111", "0101011010001", "1010110010001", "1010111110001", "1100101010110"};
            string[] lCodeTemp = new string[3];
            string sCode = null;
            bool bCheck = true;
            int iIndex = 0;
            try
            {
                while (iIndex < 3)
                {
                    bCheck = true;
                    iCnt = ranData.Next(0, 6);
                    foreach (string lTemp in lCodeTemp)
                    {
                        if(lTemp == lColCode[iCnt])
                        {
                            bCheck = false;
                            break;
                        }
                    }
                    if(bCheck == true)
                    {
                        lCodeTemp[iIndex] = lColCode[iCnt];
                        sCode = lCodeTemp[iIndex].ToString();
                        dicRow = clsTran.SearchGoods(sCode);
                        liRowData = new List<Dictionary<string, string>>();
                        liRowData.Add(dicRow);
                        bCheck = AddRow(liRowData);
                        grdSaleList.CurrentCell = grdSaleList["colSeq", iIndex];
                        UpdateDisplay();
                        iIndex++;
                    }
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

       
    }
}
