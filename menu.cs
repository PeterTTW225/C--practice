using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplicationPractice_List
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int sum = 0;

            if (chkfish.Checked) sum += 59;
            if (chkchicken.Checked) sum += 69;
            if (chkpizzas.Checked) sum += 259;
            if (chkpizzab.Checked) sum += 429;

            if (chkdrink.Checked)
                {
                    if(rdBtncoke.Checked)sum+=25;
                    if(rdBtncoffee.Checked)sum+=30;
                    if(rdBtntea.Checked)sum+=20;
                }
            if (chkfries.Checked)
            {
                if (rdBtnfriess.Checked) sum += 25;
                if (rdBtnfriesb.Checked) sum += 35;
            }
           
           

            lblshow.Text =""+sum ;

            

                

        }

        private void rdBtnfriess_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
