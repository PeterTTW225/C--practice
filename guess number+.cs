using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUESS_NUMBER_
{
    
    public partial class Form1 : Form
    {
        int min = 0, Max = 10000, answer, guess;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            answer = rd.Next(1,10000);
            txtmin.Text = Convert.ToString(min);
            txtMax.Text = Convert.ToString(Max);
            txtGuess.Text = "輸入數字吧~!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            guess = Convert.ToInt32(txtGuess.Text);

            try
            {
                if (guess == answer)
                {
                    txtmin.Text = "";
                    txtMax.Text = "";
                    txtGuess.Text = "猜對囉~!!";
                    lblTry.Text = "";
                    lblK.Text = "";
                    label3.Text = "";
                    MessageBox.Show("恭喜猜對了喔!!!", "答對了答對了!!!");
                    this.Close();
                }
                else
                {
                    int minguess, Maxguess, k;
                    minguess = Convert.ToInt32(txtmin.Text);
                    Maxguess = Convert.ToInt32(txtMax.Text);
                    k = Convert.ToInt16(lblK.Text);
                    if (guess > answer) txtMax.Text = Convert.ToString(guess);
                    else txtmin.Text = Convert.ToString(guess);
                    lblK.Text = Convert.ToString(k - 1);

                    if (guess < minguess || guess > Maxguess) MessageBox.Show("給你範圍還打錯!", "垃圾嗎?");

                    if (k == 1)
                    {
                        MessageBox.Show("爛ㄟ!!"+" "+"其實答案是:"+""+answer, "你的機會沒了!哈哈哈哈哈哈");
                        this.Close();
                    }

                }

            }

            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void lblK_Click(object sender, EventArgs e)
        {

        }

    }
}
