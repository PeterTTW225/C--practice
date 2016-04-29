using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Than_the_size_of_3numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string Num1, Num2, Num3, output;
            double num1, num2, num3;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            num3 = Convert.ToDouble(txtNum3.Text);

            Num1 = Convert.ToString(num1);
            Num2 = Convert.ToString(num2);
            Num3 = Convert.ToString(num3);

            if (num1 > num2 & num2 > num3 )
            {
                MessageBox.Show("最大值:" + Num1 +" ; "+" 最小值:" +Num3, "比較結果", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            if (num1 > num3 & num3 > num2)
            {
                MessageBox.Show("最大值:" + Num1 + ";" + "最小值:" + Num2, "比較結果", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (num2 > num1 & num1 > num3)
            {
                MessageBox.Show("最大值:" + Num2 + ";" + "最小值:" + Num3, "比較結果", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (num2 > num3 & num3 > num1)
            {
                MessageBox.Show("最大值:" + Num2 + ";" + "最小值:" + Num1, "比較結果", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (num3 > num1 & num1 > num2)
            {
                MessageBox.Show("最大值:" + Num3 + ";" + "最小值:" + Num2, "比較結果", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (num3 > num2 & num2 > num1)
            {
                MessageBox.Show("最大值:" + Num3 + ";" + "最小值:" + Num1, "比較結果", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
    }
}
