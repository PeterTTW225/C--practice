using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplicationFactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int i, N;
            N = Convert.ToInt32(txtN.Text);
            string result="";
            for (i = 1; i <= N; i++)
            {
                if (N % i == 0) 
                { result =result+ i+","; }

            }
            lblshow.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
