using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace da_the_tow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCaculate_Click(object sender, EventArgs e)
        {
            int Num1=0, Num2=0, Num3=0, Num4=0, Num5=0, Num6=0;

            Random rd1 = new Random();
            Num1 = rd1.Next(1, 49);
            System.Threading.Thread.Sleep(new System.TimeSpan(0, 0, 0, 0, 20));
            Random rd2 = new Random();
            Num2 = rd2.Next(1, 49);
            System.Threading.Thread.Sleep(new System.TimeSpan(0, 0, 0, 0, 20));
            Random rd3 = new Random();
            Num3 = rd3.Next(1, 49);
            System.Threading.Thread.Sleep(new System.TimeSpan(0, 0, 0, 0, 20));
            Random rd4 = new Random();
            Num4 = rd4.Next(1, 49);
            System.Threading.Thread.Sleep(new System.TimeSpan(0, 0, 0, 0, 20));
            Random rd5 = new Random();
            Num5 = rd5.Next(1, 49);
            System.Threading.Thread.Sleep(new System.TimeSpan(0, 0, 0, 0, 20));
            Random rd6 = new Random();
            Num6 = rd6.Next(1, 49);

            if (Num2 == Num1)
            {
                Random rd22 = new Random();
                Num2 = rd22.Next(1, 49);
            }
            if (Num3 == Num1||Num3==Num2)
            {
                Random rd33 = new Random();
                Num3 = rd33.Next(1, 49);
            }
            if (Num4 == Num1 || Num4 == Num2||Num4==Num3)
            {
                Random rd44 = new Random();
                Num4 = rd44.Next(1, 49);
            }
            if (Num5 == Num1 || Num5 == Num2||Num5==Num3||Num5==Num4)
            {
                Random rd55 = new Random();
                Num5 = rd55.Next(1, 49);
            }
            if (Num6 == Num1 || Num6 == Num2 || Num6 == Num3 || Num6 == Num4||Num6==Num5)
            {
                Random rd66 = new Random();
                Num6 = rd66.Next(1, 49);
            }

            

            txtNum1.Text = "" + Num1;
            txtNum2.Text = "" + Num2;
            txtNum3.Text = "" + Num3;
            txtNum4.Text = "" + Num4;
            txtNum5.Text = "" + Num5;
            txtNum6.Text = "" + Num6;

            
        }
    }
}
