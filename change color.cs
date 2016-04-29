using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW1_11301415
{
    public partial class Form_HW1 : Form
    {
        public Form_HW1()
        {
            InitializeComponent();
        }

        private void btnRedword_Click(object sender, EventArgs e)
        {
            lblShow.ForeColor = Color.Red;
        }

        private void btnBackyellow_Click(object sender, EventArgs e)
        {
            lblShow.BackColor = Color.Yellow;
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            lblShow.ForeColor = Color.Blue;
            lblShow.BackColor = Color.Pink;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            string input ;
            input = Convert.ToString(txtInput.Text);
            lblShow.Text = "" + input;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblShow.Text = "";
            lblShow.BackColor = Color.Pink;
            txtInput.Text = "";
        }
    }
}
