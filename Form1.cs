using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplicationAdd1toN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            int s = 0,i,a,b;
            a=Convert.ToInt32(txtN1.Text);
            b=Convert.ToInt32(txtN2.Text);
            

            for (i = a; i <= b;i++ )
            {
                s += i;
                
            }
            lblanswer.Text =""+ s;  
        }
    }
}
