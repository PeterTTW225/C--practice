using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Multi_1DArray
{
    public partial class Multi_1DArray : Form
    {
        string[] name = { "芷茜", "麒淞", "博塵", "羽晨", "豈睿" };
        int[] math = { 97 , 98 , 95 , 99 , 94 };
        int[] chin = { 85 , 90 , 86 , 97 , 92 };
        public Multi_1DArray()
        {
            InitializeComponent();
        }

        private void Multi_1DArray_Load(object sender, EventArgs e)
        {
            string res = "名字\t數學\t國文\r\n";
            res += "====\t====\t====\r\n";
            for (int i = 0; i < 5; i++)
            {
                res += name[i] + "\t";
                res += math[i] + "\t";
                res += chin[i] + "\r\n";
            }

            res += "====\t====\t=====\r\n";
            txtOutput.Text = res;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string h = "名字\t數學\t國文";
            string sep = "====\t====\t====";
            if (chkAvg.Checked)
            {
                h += "\t平均";
                sep += "\t====";
            }

            if (chkFailNum.Checked)
            {
                h += "\t不及格";
                sep += "\t======";
            }

            if (chkRank.Checked)
            {
                h += "\t名次";
                sep += "\t====";
            }

            //個別選項的處理
            double[] avg = new double[5];

            if (chkAvg.Checked)
            {
                for (int i = 0; i < 5; i++)
                    avg[i] = (math[i] + chin[i]) / 2.0;
            }

            int[] fail = new int[5];
            if (chkFailNum.Checked)
            {
                for (int i = 0; i < 5; i++)
                {
                    fail[i] = 0;
                    if (math[i] < 60) fail[i] += 1;
                    if (chin[i] < 60) fail[i] += 1;
                }
            }

            int[] rank = new int[5];
            if (chkRank.Checked)
            {
                for (int i = 0; i < 5; i++)
                {
                    rank[i] = 1;
                    int sum = math[i] + chin[i];

                    for (int j = 0; j < 5; j++)
                    {
                        if (math[j] + chin[j] > sum) rank[i] += 1;
                    }
                }
            }

            int sumMath = 0, sumChin = 0;
            if (chkCourseAvg.Checked)
            {
                for (int i = 0; i < 5; i++)
                {
                    sumMath += math[i];
                    sumChin += chin[i];
                }
            }

            string res = h + "\r\n" + sep + "\r\n";
            for (int i = 0; i < 5; i++)
            {
                res += name[i] + "\t";
                res += math[i] + "\t";
                res += chin[i] + "\t";
                if (chkAvg.Checked) res += avg[i] + "\t";
                if (chkFailNum.Checked) res += fail[i] + "\t";
                if (chkRank.Checked) res += rank[i] + "\t";
                res += "\r\n";
            }

            res += sep + "\r\n";
            if (chkCourseAvg.Checked)
            {
                res += "平均\t";
                res += sumMath / 5.0 + "\t";
                res += sumChin / 5.0 + "\r\n";
            }

            txtOutput.Text = res;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Name;
            Name = Convert.ToString(txtName.Text);
            bool Flag = false;
            for (int i = 0; i < 5; i++)
            {
                if (Name == name[i])
                {
                    Flag = true;
                    MessageBox.Show("" + Name + "的成績"+"\r\n"+"數學:"+math[i]+"分"+"\r\n"+"國文:"+chin[i]+"分", "成績來囉~", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }                
            }
            if (Flag != true)
            {
                MessageBox.Show("" + Name + "??是哪個屁孩??", "有問題啦!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
