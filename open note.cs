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

namespace sample_to_open
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                String str = sr.ReadToEnd();
                rthSHOW.Text = str;
                sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(openFileDialog1.FileName);           
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true);
                sw.WriteLine(rthSHOW.Text);                
                sw.Flush();
                sw.Close();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string str_after { get; set; }



        
    }
}
