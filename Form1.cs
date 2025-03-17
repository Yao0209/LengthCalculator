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

        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtInfo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {

        }
    }
}
