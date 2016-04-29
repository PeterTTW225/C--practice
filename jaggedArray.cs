using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jaggedArray
{
    public partial class Form1 : Form
    {
        string[][] trans = new string[30][];
        string[] name = new string[30];
        string[] gender = new string[30];
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblShow.Text = "共有0位顧客";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (counter >= 30) MessageBox.Show("儲存空間已滿", "錯誤");
            else
            {
                name[counter] = txtName.Text;
                if (rdBtnBoy.Checked) gender[counter] = "男";
                else gender[counter] = "女";

                int ctr = 0;
                if (checkBox1.Checked) ctr++;
                if (checkBox2.Checked) ctr++;
                if (checkBox3.Checked) ctr++;
                if (checkBox4.Checked) ctr++;
                if (checkBox5.Checked) ctr++;

                trans[counter] = new string[ctr];
                ctr = 0;

                if (checkBox1.Checked) trans[counter][ctr++] = checkBox1.Text;
                if (checkBox2.Checked) trans[counter][ctr++] = checkBox2.Text;
                if (checkBox3.Checked) trans[counter][ctr++] = checkBox3.Text;
                if (checkBox4.Checked) trans[counter][ctr++] = checkBox4.Text;
                if (checkBox5.Checked) trans[counter][ctr++] = checkBox5.Text;

                string output = "新顧客\r\n";
                output += name[counter] + "," + gender[counter];
                for (int i = 0; i < ctr; i++)
                {
                    output += "," + trans[counter][i];
                }
                txtshow.Text = output;

                counter++;
                lblShow.Text = "共有" + counter + "位顧客";

                txtName.Text = "";
                rdBtnBoy.Checked = true;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                txtName.Focus();
            }

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string str = "顧客列表\r\n";
            for (int i = 0; i < counter; i++)
            {
                str += (i + 1) + ":" + name[i]; 
                str+="," + gender[i];
                for (int j = 0; j < trans[i].Length; j++)
                { str += "," + trans[i][j];
                     }
                str += "\r\n";
            }
            txtshow.Text = str;
            txtName.Focus();
                
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string n = txtName.Text;
            int i;
            for (i=0; i < counter; i++)
                if (name[i] == n) break;
            if (i < counter)
            {
                string str = "!!!搜尋結果!!!\r\n";
                str += name[i] + "," + gender[i];
                for (int j=0; j < trans[i].Length; j++)
                    str += "," + trans[i][j];
                txtshow.Text = str;
            }
            else
                txtshow.Text = "!!!搜尋結果!!!\r\n沒有找到" + n;
            txtName.Text = "";
            txtName.Focus();
        }
    }
}

