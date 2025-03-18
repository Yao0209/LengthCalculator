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
        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM; //宣告一個double變數，變數名稱叫douCM

            douCM = Convert.ToDouble(txtCM.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態。

            txtM.Text = string.Format("{0:0.##########}", douCM / 100); // 井字號#決定小數點後要有幾位，一個#代表一位數字
            //將douCM的數值除以100，也就是從公分轉換成公尺
            //透過string.Format格式化成小數點後共10位的數字，轉型成文字型態，在txtM顯示結果

            txtKM.Text = string.Format("{0:0.##########}", douCM / 100000); // 公分轉換成公里
            txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54); // 公分轉換成英吋
            txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48); // 公分轉換成英呎
            txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44); // 公分轉換成碼
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM;  // 宣告一個double變數，變數名稱叫douM

            douM = Convert.ToDouble(txtM.Text); // 從txtM輸入文字框取得輸入的文字

            txtM.Text = string.Format("{0:0.##########}", douM); // 公尺轉換成公尺

            txtCM.Text = string.Format("{0:0.##########}", douM * 100); // 公尺轉換成公分
            txtKM.Text = string.Format("{0:0.##########}", douM / 1000); // 公尺轉換成公里
            txtIn.Text = string.Format("{0:0.##########}", douM * 39.37); // 公尺轉換成英吋
            txtFt.Text = string.Format("{0:0.##########}", douM * 3.281); // 公尺轉換成英呎
            txtYard.Text = string.Format("{0:0.##########}", douM * 1.094); // 公尺轉換成碼
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM;  // 宣告一個double變數，變數名稱叫douKM

            douKM = Convert.ToDouble(txtKM.Text); // 從txtKM輸入文字框取得輸入的文字

            txtKM.Text = string.Format("{0:0.##########}", douKM); // 公里轉換成公里

            txtCM.Text = string.Format("{0:0.##########}", douKM * 100000); // 公里轉換成公分
            txtM.Text = string.Format("{0:0.##########}", douKM * 1000); // 公里轉換成公尺
            txtIn.Text = string.Format("{0:0.##########}", douKM * 39370.08); // 公里轉換成英吋
            txtFt.Text = string.Format("{0:0.##########}", douKM * 3280.84); // 公里轉換成英呎
            txtYard.Text = string.Format("{0:0.##########}", douKM * 1093.613); // 公里轉換成碼
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            double douIn;  // 宣告一個double變數，變數名稱叫douIn

            douIn = Convert.ToDouble(txtIn.Text); // 從txtIn輸入文字框取得輸入的文字

            txtIn.Text = string.Format("{0:0.##########}", douIn); // 英吋轉換成英吋

            txtCM.Text = string.Format("{0:0.##########}", douIn * 2.54); // 英吋轉換成公分
            txtM.Text = string.Format("{0:0.##########}", douIn / 39.37); // 英吋轉換成公尺
            txtKM.Text = string.Format("{0:0.##########}", douIn / 39370.08); // 英吋轉換成公里
            txtFt.Text = string.Format("{0:0.##########}", douIn / 12); // 英吋轉換成英呎
            txtYard.Text = string.Format("{0:0.##########}", douIn / 36); // 英吋轉換成碼
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            double douFt;  // 宣告一個double變數，變數名稱叫douFt

            douFt = Convert.ToDouble(txtFt.Text); // 從txtFt輸入文字框取得輸入的文字

            txtFt.Text = string.Format("{0:0.##########}", douFt); // 英呎轉換成英呎

            txtCM.Text = string.Format("{0:0.##########}", douFt * 30.48); // 英呎轉換成公分
            txtM.Text = string.Format("{0:0.##########}", douFt / 3.281); // 英呎轉換成公尺
            txtKM.Text = string.Format("{0:0.##########}", douFt / 3280.84); // 英呎轉換成公里
            txtIn.Text = string.Format("{0:0.##########}", douFt * 12); // 英呎轉換成英吋
            txtYard.Text = string.Format("{0:0.##########}", douFt / 3); // 英呎轉換成碼
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard;  // 宣告一個double變數，變數名稱叫douYard

            douYard = Convert.ToDouble(txtYard.Text); // 從txtYard輸入文字框取得輸入的文字

            txtYard.Text = string.Format("{0:0.##########}", douYard); // 碼轉換成碼

            txtCM.Text = string.Format("{0:0.##########}", douYard * 91.44); // 碼轉換成公分
            txtM.Text = string.Format("{0:0.##########}", douYard / 1.094); // 碼轉換成公尺
            txtKM.Text = string.Format("{0:0.##########}", douYard / 1093.613); // 碼轉換成公里
            txtIn.Text = string.Format("{0:0.##########}", douYard * 36); // 碼轉換成英吋
            txtFt.Text = string.Format("{0:0.##########}", douYard * 3); // 碼轉換成英呎
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

        }
    }
}
