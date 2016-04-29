using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace guess_Number
{
    
    public partial class guessNumber : Form
    {
      
        int  RD;
        Random rd = new Random();
        
        public guessNumber()
        {
            InitializeComponent();
        }
    
        private void guessNumber_Load(object sender, EventArgs e)
        {

        }

        private void btnNewNumber_Click(object sender, EventArgs e)
        {
            RD = rd.Next(0,100);
            txtMessage.Text = ("Let's guess!!"+"\r\n");        
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            txtMessage.Text = ("你還偷看答案!!" + "\r\n" + "答案是: " + RD);
        }
    
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            int input;
            input = Convert.ToInt16(txtAnswer.Text);
            if (input < RD)
                txtMessage.Text += ("答案比" + input + "大"+"\r\n");
            else if (input > RD)
                txtMessage.Text += ("答案比" + input + "小"+"\r\n");
            else
                txtMessage.Text += ("你終於答對了!!答案是" + input);
            txtAnswer.Text = ("");
        }
     
        
    }
}
