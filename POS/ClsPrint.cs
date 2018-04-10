/**************************************************************************************************************************************************
 *  
 *  FileName    : ClsMain.cs
 *  Description : 프린트 로직 Class
 *  Date        : 2018. 03. 22
 *  Author      : UniBiz_ParkJIyun
 *  ---------------------------------------------------------------------------------------------------------------------------------------------------
 *  History
 * 
 *  
 * ***********************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class ClsPrint
    {

        private ClsTran clsTran = new ClsTran();

        const char STX = (char)0x02;
        const char ETX = (char)0x03; //End Text [응답용Asc]
        const char EOT = (char)0x04; //End of Text[요구용 Asc]
        const char ENQ = (char)0x05; //Enquire[프레임시작코드]
        const char ACK = (char)0x06; //Acknowledge[응답 시작]
        const char NAK = (char)0x15; //Not Acknoledge[에러응답시작]
        private SerialPort spPort = null;


        /// <summary>
        /// 포트오픈
        /// </summary>
        public void OpenPort()
        {
            try
            {
                spPort = new SerialPort()
                {
                    PortName = "COM7",
                    BaudRate = (int)9600,
                    DataBits = (int)8,
                    Parity = Parity.None,
                    StopBits = StopBits.One,
                    //Handshake = Handshake.RequestToSend,
                    Handshake = Handshake.None,
                    //Encoding = Encoding.UTF8, //한글처리 필요시
                    Encoding = Encoding.GetEncoding("ks_c_5601-1987"),
                    NewLine = "\n",
                    ReadTimeout = 500,
                    WriteTimeout = 500
                };
                
                spPort.Open();
            }
            catch (Exception ex)
            {
                spPort.Dispose();
                spPort = null;
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }


        /// <summary>
        /// 포트종료
        /// </summary>
        public void ClosePort()
        {
            try
            {
                spPort.Close();
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }


        /// <summary>
        /// 프린트실행
        /// </summary>
        public void ExecutePrint()
        {
            string sText = null;
            try
            {

                sText = CallTemplate("receipt");
                spPort.Write(sText);

                do
                {
                    //데이타를 전부 PLC로 전송 하기 위함..
                } while (spPort.WriteBufferSize == 0);
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// 템플릿 호출
        /// </summary>
        /// <returns></returns>
        private string CallTemplate(string sType)
        {
            string sTranNo = null;
            string sRet = null;
            try
            {
                //42자 맞춰
                sRet = "(주) 유니비즈시스템 \n" +
                       "사업자 번호 : 123-45-67890\n" +
                       "주      소  : 서울시 구로구 대림동\n" +
                       "대 표 이 사 : 손병우\n" +
                       "\n";

                switch (sType)
                {
                    case "receipt":
                        sRet += "안내메시지\n";

                        sTranNo = clsTran.SelectTranNo();
                        List<Dictionary<string, string>> liRet = clsTran.SelectReceipt(sTranNo);

                        sRet += "[" + liRet[0]["tran_type"] + "] " +
                                 liRet[0]["sal_date"].Substring(0, 4) + "-" + liRet[0]["sal_date"].Substring(4, 2) + "-" + liRet[0]["sal_date"].Substring(6, 2) + "          " +
                                "POS번호:" + liRet[0]["pos_no"] + "\n";

                        sRet +=
                            "------------------------------------------" + "\n" +
                            "   상품명        단가      수량      금액" + "\n" +
                            "------------------------------------------" + "\n";
                        foreach (Dictionary<string, string> dicTemp in liRet)
                        {
                            sRet += "   " +
                                     dicTemp["plu_cd"] + " " +
                                     dicTemp["sal_price"] + "      " +
                                     dicTemp["sal_qty"] + "      " +
                                     dicTemp["sal_amt"] + "\n";
                        }

                        sRet +=
                            "------------------------------------------" + "\n" +
                            "[서명]                                    " + "\n\n" +
                            "------------------------------------------" + "\n\n";
                        sRet += liRet.Count + "개" + "      " + "거래NO : " + liRet[0]["tran_no"] + "판매원 : " + ClsMain.sCashierNo;

                        sRet += "\n";
                        sRet += "소계 에누리                       0" + "\n";
                        sRet += "\n";
                        sRet += "부가세 면세 물품가액               0" + "\n";
                        sRet += "부가세 과세 물품가액               0" + "\n";
                        sRet += "부      가       세             " + liRet[0]["tot_vat"] + "\n";
                        sRet += "합               계             " + liRet[0]["tot_amt"] + "\n";
                        sRet += "\n\n\n\n\n\n\n";


                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ClsLog.WriteLog(ClsLog.LOG_EXCEPTION, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
            }
            return sRet;
        }

        /// <summary>
        /// PLC로 부터 수신된 데이타를 가지고 온다
        /// </summary>
        /// <returns></returns>
        public string DataRead()
        {
            bool bNext = false;
            string sInData = string.Empty;
            string strRetValue = string.Empty;
            string msg = string.Empty;

            DateTime start = DateTime.Now;
            do
            {
                msg = spPort.ReadExisting();
                sInData += msg;
                //TODO : 데이타에 종료문자가 있으면...
                if (msg.IndexOf(ETX) > 0)
                {
                    //TODO 데이타 처음에 정상 응답이 있으면
                    if (sInData[0] == ACK)
                    {
                        //TODO 들어오는 데이타를 분석..[ETX(1)+국번(2)+비트읽기(3)+블륵수(2)]
                        //lblInputData.Text = strInData;//Test용
                        strRetValue = sInData.Substring(8, sInData.Length - 9); //실제Data
                        bNext = true;
                    }
                    //TODO: 데이타에 비정상 응답이 들어오면..
                    else if (sInData[0] == NAK)
                    {
                        //lblInputData.Text = "NAK";
                        strRetValue = "-1";
                        bNext = true;
                    }
                }
                //DOTO : 응답이 없으면 0.5초간은 로프를둘면서 기다란다.
                TimeSpan ts = DateTime.Now.Subtract(start);
                if (ts.Milliseconds > 500)
                {
                    //lblInputData.Text = "TimeOut";
                    strRetValue = "-3";
                    bNext = true;
                }
            } while (!bNext);
            return strRetValue;
        }
    }
}
