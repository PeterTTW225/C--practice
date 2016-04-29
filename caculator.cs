using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 計算機
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.b1.Click += new System.EventHandler(this.b0_Click);
            this.b2.Click += new System.EventHandler(this.b0_Click);
            this.b3.Click += new System.EventHandler(this.b0_Click);
            this.b4.Click += new System.EventHandler(this.b0_Click);
            this.b5.Click += new System.EventHandler(this.b0_Click);
            this.b6.Click += new System.EventHandler(this.b0_Click);
            this.b7.Click += new System.EventHandler(this.b0_Click);
            this.b8.Click += new System.EventHandler(this.b0_Click);
            this.b9.Click += new System.EventHandler(this.b0_Click);

            this.bSub.Click += new System.EventHandler(this.bAdd_Click);
            this.bMul.Click += new System.EventHandler(this.bAdd_Click);
            this.bDiv.Click += new System.EventHandler(this.bAdd_Click);
        }

        private void b7_Click(object sender, EventArgs e)
        {

        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (T.Text == "0")
            {
                T.Text = "";
            }
            T.Text += ((Button)sender).Text;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            String S= e.KeyData.ToString();
            String D = S.Substring(S.Length - 1);
            String Q = S.Substring(0,S.Length - 1);

            if ((Q == "D" && S.Length == 2) || Q == "Numpad")
            {
                if (T.Text == "0")
                {
                    T.Text = "";
                }
                T.Text += D;
            }



        }

        private void bDiv_Click(object sender, EventArgs e)
        {

        }

        private void bMul_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void bDot_Click(object sender, EventArgs e)
        {
            if(T.Text.IndexOf(".")<0)
            {

                T.Text = T.Text + ".";
            }
        }

        private void bSign_Click(object sender, EventArgs e)
        {
            if (T.Text != "0")
            {
                if (T.Text.IndexOf("-") >= 0)
                {
                    T.Text.Replace("-", "");
                }
                else
                {
                    T.Text = "-" + T.Text;
                }


            }
        }


        double A;
        String op;
        private void bAdd_Click(object sender, EventArgs e)
        {
            A = double.Parse(T.Text);
            T.Text = "0";
            op = ((Button)sender).Tag.ToString();
        }

        private void bEQ_Click(object sender, EventArgs e)
        {
            double B = double.Parse(T.Text);
            double C = 0;
            switch (op)
            {
                case "\"+\"": C = A + B; break;
                case "\"-\"": C = A - B; break;
                case "\"*\"": C = A * B; break;
                case "\"/\"": C = A / B; break;

            }

            T.Text = C.ToString();
            A = C;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            String S = T.Text;
            if (S.Length > 1)
            {
                T.Text = (double.Parse(S.Substring(0, S.Length - 1))).ToString();
            }
            else
            {
                T.Text = "0";
            }

           
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            T.Text = "0";
            A = 0;
            op = "";
        }
    }
}
