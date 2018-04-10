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
    public partial class FrmHold : Form
    {
        public FrmHold()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 보류 확인
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
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
        /// 보류 취소
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("취소 하시겠습니까?", "취소 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
             }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }
    }
}
