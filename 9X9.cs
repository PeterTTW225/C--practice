using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _9X9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num;
        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            num = Convert.ToInt32(txtNum.Text);
            for (int i = 1; i <= num; i++)
            {

                for (int j = 1; j <= i; j++)
                { result += j; } result += "\r\n";
            }
            txtShow.Text = "" + result;

        }

        private void btn99_Click(object sender, EventArgs e)
        {

            string result = "";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    result =result+ j+" * "+ i + " = "+i*j+"  "+"\t";

                }
                result += "\r\n";
                txtShow.Text = "" + result;

            }

            

        }
    }
}
