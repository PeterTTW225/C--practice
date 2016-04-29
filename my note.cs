using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
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

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);

                }
                else
                {
                    File.WriteAllText(openFileDialog1.FileName, textBox1.Text, Encoding.Default);
                }
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            textBox1.Clear();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 全選_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 搜尋取代_Click(object sender, EventArgs e)
       {
            textBox1.Select(0, 0);
            panel1.Visible = true;
        }
        

		private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = textBox3.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int p;
            if (textBox1.SelectionLength > 0)
                p = textBox1.Text.IndexOf(textBox2.Text, textBox1.SelectionStart + 1);
            else
                p = textBox1.Text.IndexOf(textBox2.Text, textBox1.SelectionStart);
            
            if (p < 0)
                MessageBox.Show("未發現搜尋字串!");
            else
            {
                textBox1.SelectionStart = p;
                textBox1.SelectionLength = textBox2.TextLength;
                textBox1.Select();
            }
        }

        private void 字型_Click(object sender, EventArgs e)
        {
            {
                fontDialog1.ShowDialog();
                textBox1.Font = fontDialog1.Font;
            }

        }

        private void 顏色_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }


        int mdx, mdy;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mdx = e.X;
            mdy = e.Y;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==System.Windows.Forms.MouseButtons.Left)
            {
                panel1.Left += e.X - mdx;
                panel1.Top += e.Y - mdy;
            }
        }

        }
    }

