using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Uri http;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            webBrowser1.Height = this.ClientSize.Height - textBox1.Height;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"D:\html.txt", webBrowser1.DocumentText);
            webBrowser1.Navigate(@"D:\html.txt");
        }
    }
}
