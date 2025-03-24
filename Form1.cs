using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthCalculator
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtYard_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCM_TextChanged(object sender, EventArgs e)
        {
         
            
        }
        // 設計一個單位轉換計算的函式，沒有回傳值，設計兩個參數，1.類別參數、2.數值參數
        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtCM.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtM.Text = string.Format("{0:0.##########}", _value / 100);
            if (_kind != 2)
                txtKM.Text = string.Format("{0:0.##########}", _value / 100000);
            if (_kind != 3)
                txtIn.Text = string.Format("{0:0.##########}", _value / 2.54);
            if (_kind != 4)
                txtFt.Text = string.Format("{0:0.##########}", _value / 30.48);
            if (_kind != 5)
                txtYard.Text = string.Format("{0:0.##########}", _value / 91.44);
        }

        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數

        // 公分的綁定事件程式碼片段
        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            double douCM; //宣告一個double變數，變數名稱叫douCM
            douCM = Convert.ToDouble(txtCM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態。
            */
            strInput = txtCM.Text; //將txtCM的文字資料存入strInput變數

            /*
            txtM.Text = string.Format("{0:0.##########}", douCM / 100); // 井字號#決定小數點後要有幾位，一個#代表一位數字
            //將douCM的數值除以100，也就是從公分轉換成公尺
            //透過string.Format格式化成小數點後共10位的數字，轉型成文字型態，在txtM顯示結果

            txtKM.Text = string.Format("{0:0.##########}", douCM / 100000); // 公分轉換成公里
            txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54); // 公分轉換成英吋
            txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48); // 公分轉換成英呎
            txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44); // 公分轉換成碼
            */
            
            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                /*
                //我們把以下的單位轉換，改成可以共用的函式
                txtM.Text = string.Format("{0:0.##########}", douOutput / 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
                */

                //執行計算長度函式
                caculateAnswer(0, douOutput);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }
        // 公尺的綁定事件程式碼片段
        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            double douM;  // 宣告一個double變數，變數名稱叫douM
            douM = Convert.ToDouble(txtM.Text); // 從txtM輸入文字框取得輸入的文字
            */
            strInput = txtM.Text; //將txtM的文字資料存入strInput變數

            /*
            txtM.Text = string.Format("{0:0.##########}", douM); // 公尺轉換成公尺

            txtCM.Text = string.Format("{0:0.##########}", douM * 100); // 公尺轉換成公分
            txtKM.Text = string.Format("{0:0.##########}", douM / 0.001); // 公尺轉換成公里
            txtIn.Text = string.Format("{0:0.##########}", douM * 39.37); // 公尺轉換成英吋
            txtFt.Text = string.Format("{0:0.##########}", douM * 3.28); // 公尺轉換成英呎
            txtYard.Text = string.Format("{0:0.##########}", douM * 1.09); // 公尺轉換成碼
            */
            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                /*
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput / 0.001);
                txtIn.Text = string.Format("{0:0.##########}", douOutput * 39.37);
                txtFt.Text = string.Format("{0:0.##########}", douOutput * 3.28);
                txtYard.Text = string.Format("{0:0.##########}", douOutput * 1.09);
                */
            

            //執行計算長度函式
            caculateAnswer(1, douOutput * 100); // 事先將公尺轉換成公分
            }   
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtM文字框清除
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }
        }

        // 公里的綁定事件程式碼片段
        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            double douKM;  // 宣告一個double變數，變數名稱叫douKM
            douKM = Convert.ToDouble(txtKM.Text); // 從txtKM輸入文字框取得輸入的文字
            */
            strInput = txtKM.Text; //將txtKM的文字資料存入strInput變數

            /*
            txtKM.Text = string.Format("{0:0.##########}", douKM); // 公里轉換成公里

            txtCM.Text = string.Format("{0:0.##########}", douKM * 100000); // 公里轉換成公分
            txtM.Text = string.Format("{0:0.##########}", douKM * 1000); // 公里轉換成公尺
            txtIn.Text = string.Format("{0:0.##########}", douKM * 39370.08); // 公里轉換成英吋
            txtFt.Text = string.Format("{0:0.##########}", douKM * 3280.84); // 公里轉換成英呎
            txtYard.Text = string.Format("{0:0.##########}", douKM * 1093.613); // 公里轉換成碼
            */
            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                /*
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 100000);
                txtM.Text = string.Format("{0:0.##########}", douOutput * 1000);
                txtIn.Text = string.Format("{0:0.##########}", douOutput * 39370.08);
                txtFt.Text = string.Format("{0:0.##########}", douOutput * 3280.84);
                txtYard.Text = string.Format("{0:0.##########}", douOutput * 1093.613);
                */
                caculateAnswer(2, douOutput * 100000); // 事先將公里轉換成公分
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtKM文字框清除
                txtInfo.Text = "請輸入數字";
                txtKM.Text = "";
            }
        }

        // 英吋的綁定事件程式碼片段
        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            double douIn;  // 宣告一個double變數，變數名稱叫douIn
            douIn = Convert.ToDouble(txtIn.Text); // 從txtIn輸入文字框取得輸入的文字
            */
            strInput = txtIn.Text; //將txtIn的文字資料存入strInput變數

            /*
            txtIn.Text = string.Format("{0:0.##########}", douIn); // 英吋轉換成英吋

            txtCM.Text = string.Format("{0:0.##########}", douIn * 2.54); // 英吋轉換成公分
            txtM.Text = string.Format("{0:0.##########}", douIn / 39.37); // 英吋轉換成公尺
            txtKM.Text = string.Format("{0:0.##########}", douIn / 39370.08); // 英吋轉換成公里
            txtFt.Text = string.Format("{0:0.##########}", douIn / 12); // 英吋轉換成英呎
            txtYard.Text = string.Format("{0:0.##########}", douIn / 36); // 英吋轉換成碼
            */
            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                /*
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 2.54);
                txtM.Text = string.Format("{0:0.##########}", douOutput / 39.37);
                txtKM.Text = string.Format("{0:0.##########}", douOutput / 39370.08);
                txtFt.Text = string.Format("{0:0.##########}", douOutput / 12);
                txtYard.Text = string.Format("{0:0.##########}", douOutput / 36);
                */
                caculateAnswer(3, douOutput * 2.54); // 事先將英吋轉換成公分
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtIn文字框清除
                txtInfo.Text = "請輸入數字";
                txtIn.Text = "";
            }
        }

        // 英呎的綁定事件程式碼片段
        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {

            /*
            double douFt;  // 宣告一個double變數，變數名稱叫douFt
            douFt = Convert.ToDouble(txtFt.Text); // 從txtFt輸入文字框取得輸入的文字
            */
            strInput = txtFt.Text; //將txtFt的文字資料存入strInput變數

            /*
            txtFt.Text = string.Format("{0:0.##########}", douFt); // 英呎轉換成英呎

            txtCM.Text = string.Format("{0:0.##########}", douFt * 30.48); // 英呎轉換成公分
            txtM.Text = string.Format("{0:0.##########}", douFt / 3.281); // 英呎轉換成公尺
            txtKM.Text = string.Format("{0:0.##########}", douFt / 3280.84); // 英呎轉換成公里
            txtIn.Text = string.Format("{0:0.##########}", douFt * 12); // 英呎轉換成英吋
            txtYard.Text = string.Format("{0:0.##########}", douFt / 3); // 英呎轉換成碼
            */
            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                /*
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 30.48);
                txtM.Text = string.Format("{0:0.##########}", douOutput / 3.281);
                txtKM.Text = string.Format("{0:0.##########}", douOutput / 3280.84);
                txtIn.Text = string.Format("{0:0.##########}", douOutput * 12);
                txtYard.Text = string.Format("{0:0.##########}", douOutput / 3);
                */
                caculateAnswer(4, douOutput * 30.48); // 事先將英呎轉換成公分
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtFt文字框清除
                txtInfo.Text = "請輸入數字";
                txtFt.Text = "";
            }
        }

        // 碼的綁定事件程式碼片段
        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            double douYard;  // 宣告一個double變數，變數名稱叫douYard
            douYard = Convert.ToDouble(txtYard.Text); // 從txtYard輸入文字框取得輸入的文字
            */
            strInput = txtYard.Text; //將txtYard的文字資料存入strInput變數

            /*
            txtYard.Text = string.Format("{0:0.##########}", douYard); // 碼轉換成碼

            txtCM.Text = string.Format("{0:0.##########}", douYard * 91.44); // 碼轉換成公分
            txtM.Text = string.Format("{0:0.##########}", douYard / 1.094); // 碼轉換成公尺
            txtKM.Text = string.Format("{0:0.##########}", douYard / 1093.613); // 碼轉換成公里
            txtIn.Text = string.Format("{0:0.##########}", douYard * 36); // 碼轉換成英吋
            txtFt.Text = string.Format("{0:0.##########}", douYard * 3); // 碼轉換成英呎
            */
            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                /*
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 91.44);
                txtM.Text = string.Format("{0:0.##########}", douOutput / 1.094);
                txtKM.Text = string.Format("{0:0.##########}", douOutput / 1093.613);
                txtIn.Text = string.Format("{0:0.##########}", douOutput * 36);
                txtFt.Text = string.Format("{0:0.##########}", douOutput * 3);
                */
                caculateAnswer(5, douOutput * 91.44); // 事先將碼轉換成公分
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtYard文字框清除
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }
        }

        private void txtInfo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            // 給予每一個輸入文字框一個「空字串」，順便賦與文字框清除的功能
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
            txtInfo.Text = "";

        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}