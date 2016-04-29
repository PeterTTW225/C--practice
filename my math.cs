using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = a+b;
            label2.Text = c.ToString();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox4.Text);
            double b = double.Parse(textBox3.Text);
            double c = a - b;
            label3.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox6.Text);
            double b = double.Parse(textBox5.Text);
            double c = a*b;
            label5.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox8.Text);
            double b = double.Parse(textBox7.Text);
            double c = a/b;
            label7.Text = c.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double w = double.Parse(textBox9.Text);
            double h = double.Parse(textBox10.Text);
            h/=100;
            double bmi = w / Math.Pow(h, 2);
            label11.Text = bmi.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox11.Text);
            double b = double.Parse(textBox12.Text);
            double c = double.Parse(textBox13.Text);
            double d = 0;

            for (double i = a; i <= b; i += c)
            {
                d += i;
                label15.Text = d.ToString();
            }
        }
    }
}
