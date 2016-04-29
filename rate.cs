using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string[] name = { "芷茜", "禹辰", "麒淞", "柏辰", "智晟" };
            string res = "名字\t成績\r\n";
            res += "====\t====\r\n";
            int N1, N2, N3, N4, N5;
            N1 = Convert.ToInt16(txtN1.Text);
            N2 = Convert.ToInt16(txtN2.Text);
            N3 = Convert.ToInt16(txtN3.Text);
            N4 = Convert.ToInt16(txtN4.Text);
            N5 = Convert.ToInt16(txtN5.Text);
            int[] grade = { N1, N2, N3, N4, N5 };
            string h = "名字\t數學\t國文";
            string sep = "====\t====\t====";
                        
            
            for (int i = 0; i < 5; i++)
            {
                if (grade[i] < 0 || grade[i] > 100)
                {
                    MessageBox.Show("請輸入0~100的數字", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    res += name[i] + "\t";
                    res += grade[i] + "\r\n";

                }
            }

            res += "====\t====";

            if (chkBx.Checked)
            {
                h += "\t名次";
                sep += "\t====";


                int[] rank = new int[5];
                
                    for (int i = 0; i < 5; i++)
                    {
                        rank[i] = 1;


                        for (int j = 0; j < 5; j++)
                        {
                            if (rank[j] > rank[i]) rank[i] += 1;
                        }
                        if (chkBx.Checked) res += rank[i] + "\t";
                        res += name[i] + "\t";
                        res += grade[i] + "\t";
                        if (chkBx.Checked) res += rank[i] + "\t";
                        res += "\r\n";
                    }
                                             
                    
                }
                
                    txtOutput.Text = res;
                
            }
            
            
        }

       
    }

