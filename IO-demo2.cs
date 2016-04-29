using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IO_demo2
{
    public partial class Form1 : Form
    {
        string str_after = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string a;
                a = sr.ReadToEnd();
                textBox1.Text = a;
                sr.Close();
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            str_after = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            int b, shift, show;
            b = sr.Read();
            shift = Convert.ToInt16(txtShift.Text);     
            
            for (; ; )
            {
                show = b + shift;
                if (show > 126)
                {
                    show = (show) % 126;
                    
                }
                if (show % 126 < 32)
                {
                    show = show % 126 + 32;
                }
                break;
            }
            
            str_after = Convert.ToString(show);
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true);
                sw.WriteLine(str_after);
                sw.Flush();
                sw.Close();               
            }
            
        }
    }
}
