using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnJudge_Click(object sender, EventArgs e)
        {



            int score;

            score = Convert.ToInt32(txtInput.Text);

            if (score > 100)
            { MessageBox.Show("分數應在0~100!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else if (score < 0)
            { MessageBox.Show("分數應在0~100!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else
            
            {
                if (score > 90)
                {
                    MessageBox.Show("得到A級喔!!", "Very Good job!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                if (score <= 89 && score >= 80)
                {
                    MessageBox.Show("得到B級喔!!", "Good job!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }


                if (score <= 79 && score >= 70)
                {
                    MessageBox.Show("得到C級喔!!", "Nice job!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                if (score <= 69 && score >= 60)
                {
                    MessageBox.Show("得到D級喔!!", "加油!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                if (score < 60)
                {
                    MessageBox.Show("得到E級喔!!", "再加油!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }


            
            


        }
    }
}
