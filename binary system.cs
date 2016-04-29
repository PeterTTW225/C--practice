using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace binary_system
{
    public partial class digitsystem : Form
    {
        public digitsystem()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int Num;
            //[法2]不用先宣告;
            string numshow;
            Num = Convert.ToInt32(txtNumber.Text);
            //↑[法2] int Num = int.Parse(txtNumber.Text);
            if (rdb2.Checked)
            { numshow = Convert.ToString(Num, 2); }
            else if (rdb8.Checked)
            { numshow = Convert.ToString(Num, 8); }
            else
            { numshow = Convert.ToString(Num, 16); }
            lblResult.Text = "" + numshow;
            //[另解]lblResult.Text = numshow.ToString();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
